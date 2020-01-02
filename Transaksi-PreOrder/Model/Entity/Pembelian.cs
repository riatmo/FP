using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaksi_PreOrder.Model.Entity
{
    public class Pembelian
    {
        public string KdPembelian { get; set; }
        public string TglPembelian { get; set; }
        public string NamaBarang { get; set; }
        public int HargaBeli { get; set; }
        public string KdProdusen { get; set; }
        public string KdBarang { get; set; }
        public string KdPesanan { get; set; }
        public string KdAdmin { get; set; }
        public string Jumlah { get; set; }
        public string SubTotal { get; set; }
    }
}
