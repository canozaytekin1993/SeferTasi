using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasi.Model.Entities
{
    [Table("Yoneticiler")]
    public class Yonetici:Insan
    {
        [Key]
        public int ID { get; set; }
    }
}
