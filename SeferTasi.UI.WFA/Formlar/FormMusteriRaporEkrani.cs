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
    public partial class FormMusteriRaporEkrani : Form
    {
        public FormMusteriRaporEkrani()
        {
            InitializeComponent();
            pbStar1.Click += PbStar1_Click;
            pbStar2.Click += PbStar1_Click;
            pbStar3.Click += PbStar1_Click;
            pbStar4.Click += PbStar1_Click;
            pbStar5.Click += PbStar1_Click;

            pbStar1.MouseMove += PbStar1_MouseMove;
            pbStar2.MouseMove += PbStar1_MouseMove;
            pbStar3.MouseMove += PbStar1_MouseMove;
            pbStar4.MouseMove += PbStar1_MouseMove;
            pbStar5.MouseMove += PbStar1_MouseMove;

            pbStar1.MouseLeave += PbStar1_MouseLeave;
            pbStar2.MouseLeave += PbStar1_MouseLeave;
            pbStar3.MouseLeave += PbStar1_MouseLeave;
            pbStar4.MouseLeave += PbStar1_MouseLeave;
            pbStar5.MouseLeave += PbStar1_MouseLeave;
        }
        MusterininSiparisleriViewModel seciliSiparis;
        private void PbStar1_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                yildizlar[i].Image = Properties.Resources.star1;
            }
        }

        PictureBox[] yildizlar = new PictureBox[5];
        private void PbStar1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rbTEdilmemis.Checked) return;
            for (int i = 0; i < 5; i++)
            {
                yildizlar[i].Image = Properties.Resources.star1;
            }
            for (int j = int.Parse((sender as PictureBox).Tag.ToString()); j > 0; j--)
            {
                yildizlar[j - 1].Image = Properties.Resources.star;
            }

        }
        private void YildizlariGoster()
        {
            for (int i = 0; i < yildizlar.Length; i++)
            {
                yildizlar[i].Image = Properties.Resources.star1;
                yildizlar[i].Visible = true;
            }
        }
        private void PbStar1_Click(object sender, EventArgs e)
        {
            if (rbTEdilmemis.Checked) return;
            if (lstSiparisler.SelectedItem == null)
            {
                MessageBox.Show("Siparis Seçmediniz");
                return;
            }
            SiparisRepo sp = new SiparisRepo();
            Siparis siparis = sp.SiparisiGetir((lstSiparisler.SelectedItem as MusterininSiparisleriViewModel).SiparisID);
            siparis.Yildiz = byte.Parse((sender as PictureBox).Tag.ToString());
            sp.Update();
            FirmaRepo fr = new FirmaRepo();
            int siparissayisi;
            int yildiz = fr.FirmaYildiziGuncelle(seciliSiparis.FirmaID, out siparissayisi);
            Firma firma = fr.FirmayiGetir((lstSiparisler.SelectedItem as MusterininSiparisleriViewModel).FirmaID);
            firma.Yildiz = Convert.ToDouble(yildiz / siparissayisi);
            fr.Update();
            SiparisleriGetir();

        }
        private void rbTEdilmemis_CheckedChanged(object sender, EventArgs e)
        {
            new UIMetodlari().YildizlariSil(yildizlar);
            SiparisleriGetir();
        }

        private void rbTEdilmis_CheckedChanged_1(object sender, EventArgs e)
        {
            SiparisleriGetir();
        }
        Musteri GirisYapanMusteri;
        private void FormMusteriRaporEkrani_Load(object sender, EventArgs e)
        {
            GirisYapanMusteri = Form1.GirisYapanMusteri;
            this.Text = "Siparişlerim";
            yildizlar[0] = pbStar1;
            yildizlar[1] = pbStar2;
            yildizlar[2] = pbStar3;
            yildizlar[3] = pbStar4;
            yildizlar[4] = pbStar5;
            SiparisleriGetir();
        }
        private void SiparisleriGetir()
        {
            var siparisler = new MusteriRepo().MusteriSiparisGecmisRapor(GirisYapanMusteri.ID);
            if (rbTEdilmis.Checked)
                lstSiparisler.DataSource = siparisler.Where(x => x.TeslimTarihi != null).ToList();
            else
                lstSiparisler.DataSource = siparisler.Where(x => x.TeslimTarihi == null).ToList();
        }

        private void lstSiparisler_SelectedIndexChanged(object sender, EventArgs e)
        {
            new UIMetodlari().YildizlariSil(yildizlar);
            if (lstSiparisler.SelectedItem == null) return;
            seciliSiparis = lstSiparisler.SelectedItem as MusterininSiparisleriViewModel;
            if (rbTEdilmemis.Checked) return;
            if (seciliSiparis.Yildiz == 0)
            {
                YildizlariGoster();
                new UIMetodlari().YildizlariEnTrue(yildizlar);
            }
            else
            {
                YildizlariGoster();
                for (int i = seciliSiparis.Yildiz.Value; i > 0; i--)
                {
                    yildizlar[i - 1].Image = Properties.Resources.star;
                    new UIMetodlari().YildizlariEnFalse(yildizlar);
                }
            }
        }
    }
}
