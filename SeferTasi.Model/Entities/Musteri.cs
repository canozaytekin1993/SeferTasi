using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasi.Model.Entities
{
    [Table("Musteriler")]
    public class Musteri:Insan
    {
        [Key]
        public int ID { get; set; }
        [Index("EMailIndex", IsUnique = true)]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(250)]
        public string Adres { get; set; }
        public virtual List<Siparis> Siparisler { get; set; } = new List<Siparis>();

    }
}
