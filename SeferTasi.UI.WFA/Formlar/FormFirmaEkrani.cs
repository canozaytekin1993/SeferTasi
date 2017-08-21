using SeferTasi.BLL.Repository;
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
    public partial class FormFirmaEkrani : Form
    {
        public FormFirmaEkrani()
        {
            InitializeComponent();
        }
        Firma GirisYapanFirma;
        FormFirmaRaporEkrani FormFirmaRapor;
        FormFirmaUrunEkrani FormFirmaUrun;
        private void FormFirmaEkrani_Load(object sender, EventArgs e)
        {
            GirisYapanFirma = Form1.GirisYapanFirma;
            this.Text = $"Merhaba {GirisYapanFirma.KullanıcıAdi}";
            txtFirmaAdi.Text = GirisYapanFirma.FirmaAdi;
            txtFirmaKullaniciAdi.Text = GirisYapanFirma.KullanıcıAdi;
            txtFirmaSifre.Text = GirisYapanFirma.Sifre;
            txtFirmaTuru.Text = GirisYapanFirma.FirmaTuru;
            nMinTS.Value = (decimal)GirisYapanFirma.MinimumTeslimSuresi;
        }

        private void btnFirmaGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                GirisYapanFirma.Sifre = txtFirmaSifre.Text;
                GirisYapanFirma.MinimumTeslimSuresi = (int)nMinTS.Value;
                GirisYapanFirma.FirmaAdi = txtFirmaAdi.Text;
                new FirmaRepo().Update();
                MessageBox.Show("Güncelleme başarılı","Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormFirmaEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            GirisYapanFirma = null;
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            if(FormFirmaRapor == null || FormFirmaRapor.IsDisposed)
            {
                FormFirmaRapor = new FormFirmaRaporEkrani();
                FormFirmaRapor.Show();
            }
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            if(FormFirmaUrun == null || FormFirmaUrun.IsDisposed)
            {
                FormFirmaUrun = new FormFirmaUrunEkrani();
                FormFirmaUrun.Show();
            }
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Close();
            GirisYapanFirma = null;
        }
    }
}
