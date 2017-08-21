using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasi.Model.Entities
{
    [Table("SiparisDetaylari")]
    public class SiparisDetay
    {
        [Key]
        [Column(Order = 1)]
        public int SiparisID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int UrunID { get; set; }
        public decimal UrunFiyat { get; set; }
        public int Adet { get; set; }
        [ForeignKey("UrunID")]
        public virtual Urun Urun { get; set; }
        [ForeignKey("SiparisID")]
        public virtual Siparis Siparis { get; set; }
        public override string ToString()
        {
            return $"{this.Adet} x {this.Urun.UrunAdi} \t {this.Adet*this.UrunFiyat}";
        }
    }
}
