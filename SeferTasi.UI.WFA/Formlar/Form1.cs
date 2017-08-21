using SeferTasi.BLL.Repository;
using SeferTasi.Model.Entities;
using SeferTasi.Model.ViewModels;
using SeferTasi.UI.WFA.Formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SeferTasi.BLL.Repository.FirmaRepo;

namespace SeferTasi.UI.WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Yonetici GirisYapanYonetici { get; set; }
        public static Musteri GirisYapanMusteri { get; set; }
        public static Firma GirisYapanFirma { get; set; }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtKullaniciAdi.Focus();
            timer1.Start();

        }
        FormYoneticiEkrani FormYonetici;
        FormMusteriEkrani FormMusteri;
        FormFirmaEkrani FormFirma;
        FormYeniMusteriEkrani FormYeniMusteri;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Yonetici yonetici = new YoneticiRepo().GirisYapanYonetici(txtKullaniciAdi.Text, txtSifre.Text);
                if (yonetici != null || (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "admin"))
                {
                    FormYonetici = new FormYoneticiEkrani();
                    GirisYapanYonetici = yonetici;
                    FormYonetici.Show();
                    this.Visible = false;
                    txtTemizle();
                    txtKullaniciAdi.Focus();
                    return;
                }
                Musteri musteri = new MusteriRepo().GirisYapanMusteri(txtKullaniciAdi.Text, txtSifre.Text);
                if (musteri != null)
                {
                    FormMusteri = new FormMusteriEkrani();
                    GirisYapanMusteri = musteri;
                    FormMusteri.Show();
                    this.Visible = false;
                    txtTemizle();
                    txtKullaniciAdi.Focus();
                    return;
                }
                Firma firma = new FirmaRepo().GirisYapanFirma(txtKullaniciAdi.Text, txtSifre.Text);
                if (firma != null)
                {
                    FormFirma = new FormFirmaEkrani();
                    GirisYapanFirma = firma;
                    FormFirma.Show();
                    this.Visible = false;
                    txtTemizle();
                    txtKullaniciAdi.Focus();
                    return;
                }
                if (firma == null && musteri == null && yonetici == null)
                {
                    MessageBox.Show("Hatalı Giriş Yaptınız", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSifre.Clear();
                    txtSifre.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Giriş sırasında bir problem oldu!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtTemizle()
        {
            txtSifre.Clear();
            txtKullaniciAdi.Clear();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((FormMusteri == null || FormMusteri.IsDisposed) && (FormFirma == null || FormFirma.IsDisposed) && (FormYonetici == null || FormYonetici.IsDisposed) && (FormYeniMusteri == null || FormYeniMusteri.IsDisposed))
            {
                this.Visible = true;
            }
                
        }

        private void btnYeniMusteri_Click(object sender, EventArgs e)
        {
            FormYeniMusteri = new FormYeniMusteriEkrani();
            FormYeniMusteri.Show();
            this.Visible = false;
        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtKullaniciAdi.Text == "") return;
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.PerformClick();
            }
        }

        private void txtKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSifre.Text == "") return;
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.PerformClick();
            }
        }
    }
}
