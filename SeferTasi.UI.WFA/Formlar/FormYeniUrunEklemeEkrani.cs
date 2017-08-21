using SeferTasi.BLL.Repository;
using SeferTasi.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeferTasi.UI.WFA.Formlar
{
    public partial class FormYeniUrunEklemeEkrani : Form
    {
        public FormYeniUrunEklemeEkrani()
        {
            InitializeComponent();
        }
        Firma GirisYapanFirma = Form1.GirisYapanFirma;
        MemoryStream memoryStream = new MemoryStream();
        int bufferSize = 64;
        byte[] resimArray = new byte[64];
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategori kategori = cbmKategori.SelectedItem as Kategori;
            Urun urun = new UrunRepo().GetAll().FirstOrDefault(x => x.UrunAdi.ToLower() == txtUrunAdi.Text.ToLower());
            if (urun == null)
            {
                Urun yeniurun = new Urun()
                {
                    UrunAdi = txtUrunAdi.Text,
                    KategoriID = kategori.ID
                };
                if (memoryStream.Length > 0)
                {
                    yeniurun.Fotograf = memoryStream.ToArray();
                }
                else
                {
                    Image image = Properties.Resources.no_food_image;
                    MemoryStream stream = new MemoryStream();
                    image.Save(stream, ImageFormat.Png);
                    byte[] nofoto = stream.ToArray();
                    yeniurun.Fotograf = nofoto;
                }
                memoryStream = new MemoryStream();
                new UrunRepo().Insert(yeniurun);
                UrunDetay urundetayi = new UrunDetay()
                {
                    UrunID = yeniurun.ID,
                    FirmaID = GirisYapanFirma.ID,
                    UrunFiyat = nFiyat.Value,
                    SatistaMi = cbSatistaMi.Checked
                };
                new UrunDetayRepo().Insert(urundetayi);
            }
            else
            {
                UrunDetay urundetayi = new UrunDetay()
                {
                    UrunID = urun.ID,
                    FirmaID = GirisYapanFirma.ID,
                    UrunFiyat = nFiyat.Value,
                    SatistaMi = cbSatistaMi.Checked
                };
                new UrunDetayRepo().Insert(urundetayi);
            }
            MessageBox.Show("Ürün Başarıyla Eklendi","Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {
            Urun urun = new UrunRepo().GetAll().FirstOrDefault(x => x.UrunAdi.ToLower() == txtUrunAdi.Text.ToLower());
            if (urun != null)
            {
                var secilecekKat = urun.Kategori as Kategori;
                List<Kategori> kategoriler = (List<Kategori>)cbmKategori.DataSource;
                kategoriler.ForEach(x =>
                {
                    if (x.ID == secilecekKat.ID)
                        cbmKategori.SelectedItem = x;
                }
                );
                cbSatistaMi.Checked = true;
                nFiyat.Value = 0;
                if (urun.Fotograf != null && urun.Fotograf.Length > 0)
                    pictureBox1.Image = new Bitmap(new MemoryStream(urun.Fotograf));
                else
                {
                    Image image = Properties.Resources.no_food_image;
                    MemoryStream stream = new MemoryStream();
                    image.Save(stream, ImageFormat.Png);
                    byte[] nofoto = stream.ToArray();
                }
            }
            else
            {
                Image image = Properties.Resources.no_food_image;
                MemoryStream stream = new MemoryStream();
                image.Save(stream, ImageFormat.Png);
                byte[] nofoto = stream.ToArray();
                pictureBox1.Image = new Bitmap(new MemoryStream(nofoto));
                urun = null;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            memoryStream = new MemoryStream();
            dosyaAc.Title = "Bir fotoğraf dosyasını seçiniz";
            dosyaAc.Filter = "JPG | *.jpg|PNG | *.png";
            dosyaAc.Multiselect = false;
            dosyaAc.FileName = string.Empty;
            dosyaAc.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.Open(dosyaAc.FileName, FileMode.Open);
                while (dosya.Read(resimArray, 0, bufferSize) != 0)
                {
                    memoryStream.Write(resimArray, 0, resimArray.Length);
                }
                dosya.Close();
                dosya.Dispose();
                pictureBox1.Image = new Bitmap(memoryStream);
            }
        }

        private void FormYeniUrunEklemeEkrani_Load(object sender, EventArgs e)
        {
            this.Text = "Yeni Ürün Ekleme";
            cbmKategori.DisplayMember = "KategoriAdi";
            cbmKategori.DataSource = new KategoriRepo().GetAll();
            pictureBox1.Image = Properties.Resources.no_food_image;
        }

    }
}
