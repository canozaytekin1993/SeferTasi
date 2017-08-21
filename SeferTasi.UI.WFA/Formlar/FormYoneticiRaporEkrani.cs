using SeferTasi.BLL.Repository;
using SeferTasi.Model.Entities;
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
    public partial class FormYoneticiRaporEkrani : Form
    {
        public FormYoneticiRaporEkrani()
        {
            InitializeComponent();
        }
        Firma seciliFirma;
        private void FormYoneticiRaporEkrani_Load(object sender, EventArgs e)
        {
            if (cmbFirma.SelectedItem == null)
            {
                rbTEdilmemis.Visible = false;
                rbTEdilmis.Visible = false;
            }
            cmbFirma.DisplayMember = "FirmaAdi";
            cmbFirma.DataSource = new FirmaRepo().GetAll().ToList();
            this.Text = "Firma Sipariş Bilgi Sayfası";
        }
        private void SiparisleriYukle(Firma seciliFirma)
        {
            var urunler = new FirmaRepo().FirmaVerilenSiparisRapor(seciliFirma.ID);
            if (rbTEdilmis.Checked)
                lstFirmaSiparis.DataSource = urunler.Where(x => x.TeslimTarihi == null).ToList();
            else
                lstFirmaSiparis.DataSource = urunler.Where(x => x.TeslimTarihi != null).ToList();
            chart1.Series["Satis"].XValueMember = "UrunAdi";
            chart1.Series["Satis"].YValueMembers = "Toplam";
            chart1.DataSource = new FirmaRepo().FirmaSatisChartRapor(seciliFirma.ID);
            chart1.Series["Satis"].IsValueShownAsLabel = true;//veri etiketleri stili
            chart1.Series["Satis"].IsValueShownAsLabel = true;//veri etiketleri stili
            chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;//  3D grafik
            chart1.Series["Satis"]["DrawingStyle"] = "Cylinder";
        }

        private void rbTEdilmis_CheckedChanged(object sender, EventArgs e)
        {
            SiparisleriYukle(seciliFirma);
        }

        private void rbTEdilmemis_CheckedChanged(object sender, EventArgs e)
        {
            SiparisleriYukle(seciliFirma);
        }

        private void cmbFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFirma.SelectedItem == null)
            {
                MessageBox.Show("Firma Seçimi Yapınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            seciliFirma = cmbFirma.SelectedItem as Firma;
            SiparisleriYukle(seciliFirma);

        }
    }
}
