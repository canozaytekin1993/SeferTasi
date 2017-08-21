using SeferTasi.BLL.Repository;
using SeferTasi.BLL.UI_İslemleri;
using SeferTasi.Model.Entities;
using SeferTasi.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeferTasi.UI.WFA.Formlar
{
    public partial class FormFirmaUrunEkrani : Form
    {
        public FormFirmaUrunEkrani()
        {
            InitializeComponent();
        }
        Firma GirisYapanFirma;
        FormYeniUrunEklemeEkrani formYeniUrun;
        private void FormFirmaUrunEkrani_Load(object sender, EventArgs e)
        {
            GirisYapanFirma = Form1.GirisYapanFirma;
            UrunleriYukle();
            this.Text = "Ürün İşlemleri";
        }

        private void lstFirmaninUrunleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFirmaninUrunleri.SelectedItem == null) return;
            FirmaUrunDetaylariViewModel urunDetay = lstFirmaninUrunleri.SelectedItem as FirmaUrunDetaylariViewModel;
            txtUrunAdi.Text = urunDetay.UrunAdi;
            txtKategoriAdi.Text = urunDetay.KategoriAdi;
            cbSatistaMi.Checked = urunDetay.SatistaMi;
            nFiyat.Value = urunDetay.Fiyat;
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                UrunDetayRepo ur = new UrunDetayRepo();
                if (lstFirmaninUrunleri.SelectedItem == null)
                {
                    MessageBox.Show("Ürün seçimi yapmadınız","Hata", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    return;
                }
                UrunDetay urundetay = ur.FirmaninUrunDetayi(GirisYapanFirma.ID, (lstFirmaninUrunleri.SelectedItem as FirmaUrunDetaylariViewModel).UrunID);
                urundetay.SatistaMi = cbSatistaMi.Checked;
                urundetay.UrunFiyat = nFiyat.Value;
                ur.Update();
                UrunleriYukle();

                //UrunDetay firmaninurunu = GirisYapanFirma.UrunDetaylari.FirstOrDefault(x => x.UrunID == (lstFirmaninUrunleri.SelectedItem as FirmaUrunDetaylariViewModel).UrunID);
                //UrunDetayRepo ur = new UrunDetayRepo();
                //var urun = ur.GetAll().FirstOrDefault(x => x.FirmaID == GirisYapanFirma.ID && x.UrunID == firmaninurunu.UrunID);
                //urun.UrunFiyat = nFiyat.Value;
                //urun.SatistaMi = cbSatistaMi.Checked;
                //ur.Update();
                //UrunleriYukle();

                /*
                UrunDetay firmaninurunu = GirisYapanFirma.UrunDetaylari.FirstOrDefault(x => x.UrunID == (lstFirmaninUrunleri.SelectedItem as FirmaUrunDetaylariViewModel).UrunID);
                firmaninurunu.UrunFiyat = nFiyat.Value;
                firmaninurunu.SatistaMi = cbSatistaMi.Checked;
                UrunleriYukle();
                new UrunDetayRepo().Update();
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            try
            {
                UrunDetayRepo ur = new UrunDetayRepo();
                if (lstFirmaninUrunleri.SelectedItem == null)
                {
                    MessageBox.Show("Ürün seçimi yapmadınız","Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                ur.Delete(GirisYapanFirma.ID, (lstFirmaninUrunleri.SelectedItem as FirmaUrunDetaylariViewModel).UrunID);
                UrunleriYukle();

                //if (lstFirmaninUrunleri.SelectedItem == null) return;
                //UrunDetay firmaninurunu = GirisYapanFirma.UrunDetaylari.FirstOrDefault(x => x.UrunID == (lstFirmaninUrunleri.SelectedItem as FirmaUrunDetaylariViewModel).UrunID);
                //UrunDetayRepo ur = new UrunDetayRepo();
                //var urun = ur.GetAll().FirstOrDefault(x => x.FirmaID == GirisYapanFirma.ID && x.UrunID == firmaninurunu.UrunID);
                //urun.SatistaMi = false;
                //ur.Update();
                //UrunleriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UrunleriYukle()
        {
            var urunler = new FirmaRepo().FirmaninUrunDetaylari(GirisYapanFirma.ID);
            if (rbSOlan.Checked)
                lstFirmaninUrunleri.DataSource = urunler.Where(x => x.SatistaMi).ToList();
            else
                lstFirmaninUrunleri.DataSource = urunler.Where(x => x.SatistaMi == false).ToList();
        }
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            var urunler = new FirmaRepo().FirmaninUrunDetaylari(GirisYapanFirma.ID);
            if (rbSOlan.Checked)
                lstFirmaninUrunleri.DataSource = urunler.Where(x => x.SatistaMi).Where(y => y.UrunAdi.ToLower().Contains(txtArama.Text.ToLower()) || y.KategoriAdi.ToLower().Contains(txtArama.Text.ToLower())).ToList();
            else
                lstFirmaninUrunleri.DataSource = urunler.Where(x => x.SatistaMi == false).Where(y => y.UrunAdi.ToLower().Contains(txtArama.Text.ToLower()) || y.KategoriAdi.ToLower().Contains(txtArama.Text.ToLower())).ToList();
        }

        private void rbSOlmayan_CheckedChanged(object sender, EventArgs e)
        {
            if (lstFirmaninUrunleri.SelectedItem == null)
                new UIMetodlari().FormuTemizle(this);
            UrunleriYukle();
        }

        private void rbSOlan_CheckedChanged(object sender, EventArgs e)
        {
            if (lstFirmaninUrunleri.SelectedItem == null)
                new UIMetodlari().FormuTemizle(this);
            UrunleriYukle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(formYeniUrun == null || formYeniUrun.IsDisposed)
            {
                formYeniUrun = new FormYeniUrunEklemeEkrani();
                formYeniUrun.Show();
            }
        }
    }
}
