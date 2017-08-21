using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasi.Model.Entities
{
    [Table("Firmalar")]
    public class Firma
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(20)]
        public string FirmaTuru { get; set; }
        [Required]
        [MaxLength(25)]
        public string FirmaAdi { get; set; }
        [Required]
        [MaxLength(16)]
        public string Sifre { get; set; }
        [Index("KullaniciAdiIndex", IsUnique = true)]
        [MaxLength(25)]
        public string KullanıcıAdi { get; set; }
        public double Yildiz { get; set; } = 0;
        public int? MinimumTeslimSuresi { get; set; }
        public bool AktifMi { get; set; } = true;
        public virtual List<UrunDetay> UrunDetaylari { get; set; } = new List<UrunDetay>();
        public virtual List<Siparis> Siparisler { get; set; } = new List<Siparis>();
    }
}
