using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using Transaksi_PreOrder.Model.Entity;
using Transaksi_PreOrder.Model.Context;


namespace Transaksi_PreOrder.Model.Repository
{
    public class ProdusenRepository
    {
        //objek connection 
        private MySqlConnection _conn;

        //constructor
        public ProdusenRepository(DbContext context)
        {
            //inisialisasi objek conn
            _conn = context.Conn;
        }

        public int Create(Produsen prod)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into produsen (kd_produsen, nama_produsen, alamat_produsen, telp_produsen)
                           values (@kd_produsen, @nama_produsen, @alamat_produsen, @telp_produsen)";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_produsen", prod.KdProdusen);
                cmd.Parameters.AddWithValue("@nama_produsen", prod.Nama);
                cmd.Parameters.AddWithValue("@alamat_produsen", prod.Alamat);
                cmd.Parameters.AddWithValue("@telp_produsen", prod.Telpon);

                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Update(Produsen prod)
        {
            int result1 = 0;

            // deklarasi perintah SQL
            string sql = @"update produsen set nama_produsen = @nama_produsen, alamat_produsen = @alamat_produsen, telp_produsen = @telp_produsen
                           where kd_produsen = @kd_produsen";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@nama_produsen", prod.Nama);
                cmd.Parameters.AddWithValue("@alamat_produsen", prod.Alamat);
                cmd.Parameters.AddWithValue("@telp_produsen", prod.Telpon);
                cmd.Parameters.AddWithValue("@kd_produsen", prod.KdProdusen);

                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result1 = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result1;
        }

        public List<Produsen> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Produsen> list = new List<Produsen>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select kd_produsen, nama_produsen, alamat_produsen, telp_produsen
                               from produsen order by kd_produsen";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Produsen prod = new Produsen();

                            prod.KdProdusen = dtr["kd_produsen"].ToString();
                            prod.Nama = dtr["nama_produsen"].ToString();
                            prod.Alamat = dtr["alamat_produsen"].ToString();
                            prod.Telpon = dtr["telp_produsen"].ToString();

                            list.Add(prod);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        public List<Produsen> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Produsen> list = new List<Produsen>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select kd_produsen, nama_produsen, alamat_produsen, telp_produsen
                               from produsen 
                               where nama_produsen like @nama_produsen
                               order by nama_produsen";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@nama_produsen", "%" + nama + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Produsen prod = new Produsen();
                            prod.KdProdusen = dtr["kd_produsen"].ToString();
                            prod.Nama = dtr["nama_produsen"].ToString();
                            prod.Alamat = dtr["alamat_produsen"].ToString();
                            prod.Telpon = dtr["telp_produsen"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(prod);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }

        public int Delete(Produsen prod)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from produsen where kd_produsen = @kd_produsen";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_produsen", prod.KdProdusen);

                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

       /* public int Pembayaran(Pesanan psn)
        {
            int result1 = 0;

            // deklarasi perintah SQL


            string sql = @"update pesanan set cara_bayar = @cara_bayar
                           where kd_pesanan = @kd_pesanan";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_pesanan", psn.KdPesanan);
                cmd.Parameters.AddWithValue("@cara_bayar", psn.CaraBayar);


                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result1 = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result1;
        }*/

        public int NoProdusen()
        {
            int no = 0;

            //string sql = @"select right(kd_pesanan,2) as nopesanan
            //               from pesanan
            //               WHERE kd_pesanan=(SELECT MAX(kd_pesanan) FROM pesanan);";

            //string sql = @"SELECT MAX(right(kd_pesanan,2)) as nopesanan FROM pesanan";

            string sql = @"SELECT RIGHT(kd_produsen,3) AS noprodusen FROM produsen order by noprodsen desc LIMIT 1";


            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                using (MySqlDataReader dtr = cmd.ExecuteReader())
                {
                    // panggil method Read untuk mendapatkan baris dari result set
                    if (dtr.Read())
                    {
                        no = Convert.ToInt32(dtr["noprodusen"]);
                    }
                }
            }

            return no;
        }
    }
}
