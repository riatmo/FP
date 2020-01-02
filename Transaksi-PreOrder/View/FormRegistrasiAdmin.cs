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
    public partial class FormRegistrasiAdmin : Form
    {
        // deklarasi tipe data untuk event tambah data & update
        public delegate void CreateRegistAdminEventHandler(Admin adm);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateRegistAdminEventHandler AdminCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateRegistAdminEventHandler AdminUpdate;

        //objek controller produsen
        private AdminController AdmController;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek pesanan
        private Admin adm;

        public FormRegistrasiAdmin()
        {
            InitializeComponent();
        }

        // constructor untuk inisialisasi data ketika entri data baru
        public FormRegistrasiAdmin(string title, AdminController AdmController) : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.AdmController = AdmController;

            //txtKdProdusen.Text = "PR00" + Convert.ToString(prodController.noProdusen() + 1);
        }

        // constructor untuk inisialisasi data ketika mengedit data
        public FormRegistrasiAdmin(string title, Admin admDit, AdminController AdmController) : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.AdmController = AdmController;

            isNewData = false; // set status edit data
            adm = admDit; // set objek mhs yang akan diedit

            // untuk edit data, tampilkan data lama
            txtKdAdmin.Text = adm.KdAdmin;
            txtUsername.Text = adm.Username;
            txtPassword.Text = adm.Password;
            txtNama.Text = adm.Nama;
            txtEmail.Text = adm.Email;
            txtNomorTelp.Text = adm.Hp;
            txtJabatan.Text = adm.Jabatan;
        }
    }
}
