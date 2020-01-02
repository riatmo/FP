using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaksi_PreOrder.Model.Entity
{
    public class Pesanan
    {
        public string KdPesanan { get; set; }
        public string CaraBayar { get; set; }
        public string TglPesan { get; set; }
        public string JatuhTempo { get; set; }
        public string KdPembeli { get; set; }
        public string Catatan { get; set; }
        public int Dp { get; set; }
        public int total { get; set; }
        public int SisaPembayaran { get; set; }
        public string KdAdmin { get; set; }
        public string StatusPesanan { get; set; }
    }
}
