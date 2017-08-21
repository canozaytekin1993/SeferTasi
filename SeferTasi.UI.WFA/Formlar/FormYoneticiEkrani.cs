using SeferTasi.BLL.Repository;
using SeferTasi.BLL.UI_İslemleri;
using SeferTasi.Model.Entities;
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

namespace SeferTasi.UI.WFA
{
    public partial class FormYoneticiEkrani : Form
    {
        public FormYoneticiEkrani()
        {
            InitializeComponent();
        }
        Yonetici yonetici = new Yonetici();
        public static Firma RaporlanacakFirma;
        FormYoneticiRaporEkrani formYoneticiRaporEkrani;
        UIMetodlari UI = new UIMetodlari();
        public void FormuTemizle()
        {
            foreach (Control item in this.gbYonetici.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
            }
            foreach (Control item in this.gbFirma.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is NumericUpDown)
                    (item as NumericUpDown).Value = 0;
            }
        }
        private void FormYoneticiEkrani_Load(object sender, EventArgs e)
        {
            if (Form1.GirisYapanYonetici != null)
                this.Text = $"Merhaba, {Form1.GirisYapanYonetici.AdSoyad}";
            else this.Text = $"Merhaba, Admin";
            lstFirmalar.DisplayMember = "FirmaAdi";
            lstYoneticiler.DisplayMember = "AdSoyad";
        }
        private void rbtnYonetici_CheckedChanged(object sender, EventArgs e)
        {
            gbFirma.Visible = false;
            gbYonetici.Visible = true;
            btnRaporlama.Enabled = false;
            lstYoneticiler.DataSource = new YoneticiRepo().GetAll();
            UI.FormuTemizle(gbYonetici,gbFirma);
        }

        private void rbtnFirma_CheckedChanged(object sender, EventArgs e)
        {
            gbYonetici.Visible = false;
            gbFirma.Visible = true;
            btnRaporlama.Enabled = true;
            lstFirmalar.DataSource = new FirmaRepo().GetAll();
            UI.FormuTemizle(gbYonetici, gbFirma);
        }

