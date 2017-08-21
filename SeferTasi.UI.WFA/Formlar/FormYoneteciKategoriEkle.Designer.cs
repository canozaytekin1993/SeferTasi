namespace SeferTasi.UI.WFA.Formlar
{
    partial class FormYoneteciKategoriEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYoneteciKategoriEkle));
            this.btnFirmaEkle = new System.Windows.Forms.Button();
            this.imageListKategori = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtYoneticiSoyad = new System.Windows.Forms.TextBox();
            this.lstKategoriler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirmaEkle
            // 
            this.btnFirmaEkle.BackColor = System.Drawing.Color.Cornsilk;
            this.btnFirmaEkle.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFirmaEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnFirmaEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirmaEkle.ImageIndex = 0;
            this.btnFirmaEkle.ImageList = this.imageListKategori;
            this.btnFirmaEkle.Location = new System.Drawing.Point(120, 120);
            this.btnFirmaEkle.Name = "btnFirmaEkle";
            this.btnFirmaEkle.Size = new System.Drawing.Size(109, 52);
            this.btnFirmaEkle.TabIndex = 8;
            this.btnFirmaEkle.Text = "Ekle";
            this.btnFirmaEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirmaEkle.UseVisualStyleBackColor = false;
            this.btnFirmaEkle.Click += new System.EventHandler(this.btnFirmaEkle_Click);
            // 
            // imageListKategori
            // 
            this.imageListKategori.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListKategori.ImageStream")));
            this.imageListKategori.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListKategori.Images.SetKeyName(0, "insert.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kategori Adı :";
            // 
            // txtYoneticiSoyad
            // 
            this.txtYoneticiSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYoneticiSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.txtYoneticiSoyad.Location = new System.Drawing.Point(120, 81);
            this.txtYoneticiSoyad.Name = "txtYoneticiSoyad";
            this.txtYoneticiSoyad.Size = new System.Drawing.Size(109, 21);
            this.txtYoneticiSoyad.TabIndex = 9;
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstKategoriler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.lstKategoriler.FormattingEnabled = true;
            this.lstKategoriler.ItemHeight = 15;
            this.lstKategoriler.Location = new System.Drawing.Point(235, 81);
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.Size = new System.Drawing.Size(126, 169);
            this.lstKategoriler.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 57);
            this.label1.TabIndex = 31;
            this.label1.Text = "Kategori Ekle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(367, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // FormYoneteciKategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(627, 270);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstKategoriler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYoneticiSoyad);
            this.Controls.Add(this.btnFirmaEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormYoneteciKategoriEkle";
            this.Text = "FormYoneteciKategoriEkle";
            this.Load += new System.EventHandler(this.FormYoneteciKategoriEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirmaEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYoneticiSoyad;
        private System.Windows.Forms.ImageList imageListKategori;
        private System.Windows.Forms.ListBox lstKategoriler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}