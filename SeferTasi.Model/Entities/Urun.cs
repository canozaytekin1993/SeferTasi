using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasi.Model.Entities
{
    [Table("Urunler")]
    public class Urun
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string UrunAdi { get; set; }
        public byte[] Fotograf { get; set; }
        public int KategoriID { get; set; }
        [ForeignKey("KategoriID")]
        public virtual Kategori Kategori { get; set; }
        public virtual List<UrunDetay> UrunDetaylari { get; set; } = new List<UrunDetay>();
        public virtual List<SiparisDetay> SiparisDetaylari { get; set; } = new List<SiparisDetay>();
    }
}
