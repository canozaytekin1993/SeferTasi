namespace SeferTasi.UI.WFA
{
    partial class FormYoneticiEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYoneticiEkrani));
            this.rbtnYonetici = new System.Windows.Forms.RadioButton();
            this.rbtnFirma = new System.Windows.Forms.RadioButton();
            this.gbFirma = new System.Windows.Forms.GroupBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.ımageAdmin = new System.Windows.Forms.ImageList(this.components);
            this.cbAktifMi = new System.Windows.Forms.CheckBox();
            this.nMinTS = new System.Windows.Forms.NumericUpDown();
            this.lstFirmalar = new System.Windows.Forms.ListBox();
            this.btnFirmaGuncelle = new System.Windows.Forms.Button();
            this.btnFirmaSil = new System.Windows.Forms.Button();
            this.btnFirmaEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFirmaSifre = new System.Windows.Forms.TextBox();
            this.txtFirmaKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtFirmaTuru = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.gbYonetici = new System.Windows.Forms.GroupBox();
            this.btnYeni1 = new System.Windows.Forms.Button();
            this.lstYoneticiler = new System.Windows.Forms.ListBox();
            this.btnYoneticiGuncelle = new System.Windows.Forms.Button();
            this.btnYoneticiSil = new System.Windows.Forms.Button();
            this.btnYoneticiEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYoneticiTelefon = new System.Windows.Forms.TextBox();
            this.txtYoneticiTCKN = new System.Windows.Forms.TextBox();
            this.txtYoneticiSifre = new System.Windows.Forms.TextBox();
            this.txtYoneticiKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtYoneticiSoyad = new System.Windows.Forms.TextBox();
            this.btnRaporlama = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbFirmaBanner = new System.Windows.Forms.PictureBox();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.gbFirma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMinTS)).BeginInit();
            this.gbYonetici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirmaBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnYonetici
            // 
            this.rbtnYonetici.AutoSize = true;
            this.rbtnYonetici.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnYonetici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.rbtnYonetici.Location = new System.Drawing.Point(9, 94);
            this.rbtnYonetici.Name = "rbtnYonetici";
            this.rbtnYonetici.Size = new System.Drawing.Size(141, 23);
            this.rbtnYonetici.TabIndex = 0;
            this.rbtnYonetici.TabStop = true;
            this.rbtnYonetici.Text = "Yönetici İşlemleri";
            this.rbtnYonetici.UseVisualStyleBackColor = true;
            this.rbtnYonetici.CheckedChanged += new System.EventHandler(this.rbtnYonetici_CheckedChanged);
            // 
            // rbtnFirma
            // 
            this.rbtnFirma.AutoSize = true;
            this.rbtnFirma.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnFirma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.rbtnFirma.Location = new System.Drawing.Point(156, 94);
            this.rbtnFirma.Name = "rbtnFirma";
            this.rbtnFirma.Size = new System.Drawing.Size(126, 23);
            this.rbtnFirma.TabIndex = 0;
            this.rbtnFirma.TabStop = true;
            this.rbtnFirma.Text = "Firma İşlemleri";
            this.rbtnFirma.UseVisualStyleBackColor = true;
            this.rbtnFirma.CheckedChanged += new System.EventHandler(this.rbtnFirma_CheckedChanged);
            // 
            // gbFirma
            // 
            this.gbFirma.Controls.Add(this.btnYeni);
            this.gbFirma.Controls.Add(this.cbAktifMi);
            this.gbFirma.Controls.Add(this.nMinTS);
            this.gbFirma.Controls.Add(this.lstFirmalar);
            this.gbFirma.Controls.Add(this.btnFirmaGuncelle);
            this.gbFirma.Controls.Add(this.btnFirmaSil);
            this.gbFirma.Controls.Add(this.btnFirmaEkle);
            this.gbFirma.Controls.Add(this.label8);
            this.gbFirma.Controls.Add(this.label9);
            this.gbFirma.Controls.Add(this.label10);
            this.gbFirma.Controls.Add(this.label11);
            this.gbFirma.Controls.Add(this.label12);
            this.gbFirma.Controls.Add(this.txtFirmaSifre);
            this.gbFirma.Controls.Add(this.txtFirmaKullaniciAdi);
            this.gbFirma.Controls.Add(this.txtFirmaTuru);
            this.gbFirma.Controls.Add(this.txtFirmaAdi);
            this.gbFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbFirma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.gbFirma.Location = new System.Drawing.Point(394, 134);
            this.gbFirma.Name = "gbFirma";
            this.gbFirma.Size = new System.Drawing.Size(368, 288);
            this.gbFirma.TabIndex = 1;
            this.gbFirma.TabStop = false;
            this.gbFirma.Text = "FİRMA EKRANI";
            this.gbFirma.Visible = false;
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.Cornsilk;
            this.btnYeni.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnYeni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeni.ImageKey = "yeni.png";
            this.btnYeni.ImageList = this.ımageAdmin;
            this.btnYeni.Location = new System.Drawing.Point(115, 175);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(102, 46);
            this.btnYeni.TabIndex = 33;
            this.btnYeni.Text = "Yeni     Firma";
            this.btnYeni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // ımageAdmin
            // 
            this.ımageAdmin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageAdmin.ImageStream")));
            this.ımageAdmin.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageAdmin.Images.SetKeyName(0, "delete.png");
            this.ımageAdmin.Images.SetKeyName(1, "insert.png");
            this.ımageAdmin.Images.SetKeyName(2, "update.png");
            this.ımageAdmin.Images.SetKeyName(3, "exit.png");
            this.ımageAdmin.Images.SetKeyName(4, "rapor.png");
            this.ımageAdmin.Images.SetKeyName(5, "yeni.png");
            // 
            // cbAktifMi
            // 
            this.cbAktifMi.AutoSize = true;
            this.cbAktifMi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbAktifMi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cbAktifMi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.cbAktifMi.Location = new System.Drawing.Point(12, 175);
            this.cbAktifMi.Name = "cbAktifMi";
            this.cbAktifMi.Size = new System.Drawing.Size(90, 23);
            this.cbAktifMi.TabIndex = 5;
            this.cbAktifMi.Text = "Aktif Mi :";
            this.cbAktifMi.UseVisualStyleBackColor = true;
            // 
            // nMinTS
            // 
            this.nMinTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nMinTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.nMinTS.Location = new System.Drawing.Point(108, 145);
            this.nMinTS.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nMinTS.Name = "nMinTS";
            this.nMinTS.Size = new System.Drawing.Size(109, 21);
            this.nMinTS.TabIndex = 4;
            this.nMinTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstFirmalar
            // 
            this.lstFirmalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstFirmalar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.lstFirmalar.FormattingEnabled = true;
            this.lstFirmalar.ItemHeight = 15;
            this.lstFirmalar.Location = new System.Drawing.Point(223, 28);
            this.lstFirmalar.Name = "lstFirmalar";
            this.lstFirmalar.Size = new System.Drawing.Size(126, 184);
            this.lstFirmalar.TabIndex = 6;
            this.lstFirmalar.SelectedIndexChanged += new System.EventHandler(this.lstFirmalar_SelectedIndexChanged);
            // 
            // btnFirmaGuncelle
            // 
            this.btnFirmaGuncelle.BackColor = System.Drawing.Color.Cornsilk;
            this.btnFirmaGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnFirmaGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaGuncelle.ImageIndex = 2;
            this.btnFirmaGuncelle.ImageList = this.ımageAdmin;
            this.btnFirmaGuncelle.Location = new System.Drawing.Point(246, 222);
            this.btnFirmaGuncelle.Name = "btnFirmaGuncelle";
            this.btnFirmaGuncelle.Size = new System.Drawing.Size(103, 52);
            this.btnFirmaGuncelle.TabIndex = 9;
            this.btnFirmaGuncelle.Text = "Güncelle";
            this.btnFirmaGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirmaGuncelle.UseVisualStyleBackColor = false;
            this.btnFirmaGuncelle.Click += new System.EventHandler(this.btnFirmaGuncelle_Click);
            // 
            // btnFirmaSil
            // 
            this.btnFirmaSil.BackColor = System.Drawing.Color.Cornsilk;
            this.btnFirmaSil.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnFirmaSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaSil.ImageIndex = 0;
            this.btnFirmaSil.ImageList = this.ımageAdmin;
            this.btnFirmaSil.Location = new System.Drawing.Point(135, 222);
            this.btnFirmaSil.Name = "btnFirmaSil";
            this.btnFirmaSil.Size = new System.Drawing.Size(103, 52);
            this.btnFirmaSil.TabIndex = 8;
            this.btnFirmaSil.Text = "Sil";
            this.btnFirmaSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirmaSil.UseVisualStyleBackColor = false;
            this.btnFirmaSil.Click += new System.EventHandler(this.btnFirmaSil_Click);
            // 
            // btnFirmaEkle
            // 
            this.btnFirmaEkle.BackColor = System.Drawing.Color.Cornsilk;
            this.btnFirmaEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnFirmaEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaEkle.ImageIndex = 1;
            this.btnFirmaEkle.ImageList = this.ımageAdmin;
            this.btnFirmaEkle.Location = new System.Drawing.Point(24, 222);
            this.btnFirmaEkle.Name = "btnFirmaEkle";
            this.btnFirmaEkle.Size = new System.Drawing.Size(103, 52);
            this.btnFirmaEkle.TabIndex = 7;
            this.btnFirmaEkle.Text = "Ekle";
            this.btnFirmaEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirmaEkle.UseVisualStyleBackColor = false;
            this.btnFirmaEkle.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(12, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Min Teslim :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(54, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Şifre :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(0, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Kullanıcı Adı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(12, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Firma Türü :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(20, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 19);
            this.label12.TabIndex = 15;
            this.label12.Text = "Firma Adı :";
            // 
            // txtFirmaSifre
            // 
            this.txtFirmaSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtFirmaSifre.Location = new System.Drawing.Point(108, 116);
            this.txtFirmaSifre.Name = "txtFirmaSifre";
            this.txtFirmaSifre.PasswordChar = '*';
            this.txtFirmaSifre.Size = new System.Drawing.Size(109, 21);
            this.txtFirmaSifre.TabIndex = 3;
            // 
            // txtFirmaKullaniciAdi
            // 
            this.txtFirmaKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtFirmaKullaniciAdi.Location = new System.Drawing.Point(108, 87);
            this.txtFirmaKullaniciAdi.Name = "txtFirmaKullaniciAdi";
            this.txtFirmaKullaniciAdi.PasswordChar = '*';
            this.txtFirmaKullaniciAdi.Size = new System.Drawing.Size(109, 21);
            this.txtFirmaKullaniciAdi.TabIndex = 2;
            // 
            // txtFirmaTuru
            // 
            this.txtFirmaTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtFirmaTuru.Location = new System.Drawing.Point(108, 59);
            this.txtFirmaTuru.Name = "txtFirmaTuru";
            this.txtFirmaTuru.Size = new System.Drawing.Size(109, 21);
            this.txtFirmaTuru.TabIndex = 1;
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtFirmaAdi.Location = new System.Drawing.Point(108, 29);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(109, 21);
            this.txtFirmaAdi.TabIndex = 0;
            // 
            // gbYonetici
            // 
            this.gbYonetici.Controls.Add(this.btnYeni1);
            this.gbYonetici.Controls.Add(this.lstYoneticiler);
            this.gbYonetici.Controls.Add(this.btnYoneticiGuncelle);
            this.gbYonetici.Controls.Add(this.btnYoneticiSil);
            this.gbYonetici.Controls.Add(this.btnYoneticiEkle);
            this.gbYonetici.Controls.Add(this.label6);
            this.gbYonetici.Controls.Add(this.label5);
            this.gbYonetici.Controls.Add(this.label4);
            this.gbYonetici.Controls.Add(this.label3);
            this.gbYonetici.Controls.Add(this.label2);
            this.gbYonetici.Controls.Add(this.txtYoneticiTelefon);
            this.gbYonetici.Controls.Add(this.txtYoneticiTCKN);
            this.gbYonetici.Controls.Add(this.txtYoneticiSifre);
            this.gbYonetici.Controls.Add(this.txtYoneticiKullaniciAdi);
            this.gbYonetici.Controls.Add(this.txtYoneticiSoyad);
            this.gbYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbYonetici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.gbYonetici.Location = new System.Drawing.Point(9, 134);
            this.gbYonetici.Name = "gbYonetici";
            this.gbYonetici.Size = new System.Drawing.Size(379, 288);
            this.gbYonetici.TabIndex = 0;
            this.gbYonetici.TabStop = false;
            this.gbYonetici.Text = "YÖNETİCİ EKRANI";
            this.gbYonetici.Visible = false;
            // 
            // btnYeni1
            // 
            this.btnYeni1.BackColor = System.Drawing.Color.Cornsilk;
            this.btnYeni1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnYeni1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnYeni1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYeni1.ImageKey = "yeni.png";
            this.btnYeni1.ImageList = this.ımageAdmin;
            this.btnYeni1.Location = new System.Drawing.Point(130, 175);
            this.btnYeni1.Name = "btnYeni1";
            this.btnYeni1.Size = new System.Drawing.Size(102, 46);
            this.btnYeni1.TabIndex = 51;
            this.btnYeni1.Text = "Yeni    Yönetici";
            this.btnYeni1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeni1.UseVisualStyleBackColor = false;
            this.btnYeni1.Click += new System.EventHandler(this.btnYeni1_Click);
            // 
            // lstYoneticiler
            // 
            this.lstYoneticiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstYoneticiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.lstYoneticiler.FormattingEnabled = true;
            this.lstYoneticiler.ItemHeight = 15;
            this.lstYoneticiler.Location = new System.Drawing.Point(240, 32);
            this.lstYoneticiler.Name = "lstYoneticiler";
            this.lstYoneticiler.Size = new System.Drawing.Size(126, 184);
            this.lstYoneticiler.TabIndex = 5;
            this.lstYoneticiler.SelectedIndexChanged += new System.EventHandler(this.lstYoneticiler_SelectedIndexChanged);
            // 
            // btnYoneticiGuncelle
            // 
            this.btnYoneticiGuncelle.BackColor = System.Drawing.Color.Cornsilk;
            this.btnYoneticiGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnYoneticiGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYoneticiGuncelle.ImageIndex = 2;
            this.btnYoneticiGuncelle.ImageList = this.ımageAdmin;
            this.btnYoneticiGuncelle.Location = new System.Drawing.Point(261, 222);
            this.btnYoneticiGuncelle.Name = "btnYoneticiGuncelle";
            this.btnYoneticiGuncelle.Size = new System.Drawing.Size(103, 52);
            this.btnYoneticiGuncelle.TabIndex = 8;
            this.btnYoneticiGuncelle.Text = "Güncelle";
            this.btnYoneticiGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYoneticiGuncelle.UseVisualStyleBackColor = false;
            this.btnYoneticiGuncelle.Click += new System.EventHandler(this.btnYoneticiGuncelle_Click);
            // 
            // btnYoneticiSil
            // 
            this.btnYoneticiSil.BackColor = System.Drawing.Color.Cornsilk;
            this.btnYoneticiSil.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnYoneticiSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYoneticiSil.ImageIndex = 0;
            this.btnYoneticiSil.ImageList = this.ımageAdmin;
            this.btnYoneticiSil.Location = new System.Drawing.Point(150, 222);
            this.btnYoneticiSil.Name = "btnYoneticiSil";
            this.btnYoneticiSil.Size = new System.Drawing.Size(103, 52);
            this.btnYoneticiSil.TabIndex = 7;
            this.btnYoneticiSil.Text = "Sil";
            this.btnYoneticiSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYoneticiSil.UseVisualStyleBackColor = false;
            this.btnYoneticiSil.Click += new System.EventHandler(this.btnYoneticiSil_Click);
            // 
            // btnYoneticiEkle
            // 
            this.btnYoneticiEkle.BackColor = System.Drawing.Color.Cornsilk;
            this.btnYoneticiEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYoneticiEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnYoneticiEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYoneticiEkle.ImageIndex = 1;
            this.btnYoneticiEkle.ImageList = this.ımageAdmin;
            this.btnYoneticiEkle.Location = new System.Drawing.Point(39, 222);
            this.btnYoneticiEkle.Name = "btnYoneticiEkle";
            this.btnYoneticiEkle.Size = new System.Drawing.Size(103, 52);
            this.btnYoneticiEkle.TabIndex = 6;
            this.btnYoneticiEkle.Text = "Ekle";
            this.btnYoneticiEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYoneticiEkle.UseVisualStyleBackColor = false;
            this.btnYoneticiEkle.Click += new System.EventHandler(this.btnYoneticiEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(50, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Telefon :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(64, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "TCKN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(69, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(15, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(35, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad :";
            // 
            // txtYoneticiTelefon
            // 
            this.txtYoneticiTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiTelefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtYoneticiTelefon.Location = new System.Drawing.Point(123, 145);
            this.txtYoneticiTelefon.Name = "txtYoneticiTelefon";
            this.txtYoneticiTelefon.Size = new System.Drawing.Size(109, 21);
            this.txtYoneticiTelefon.TabIndex = 4;
            // 
            // txtYoneticiTCKN
            // 
            this.txtYoneticiTCKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiTCKN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtYoneticiTCKN.Location = new System.Drawing.Point(123, 116);
            this.txtYoneticiTCKN.Name = "txtYoneticiTCKN";
            this.txtYoneticiTCKN.Size = new System.Drawing.Size(109, 21);
            this.txtYoneticiTCKN.TabIndex = 3;
            // 
            // txtYoneticiSifre
            // 
            this.txtYoneticiSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtYoneticiSifre.Location = new System.Drawing.Point(123, 87);
            this.txtYoneticiSifre.Name = "txtYoneticiSifre";
            this.txtYoneticiSifre.PasswordChar = '*';
            this.txtYoneticiSifre.Size = new System.Drawing.Size(109, 21);
            this.txtYoneticiSifre.TabIndex = 2;
            // 
            // txtYoneticiKullaniciAdi
            // 
            this.txtYoneticiKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtYoneticiKullaniciAdi.Location = new System.Drawing.Point(123, 59);
            this.txtYoneticiKullaniciAdi.Name = "txtYoneticiKullaniciAdi";
            this.txtYoneticiKullaniciAdi.Size = new System.Drawing.Size(109, 21);
            this.txtYoneticiKullaniciAdi.TabIndex = 1;
            // 
            // txtYoneticiSoyad
            // 
            this.txtYoneticiSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtYoneticiSoyad.Location = new System.Drawing.Point(123, 32);
            this.txtYoneticiSoyad.Name = "txtYoneticiSoyad";
            this.txtYoneticiSoyad.Size = new System.Drawing.Size(109, 21);
            this.txtYoneticiSoyad.TabIndex = 0;
            // 
            // btnRaporlama
            // 
            this.btnRaporlama.BackColor = System.Drawing.Color.Cornsilk;
            this.btnRaporlama.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnRaporlama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnRaporlama.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRaporlama.ImageKey = "rapor.png";
            this.btnRaporlama.ImageList = this.ımageAdmin;
            this.btnRaporlama.Location = new System.Drawing.Point(527, 82);
            this.btnRaporlama.Name = "btnRaporlama";
            this.btnRaporlama.Size = new System.Drawing.Size(102, 46);
            this.btnRaporlama.TabIndex = 2;
            this.btnRaporlama.Text = "Firma    Rapor";
            this.btnRaporlama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaporlama.UseVisualStyleBackColor = false;
            this.btnRaporlama.Click += new System.EventHandler(this.btnRaporlama_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 57);
            this.label1.TabIndex = 30;
            this.label1.Text = "Yönetici İşlemleri";
            // 
            // pbFirmaBanner
            // 
            this.pbFirmaBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbFirmaBanner.Image")));
            this.pbFirmaBanner.InitialImage = null;
            this.pbFirmaBanner.Location = new System.Drawing.Point(768, 23);
            this.pbFirmaBanner.Name = "pbFirmaBanner";
            this.pbFirmaBanner.Size = new System.Drawing.Size(431, 399);
            this.pbFirmaBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFirmaBanner.TabIndex = 31;
            this.pbFirmaBanner.TabStop = false;
            // 
            // btnKategori
            // 
            this.btnKategori.BackColor = System.Drawing.Color.Cornsilk;
            this.btnKategori.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnKategori.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKategori.ImageKey = "insert.png";
            this.btnKategori.ImageList = this.ımageAdmin;
            this.btnKategori.Location = new System.Drawing.Point(419, 82);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(102, 46);
            this.btnKategori.TabIndex = 32;
            this.btnKategori.Text = "Kategori Ekle";
            this.btnKategori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKategori.UseVisualStyleBackColor = false;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.Cornsilk;
            this.btnCıkıs.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCıkıs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnCıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCıkıs.ImageIndex = 3;
            this.btnCıkıs.ImageList = this.ımageAdmin;
            this.btnCıkıs.Location = new System.Drawing.Point(632, 82);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(102, 46);
            this.btnCıkıs.TabIndex = 50;
            this.btnCıkıs.Text = "Çıkış Yap";
            this.btnCıkıs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // FormYoneticiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(1221, 437);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.pbFirmaBanner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRaporlama);
            this.Controls.Add(this.gbYonetici);
            this.Controls.Add(this.gbFirma);
            this.Controls.Add(this.rbtnFirma);
            this.Controls.Add(this.rbtnYonetici);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormYoneticiEkrani";
            this.Text = "FormYoneticiEkrani";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormYoneticiEkrani_FormClosed);
            this.Load += new System.EventHandler(this.FormYoneticiEkrani_Load);
            this.gbFirma.ResumeLayout(false);
            this.gbFirma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nMinTS)).EndInit();
            this.gbYonetici.ResumeLayout(false);
            this.gbYonetici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirmaBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnYonetici;
        private System.Windows.Forms.RadioButton rbtnFirma;
        private System.Windows.Forms.GroupBox gbFirma;
        private System.Windows.Forms.GroupBox gbYonetici;
        private System.Windows.Forms.TextBox txtYoneticiSoyad;
        private System.Windows.Forms.TextBox txtYoneticiTCKN;
        private System.Windows.Forms.TextBox txtYoneticiSifre;
        private System.Windows.Forms.TextBox txtYoneticiKullaniciAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYoneticiGuncelle;
        private System.Windows.Forms.Button btnYoneticiSil;
        private System.Windows.Forms.Button btnYoneticiEkle;
        private System.Windows.Forms.TextBox txtYoneticiTelefon;
        private System.Windows.Forms.ListBox lstFirmalar;
        private System.Windows.Forms.Button btnFirmaGuncelle;
        private System.Windows.Forms.Button btnFirmaSil;
        private System.Windows.Forms.Button btnFirmaEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFirmaSifre;
        private System.Windows.Forms.TextBox txtFirmaKullaniciAdi;
        private System.Windows.Forms.TextBox txtFirmaTuru;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.ListBox lstYoneticiler;
        private System.Windows.Forms.NumericUpDown nMinTS;
        private System.Windows.Forms.CheckBox cbAktifMi;
        private System.Windows.Forms.Button btnRaporlama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ımageAdmin;
        private System.Windows.Forms.PictureBox pbFirmaBanner;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnYeni1;
    }
}