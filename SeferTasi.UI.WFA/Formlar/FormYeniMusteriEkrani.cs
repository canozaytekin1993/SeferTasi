using SeferTasi.BLL.Repository;
using SeferTasi.BLL.UI_İslemleri;
using SeferTasi.Model.Entities;
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

namespace SeferTasi.UI.WFA.Formlar
{
    public partial class FormYeniMusteriEkrani : Form
    {
        public FormYeniMusteriEkrani()
        {
            InitializeComponent();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                new YoneticiRepo().KullaniciAdiKontrol(txtKullaniciAdi.Text, txtTCKN.Text, txtEmail.Text, txtTelefon.Text);
                new MusteriRepo().Insert(new Musteri()
                {
                    KullanıcıAdi = txtKullaniciAdi.Text,
                    AdSoyad = txtAdSoyad.Text,
                    Adres = txtAdres.Text,
                    Email = txtEmail.Text,
                    Sifre = txtSifre.Text,
                    TCKN = txtTCKN.Text,
                    Telefon = txtTelefon.Text
                });
                new UIMetodlari().FormuTemizle(this);
                MessageBox.Show("Yeni Üye Oluşturuldu\nGiriş sayfasından giriş yapabilirsiniz", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FormYeniMusteriEkrani_Load(object sender, EventArgs e)
        {
            this.Text = "Yeni Müşteri Ekleme";
        }
    }
}
