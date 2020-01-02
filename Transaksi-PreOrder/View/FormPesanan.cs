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
    public partial class FormPesanan : Form
    {

        //Menampilkan kode admin yg login saat ini
        public string currentAdmin = Login.AdminInfo.CurrentLoggedInAdmin;

        //deklarasi untuk event tambah data & update
        public delegate void CreatePesananHandler(Pesanan psn);

        //event tambah data
        public event CreatePesananHandler PesananCreate;

        //event update data
        public event CreatePesananHandler PesananUpdate;

        //objek kontroller pesanan
        private PesananController controller1;

        //objek kontroller detail
        private DetailPesananController controllerdetail;

        private PelangganController controllerPelanggan;

        //private AdminController controllerAdmin;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek pesanan
        private Pesanan psn;

        private Pelanggan plg;



        public FormPesanan()
        {
            InitializeComponent();
            controllerdetail = new DetailPesananController();
            controllerPelanggan = new PelangganController();


        }

        internal class PesananInfo
        {
            public static string KodePesanan {
                get;
                set;
            }
        }


        // constructor untuk inisialisasi data ketika entri data baru
        public FormPesanan(string title, PesananController controller1)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller1 = controller1;

            txtKdPesanan.Text = "PN00" + Convert.ToString(controller1.noPesanan() + 1);
        }

        private void FormPesanan_Load(object sender, EventArgs e)
        {
            //tampil kode admin yg login
            txtAdmin.Text = currentAdmin;
            //txtKdPesanan.Text = "PN00" + Convert.ToString(controller1.noPesanan() + 1);


        }


        // constructor untuk inisialisasi data ketika mengedit data
        public FormPesanan(string title, Pesanan obj1, PesananController controller1)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller1 = controller1;

            isNewData = false; // set status edit data
            psn = obj1; // set objek mhs yang akan diedit

            // untuk edit data, tampilkan data lama
            
            txtKdPesanan.Text = psn.KdPesanan;
            txtAdmin.Text = psn.KdAdmin;
            datePesanan.Text = psn.TglPesan;
            dateTempo.Text = psn.JatuhTempo;
            txtStatusPesanan.Text = psn.StatusPesanan;
           
        }

        private void onCreateEventHandler(DetailPesanan detailPesanan)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) psn = new Pesanan();

            if (isNewData)  plg = new Pelanggan();

            plg.KdPembeli = txtKodePel.Text;
            plg.Nama = txtNamaPel.Text;
            plg.Hp = txtTelfon.Text;
            plg.Alamat = txtAlamat.Text;
            plg.Kecamatan = txtKecPesanan.Text;
            plg.Kabupaten = txtKabPesanan.Text;
            plg.Provinsi = txtProvPesanan.Text;
            plg.KodePos = txtKdPosPesanan.Text;




            // set nilai property objek mahasiswa yg diambil dari TextBox

            datePesanan.Format = DateTimePickerFormat.Custom;
            datePesanan.CustomFormat = "yyyy-MM-dd";

            dateTempo.Format = DateTimePickerFormat.Custom;
            dateTempo.CustomFormat = "yyyy-MM-dd";

            psn.KdPesanan = txtKdPesanan.Text;
            psn.KdPembeli = txtKodePel.Text;
            psn.KdAdmin = txtAdmin.Text;
            psn.TglPesan = datePesanan.Text;
            psn.JatuhTempo = dateTempo.Text;
            psn.StatusPesanan = txtStatusPesanan.Text;
            
            //psn.CaraBayar = cmbPlhPembayaran.Text;

            PesananInfo.KodePesanan = txtKdPesanan.Text;


            int result1 = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result1 = controller1.Create(psn);
                result1 = controllerPelanggan.Create(plg);

                if (result1 > 0) // tambah data berhasil
                {
                    PesananCreate(psn); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    //txtKdPesanan.Clear();
                    
                }

                FormDetailPesanan formDetail = new FormDetailPesanan("tambah Barang", controllerdetail);

                formDetail.DetailPesananCreate += onCreateEventHandler;

                formDetail.ShowDialog();
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result1 = controller1.Update(psn);

                if (result1 > 0)
                {
                    PesananUpdate(psn); // panggil event OnUpdate
                    this.Close();
                }
            }

            
        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
