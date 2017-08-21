using SeferTasi.BLL.Repository;
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
    public partial class FormFirmaRaporEkrani : Form
    {
        public FormFirmaRaporEkrani()
        {
            InitializeComponent();
        }
        Firma GirisYapanFirma;
        private void FormFirmaRaporEkrani_Load(object sender, EventArgs e)
        {
            GirisYapanFirma = Form1.GirisYapanFirma;
            SiparisleriYukle();
            this.Text = "Alınan Sipariş Sayfası";
            chart1.Series["Satis"].XValueMember = "UrunAdi";
            chart1.Series["Satis"].YValueMembers = "Toplam";
            chart1.DataSource = new FirmaRepo().FirmaSatisChartRapor(GirisYapanFirma.ID);
        }
        private void SiparisleriYukle()
        {
            var urunler = new FirmaRepo().FirmaVerilenSiparisRapor(GirisYapanFirma.ID);
            if (rbTEdilmis.Checked)
                lstMusteriSiparis.DataSource = urunler.Where(x => x.TeslimTarihi==null).ToList();
            else
                lstMusteriSiparis.DataSource = urunler.Where(x => x.TeslimTarihi != null).ToList();
        }
        private void rbTEdilmis_CheckedChanged(object sender, EventArgs e)
        {
            SiparisleriYukle();
            btnTesim.Enabled = true;
        }
        private void rbTEdilmemis_CheckedChanged(object sender, EventArgs e)
        {
            SiparisleriYukle();
            btnTesim.Enabled = false;
        }

        private void btnTesim_Click(object sender, EventArgs e)
        {
            if (lstMusteriSiparis.SelectedItem == null)
            {
                MessageBox.Show("Lütfen teslim ettiğiniz siparişi seçiniz", "Sipariş Seçmediniz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SiparisRepo sp = new SiparisRepo();
            Siparis siparis = sp.SiparisiGetir((lstMusteriSiparis.SelectedItem as FirmaVerilenSiparislerViewModel).SiparisID);
            //FirmaVerilenSiparislerViewModel secilisiparis = lstMusteriSiparis.SelectedItem as FirmaVerilenSiparislerViewModel;
            siparis.TeslimTarihi = DateTime.Now;
            sp.Update();
            SiparisleriYukle();
        }
    }
}
