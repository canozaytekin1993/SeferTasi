using SeferTasi.Model.Entities;
using System;

namespace SeferTasi.Model.ViewModels
{
    public class MusteriGecmisSiparislerViewModel
    {
        public int SiparisID { get; set; }
        public string FirmaAdi { get; set; }
        public string UrunAdi { get; set; }
        public string FirmaTuru { get; set; }
        public string KategoriAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
        public decimal Toplam { get; set; }
        public int MusteriID { get; set; }
        public int MinimumTeslimSuresi { get; set; }
        public DateTime TeslimTarihi { get; set; }

        
    }
}