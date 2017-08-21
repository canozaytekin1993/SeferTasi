using SeferTasi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasi.DAL
{
    public class MyContext:DbContext
    {
        public MyContext()
            : base("name=LocalCon")
        {
            this.Database.CreateIfNotExists(); //database yoksa oluşturuyor. bilgileri migrationstan alıyor. update-database görevi görüyor bir nevi.
        }
        public virtual DbSet<Firma> Firmalar { get; set; }
        public virtual DbSet<Musteri> Musteriler { get; set; }
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Yonetici> Yoneticiler { get; set; }
        public virtual DbSet<Siparis> Siparisler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<SiparisDetay> SiparisDetaylar { get; set; }
        public virtual DbSet<UrunDetay> UrunDetaylari { get; set; }

    }
}
