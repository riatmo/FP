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
    public partial class FormListBarang : Form
    {
        // deklarasi collection untuk menampung objek barang
        private List<Barang> listBarang = new List<Barang>();

        // deklarasi objek controller barang
        private BarangController barangController;

        public FormListBarang()
        {
            InitializeComponent();

            barangController = new BarangController();
            
            ListBarang();
            LoadBarang();
        }

        //List view barang
        private void ListBarang()
        {
            
            lvwListBarang.View = View.Details;
            lvwListBarang.FullRowSelect = true;
            lvwListBarang.GridLines = true;

            lvwListBarang.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwListBarang.Columns.Add("KD Barang", 80, HorizontalAlignment.Center);
            lvwListBarang.Columns.Add("Nama", 292, HorizontalAlignment.Center);
            lvwListBarang.Columns.Add("Harga", 100, HorizontalAlignment.Left);
            lvwListBarang.Columns.Add("Qty", 50, HorizontalAlignment.Center);
            lvwListBarang.Columns.Add("Warna", 80, HorizontalAlignment.Center);
            lvwListBarang.Columns.Add("Ukuran", 80, HorizontalAlignment.Center);
        }

        //Memuat barang dari DB kelistview
        private void LoadBarang()
        {
            // kosongkan listview
            lvwListBarang.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listBarang = barangController.ReadAllBarang();

            // ekstrak objek mhs dari collection
            foreach (var brg in listBarang)
            {
                var noUrut = lvwListBarang.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(brg.KdBarang);
                item.SubItems.Add(brg.Nama);
                item.SubItems.Add(Convert.ToString(brg.Harga));
                item.SubItems.Add(Convert.ToString(brg.Qty));
                item.SubItems.Add(brg.Warna);
                item.SubItems.Add(brg.Ukuran);

                // tampilkan data mhs ke listview
                lvwListBarang.Items.Add(item);
            }
        }

        private void UpdateBarangHandler(Barang brg)
        {
            // ambil index data mhs yang edit
            int index = lvwListBarang.SelectedIndices[0];

            // update informasi mhs di listview
            ListViewItem itemRow = lvwListBarang.Items[index];
            itemRow.SubItems[1].Text = brg.KdBarang;
            itemRow.SubItems[2].Text = brg.Nama;
            itemRow.SubItems[3].Text = Convert.ToString(brg.Harga);
            itemRow.SubItems[4].Text = Convert.ToString(brg.Qty);
            itemRow.SubItems[5].Text = brg.Warna;
            itemRow.SubItems[6].Text = brg.Ukuran;

        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if(lvwListBarang.SelectedItems.Count > 0)
            { 
            // ambil objek mhs yang mau diedit dari collection
            Barang brg = listBarang[lvwListBarang.SelectedIndices[0]];

            // buat objek form entry data mahasiswa
            EntryBarang frmEntry = new EntryBarang("Edit Data Barang", brg, barangController);

            // mendaftarkan method event handler untuk merespon event OnUpdate
            frmEntry.onUpdate += UpdateBarangHandler;

            // tampilkan form entry mahasiswa
            frmEntry.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }           
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwListBarang.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data barang ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Barang brg = listBarang[lvwListBarang.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = barangController.Delete(brg);
                    if (result > 0) LoadBarang();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data mahasiswa belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCariBarang_TextChanged(object sender, EventArgs e)
        {
            // kosongkan listview
            lvwListBarang.Items.Clear();

            // panggil method ReadByNama dan tampung datanya ke dalam collection
            listBarang = barangController.ReadByNama(txtCariBarang.Text);

            // ekstrak objek mhs dari collection
            foreach (var brg in listBarang)
            {
                var noUrut = lvwListBarang.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(brg.KdBarang);
                item.SubItems.Add(brg.Nama);
                item.SubItems.Add(Convert.ToString(brg.Harga));
                item.SubItems.Add(Convert.ToString(brg.Qty));
                item.SubItems.Add(brg.Warna);
                item.SubItems.Add(brg.Ukuran);

                // tampilkan data mhs ke listview
                lvwListBarang.Items.Add(item);
            }
        }
    }
}
