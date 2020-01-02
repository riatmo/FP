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
    class PembelianRepository
    {
        private MySqlConnection _conn;

        public PembelianRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Pembelian pbl)
        {
            int result = 0;

            string sql = @"insert into pembelian (kd_pembelian, tgl_pembelian, nama_barang, jumlah_barang, harga_beli, kd_produsen, kd_barang, kd_pesanan, kd_admin) 
                        values (@kd_pembelian, @tgl_pembelian, @nama_barang, @jumlah_barang, @harga_beli, @kd_produsen, @kd_barang, @kd_pesanan, kd_admin)";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd_pembelian", pbl.KdPembelian);
                cmd.Parameters.AddWithValue("@tgl_pembelian", pbl.TglPembelian);
                cmd.Parameters.AddWithValue("@nama_barang", pbl.NamaBarang);
                cmd.Parameters.AddWithValue("@jumlah_barang", pbl.Jumlah);
                cmd.Parameters.AddWithValue("@harga_beli", pbl.HargaBeli);
                cmd.Parameters.AddWithValue("@kd_produsen", pbl.KdProdusen);
                cmd.Parameters.AddWithValue("@kd_barang", pbl.KdBarang);
                cmd.Parameters.AddWithValue("@kd_pesanan", pbl.KdPesanan);
                cmd.Parameters.AddWithValue("@kd_admin", pbl.KdAdmin);                

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error : {0}", ex.Message);
                }
            }

            return result;
        }

        public int Update(Pembelian pbl)
        {
            int result = 0;

            // deklarasi perintah SQL

            string sql = @"update pembelian set tgl_pembelian = @tgl_pembelian,  nama_barang = @nama_barang, jumlah_barang = @jumlah_barang, harga_beli = @harga_beli, 
                            kd_produsen = @kd_produsen, kd_barang = @kd_barang, kd_pesanan = @kd_pesanan, kd_admin = @kd_admin
                           where kd_pembelian = @kd_pembelian";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya                
                cmd.Parameters.AddWithValue("@tgl_pembelian", pbl.TglPembelian);
                cmd.Parameters.AddWithValue("@nama_barang", pbl.NamaBarang);
                cmd.Parameters.AddWithValue("@jumlah_barang", pbl.Jumlah);
                cmd.Parameters.AddWithValue("@harga_beli", pbl.HargaBeli);
                cmd.Parameters.AddWithValue("@kd_produsen", pbl.KdProdusen);
                cmd.Parameters.AddWithValue("@kd_barang", pbl.KdBarang);
                cmd.Parameters.AddWithValue("@kd_pesanan", pbl.KdPesanan);
                cmd.Parameters.AddWithValue("@kd_admin", pbl.KdAdmin);
                cmd.Parameters.AddWithValue("@kd_pembelian", pbl.KdPembelian);

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

        public int Delete(Pembelian pbl)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from pembelian
                           where kd_pembelian = @kd_pembelian";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_pembelian", pbl.KdPembelian);

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

        public List<Pembelian> ReadAll()
        {
            List<Pembelian> list = new List<Pembelian>();

            try
            {
                string sql = @"select kd_pembelian, tgl_pembelian, nama_barang, jumlah_barang, harga_beli, kd_produsen, kd_barang, kd_pesanan, kd_admin
                from pembelian order by kd_pembelian";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Pembelian pbl = new Pembelian();
                            pbl.KdPembelian = dtr["kd_pembelian"].ToString();
                            pbl.TglPembelian = dtr["tgl_pembelian"].ToString();
                            pbl.NamaBarang = dtr["nama_barang"].ToString();
                            pbl.NamaBarang = dtr["jumlah_barang"].ToString();
                            pbl.HargaBeli = Convert.ToInt32(dtr["harga_beli"].ToString());
                            pbl.KdProdusen = dtr["kd_produsen"].ToString();
                            pbl.KdBarang = dtr["kd_barang"].ToString();
                            pbl.KdPesanan = dtr["kd_pesanan"].ToString();
                            pbl.KdAdmin = dtr["kd_admin"].ToString();

                            list.Add(pbl);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Read All error : {0}", ex.Message);
            }
            return list;
        }

        public List<Pembelian> ReadByNama(string nama)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Pembelian> list = new List<Pembelian>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select kd_pembelian, tgl_pembelian, nama_barang, jumlah_barang, harga_beli, kd_produsen, kd_barang, kd_pesanan, kd_admin
                               from pembelian 
                               where nama_barang like @nama_barang
                               order by nama_barang";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@nama_barang", "%" + nama + "%");

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {   
                            // proses konversi dari row result set ke object
                            Pembelian pbl = new Pembelian();
                            pbl.KdPembelian = dtr["kd_pembelian"].ToString();
                            pbl.TglPembelian = dtr["tgl_pembelian"].ToString();
                            pbl.NamaBarang = dtr["nama_barang"].ToString();
                            pbl.NamaBarang = dtr["jumlah_barang"].ToString();
                            pbl.HargaBeli = Convert.ToInt32(dtr["harga_beli"].ToString());
                            pbl.KdProdusen = dtr["kd_produsen"].ToString();
                            pbl.KdBarang = dtr["kd_barang"].ToString();
                            pbl.KdPesanan = dtr["kd_pesanan"].ToString();
                            pbl.KdAdmin = dtr["kd_admin"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(pbl);
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

    }
}