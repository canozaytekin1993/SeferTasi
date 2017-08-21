namespace SeferTasi.UI.WFA.Formlar
{
    partial class FormYeniUrunEklemeEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYeniUrunEklemeEkrani));
            this.cbSatistaMi = new System.Windows.Forms.CheckBox();
            this.nFiyat = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.ımageListYeniUrun = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dosyaAc = new System.Windows.Forms.OpenFileDialog();
            this.cbmKategori = new System.Windows.Forms.ComboBox();
            this.btnFotograf = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSatistaMi
            // 
            this.cbSatistaMi.AutoSize = true;
            this.cbSatistaMi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSatistaMi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.cbSatistaMi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.cbSatistaMi.Location = new System.Drawing.Point(10, 171);
            this.cbSatistaMi.Name = "cbSatistaMi";
            this.cbSatistaMi.Size = new System.Drawing.Size(103, 23);
            this.cbSatistaMi.TabIndex = 50;
            this.cbSatistaMi.Text = "Satışta Mı :";
            this.cbSatistaMi.UseVisualStyleBackColor = true;
            // 
            // nFiyat
            // 
            this.nFiyat.DecimalPlaces = 2;
            this.nFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.nFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.nFiyat.Location = new System.Drawing.Point(107, 136);
            this.nFiyat.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nFiyat.Name = "nFiyat";
            this.nFiyat.Size = new System.Drawing.Size(159, 21);
            this.nFiyat.TabIndex = 46;
            this.nFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(6, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 19);
            this.label11.TabIndex = 47;
            this.label11.Text = "Ürün Fiyatı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Kategori :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(19, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 19);
            this.label12.TabIndex = 49;
            this.label12.Text = "Ürün Adı :";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.txtUrunAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtUrunAdi.Location = new System.Drawing.Point(107, 102);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(159, 21);
            this.txtUrunAdi.TabIndex = 45;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Cornsilk;
            this.btnEkle.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.ImageIndex = 1;
            this.btnEkle.ImageList = this.ımageListYeniUrun;
            this.btnEkle.Location = new System.Drawing.Point(173, 194);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 52);
            this.btnEkle.TabIndex = 52;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ımageListYeniUrun
            // 
            this.ımageListYeniUrun.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageListYeniUrun.ImageStream")));
            this.ımageListYeniUrun.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageListYeniUrun.Images.SetKeyName(0, "photo.png");
            this.ımageListYeniUrun.Images.SetKeyName(1, "insert.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(282, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dosyaAc
            // 
            this.dosyaAc.FileName = "openFileDialog1";
            // 
            // cbmKategori
            // 
            this.cbmKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.cbmKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.cbmKategori.FormattingEnabled = true;
            this.cbmKategori.Location = new System.Drawing.Point(107, 69);
            this.cbmKategori.Name = "cbmKategori";
            this.cbmKategori.Size = new System.Drawing.Size(159, 23);
            this.cbmKategori.TabIndex = 51;
            // 
            // btnFotograf
            // 
            this.btnFotograf.BackColor = System.Drawing.Color.Cornsilk;
            this.btnFotograf.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFotograf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnFotograf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFotograf.ImageKey = "photo.png";
            this.btnFotograf.ImageList = this.ımageListYeniUrun;
            this.btnFotograf.Location = new System.Drawing.Point(52, 194);
            this.btnFotograf.Name = "btnFotograf";
            this.btnFotograf.Size = new System.Drawing.Size(106, 52);
            this.btnFotograf.TabIndex = 54;
            this.btnFotograf.Text = "Fotoğraf     Seç";
            this.btnFotograf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFotograf.UseVisualStyleBackColor = false;
            this.btnFotograf.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(144, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 57);
            this.label3.TabIndex = 56;
            this.label3.Text = "YENİ ÜRÜN";
            // 
            // FormYeniUrunEklemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(526, 270);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFotograf);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbmKategori);
            this.Controls.Add(this.cbSatistaMi);
            this.Controls.Add(this.nFiyat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtUrunAdi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormYeniUrunEklemeEkrani";
            this.Text = "FormYeniUrunEklemeEkrani";
            this.Load += new System.EventHandler(this.FormYeniUrunEklemeEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSatistaMi;
        private System.Windows.Forms.NumericUpDown nFiyat;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog dosyaAc;
        private System.Windows.Forms.ComboBox cbmKategori;
        private System.Windows.Forms.Button btnFotograf;
        private System.Windows.Forms.ImageList ımageListYeniUrun;
        private System.Windows.Forms.Label label3;
    }
}