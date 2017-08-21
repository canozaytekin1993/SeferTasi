using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasi.Model.Entities
{
    [Table("Siparisler")]
    public class Siparis
    {
        [Key]
        public int ID { get; set; }
        public int MusteriID { get; set; }
        public int FirmaID { get; set; }
        [Required]
        public string OdemeTipi { get; set; }
        public DateTime SiparisTarihi { get; set; } = DateTime.Now;
        public DateTime? TeslimTarihi { get; set; }
        public int? Yildiz { get; set; }
        public DateTime IstenenTarih { get; set; }
        [ForeignKey("MusteriID")]
        public virtual Musteri Musteri { get; set; }
        [ForeignKey("FirmaID")]
        public virtual Firma Firma { get; set; }
        public virtual List<SiparisDetay> SiparisDetaylari { get; set; } = new List<SiparisDetay>();
    }

}
