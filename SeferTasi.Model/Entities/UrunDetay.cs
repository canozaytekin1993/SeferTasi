using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasi.Model.Entities
{
    [Table("Urun Detaylari")]
    public class UrunDetay
    {
        [Key]
        [Column(Order = 1)]
        public int UrunID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int FirmaID { get; set; }
        public decimal UrunFiyat { get; set; } = 0;
        public bool SatistaMi { get; set; } = true;
        [ForeignKey("UrunID")]
        public virtual Urun Urun { get; set; }
        [ForeignKey("FirmaID")]
        public virtual Firma Firma { get; set; }
    }
}
