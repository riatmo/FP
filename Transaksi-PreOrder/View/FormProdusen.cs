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
    public partial class FormProdusen : Form
    {
        // deklarasi tipe data untuk event tambah data & update
        public delegate void CreateProdusenEventHandler(Produsen prod);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateProdusenEventHandler ProdusenCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateProdusenEventHandler ProdusenUpdate;

        //objek controller produsen
        private ProdusenController prodController;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek pesanan
        private Produsen prod;

        public FormProdusen()
        {
            InitializeComponent();
        }    

        // constructor untuk inisialisasi data ketika entri data baru
        public FormProdusen(string title, ProdusenController prodController) : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.prodController = prodController;

            //txtKdProdusen.Text = "PR00" + Convert.ToString(prodController.noProdusen() + 1);
        }

        // constructor untuk inisialisasi data ketika mengedit data
        public FormProdusen(string title, Produsen prodDit, ProdusenController prodController) : this() {
            // ganti text/judul form
            this.Text = title;
            this.prodController = prodController;

            isNewData = false; // set status edit data
            prod = prodDit; // set objek mhs yang akan diedit

            // untuk edit data, tampilkan data lama
            txtKdProdusen.Text = prod.KdProdusen;
            txtNama.Text = prod.Nama;
            txtAlamat.Text = prod.Alamat;
            txtTelepon.Text = prod.Telpon;
        }

        private void btTambahProdusen_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) prod = new Produsen();

            // set nilai property objek mahasiswa yg diambil dari TextBox
            prod.KdProdusen = txtKdProdusen.Text;
            prod.Nama = txtNama.Text;
            prod.Alamat = txtAlamat.Text;
            prod.Telpon = txtTelepon.Text;

            int result = 0;

            if (isNewData)// tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = prodController.Create(prod);

                if (result > 0) // tambah data berhasil
                {
                    ProdusenCreate(prod); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtKdProdusen.Clear();
                    txtNama.Clear();
                    txtAlamat.Clear();
                    txtTelepon.Clear();

                    txtKdProdusen.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = prodController.Update(prod);

                if (result > 0)
                {
                    ProdusenUpdate(prod); // panggil event OnUpdate
                    this.Close();
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
