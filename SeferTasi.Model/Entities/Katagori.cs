using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasi.Model.Entities
{
    [Table("Kategoriler")]
    public class Kategori
    {
        private string _kategoriAdi;
        [Key]
        public int ID { get; set; }
        [Required]
        [MaxLength(25)]
        public string KategoriAdi
        {
            get { return _kategoriAdi; }
            set
            {
                foreach (char c in value)
                {
                    if (char.IsDigit(c)) throw new Exception("Kategori Adında Rakam Bulunamaz");
                }
                _kategoriAdi = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }
        public virtual List<Urun> Urunler { get; set; } = new List<Urun>();
        public override string ToString()
        {
            return KategoriAdi;
        }
    }
}
