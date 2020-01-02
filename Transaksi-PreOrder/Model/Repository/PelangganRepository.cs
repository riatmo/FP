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
    public class PelangganRepository
    {
        private MySqlConnection _conn;

        public PelangganRepository(DbContext context)
        {
            _conn = context.Conn;
        }


        public int Create(Pelanggan pelanggan)
        {
            int result = 0;


            
            string sql = @"insert into pembeli(kd_pembeli, nama_pembeli, telp_pembeli, alamat_pembeli, kecamatan, kabupaten, provinsi, kode_pos)
                           values (@kd_pembeli, @nama_pembeli, @telp_pembeli, @alamat_pembeli, @kecamatan, @kabupaten, @provinsi, @kode_pos)";
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_pembeli", pelanggan.KdPembeli);
                cmd.Parameters.AddWithValue("@nama_pembeli", pelanggan.Nama);
                cmd.Parameters.AddWithValue("@telp_pembeli", pelanggan.Hp);
                cmd.Parameters.AddWithValue("@alamat_pembeli", pelanggan.Alamat);
                cmd.Parameters.AddWithValue("@kecamatan", pelanggan.Kecamatan);
                cmd.Parameters.AddWithValue("@kabupaten", pelanggan.Kabupaten);
                cmd.Parameters.AddWithValue("@provinsi", pelanggan.Provinsi);
                cmd.Parameters.AddWithValue("@kode_pos", pelanggan.KodePos);

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

        public List<Pelanggan> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Pelanggan> list = new List<Pelanggan>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select kd_pembeli, nama_pembeli, telp_pembeli, alamat_pembeli, kecamatan, kabupaten, provinsi, kode_pos
                                from pembeli
                               order by nama_pembeli";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pelanggan plg = new Pelanggan();

                            plg.KdPembeli = dtr["kd_pembeli"].ToString();
                            plg.Nama = dtr["nama_pembeli"].ToString();
                            plg.Hp = dtr["telp_pembeli"].ToString();
                            plg.Alamat = dtr["alamat_pembeli"].ToString();
                            plg.Kecamatan = dtr["kecamatan"].ToString();
                            plg.Kabupaten = dtr["provinsi"].ToString();
                            plg.Provinsi = dtr["provinsi"].ToString();
                            plg.KodePos = dtr["kode_pos"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(plg);
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

        public int Update(Pelanggan pel)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update pembeli set  nama_pembeli =@nama_pembeli, telp_pembeli=@telp_pembeli, alamat_pembeli=@alamat_pembeli, kecamatan=@kecamatan, kabupaten=@kabupaten, provinsi=@provinsi, kode_pos=@kode_pos
                           where kd_pembeli = @kd_pembeli";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_pembeli", pel.KdPembeli);
                cmd.Parameters.AddWithValue("@nama_pembeli", pel.Nama);
                cmd.Parameters.AddWithValue("@telp_pembeli", pel.Hp);
                cmd.Parameters.AddWithValue("@alamat_pembeli", pel.Alamat);
                cmd.Parameters.AddWithValue("@kecamatan", pel.Kecamatan);
                cmd.Parameters.AddWithValue("@kabupaten", pel.Kabupaten);
                cmd.Parameters.AddWithValue("@provinsi", pel.Provinsi);
                cmd.Parameters.AddWithValue("@kode_pos", pel.KodePos);


                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(Pelanggan pel)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from pembeli
                           where kd_pembeli = @kd_pembeli";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_pembeli", pel.KdPembeli);

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




    }
}
