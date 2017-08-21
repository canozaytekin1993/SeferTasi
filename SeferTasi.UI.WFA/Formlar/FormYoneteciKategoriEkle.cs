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
    public partial class FormYoneteciKategoriEkle : Form
    {
        public FormYoneteciKategoriEkle()
        {
            InitializeComponent();
        }

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in new KategoriRepo().GetAll())
                {
                    if (item.KategoriAdi == txtYoneticiSoyad.Text)
                    {
                        MessageBox.Show("Bu kategori adı zaten mevcut", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                new KategoriRepo().Insert(new Kategori()
                {
                    KategoriAdi = txtYoneticiSoyad.Text,
                });
                lstKategoriler.DisplayMember = "KategoriAdi";
                lstKategoriler.DataSource = new KategoriRepo().GetAll();
                MessageBox.Show("Kategori Başarıyla Eklendi", "Tebrikler", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormYoneteciKategoriEkle_Load(object sender, EventArgs e)
        {
            this.Text = "Yönetici Kategori Ekleme";
            lstKategoriler.DisplayMember = "KategoriAdi";
            lstKategoriler.DataSource = new KategoriRepo().GetAll();
        }
    }
}
