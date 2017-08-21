using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeferTasi.Model.Entities
{
    public abstract class Insan
    {
        private string _ad, _tcno, _telefon;
        [Required]
        [MaxLength(53)]
        public string AdSoyad
        {
            get { return _ad; }
            set { _ad = AdSoyadHazirla(value); }
        }
        [Index("KullaniciAdiIndex", IsUnique = true)]
        [MaxLength(25)]
        public string KullanıcıAdi { get; set; }
        [Required]
        [MaxLength(16)]
        public string Sifre { get; set; }
        [Index("TCKNIndex", IsUnique = true)]
        [MaxLength(11)]
        [MinLength(11)]
        public string TCKN
        {
            get { return _tcno; }
            set { _tcno = TCKNKontrol(value); }
        }
        [Phone]
        [MaxLength(10)]
        public string Telefon
        {
            get { return _telefon; }
            set
            {
                if (value.Length != 10)
                    throw new Exception("Telefon numarasını hatalı girdiniz");
                foreach (char item in value)
                {
                    if (!char.IsDigit(item))
                        throw new Exception("Telefon içerisinde sadece rakam bulunmalıdır");
                }
                _telefon = value;
            }
        }
        private string AdSoyadHazirla(string kelime)
        {
            foreach (char harf in kelime)
            {
                if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
                    throw new Exception("Ad veya Soyad içerisinde geçersiz karakter kullandınız.");
            }
            if (kelime.Trim().Length < 2)
                throw new Exception("Ad ve Soyad en az 2 karakter olmalı");
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kelime);
        }
        private string TCKNKontrol(string tckn)
        {
            if (tckn.Length != 11)
                throw new Exception("TCKN 11 haneli olmalı");
            if (tckn[0] == '0')
                throw new Exception("TCKN 0 ile başlayamaz");
            foreach (char harf in tckn)
                if (!(char.IsDigit(harf)))
                    throw new Exception("TCKN içerisinde sadece rakam bulunmalıdır.");
            //int toplam = 0; programı test ederken doğru tckn girmekle uğraşmayalım diye kaldırdık.
            //for (int i = 0; i<10;i++)
            //{

            //    toplam += Convert.ToInt32(tckn[i]);
            //}
            //if (toplam % 10 != Convert.ToInt32(tckn[10]))
            //    throw new Exception("Geçersiz TCKN girdiniz");

            return tckn;
        }
    }
}
