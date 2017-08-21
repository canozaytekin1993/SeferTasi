namespace SeferTasi.UI.WFA.Formlar
{
    partial class FormYoneticiRaporEkrani
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYoneticiRaporEkrani));
            this.lstFirmaSiparis = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFirma = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rbTEdilmemis = new System.Windows.Forms.RadioButton();
            this.rbTEdilmis = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstFirmaSiparis
            // 
            this.lstFirmaSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.lstFirmaSiparis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.lstFirmaSiparis.FormattingEnabled = true;
            this.lstFirmaSiparis.ItemHeight = 15;
            this.lstFirmaSiparis.Location = new System.Drawing.Point(6, 117);
            this.lstFirmaSiparis.Name = "lstFirmaSiparis";
            this.lstFirmaSiparis.Size = new System.Drawing.Size(282, 259);
            this.lstFirmaSiparis.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(66, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(654, 57);
            this.label3.TabIndex = 55;
            this.label3.Text = "FİRMALARIN SATIŞ BİLGİLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "Firma Seç :";
            // 
            // cmbFirma
            // 
            this.cmbFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.cmbFirma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(135)))));
            this.cmbFirma.FormattingEnabled = true;
            this.cmbFirma.Location = new System.Drawing.Point(120, 84);
            this.cmbFirma.Name = "cmbFirma";
            this.cmbFirma.Size = new System.Drawing.Size(168, 23);
            this.cmbFirma.TabIndex = 58;
            this.cmbFirma.SelectedIndexChanged += new System.EventHandler(this.cmbFirma_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(152)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(405, 84);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.WhiteSmoke;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(96)))));
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Satis";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(380, 300);
            this.chart1.TabIndex = 61;
            this.chart1.Text = "chart1";
            // 
            // rbTEdilmemis
            // 
            this.rbTEdilmemis.AutoSize = true;
            this.rbTEdilmemis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.rbTEdilmemis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.rbTEdilmemis.Location = new System.Drawing.Point(297, 115);
            this.rbTEdilmemis.Name = "rbTEdilmemis";
            this.rbTEdilmemis.Size = new System.Drawing.Size(114, 23);
            this.rbTEdilmemis.TabIndex = 59;
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
            this.rbTEdilmis.Location = new System.Drawing.Point(297, 92);
            this.rbTEdilmis.Name = "rbTEdilmis";
            this.rbTEdilmis.Size = new System.Drawing.Size(89, 23);
            this.rbTEdilmis.TabIndex = 60;
            this.rbTEdilmis.TabStop = true;
            this.rbTEdilmis.Text = "Bekleyen";
            this.rbTEdilmis.UseVisualStyleBackColor = true;
            this.rbTEdilmis.CheckedChanged += new System.EventHandler(this.rbTEdilmis_CheckedChanged);
            // 
            // FormYoneticiRaporEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(786, 395);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.rbTEdilmemis);
            this.Controls.Add(this.rbTEdilmis);
            this.Controls.Add(this.cmbFirma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstFirmaSiparis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormYoneticiRaporEkrani";
            this.Text = "YoneticiRaporEkranı";
            this.Load += new System.EventHandler(this.FormYoneticiRaporEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFirmaSiparis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFirma;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton rbTEdilmemis;
        private System.Windows.Forms.RadioButton rbTEdilmis;
    }
}