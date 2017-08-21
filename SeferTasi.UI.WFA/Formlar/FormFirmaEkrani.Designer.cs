namespace SeferTasi.UI.WFA
{
    partial class FormFirmaEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFirmaEkrani));
            this.nMinTS = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFirmaSifre = new System.Windows.Forms.TextBox();
            this.txtFirmaKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.btnFirmaGuncelle = new System.Windows.Forms.Button();
            this.ımageListFirma = new System.Windows.Forms.ImageList(this.components);
            this.txtFirmaTuru = new System.Windows.Forms.TextBox();
            this.btnUrunler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbFirmaBanner = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCıkıs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nMinTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirmaBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // nMinTS
            // 
            this.nMinTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.nMinTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.nMinTS.Location = new System.Drawing.Point(143, 245);
            this.nMinTS.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nMinTS.Name = "nMinTS";
            this.nMinTS.Size = new System.Drawing.Size(122, 21);
            this.nMinTS.TabIndex = 20;
            this.nMinTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(47, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 23;
            this.label8.Text = "Min Teslim :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(89, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Şifre :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(35, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 19);
            this.label10.TabIndex = 25;
            this.label10.Text = "Kullanıcı Adı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(47, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Firma Türü :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(55, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "Firma Adı :";
            // 
            // txtFirmaSifre
            // 
            this.txtFirmaSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.txtFirmaSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtFirmaSifre.Location = new System.Drawing.Point(143, 209);
            this.txtFirmaSifre.Name = "txtFirmaSifre";
            this.txtFirmaSifre.PasswordChar = '*';
            this.txtFirmaSifre.Size = new System.Drawing.Size(122, 21);
            this.txtFirmaSifre.TabIndex = 19;
            // 
            // txtFirmaKullaniciAdi
            // 
            this.txtFirmaKullaniciAdi.Enabled = false;
            this.txtFirmaKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.txtFirmaKullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtFirmaKullaniciAdi.Location = new System.Drawing.Point(143, 173);
            this.txtFirmaKullaniciAdi.Name = "txtFirmaKullaniciAdi";
            this.txtFirmaKullaniciAdi.Size = new System.Drawing.Size(122, 21);
            this.txtFirmaKullaniciAdi.TabIndex = 18;
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.txtFirmaAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtFirmaAdi.Location = new System.Drawing.Point(143, 101);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(122, 21);
            this.txtFirmaAdi.TabIndex = 16;
            // 
            // btnFirmaGuncelle
            // 
            this.btnFirmaGuncelle.BackColor = System.Drawing.Color.Cornsilk;
            this.btnFirmaGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFirmaGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnFirmaGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaGuncelle.ImageIndex = 1;
            this.btnFirmaGuncelle.ImageList = this.ımageListFirma;
            this.btnFirmaGuncelle.Location = new System.Drawing.Point(143, 272);
            this.btnFirmaGuncelle.Name = "btnFirmaGuncelle";
            this.btnFirmaGuncelle.Size = new System.Drawing.Size(105, 52);
            this.btnFirmaGuncelle.TabIndex = 28;
            this.btnFirmaGuncelle.Text = "Güncelle";
            this.btnFirmaGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirmaGuncelle.UseVisualStyleBackColor = false;
            this.btnFirmaGuncelle.Click += new System.EventHandler(this.btnFirmaGuncelle_Click);
            // 
            // ımageListFirma
            // 
            this.ımageListFirma.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListFirma.ImageStream")));
            this.ımageListFirma.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListFirma.Images.SetKeyName(0, "siparis.png");
            this.ımageListFirma.Images.SetKeyName(1, "update.png");
            this.ımageListFirma.Images.SetKeyName(2, "urun.png");
            this.ımageListFirma.Images.SetKeyName(3, "exit.png");
            // 
            // txtFirmaTuru
            // 
            this.txtFirmaTuru.Enabled = false;
            this.txtFirmaTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.txtFirmaTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtFirmaTuru.Location = new System.Drawing.Point(143, 137);
            this.txtFirmaTuru.Name = "txtFirmaTuru";
            this.txtFirmaTuru.Size = new System.Drawing.Size(122, 21);
            this.txtFirmaTuru.TabIndex = 17;
            // 
            // btnUrunler
            // 
            this.btnUrunler.BackColor = System.Drawing.Color.Cornsilk;
            this.btnUrunler.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUrunler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnUrunler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunler.ImageKey = "urun.png";
            this.btnUrunler.ImageList = this.ımageListFirma;
            this.btnUrunler.Location = new System.Drawing.Point(271, 157);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(105, 52);
            this.btnUrunler.TabIndex = 28;
            this.btnUrunler.Text = "Ürün İşlemleri";
            this.btnUrunler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunler.UseVisualStyleBackColor = false;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 57);
            this.label1.TabIndex = 29;
            this.label1.Text = "Firma İşlemleri";
            // 
            // pbFirmaBanner
            // 
            this.pbFirmaBanner.Image = ((System.Drawing.Image)(resources.GetObject("pbFirmaBanner.Image")));
            this.pbFirmaBanner.InitialImage = null;
            this.pbFirmaBanner.Location = new System.Drawing.Point(382, 60);
            this.pbFirmaBanner.Name = "pbFirmaBanner";
            this.pbFirmaBanner.Size = new System.Drawing.Size(268, 264);
            this.pbFirmaBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFirmaBanner.TabIndex = 30;
            this.pbFirmaBanner.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageKey = "siparis.png";
            this.button1.ImageList = this.ımageListFirma;
            this.button1.Location = new System.Drawing.Point(271, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 52);
            this.button1.TabIndex = 28;
            this.button1.Text = "Siparişler";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnSiparisler_Click);
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.Cornsilk;
            this.btnCıkıs.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCıkıs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnCıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCıkıs.ImageIndex = 3;
            this.btnCıkıs.ImageList = this.ımageListFirma;
            this.btnCıkıs.Location = new System.Drawing.Point(268, 272);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(108, 52);
            this.btnCıkıs.TabIndex = 50;
            this.btnCıkıs.Text = "Çıkış Yap";
            this.btnCıkıs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // FormFirmaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(669, 346);
            this.Controls.Add(this.btnCıkıs);
            this.Controls.Add(this.pbFirmaBanner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUrunler);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFirmaGuncelle);
            this.Controls.Add(this.nMinTS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtFirmaSifre);
            this.Controls.Add(this.txtFirmaKullaniciAdi);
            this.Controls.Add(this.txtFirmaTuru);
            this.Controls.Add(this.txtFirmaAdi);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFirmaEkrani";
            this.Text = "FormFirmaEkrani";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFirmaEkrani_FormClosed);
            this.Load += new System.EventHandler(this.FormFirmaEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nMinTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirmaBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nMinTS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFirmaSifre;
        private System.Windows.Forms.TextBox txtFirmaKullaniciAdi;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.Button btnFirmaGuncelle;
        private System.Windows.Forms.TextBox txtFirmaTuru;
        private System.Windows.Forms.Button btnUrunler;
        private System.Windows.Forms.ImageList ımageListFirma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbFirmaBanner;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCıkıs;
    }
}