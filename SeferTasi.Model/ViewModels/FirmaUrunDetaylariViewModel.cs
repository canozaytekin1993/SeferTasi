using SeferTasi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasi.Model.ViewModels
{
    public class FirmaUrunDetaylariViewModel
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public byte[] Fotograf { get; set; }
        public decimal Fiyat { get; set; }
        public bool SatistaMi { get; set; }
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public int FirmaID { get; set; }
        public Urun Urun { get; set; }
        public Firma Fimra { get; set; }
        public override string ToString()
        {
            return $"{UrunAdi}     \t{Fiyat:c}";
        }
    }
}
