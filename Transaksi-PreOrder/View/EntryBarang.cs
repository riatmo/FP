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
    public partial class EntryBarang : Form
    {

        //deklarasi untuk event tambah data & update
        public delegate void CreateUpdateHandler(Barang brg);

        //event tambah data
        //public event CreateUpdateHandler onCreate;

        //event update data
        public event CreateUpdateHandler onUpdate;

        //objek controller
        private BarangController brgController;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek mahasiswa
        private Barang brg;


        public EntryBarang()
        {
            InitializeComponent();
        }

        // constructor untuk inisialisasi data ketika entri data baru
        public EntryBarang(string title, BarangController brgController) : this() {
            // ganti text/judul form
            this.Text = title;
            this.brgController = brgController;
        }

        // constructor untuk inisialisasi data ketika mengedit data
        public EntryBarang(string title, Barang obj, BarangController brgController) : this() {
            // ganti text/judul form
            this.Text = title;
            this.brgController = brgController;

            isNewData = false; // set status edit data
            brg = obj; // set objek mhs yang akan diedit

            // untuk edit data, tampilkan data lama
            //int harga = Convert.ToInt32(txtHarga.Text);
            //harga = brg.Harga;

            //int qty = Convert.ToInt32(txtQty.Text);
            //qty = brg.Qty;
            txtHarga.Text = brg.Harga.ToString();
            txtQty.Text = brg.Qty.ToString();
            //txtHarga.Text = brg.Harga;
            txtKdBarang.Text = brg.KdBarang;
            txtNmBarang.Text = brg.Nama;
            txtUkuran.Text = brg.Ukuran;
            txtWarna.Text = brg.Warna;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) brg = new Barang();

            // set nilai property objek mahasiswa yg diambil dari TextBox
            brg.Harga = Convert.ToInt32(txtHarga.Text);
            brg.Qty = Convert.ToInt32(txtQty.Text);
            brg.KdBarang = txtKdBarang.Text;
            brg.Nama = txtNmBarang.Text;
            brg.Ukuran = txtUkuran.Text;
            brg.Warna = txtWarna.Text;

            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = brgController.Create(brg);

                if (result > 0) // tambah data berhasil
                {
                    //onCreate(brg); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtHarga.Clear();
                    txtQty.Clear();
                    txtKdBarang.Clear();
                    txtNmBarang.Clear();
                    txtUkuran.Clear();
                    txtWarna.Clear();

                    txtKdBarang.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = brgController.Update(brg);

                if (result > 0)
                {
                    onUpdate(brg); // panggil event OnUpdate
                    this.Close();
                }
            }

        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
