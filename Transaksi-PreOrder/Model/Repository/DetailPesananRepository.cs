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
    public class DetailPesananRepository
    {
        //objek connection 
        private MySqlConnection _conn;

        //constructor
        public DetailPesananRepository(DbContext context)
        {
            //inisialisasi objek conn
            _conn = context.Conn;
        }

        public int Create(DetailPesanan detailPesanan)
        {
            int result = 0;
            

            //detail pesanan
            string sql = @"insert into detail_pesanan (kd_detail, kd_barang, Qty, Subtotal, kd_pesanan)
                           values (@kd_detail, @kd_barang, @Qty, ( @Qty * (SELECT harga FROM barang WHERE kd_barang = @kd_barang)), @kd_pesanan);

                           UPDATE pesanan SET total = (SELECT SUM(subtotal) FROM detail_pesanan WHERE kd_pesanan = @kd_pesanan)
                           WHERE kd_pesanan = @kd_pesanan
                            ";

            //detail pesanan
            //string sql = @"insert into detail_pesanan (kd_detail,kd_pesanan)
            //               values (@kddetail,@kdpesanan)";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_detail", detailPesanan.KdDetail);
                cmd.Parameters.AddWithValue("@kd_barang", detailPesanan.KdBarang);
                cmd.Parameters.AddWithValue("@Qty", detailPesanan.Qty);
                //cmd.Parameters.AddWithValue("@Subtotal", detail.Subtotal);
                cmd.Parameters.AddWithValue("@kd_pesanan", detailPesanan.KdPesanan);  

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

        public int Update(DetailPesanan detailPesanan)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update detail_pesanan set qty = @qty, kd_barang = @kd_barang, subtotal =( @Qty * (SELECT harga FROM barang WHERE kd_barang = @kd_barang))
                           where kd_detail = @kd_detail";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_barang", detailPesanan.KdBarang);
                cmd.Parameters.AddWithValue("@qty", detailPesanan.Qty);
                cmd.Parameters.AddWithValue("@kd_detail", detailPesanan.KdDetail);


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

        public List<DetailPesanan> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<DetailPesanan> list = new List<DetailPesanan>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select kd_detail,kd_pesanan,kd_barang,qty,subtotal
                               from detail_pesanan order by kd_detail";
                //, tgl_pesanan, jatuh_tempo, sts_pesanan,cara_bayar

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            DetailPesanan detail = new DetailPesanan();

                            detail.KdDetail = dtr["kd_detail"].ToString();
                            detail.KdPesanan = dtr["kd_pesanan"].ToString();
                            detail.KdBarang = dtr["kd_barang"].ToString();
                            detail.Subtotal = Convert.ToInt16(dtr["subtotal"]);
                            detail.Qty = Convert.ToInt16(dtr["qty"]);

                            list.Add(detail);
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

        public int NoDetail(string kdpesanan)
        {
            int no = 0;

            string sql = @"select right(kd_detail,1) as nodetail
                           from detail_pesanan
                           where kd_detail = (SELECT MAX(kd_detail) FROM detail_pesanan where kd_pesanan = @kdpesanan)";
            

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))


            {
                cmd.Parameters.AddWithValue("@kdpesanan", kdpesanan);
                // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                using (MySqlDataReader dtr = cmd.ExecuteReader())
                {
                    // panggil method Read untuk mendapatkan baris dari result set
                    if (dtr.Read())
                    {
                        no = Convert.ToInt16(dtr["nodetail"]);
                    }
                }
            }

            return no;
        }

        public int Delete(DetailPesanan detailPesanan)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"DELETE FROM detail_pesanan where kd_detail=@kd_detail;
UPDATE pesanan SET total = (SELECT SUM(subtotal) FROM detail_pesanan WHERE kd_pesanan = @kd_pesanan)
                           WHERE kd_pesanan = @kd_pesanan
                           
                            ";

                           

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@kd_detail", detailPesanan.KdDetail);
                cmd.Parameters.AddWithValue("@kd_pesanan", detailPesanan.KdPesanan);

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

        public int BacaSUb(string kddet)
        {
            int Subtotal = 0;


            string sql = @"select subtotal
                               from detail_pesanan where kd_detail = @kd_detail";
            //, tgl_pesanan, jatuh_tempo, sts_pesanan,cara_bayar

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kd_detail", kddet);


                using (MySqlDataReader dtr = cmd.ExecuteReader())
                {

                    while (dtr.Read()){
                        Subtotal = Convert.ToInt16(dtr["subtotal"]);
                    }
                    


                }

            }
            return Subtotal;
        }
    }
}
