namespace SeferTasi.UI.WFA.Formlar
{
    partial class FormFirmaUrunEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFirmaUrunEkrani));
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.ımageFirmaUrun = new System.Windows.Forms.ImageList(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.lstFirmaninUrunleri = new System.Windows.Forms.ListBox();
            this.cbSatistaMi = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.nFiyat = new System.Windows.Forms.NumericUpDown();
            this.rbSOlan = new System.Windows.Forms.RadioButton();
            this.rbSOlmayan = new System.Windows.Forms.RadioButton();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.BackColor = System.Drawing.Color.Cornsilk;
            this.btnUrunGuncelle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUrunGuncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnUrunGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunGuncelle.ImageIndex = 2;
            this.btnUrunGuncelle.ImageList = this.ımageFirmaUrun;
            this.btnUrunGuncelle.Location = new System.Drawing.Point(206, 301);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(91, 52);
            this.btnUrunGuncelle.TabIndex = 41;
            this.btnUrunGuncelle.Text = "Güncelle";
            this.btnUrunGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunGuncelle.UseVisualStyleBackColor = false;
            this.btnUrunGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // ımageFirmaUrun
            // 
            this.ımageFirmaUrun.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageFirmaUrun.ImageStream")));
            this.ımageFirmaUrun.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageFirmaUrun.Images.SetKeyName(0, "delete.png");
            this.ımageFirmaUrun.Images.SetKeyName(1, "insert.png");
            this.ımageFirmaUrun.Images.SetKeyName(2, "update.png");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(222, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 19);
            this.label11.TabIndex = 37;
            this.label11.Text = "Ürün Fiyatı :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(235, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 19);
            this.label12.TabIndex = 38;
            this.label12.Text = "Ürün Adı :";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.BackColor = System.Drawing.Color.Cornsilk;
            this.btnUrunSil.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUrunSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnUrunSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunSil.ImageIndex = 0;
            this.btnUrunSil.ImageList = this.ımageFirmaUrun;
            this.btnUrunSil.Location = new System.Drawing.Point(303, 301);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(91, 52);
            this.btnUrunSil.TabIndex = 41;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunSil.UseVisualStyleBackColor = false;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // lstFirmaninUrunleri
            // 
            this.lstFirmaninUrunleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lstFirmaninUrunleri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.lstFirmaninUrunleri.FormattingEnabled = true;
            this.lstFirmaninUrunleri.ItemHeight = 15;
            this.lstFirmaninUrunleri.Location = new System.Drawing.Point(18, 115);
            this.lstFirmaninUrunleri.Name = "lstFirmaninUrunleri";
            this.lstFirmaninUrunleri.Size = new System.Drawing.Size(175, 229);
            this.lstFirmaninUrunleri.TabIndex = 42;
            this.lstFirmaninUrunleri.SelectedIndexChanged += new System.EventHandler(this.lstFirmaninUrunleri_SelectedIndexChanged);
            // 
            // cbSatistaMi
            // 
            this.cbSatistaMi.AutoSize = true;
            this.cbSatistaMi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSatistaMi.Checked = true;
            this.cbSatistaMi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSatistaMi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cbSatistaMi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.cbSatistaMi.Location = new System.Drawing.Point(226, 241);
            this.cbSatistaMi.Name = "cbSatistaMi";
            this.cbSatistaMi.Size = new System.Drawing.Size(103, 23);
            this.cbSatistaMi.TabIndex = 43;
            this.cbSatistaMi.Text = "Satışta Mı :";
            this.cbSatistaMi.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cornsilk;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.ımageFirmaUrun;
            this.button1.Location = new System.Drawing.Point(400, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 52);
            this.button1.TabIndex = 41;
            this.button1.Text = "Yeni      Ürün";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(235, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Kategori :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Enabled = false;
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.txtUrunAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtUrunAdi.Location = new System.Drawing.Point(323, 172);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(159, 21);
            this.txtUrunAdi.TabIndex = 29;
            // 
            // nFiyat
            // 
            this.nFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.nFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.nFiyat.Location = new System.Drawing.Point(323, 206);
            this.nFiyat.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nFiyat.Name = "nFiyat";
            this.nFiyat.Size = new System.Drawing.Size(159, 21);
            this.nFiyat.TabIndex = 33;
            this.nFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rbSOlan
            // 
            this.rbSOlan.AutoSize = true;
            this.rbSOlan.Checked = true;
            this.rbSOlan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rbSOlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.rbSOlan.Location = new System.Drawing.Point(199, 78);
            this.rbSOlan.Name = "rbSOlan";
            this.rbSOlan.Size = new System.Drawing.Size(108, 23);
            this.rbSOlan.TabIndex = 45;
            this.rbSOlan.TabStop = true;
            this.rbSOlan.Text = "Satışta Olan";
            this.rbSOlan.UseVisualStyleBackColor = true;
            this.rbSOlan.CheckedChanged += new System.EventHandler(this.rbSOlan_CheckedChanged);
            // 
            // rbSOlmayan
            // 
            this.rbSOlmayan.AutoSize = true;
            this.rbSOlmayan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rbSOlmayan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.rbSOlmayan.Location = new System.Drawing.Point(323, 78);
            this.rbSOlmayan.Name = "rbSOlmayan";
            this.rbSOlmayan.Size = new System.Drawing.Size(137, 23);
            this.rbSOlmayan.TabIndex = 45;
            this.rbSOlmayan.Text = "Satışta Olmayan";
            this.rbSOlmayan.UseVisualStyleBackColor = true;
            this.rbSOlmayan.CheckedChanged += new System.EventHandler(this.rbSOlmayan_CheckedChanged);
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.txtArama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtArama.Location = new System.Drawing.Point(18, 78);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(175, 21);
            this.txtArama.TabIndex = 29;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(60, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 57);
            this.label3.TabIndex = 46;
            this.label3.Text = "URUN İŞLEMLERİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(497, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 327);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Enabled = false;
            this.txtKategoriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.txtKategoriAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtKategoriAdi.Location = new System.Drawing.Point(323, 139);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(159, 21);
            this.txtKategoriAdi.TabIndex = 29;
            // 
            // FormFirmaUrunEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(843, 370);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbSOlmayan);
            this.Controls.Add(this.rbSOlan);
            this.Controls.Add(this.cbSatistaMi);
            this.Controls.Add(this.lstFirmaninUrunleri);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.nFiyat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtArama);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.txtUrunAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFirmaUrunEkrani";
            this.Text = "FormFirmaUrunEkrani";
            this.Load += new System.EventHandler(this.FormFirmaUrunEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.ListBox lstFirmaninUrunleri;
        private System.Windows.Forms.CheckBox cbSatistaMi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.NumericUpDown nFiyat;
        private System.Windows.Forms.RadioButton rbSOlan;
        private System.Windows.Forms.RadioButton rbSOlmayan;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ImageList ımageFirmaUrun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtKategoriAdi;
    }
}