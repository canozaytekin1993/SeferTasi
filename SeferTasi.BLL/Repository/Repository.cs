using SeferTasi.DAL;
using SeferTasi.Model.Entities;
using SeferTasi.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasi.BLL.Repository
{
    public class FirmaRepo : RepositoryBase<Firma, int>
    {
        public Firma FirmayiGetir(int firmaid)
        {
            Firma firma = new FirmaRepo().GetAll().FirstOrDefault(x => x.ID == firmaid);
            return firma;
        }
        public int FirmaYildiziGuncelle(int firmaid, out int siparissayisi)
        {
            MyContext db = new MyContext();
            List<Siparis> Firmaninsiparisleri = new SiparisRepo().GetAll().Where(x => x.FirmaID == firmaid).ToList();
            int yildiz = Firmaninsiparisleri.Sum(x => x.Yildiz.Value);
            siparissayisi = Firmaninsiparisleri.Count(x => x.Yildiz > 0);
            return yildiz;
        }
        public List<FirmaTuruViewModel> FirmaTurleriniGetir()
        {
            MyContext db = new MyContext();
            var firmaturleri = from firma in db.Firmalar
                               group new
                               {
                                   firma
                               } by new
                               {
                                   firma.FirmaTuru
                               } into firmaturugrup
                               select new FirmaTuruViewModel
                               {
                                   FirmaTuru = firmaturugrup.Key.FirmaTuru
                               };
            return firmaturleri.ToList();
        }
        public static Firma GirisYapan { get; set; } = new Firma();
        public Firma GirisYapanFirma(string kullaniciAdi, string sifre)
        {
            List<Firma> Firmalar = new FirmaRepo().GetAll().Where(x => x.AktifMi).ToList();
            Firma Firma = Firmalar.FirstOrDefault(x => x.KullanıcıAdi == kullaniciAdi && x.Sifre == sifre);
            return Firma;
        }
        public List<FirmaUrunDetaylariViewModel> FirmaninUrunDetaylari(int id)
        {
            MyContext db = new MyContext();
            var firmaurunleri = from f in db.Firmalar
                                join ud in db.UrunDetaylari on f.ID equals ud.FirmaID
                                join u in db.Urunler on ud.UrunID equals u.ID
                                where f.ID == id
                                select new FirmaUrunDetaylariViewModel
                                {
                                    UrunAdi = u.UrunAdi,
                                    Fiyat = ud.UrunFiyat,
                                    UrunID = u.ID,
                                    FirmaID = id,
                                    Fimra = ud.Firma,
                                    Urun = ud.Urun,
                                    KategoriAdi = u.Kategori.KategoriAdi,
                                    SatistaMi = ud.SatistaMi,
                                    KategoriID = u.KategoriID,
                                    Fotograf = u.Fotograf
                                };
            return firmaurunleri.ToList();
        }
        
        public List<FirmaSatisChartView> FirmaSatisChartRapor(int id)
        {
            MyContext db = new MyContext();
            var chart = from f in db.Firmalar
                        join s in db.Siparisler on f.ID equals s.FirmaID
                        join sd in db.SiparisDetaylar on s.ID equals sd.SiparisID
                        join u in db.Urunler on sd.UrunID equals u.ID
                        where f.ID == id
                        group new
                        {
                            sd,
                            u
                        } by new
                        {
                            u.UrunAdi,
                            sd.UrunID
                        } into chartGrup
                        select new FirmaSatisChartView
                        {
                            UrunAdi = chartGrup.Key.UrunAdi,
                            UrunID = chartGrup.Key.UrunID,
                            Toplam = chartGrup.Sum(x => x.sd.Adet)
                        };
            return chart.ToList();
        }

        public List<FirmaVerilenSiparislerViewModel> FirmaVerilenSiparisRapor(int id)
        {

            MyContext db = new MyContext();
            var firmaninraporlari = from f in db.Firmalar
                                    join ud in db.UrunDetaylari on f.ID equals ud.FirmaID
                                    join u in db.Urunler on ud.UrunID equals u.ID
                                    join sd in db.SiparisDetaylar on u.ID equals sd.UrunID
                                    join s in db.Siparisler on sd.SiparisID equals s.ID
                                    join m in db.Musteriler on s.MusteriID equals m.ID
                                    join k in db.Kategoriler on u.KategoriID equals k.ID
                                    where f.ID == id
                                    group new
                                    {
                                        s,
                                        sd,
                                        m
                                    } by new
                                    {
                                        s.ID,
                                        m.AdSoyad,
                                        s.SiparisTarihi,
                                        s.TeslimTarihi

                                    } into firmaGrup
                                    select new FirmaVerilenSiparislerViewModel
                                    {
                                        SiparisID = firmaGrup.Key.ID,
                                        MusteriAdiSoyadi = firmaGrup.Key.AdSoyad,
                                        SiparisTarihi = firmaGrup.Key.SiparisTarihi,
                                        Toplam = firmaGrup.Sum(x => x.sd.UrunFiyat),
                                        TeslimTarihi = firmaGrup.Key.TeslimTarihi
                                    };
            return firmaninraporlari.ToList();


            //MyContext db = new MyContext();
            //var firmaninraporlari = from f in db.Firmalar
            //                        join ud in db.UrunDetaylari on f.ID equals ud.FirmaID
            //                        join u in db.Urunler on ud.UrunID equals u.ID
            //                        join sd in db.SiparisDetaylar on u.ID equals sd.UrunID
            //                        join s in db.Siparisler on sd.SiparisID equals s.ID
            //                        join m in db.Musteriler on s.MusteriID equals m.ID
            //                        join k in db.Kategoriler on u.KategoriID equals k.ID
            //                        where f.ID == id
            //                        select new FirmaVerilenSiparislerViewModel
            //                        {
            //                            Adet = sd.Adet,
            //                            Adres = m.Adres,
            //                            FirmaAdi = f.FirmaAdi,
            //                            Fiyat = ud.UrunFiyat,
            //                            MusteriAdiSoyadi = m.AdSoyad,
            //                            SiparisID = s.ID,
            //                            SiparisTarihi = s.SiparisTarihi,
            //                            TeslimTarihi = s.TeslimTarihi,
            //                            UrunAdi = u.UrunAdi
            //                        };
            //return firmaninraporlari.ToList();
        }
    }
    public class KategoriRepo : RepositoryBase<Kategori, int> { }
    public class MusteriRepo : RepositoryBase<Musteri, int>
    {
        public static Musteri GirisYapan { get; set; } = new Musteri();
        public Musteri GirisYapanMusteri(string kullaniciAdi, string sifre)
        {
            List<Musteri> Musteriler = new MusteriRepo().GetAll();
            Musteri musteri = Musteriler.FirstOrDefault(x => x.KullanıcıAdi == kullaniciAdi && x.Sifre == sifre);
            return musteri;
        }
        public List<MusterininSiparisleriViewModel> MusteriSiparisGecmisRapor(int id)
        {
            MyContext db = new MyContext();
            var musterninsiparisleri = from m in db.Musteriler
                                       join s in db.Siparisler on m.ID equals s.MusteriID
                                       join sd in db.SiparisDetaylar on s.ID equals sd.SiparisID
                                       join f in db.Firmalar on s.FirmaID equals f.ID
                                       where m.ID == id
                                       group new
                                       {
                                           sd.UrunFiyat,
                                           sd.Adet,
                                           f.FirmaAdi,
                                       } by new
                                       {
                                           sd.SiparisID,
                                           f.FirmaAdi,
                                           s.TeslimTarihi,
                                           s.Yildiz,
                                           f.ID
                                       } into siparisgrup
                                       select new MusterininSiparisleriViewModel
                                       {
                                           FirmaAdi = siparisgrup.Key.FirmaAdi,
                                           Tutar = siparisgrup.Sum(x => x.UrunFiyat * x.Adet),
                                           TeslimTarihi = siparisgrup.Key.TeslimTarihi,
                                           SiparisID = siparisgrup.Key.SiparisID,
                                           Yildiz = siparisgrup.Key.Yildiz,
                                           FirmaID = siparisgrup.Key.ID
                                       };
            return musterninsiparisleri.ToList();
            //MyContext db = new MyContext();
            //var rapor = from m in db.Musteriler
            //            join s in db.Siparisler on m.ID equals s.MusteriID
            //            join sd in db.SiparisDetaylar on s.ID equals sd.SiparisID
            //            join u in db.Urunler on sd.UrunID equals u.ID
            //            join ud in db.UrunDetaylari on u.ID equals ud.UrunID
            //            join f in db.Firmalar on s.FirmaID equals f.ID
            //            where m.ID == id
            //            select new MusteriGecmisSiparislerViewModel
            //            {
            //                SiparisID = s.ID,
            //                MusteriID = m.ID,
            //                FirmaAdi = f.FirmaAdi,
            //                UrunAdi = u.UrunAdi,
            //                Adet = sd.Adet,
            //                Fiyat = ud.UrunFiyat,
            //                Toplam = ud.UrunFiyat * sd.Adet,
            //                TeslimTarihi = s.TeslimTarihi
            //            };
            //return rapor.ToList();
        }
    }
    public class SiparisRepo : RepositoryBase<Siparis, int>
    {
        
        public Siparis SiparisiGetir(int siparisid)
        {
            Siparis siparis = new SiparisRepo().GetAll().FirstOrDefault(x => x.ID == siparisid);
            return siparis;
        }
        public bool SiparisiOlustur(Siparis yeniSiparis, List<SiparisDetay> sepet)
        {
            using (MyContext db = new MyContext())
            {
                using (var tran = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Siparisler.Add(yeniSiparis);
                        db.SaveChanges();
                        foreach (var item in sepet)
                        {
                            db.SiparisDetaylar.Add(new SiparisDetay()
                            {
                                SiparisID = yeniSiparis.ID,
                                UrunID = item.UrunID,
                                Adet = item.Adet,
                                UrunFiyat = item.UrunFiyat
                            });
                        }
                        db.SaveChanges();
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        return false;
                    }
                }
            }
            return true;
        }
    }
    public class SiparisDetayRepo : RepositoryBase<SiparisDetay, int> { }
    public class UrunRepo : RepositoryBase<Urun, int>
    {
        public List<Urun> GetAllByCategory(Kategori kategori)
        {
            dbContext = new MyContext();
            Kategori kat = dbContext.Kategoriler.Find(kategori.ID);
            return kat != null ? kat.Urunler : new List<Urun>();
        }

    }
    public class UrunDetayRepo : RepositoryBase<UrunDetay, int>
    {
        public UrunDetay FirmaninUrunDetayi(int firmaid, int urunid)
        {
            UrunDetay urundetay = new UrunDetayRepo().GetAll().FirstOrDefault(x => x.FirmaID == firmaid && x.UrunID == urunid);
            return urundetay;
        }
        public List<UrunDetay> ProductSearch(string key)
        {
            return this.GetAll().Where(x => x.SatistaMi).Where(y => (y.Urun.UrunAdi.ToLower().Contains(key.ToLower()))).ToList();
        }
        public List<UrunDetay> TumAktifUrunDetaylariGetir(int firmaid)
        {
            return new MyContext().UrunDetaylari.Where(x => x.SatistaMi).ToList();
        }
        public void Delete(int firmaid, int urunid) //basedeki sqlden siliyor. burda satıştamı false yapılıyor.
        {
            try
            {
                UrunDetay silinecek = new UrunDetayRepo().GetAll().FirstOrDefault(x => x.FirmaID == firmaid && x.UrunID == urunid);
                if (silinecek == null) return;
                silinecek.SatistaMi = false;
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public class YoneticiRepo : RepositoryBase<Yonetici, int>
    {
        public Yonetici GirisYapanYonetici(string kullaniciAdi, string sifre)
        {
            List<Yonetici> Yoneticiler = new YoneticiRepo().GetAll();
            Yonetici yonetici = Yoneticiler.FirstOrDefault(x => x.KullanıcıAdi == kullaniciAdi && x.Sifre == sifre);
            return yonetici;
        }
        public void KullaniciAdiKontrol(string kullaniciAdi, string tckn, string email, string telefon)
        {
            List<Yonetici> Yoneticiler = new YoneticiRepo().GetAll();
            foreach (var item in Yoneticiler)
            {
                if (item.KullanıcıAdi == kullaniciAdi) throw new Exception("Bu kullanıcı adı zaten mevcut");
                if (item.TCKN == tckn) throw new Exception("TCKN numarası daha önce kullanılmış");
                if (item.Telefon == telefon) throw new Exception("Telefon numarası daha önce kullanılmış");
            }
            List<Firma> Firmalar = new FirmaRepo().GetAll();
            foreach (var item in Firmalar)
            {
                if (item.KullanıcıAdi == kullaniciAdi) throw new Exception("Bu kullanıcı adı zaten mevcut");
            }
            List<Musteri> Musteriler = new MusteriRepo().GetAll();
            foreach (var item in Musteriler)
            {
                if (item.KullanıcıAdi == kullaniciAdi) throw new Exception("Bu kullanıcı adı zaten mevcut");
                if (item.TCKN == tckn) throw new Exception("TCKN numarası daha önce kullanılmış");
                if (item.Email == email) throw new Exception("Bu email adresi kullanılıyor");
                if (item.Telefon == telefon) throw new Exception("Telefon numarası daha önce kullanılmış");

            }
        }
    }
}

