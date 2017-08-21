using SeferTasi.BLL.Repository;
using SeferTasi.Model.Entities;
using SeferTasi.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeferTasi.UI.WFA.Formlar
{
    public partial class FormMusteriSiparis : Form
    {
        public FormMusteriSiparis()
        {
            InitializeComponent();
        }
        FirmaTuruViewModel seciliFirmaTuru;
        FirmaUrunDetaylariViewModel seciliUrunDetay;
        Firma seciliFirma;
        List<SiparisDetay> sepetUrunler = new List<SiparisDetay>();
        private void FormMusteriSiparis_Load(object sender, EventArgs e)
        {
            cmbFirma.DisplayMember = "FirmaTuru";
            cmbKategori.DataSource = new FirmaRepo().FirmaTurleriniGetir();
            SetGroupBoxVisibility(gbFirmaEkrani);
            rbNakit.Checked = true;
            rbHemenTeslim.Checked = true;
            lblDerece.Visible = false;
            this.Text = "Müşteri Sipariş";
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedItem == null)
            {
                MessageBox.Show("Kategori Seçimi Yapınız!!!","Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            seciliFirmaTuru = cmbKategori.SelectedItem as FirmaTuruViewModel;
            cmbFirma.DisplayMember = "FirmaAdi";
            cmbFirma.DataSource = new FirmaRepo().GetAll().Where(x => x.FirmaTuru == seciliFirmaTuru.FirmaTuru).ToList();
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;
            if (cmbFirma.SelectedItem == null) return;
            seciliUrunDetay = lstUrunler.SelectedItem as FirmaUrunDetaylariViewModel;
            pbUrun.Image = new Bitmap(new MemoryStream(seciliUrunDetay.Fotograf));
            txtUrunAdi.Text = seciliUrunDetay.UrunAdi;
            txtFiyat.Text = seciliUrunDetay.Fiyat.ToString();
        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            SetGroupBoxVisibility(gbUrunEkrani);
        }
        public void SetGroupBoxVisibility(GroupBox gb)
        {
            gbFirmaEkrani.Visible = false;
            gbFirmaEkrani.Dock = DockStyle.None;
            gbUrunEkrani.Visible = false;
            gbUrunEkrani.Dock = DockStyle.None;
            gbOdeme.Visible = false;
            gbOdeme.Dock = DockStyle.None;
            gb.Visible = true;
            gb.Dock = DockStyle.Fill;
        }

        private void btnSepeteDon_Click(object sender, EventArgs e)
        {
            SetGroupBoxVisibility(gbUrunEkrani);
        }

        private void btnFirmayaDon_Click(object sender, EventArgs e)
        {
            SetGroupBoxVisibility(gbFirmaEkrani);
        }

        private void cmbFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliFirma = cmbFirma.SelectedItem as Firma;
            lblDerece.Text = seciliFirma.Yildiz.ToString();
            var urunler = new FirmaRepo().FirmaninUrunDetaylari(seciliFirma.ID);
            lstUrunler.DataSource = urunler.Where(x => x.SatistaMi).ToList();
            lblDerece.Visible = true;
            lblDerece.Text = seciliFirma.Yildiz.ToString();
            lblTeslimSuresi.Text = $" " + seciliFirma.MinimumTeslimSuresi.ToString() + " dk";
            lblDerece.Text = seciliFirma.Yildiz.ToString();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (sepetUrunler.Count == 0) { MessageBox.Show("Öncelikle Sepete Ürün Eklemelisiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            SetGroupBoxVisibility(gbOdeme);
        }

        private void btnSepetEkle_Click(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedItem == null) return;

            FirmaUrunDetaylariViewModel seciliUrun = lstUrunler.SelectedItem as FirmaUrunDetaylariViewModel;
            bool varmi = false;
            foreach (var surunler in sepetUrunler)
            {
                if (seciliUrun.UrunID == surunler.UrunID)
                    varmi = true;
            }
            if (varmi)
            {
                sepetUrunler.Where(x => x.UrunID == seciliUrun.UrunID).FirstOrDefault().Adet += Convert.ToInt16(nAdet.Value);
            }
            else
            {
                sepetUrunler.Add(new SiparisDetay()
                {
                    Adet = (int)(nAdet.Value),
                    UrunID = seciliUrun.UrunID,
                    Urun = seciliUrun.Urun,
                    UrunFiyat = seciliFirma.UrunDetaylari.FirstOrDefault(x => x.UrunID == seciliUrun.UrunID).UrunFiyat
                });
            }
            SepetDoldur();
        }
        private void SepetDoldur()
        {
            lstSepet.Items.Clear();
            decimal sepetTutari = 0;
            foreach (var item in sepetUrunler)
            {
                lstSepet.Items.Add(item);
                sepetTutari += item.UrunFiyat * item.Adet;
            }
            lblTutar.Text = $"Toplam : {sepetTutari:c2}\nKDV : {sepetTutari * 0.18m:c2}";
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.FirmaID = seciliFirma.ID;
            yeniSiparis.Yildiz = 0;
            yeniSiparis.MusteriID = Form1.GirisYapanMusteri.ID;
            yeniSiparis.SiparisTarihi = DateTime.Now;
            if (rbHemenTeslim.Checked) yeniSiparis.IstenenTarih = DateTime.Now.AddMinutes((double)seciliFirma.MinimumTeslimSuresi);
            if (rbİleriTarih.Checked) yeniSiparis.IstenenTarih = dtpIstenenTarih.Value;
            if (rbNakit.Checked) yeniSiparis.OdemeTipi = rbNakit.Text;
            if (rbKrediKarti.Checked) yeniSiparis.OdemeTipi = rbKrediKarti.Text;
            if (rbSodexo.Checked) yeniSiparis.OdemeTipi = rbSodexo.Text;
            try
            {
                bool durum = new SiparisRepo().SiparisiOlustur(yeniSiparis, sepetUrunler);
                if (durum)
                {
                    MessageBox.Show("Siparişiniz oluşmuştur", "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sepetUrunler = new List<SiparisDetay>();
                    SepetDoldur();
                }
                else MessageBox.Show("Siparişiniz oluşturulurken hata meydana geldi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbHemenTeslim_CheckedChanged(object sender, EventArgs e)
        {
            dtpIstenenTarih.Enabled = false;
        }

        private void rbİleriTarih_CheckedChanged(object sender, EventArgs e)
        {
            dtpIstenenTarih.Enabled = true;
            dtpIstenenTarih.MinDate = DateTime.Now.AddMinutes(30);
            dtpIstenenTarih.MaxDate = DateTime.Now.AddDays(7);
        }
    }
}
