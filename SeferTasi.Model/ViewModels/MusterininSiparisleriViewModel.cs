using System;

namespace SeferTasi.BLL.Repository
{
    public class MusterininSiparisleriViewModel
    {
        public int SiparisID { get; set; }
        public int FirmaID { get; set; }
        public string FirmaAdi { get; set; }
        public decimal Tutar { get; set; }
        public int Adet { get; set; }
        public int? Yildiz { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        public override string ToString()
        {
            return $"{FirmaAdi} \t {Tutar:c}";
        }
    }
}