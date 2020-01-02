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
    public class ProdusenController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private ProdusenRepository _repository;

        public int Create(Produsen prod)
        {
            int result = 0;

            // Validasi Kode produsen tidak boleh NULL
            if (string.IsNullOrEmpty(prod.KdProdusen))
            {
                MessageBox.Show("Kode Produsen harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Validasi nama tidak boleh NULL
            if (string.IsNullOrEmpty(prod.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Validasi alamat tidak boleh NULL
            if (string.IsNullOrEmpty(prod.Alamat))
            {
                MessageBox.Show("Alamat harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Validasi telepon tidak boleh NULL
            if (string.IsNullOrEmpty(prod.Telpon))
            {
                MessageBox.Show("Telepon harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new ProdusenRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(prod);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Produsen berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Produsen gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Produsen prod)
        {
            int result = 0;

            // Validasi kode produsen tidak boleh NULL
            if (string.IsNullOrEmpty(prod.KdProdusen))
            {
                MessageBox.Show("Kode Produsen harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Validasi nama tidak boleh NULL
            if (string.IsNullOrEmpty(prod.Nama))
            {
                MessageBox.Show("Kode Produsen harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Validasi alamat tidak boleh NULL
            if (string.IsNullOrEmpty(prod.Alamat))
            {
                MessageBox.Show("Kode Produsen harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // Validasi telepon tidak boleh NULL
            if (string.IsNullOrEmpty(prod.Telpon))
            {
                MessageBox.Show("Kode Produsen harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new ProdusenRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Update(prod);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Produsen berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Produsen gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public List<Produsen> ReadAllProdusen()
        {
            List<Produsen> list = new List<Produsen>();

            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new ProdusenRepository(context);

                // panggil method Create class repository untuk menambahkan data
                list = _repository.ReadAll();
            }

            return list;

        }

        public List<Produsen> ReadByNama(string nama)
        {
            // membuat objek collection
            List<Produsen> list = new List<Produsen>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new ProdusenRepository(context);

                // panggil method GetByNama yang ada di dalam class repository
                list = _repository.ReadByNama(nama);
            }

            return list;
        }

        public int Delete(Produsen prod)
        {
            int result = 0;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new ProdusenRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(prod);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Produsen berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Produsen gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int noProdusen()
        {
            int no;
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new ProdusenRepository(context);

                // panggil method Create class repository untuk menambahkan data
                no = _repository.NoProdusen();
            }

            return no;
        }
    }
}
