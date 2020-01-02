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
    public partial class FormPelanggan : Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void PelangganHandler(Pelanggan pel);


        // deklarasi event ketika terjadi proses update data
        public event PelangganHandler PelUpdate;
        public event PelangganHandler Create;

        private PelangganController controller;

        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek mahasiswa
        private Pelanggan pel;


        public FormPelanggan()
        {
            InitializeComponent();
        }


        // constructor untuk inisialisasi data ketika entri data baru
        public FormPelanggan(string title, PelangganController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;
        }

        public FormPelanggan(string title, Pelanggan obj, PelangganController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            pel = obj; // set objek mhs yang akan diedit

            // untuk edit data, tampilkan data lama
            txtKdPel.Text = pel.KdPembeli;
            txtNama.Text = pel.Nama;
            txtAlamat.Text = pel.Alamat;
            txtHp.Text = pel.Hp;
            txtKab.Text = pel.Kabupaten;
            txtKec.Text = pel.Kecamatan;
            txtProv.Text = pel.Provinsi;
            txtPos.Text = pel.KodePos;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) pel = new Pelanggan();

            // set nilai property objek mahasiswa yg diambil dari TextBox
            pel.KdPembeli = txtKdPel.Text;
            pel.Nama = txtNama.Text;
            pel.Alamat = txtAlamat.Text;
              pel.Hp = txtHp.Text;
              pel.Kabupaten = txtKab.Text;
              pel.Kecamatan = txtKec.Text;
             pel.Provinsi = txtProv.Text;
             pel.KodePos = txtPos.Text;

            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(pel);

                if (result > 0) // tambah data berhasil
                {
                    Create(pel); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(pel);

                if (result > 0)
                {
                    PelUpdate(pel); // panggil event OnUpdate
                    this.Close();
                }
            }
        }
    }
}