        private void lstYoneticiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstYoneticiler.SelectedItem == null) return;
            Yonetici seciliYonetici = lstYoneticiler.SelectedItem as Yonetici;
            txtYoneticiSoyad.Text = seciliYonetici.AdSoyad;
            txtYoneticiKullaniciAdi.Text = seciliYonetici.KullanıcıAdi;
            txtYoneticiSifre.Text = seciliYonetici.Sifre;
            txtYoneticiTCKN.Text = seciliYonetici.TCKN;
            txtYoneticiTelefon.Text = seciliYonetici.Telefon;
            txtYoneticiKullaniciAdi.Enabled = false;
            txtYoneticiTCKN.Enabled = false;
        }

        private void btnYoneticiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                new YoneticiRepo().KullaniciAdiKontrol(txtYoneticiKullaniciAdi.Text, txtYoneticiTCKN.Text, "1",txtYoneticiTelefon.Text);
                new YoneticiRepo().Insert(new Yonetici()
                {
                    AdSoyad = txtYoneticiSoyad.Text,
                    KullanıcıAdi = txtYoneticiKullaniciAdi.Text,
                    Sifre = txtYoneticiSifre.Text,
                    TCKN = txtYoneticiTCKN.Text,
                    Telefon = txtYoneticiTelefon.Text
                });
                lstYoneticiler.DataSource = new YoneticiRepo().GetAll();
                UI.FormuTemizle(gbFirma, gbYonetici);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstFirmalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFirmalar.SelectedItem == null) return;
            Firma seciliFirma = lstFirmalar.SelectedItem as Firma;
            txtFirmaAdi.Text = seciliFirma.FirmaAdi;
            txtFirmaKullaniciAdi.Text = seciliFirma.KullanıcıAdi;
            txtFirmaSifre.Text = seciliFirma.Sifre;
            txtFirmaTuru.Text = seciliFirma.FirmaTuru;
            nMinTS.Value = (int)seciliFirma.MinimumTeslimSuresi;
            cbAktifMi.Checked = seciliFirma.AktifMi;
            txtFirmaKullaniciAdi.Enabled = false;
            RaporlanacakFirma = new FirmaRepo().GetByID(seciliFirma.ID);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                new YoneticiRepo().KullaniciAdiKontrol(txtFirmaKullaniciAdi.Text, "1", "1","1");
                new FirmaRepo().Insert(new Firma()
                {
                    FirmaAdi = txtFirmaAdi.Text,
                    FirmaTuru = txtFirmaTuru.Text,
                    KullanıcıAdi = txtFirmaKullaniciAdi.Text,
                    MinimumTeslimSuresi = (int)nMinTS.Value,
                    AktifMi = cbAktifMi.Checked,
                    Sifre = txtFirmaSifre.Text
                });
                lstFirmalar.DataSource = new FirmaRepo().GetAll();
                UI.FormuTemizle(gbFirma, gbYonetici);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnYoneticiSil_Click(object sender, EventArgs e)
        {
            if (lstYoneticiler.SelectedItem == null) return;
            Yonetici seciliYonetici = lstYoneticiler.SelectedItem as Yonetici;
            try
            {
                new YoneticiRepo().Delete(seciliYonetici);
                lstYoneticiler.DataSource = new YoneticiRepo().GetAll();
                seciliYonetici = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnFirmaSil_Click(object sender, EventArgs e)
        {
            if (lstFirmalar.SelectedItem == null) return;
            Firma seciliFirma = lstFirmalar.SelectedItem as Firma;
            try
            {
                new FirmaRepo().Delete(seciliFirma);
                lstFirmalar.DataSource = new FirmaRepo().GetAll();
                seciliFirma = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnYoneticiGuncelle_Click(object sender, EventArgs e)
        {
            if (lstYoneticiler.SelectedItem == null) return;
            Yonetici seciliYonetici = lstYoneticiler.SelectedItem as Yonetici;
            try
            {
                seciliYonetici = new YoneticiRepo().GetByID(seciliYonetici.ID);
                seciliYonetici.AdSoyad = txtYoneticiSoyad.Text;
                seciliYonetici.Sifre = txtYoneticiSifre.Text;
                seciliYonetici.Telefon = txtYoneticiTelefon.Text;
                new YoneticiRepo().Update();
                lstYoneticiler.DataSource = new YoneticiRepo().GetAll();
                seciliYonetici = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnFirmaGuncelle_Click(object sender, EventArgs e)
        {
            if (lstFirmalar.SelectedItem == null) return;
            Firma seciliFirma = lstFirmalar.SelectedItem as Firma;
            try
            {
                seciliFirma = new FirmaRepo().GetByID(seciliFirma.ID);
                seciliFirma.FirmaAdi = txtFirmaAdi.Text;
                seciliFirma.FirmaTuru = txtFirmaTuru.Text;
                seciliFirma.AktifMi = cbAktifMi.Checked;
                seciliFirma.MinimumTeslimSuresi = (int)nMinTS.Value;
                seciliFirma.Sifre = txtFirmaSifre.Text;
                new FirmaRepo().Update();
                lstFirmalar.DataSource = new FirmaRepo().GetAll();
                seciliFirma = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnYoneticiTemizle_Click(object sender, EventArgs e)
        {
            lstYoneticiler.SelectedItem = null;
            txtYoneticiTCKN.Enabled = true;
            txtYoneticiKullaniciAdi.Enabled = true;
            UI.FormuTemizle(gbFirma, gbYonetici);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstFirmalar.SelectedItem = null;
            txtFirmaKullaniciAdi.Enabled = true;
            UI.FormuTemizle(gbFirma, gbYonetici);
        }

        private void FormYoneticiEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.GirisYapanYonetici = null;
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            if(lstFirmalar.SelectedItem == null)
            {
                MessageBox.Show("Firma seçimi yapmalısınız!","Bilgilendirme", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if(formYoneticiRaporEkrani == null || formYoneticiRaporEkrani.IsDisposed)
            {
                formYoneticiRaporEkrani = new FormYoneticiRaporEkrani();
                formYoneticiRaporEkrani.Show();
            }
        }
        FormYoneteciKategoriEkle formKategoriEkleEkranı;    
        private void btnKategori_Click(object sender, EventArgs e)
        {
            if (formKategoriEkleEkranı == null || formKategoriEkleEkranı.IsDisposed)
            {
                formKategoriEkleEkranı = new FormYoneteciKategoriEkle();
                formKategoriEkleEkranı.Show();
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            lstFirmalar.SelectedItem = null;
            txtFirmaKullaniciAdi.Enabled = true;
            UI.FormuTemizle(gbFirma, gbYonetici);
        }

        private void btnYeni1_Click(object sender, EventArgs e)
        {
            lstYoneticiler.SelectedItem = null;
            txtYoneticiTCKN.Enabled = true;
            txtYoneticiKullaniciAdi.Enabled = true;
            UI.FormuTemizle(gbFirma, gbYonetici);
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
