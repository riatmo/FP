using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Transaksi_PreOrder.Model.Entity;
using Transaksi_PreOrder.Controller;

namespace Transaksi_PreOrder
{
    public partial class FormListProdusen : Form
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        private List<Produsen> listProdusen = new List<Produsen>();

        // deklarasi objek controller
        private ProdusenController prodController;

        // constructor
        public FormListProdusen()
        {
            InitializeComponent();

            prodController = new ProdusenController();

            ListProdusen();
            LoadProdusen();
        }

        private void ListProdusen()
        {
            lvwListProdusen.View = View.Details;
            lvwListProdusen.FullRowSelect = true;
            lvwListProdusen.GridLines = true;

            lvwListProdusen.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwListProdusen.Columns.Add("Kode Produsen", 90, HorizontalAlignment.Center);
            lvwListProdusen.Columns.Add("Nama", 350, HorizontalAlignment.Center);
            lvwListProdusen.Columns.Add("Alamat", 100, HorizontalAlignment.Center);
            lvwListProdusen.Columns.Add("Telepon", 100, HorizontalAlignment.Center);
        }

        private void LoadProdusen()
        {
            lvwListProdusen.Items.Clear();

            listProdusen = prodController.ReadAllProdusen();

            foreach (var prod in listProdusen)
            {
                var noUrut = lvwListProdusen.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(prod.KdProdusen);
                item.SubItems.Add(prod.Nama);
                item.SubItems.Add(prod.Alamat);
                item.SubItems.Add(prod.Telpon);

                lvwListProdusen.Items.Add(item);
            }
        }

        private void UpdateProdusenEventHandler(Produsen prod)
        {
            // ambil index data mhs yang edit
            int index = lvwListProdusen.SelectedIndices[0];

            // update informasi mhs di listview
            ListViewItem itemRow = lvwListProdusen.Items[index];
            itemRow.SubItems[1].Text = prod.KdProdusen;
            itemRow.SubItems[2].Text = prod.Nama;
            itemRow.SubItems[3].Text = prod.Alamat;
            itemRow.SubItems[4].Text = prod.Telpon;
        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwListProdusen.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Produsen prod = listProdusen[lvwListProdusen.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FormProdusen frmProd = new FormProdusen("Edit Data Produsen", prod, prodController);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmProd.ProdusenUpdate += UpdateProdusenEventHandler;

                // tampilkan form entry mahasiswa
                frmProd.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwListProdusen.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data barang ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Produsen prod = listProdusen[lvwListProdusen.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = prodController.Delete(prod);
                    if (result > 0) LoadProdusen();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data mahasiswa belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCariProdusen_TextChanged(object sender, EventArgs e)
        {
            // kosongkan listview
            lvwListProdusen.Items.Clear();

            // panggil method ReadByNama dan tampung datanya ke dalam collection
            listProdusen = prodController.ReadByNama(txtCariProdusen.Text);

            // ekstrak objek mhs dari collection
            foreach (var prod in listProdusen)
            {
                var noUrut = lvwListProdusen.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(prod.KdProdusen);
                item.SubItems.Add(prod.Nama);
                item.SubItems.Add(prod.Alamat);
                item.SubItems.Add(prod.Telpon);

                // tampilkan data mhs ke listview
                lvwListProdusen.Items.Add(item);
            }
        }
    }
}
