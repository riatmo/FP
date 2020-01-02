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
    public partial class FormPembayaran : Form
    {

        public string currentAdmin = Login.AdminInfo.CurrentLoggedInAdmin;

        //deklarasi untuk event tambah data & update
        public delegate void CreatePesananHandler(Pesanan psn);

        //event tambah data
        //public event CreatePesananHandler PesananCreate;

        //event update data
        public event CreatePesananHandler PesananUpdate;

        //objek kontroller pesanan
        private PesananController controller1;

        // deklarasi field untuk meyimpan objek pesanan
        private Pesanan psn;

        public FormPembayaran()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        // constructor untuk inisialisasi data ketika mengedit data
        public FormPembayaran(string title, Pesanan obj1, PesananController controller1)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller1 = controller1;

             // set status edit data
            psn = obj1; // set objek mhs yang akan diedit

            // untuk edit data, tampilkan data lama

            //txtKdPesanan.Text = psn.KdPesanan;
            //txtAdmin.Text = psn.KdAdmin;
            //datePesanan.Text = psn.TglPesan;
            //dateTempo.Text = psn.JatuhTempo;
            //txtStatusPesanan.Text = psn.StatusPesanan;
            lblKodePsn.Text = psn.KdPesanan;
            txtKdTpembeli.Text = psn.KdPembeli;
            txtKdTatasnama.Text = controller1.Nama(psn.KdPembeli);
            cmbPesanan.Text = psn.StatusPesanan;
            cmbPilihPembayaran.Text = psn.CaraBayar;
            txtTotTag.Text = Convert.ToString( controller1.Total(psn.KdPesanan));
            txtJumPem.Text = Convert.ToString(psn.Dp);
            txtKekurangan.Text = Convert.ToString(controller1.Total(psn.KdPesanan) - Convert.ToInt16( txtJumPem.Text));
            
            
            //txtKekurangan.Text = Convert.ToString(psn.SisaPembayaran);

        }

        private void btnTambahTP_Click(object sender, EventArgs e)
        {



            psn.CaraBayar = cmbPilihPembayaran.Text;
            psn.Dp = Convert.ToInt16( txtJumPem.Text);

            int result1 = 0;
            result1 = controller1.Update(psn);

            if (result1 > 0)
            {
                PesananUpdate(psn); // panggil event OnUpdate
                this.Close();
            }

           
            

        }

        private void FormPembayaran_Load(object sender, EventArgs e)
        {
            
        }
    }
}