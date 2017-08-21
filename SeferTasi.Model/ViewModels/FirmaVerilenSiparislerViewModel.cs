using System;

namespace SeferTasi.Model.ViewModels
{
    public class FirmaVerilenSiparislerViewModel
    {
        public int SiparisID { get; set; }
        public string MusteriAdiSoyadi { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }
        public decimal Toplam { get; set; }
        public string Adres { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public string FirmaAdi { get; set; }
        public override string ToString()
        {
            return $"Ad: {MusteriAdiSoyadi} \t  Tutar: {Toplam:c}";
            //Teslim Durumu:{TeslimTarihi==null?"Teslim Edildi":"Teslim Edilmedi"}
        }
    }
}