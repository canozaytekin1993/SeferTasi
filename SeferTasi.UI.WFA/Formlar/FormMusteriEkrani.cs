using SeferTasi.BLL.Repository;
using SeferTasi.Model.Entities;
using SeferTasi.UI.WFA.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeferTasi.UI.WFA
{
    public partial class FormMusteriEkrani : Form
    {
        FormMusteriSiparis FormMusteriSiparis;
        FormMusteriRaporEkrani FormMusteriRapor;
        public FormMusteriEkrani()
        {
            InitializeComponent();
        }

        private void btnSiparisGecmisi_Click(object sender, EventArgs e)
        {
            if (FormMusteriRapor == null || FormMusteriRapor.IsDisposed)
            {
                FormMusteriRapor = new FormMusteriRaporEkrani();
                FormMusteriRapor.Show();
            }
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            if (FormMusteriSiparis == null || FormMusteriSiparis.IsDisposed)
            {
                FormMusteriSiparis = new FormMusteriSiparis();
                FormMusteriSiparis.Show();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                GirisYapanMusteri.AdSoyad = txtAdSoyad.Text;
                GirisYapanMusteri.KullanıcıAdi = txtKullaniciAdi.Text;
                GirisYapanMusteri.Sifre = txtSifre.Text;
                GirisYapanMusteri.Telefon = txtTelefon.Text;
                GirisYapanMusteri.Adres = txtTelefon.Text;
                GirisYapanMusteri.Email = txtEmail.Text;
                GirisYapanMusteri.TCKN = txtTCKN.Text;

                new MusteriRepo().Update();
                MessageBox.Show("Güncelleme başarılı", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    foreach (var ve in eve.ValidationErrors)
                    {
                        MessageBox.Show($"{ve.PropertyName} - {ve.ErrorMessage}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Musteri GirisYapanMusteri;
        private void FormMusteriEkrani_Load(object sender, EventArgs e)
        {
            GirisYapanMusteri = Form1.GirisYapanMusteri;
            this.Text = $"Merhaba {GirisYapanMusteri.KullanıcıAdi}";
            txtAdSoyad.Text = GirisYapanMusteri.AdSoyad;
            txtKullaniciAdi.Text = GirisYapanMusteri.KullanıcıAdi;
            txtSifre.Text = GirisYapanMusteri.Sifre;
            txtTelefon.Text = GirisYapanMusteri.Telefon;
            txtAdres.Text = GirisYapanMusteri.Adres;
            txtEmail.Text = GirisYapanMusteri.Email;
            txtTCKN.Text = GirisYapanMusteri.TCKN;
        }

        private void FormMusteriEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisYapanMusteri = null;
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Close();
            GirisYapanMusteri = null;
        }
    }
}
