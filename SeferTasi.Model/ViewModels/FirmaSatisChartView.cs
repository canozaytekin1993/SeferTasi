using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasi.Model.ViewModels
{
    public class FirmaSatisChartView
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public bool SatistaMi { get; set; }
        public double Yildiz { get; set; } = 0;
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public int FirmaID { get; set; }
        public int Adet { get; set; }
        public int Toplam { get; set; }

        public override string ToString()
        {
            return $"{UrunAdi} {Toplam}";
        }
    }
}
