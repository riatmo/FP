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
    public class PesananController
    {
        //objek CRUD
        private PesananRepository _repository;


        public int Create(Pesanan psn)
        {
            int result1 = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(psn.KdPesanan))
            {
                MessageBox.Show("Kode barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new PesananRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result1 = _repository.Create(psn);
            }

            if (result1 > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data mahasiswa gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result1;
        }

        public int Update(Pesanan psn)
        {
            int result1 = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(psn.KdPesanan))
            {
                MessageBox.Show("Kode barang harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new PesananRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result1 = _repository.Update(psn);
            }

            if (result1 > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data mahasiswa gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result1;
        }

        public List<Pesanan> ReadAllPesanan()
        {
            List<Pesanan> list = new List<Pesanan>();

            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new PesananRepository(context);

                // panggil method Create class repository untuk menambahkan data
                list = _repository.ReadAll();
            }

            return list;

        }

        public int Delete(Pesanan psn)
        {
            int result = 0;


            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PesananRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(psn);
            }

            if (result > 0)
            {
                MessageBox.Show("Data mahasiswa berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data mahasiswa gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int noPesanan()
        {
            int no;
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new PesananRepository(context);

                // panggil method Create class repository untuk menambahkan data
                no = _repository.NoPesanan();
            }

            return no;
        }

        public int Total(string kdpsn)
        {
            int no;
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new PesananRepository(context);

                // panggil method Create class repository untuk menambahkan data
                no = _repository.Total(kdpsn);
            }

            return no;
        }

        public string Nama(string kdpel)
        {
            string nama;
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new PesananRepository(context);

                // panggil method Create class repository untuk menambahkan data
                nama = _repository.Nama(kdpel);
            }

            return nama;
        }

    }
}
