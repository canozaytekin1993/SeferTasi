namespace SeferTasi.UI.WFA.Formlar
{
    partial class FormFirmaRaporEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFirmaRaporEkrani));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.rbTEdilmemis = new System.Windows.Forms.RadioButton();
            this.rbTEdilmis = new System.Windows.Forms.RadioButton();
            this.lstMusteriSiparis = new System.Windows.Forms.ListBox();
            this.btnTesim = new System.Windows.Forms.Button();
            this.ımageFirmaRapor = new System.Windows.Forms.ImageList(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(192, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 57);
            this.label3.TabIndex = 47;
            this.label3.Text = "FİRMA SİPARİŞLERİ";
            // 
            // rbTEdilmemis
            // 
            this.rbTEdilmemis.AutoSize = true;
            this.rbTEdilmemis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rbTEdilmemis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.rbTEdilmemis.Location = new System.Drawing.Point(331, 108);
            this.rbTEdilmemis.Name = "rbTEdilmemis";
            this.rbTEdilmemis.Size = new System.Drawing.Size(114, 23);
            this.rbTEdilmemis.TabIndex = 50;
            this.rbTEdilmemis.Text = "Tamamlanan";
            this.rbTEdilmemis.UseVisualStyleBackColor = true;
            this.rbTEdilmemis.CheckedChanged += new System.EventHandler(this.rbTEdilmemis_CheckedChanged);
            // 
            // rbTEdilmis
            // 
            this.rbTEdilmis.AutoSize = true;
            this.rbTEdilmis.Checked = true;
            this.rbTEdilmis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rbTEdilmis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.rbTEdilmis.Location = new System.Drawing.Point(331, 85);
            this.rbTEdilmis.Name = "rbTEdilmis";
            this.rbTEdilmis.Size = new System.Drawing.Size(89, 23);
            this.rbTEdilmis.TabIndex = 51;
            this.rbTEdilmis.TabStop = true;
            this.rbTEdilmis.Text = "Bekleyen";
            this.rbTEdilmis.UseVisualStyleBackColor = true;
            this.rbTEdilmis.CheckedChanged += new System.EventHandler(this.rbTEdilmis_CheckedChanged);
            // 
            // lstMusteriSiparis
            // 
            this.lstMusteriSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lstMusteriSiparis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.lstMusteriSiparis.FormattingEnabled = true;
            this.lstMusteriSiparis.ItemHeight = 15;
            this.lstMusteriSiparis.Location = new System.Drawing.Point(23, 72);
            this.lstMusteriSiparis.Name = "lstMusteriSiparis";
            this.lstMusteriSiparis.Size = new System.Drawing.Size(302, 289);
            this.lstMusteriSiparis.TabIndex = 49;
            // 
            // btnTesim
            // 
            this.btnTesim.BackColor = System.Drawing.Color.Cornsilk;
            this.btnTesim.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTesim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.btnTesim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTesim.ImageIndex = 0;
            this.btnTesim.ImageList = this.ımageFirmaRapor;
            this.btnTesim.Location = new System.Drawing.Point(331, 292);
            this.btnTesim.Name = "btnTesim";
            this.btnTesim.Size = new System.Drawing.Size(114, 69);
            this.btnTesim.TabIndex = 52;
            this.btnTesim.Text = "Sipariş       Teslim Et";
            this.btnTesim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTesim.UseVisualStyleBackColor = false;
            this.btnTesim.Click += new System.EventHandler(this.btnTesim_Click);
            // 
            // ımageFirmaRapor
            // 
            this.ımageFirmaRapor.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageFirmaRapor.ImageStream")));
            this.ımageFirmaRapor.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageFirmaRapor.Images.SetKeyName(0, "tick.png");
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(152)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(451, 72);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.WhiteSmoke;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(96)))));
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Satis";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(380, 300);
            this.chart1.TabIndex = 55;
            this.chart1.Text = "chart1";
            // 
            // FormFirmaRaporEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(838, 394);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnTesim);
            this.Controls.Add(this.rbTEdilmemis);
            this.Controls.Add(this.rbTEdilmis);
            this.Controls.Add(this.lstMusteriSiparis);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFirmaRaporEkrani";
            this.Text = "FormFirmaRaporEkrani";
            this.Load += new System.EventHandler(this.FormFirmaRaporEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbTEdilmemis;
        private System.Windows.Forms.RadioButton rbTEdilmis;
        private System.Windows.Forms.ListBox lstMusteriSiparis;
        private System.Windows.Forms.Button btnTesim;
        private System.Windows.Forms.ImageList ımageFirmaRapor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}