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
    public partial class FormListPelanggan : Form
    {

        private List<Pelanggan> listPelanggan = new List<Pelanggan>();

        private PelangganController controller;


        public FormListPelanggan()
        {
            InitializeComponent();

            controller = new PelangganController();
            ListViewPelanggan();
            LoadPelanggan();

        }

        private void ListViewPelanggan()
        {
            lvwListPelanggan.View = System.Windows.Forms.View.Details;
            lvwListPelanggan.FullRowSelect = true;
            lvwListPelanggan.GridLines = true;

            lvwListPelanggan.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwListPelanggan.Columns.Add("Kode", 50, HorizontalAlignment.Center);
            lvwListPelanggan.Columns.Add("Nama", 100, HorizontalAlignment.Left);
            lvwListPelanggan.Columns.Add("Telp", 80, HorizontalAlignment.Center);
            lvwListPelanggan.Columns.Add("Alamat", 80, HorizontalAlignment.Center);
            lvwListPelanggan.Columns.Add("Kecamatan", 80, HorizontalAlignment.Center);
            lvwListPelanggan.Columns.Add("Kabupaten", 80, HorizontalAlignment.Center);
            lvwListPelanggan.Columns.Add("Provinsi", 80, HorizontalAlignment.Center);
            lvwListPelanggan.Columns.Add("Pos", 80, HorizontalAlignment.Center);
            
        }


        private void LoadPelanggan()
        {
            // kosongkan listview
            lvwListPelanggan.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listPelanggan = controller.ReadAll();

            // ekstrak objek mhs dari collection
            foreach (var pel in listPelanggan)
            {
                var noUrut = lvwListPelanggan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pel.KdPembeli);
                item.SubItems.Add(pel.Nama);
                item.SubItems.Add(pel.Hp);
                item.SubItems.Add(pel.Alamat);
                item.SubItems.Add(pel.Kecamatan);
                item.SubItems.Add(pel.Kabupaten);
                item.SubItems.Add(pel.Provinsi);
                item.SubItems.Add(pel.KodePos);

                // tampilkan data mhs ke listview
                lvwListPelanggan.Items.Add(item);
            }
        }

        private void CreatePelangganHadler(Pelanggan pel)
        {
            // tambahkan objek mhs yang baru ke dalam collection
            listPelanggan.Add(pel);

            int noUrut = lvwListPelanggan.Items.Count + 1;

            // tampilkan data mhs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            

            item.SubItems.Add ( pel.KdPembeli);
            item.SubItems.Add ( pel.Nama);
            item.SubItems.Add ( pel.Hp);
            item.SubItems.Add ( pel.Alamat);
            item.SubItems.Add ( pel.Kecamatan);
            item.SubItems.Add ( pel.Kabupaten);
            item.SubItems.Add ( pel.Provinsi);
            item.SubItems.Add ( pel.KodePos);

            lvwListPelanggan.Items.Add(item);
        }


        private void UpdatePelangganHandler(Pelanggan pel)
        {
            // ambil index data mhs yang edit
            int index = lvwListPelanggan.SelectedIndices[0];

            // update informasi mhs di listview
            ListViewItem itemRow = lvwListPelanggan.Items[index];
            itemRow.SubItems[1].Text = pel.KdPembeli;
            itemRow.SubItems[2].Text = pel.Nama;
            itemRow.SubItems[3].Text = pel.Hp;
            itemRow.SubItems[4].Text = pel.Alamat;
            itemRow.SubItems[5].Text = pel.Kecamatan;
            itemRow.SubItems[6].Text = pel.Kabupaten;
            itemRow.SubItems[7].Text = pel.Provinsi;
            itemRow.SubItems[8].Text = pel.KodePos;

        }

        private void btnPerbaiki_Click(object sender, EventArgs e)
        {
            if (lvwListPelanggan.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Pelanggan pel = listPelanggan[lvwListPelanggan.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FormPelanggan formPelanggan = new FormPelanggan("Edit Data Pelanggan", pel, controller);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                formPelanggan.PelUpdate += UpdatePelangganHandler;

                // tampilkan form entry mahasiswa
                formPelanggan.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // buat objek form entry data mahasiswa
            FormPelanggan frmEntry = new FormPelanggan("Tambah Data Pelangan", controller);

            // mendaftarkan method event handler untuk merespon event OnCreate
            frmEntry.Create += CreatePelangganHadler;

            // tampilkan form entry mahasiswa
            frmEntry.ShowDialog();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (lvwListPelanggan.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data pelanggan ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Pelanggan pel = listPelanggan[lvwListPelanggan.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(pel);
                    if (result > 0) LoadPelanggan();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data mahasiswa belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
