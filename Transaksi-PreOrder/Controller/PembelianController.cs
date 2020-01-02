using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Transaksi_PreOrder.Model.Entity;
using Transaksi_PreOrder.Model.Repository;
using Transaksi_PreOrder.Model.Context;

namespace Transaksi_PreOrder.Controller
{
    public class PembelianController
    {
        // CRUD
        private PembelianRepository _repository;

        public int Create(Pembelian pbl)
        {
            int result = 0;

            // kode pembelian wajib diisi
            if (string.IsNullOrEmpty(pbl.KdPembelian))
            {
                MessageBox.Show("Kode pembelian harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // nama barang wajib diisi
            if (string.IsNullOrEmpty(pbl.NamaBarang))
            {
                MessageBox.Show("Nama barang haru diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Harga pembelian wajib diisi
            if (string.IsNullOrEmpty(Convert.ToString(pbl.HargaBeli)))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // produsen
            if (string.IsNullOrEmpty(pbl.KdProdusen))
            {
                MessageBox.Show("Kode produsen harus diisi !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Barang
            if (string.IsNullOrEmpty(pbl.KdBarang))
            {
                MessageBox.Show("Kode barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Pesanan
            if (string.IsNullOrEmpty(pbl.KdPesanan))
            {
                MessageBox.Show("Kode pesanan harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Admin
            if (string.IsNullOrEmpty(pbl.KdAdmin))
            {
                MessageBox.Show("Kode barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // buat clas repo
                _repository = new PembelianRepository(context);

                // manggil method repo biar nambah data
                result = _repository.Create(pbl);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pembelian berhasil disimpan !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data pembelian gagal disimpan !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }

        public int Update(Pembelian pbl)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(pbl.KdPembelian))
            {
                MessageBox.Show("Kode pembelian harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(pbl.NamaBarang))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Convert.ToString(pbl.HargaBeli)))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(Convert.ToString(pbl.Jumlah)))
            {
                MessageBox.Show("Harga harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pbl.Jumlah))
            {
                MessageBox.Show("Jumlah harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pbl.KdBarang))
            {
                MessageBox.Show("Kode Barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new PembelianRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Update(pbl);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pembelian disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pembelian gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Pembelian pbl)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(pbl.KdPembelian))
            {
                MessageBox.Show("KD pembelian harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PembelianRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(pbl);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pembelian berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data pembelian gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public List<Pembelian> ReadAllPembelian()
        {
            List<Pembelian> list = new List<Pembelian>();

            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new PembelianRepository(context);

                // panggil method Create class repository untuk menambahkan data
                list = _repository.ReadAll();
            }

            return list;

        }

        public List<Pembelian> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Pembelian> list = new List<Pembelian>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PembelianRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }

            return list;
        }
    }
}