using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transaksi_PreOrder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // buat objek form login
            Login login = new Login();

            // tampilkan form login
            if (login.ShowDialog() == DialogResult.OK) // jika user dan password benar
                Application.Run(new FormUtama()); // jalankan form utama
            else
                Application.Exit(); // keluar dari aplikasi
        }
    }
}
