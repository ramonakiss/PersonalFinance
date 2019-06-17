namespace Piggy_bank_vizsga
{
    partial class AttekintesHaviUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttekintesHaviUC));
            this.katKoltes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.szazalekosKoltes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblDiagrHavi = new System.Windows.Forms.Label();
            this.lblDiagrSzaz = new System.Windows.Forms.Label();
            this.bunifuGradientPanel3 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblKiadas = new System.Windows.Forms.Label();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblBevetel = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblAktualis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.katKoltes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szazalekosKoltes)).BeginInit();
            this.bunifuGradientPanel3.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // katKoltes
            // 
            this.katKoltes.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.katKoltes.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.katKoltes.Legends.Add(legend1);
            this.katKoltes.Location = new System.Drawing.Point(119, 176);
            this.katKoltes.Name = "katKoltes";
            this.katKoltes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "Összesen";
            this.katKoltes.Series.Add(series1);
            this.katKoltes.Size = new System.Drawing.Size(364, 375);
            this.katKoltes.TabIndex = 11;
            this.katKoltes.Text = "chart";
            this.katKoltes.Paint += new System.Windows.Forms.PaintEventHandler(this.katKoltes_Paint);
            // 
            // szazalekosKoltes
            // 
            this.szazalekosKoltes.BackColor = System.Drawing.Color.Black;
            chartArea2.Name = "ChartArea1";
            this.szazalekosKoltes.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.szazalekosKoltes.Legends.Add(legend2);
            this.szazalekosKoltes.Location = new System.Drawing.Point(537, 165);
            this.szazalekosKoltes.Name = "szazalekosKoltes";
            this.szazalekosKoltes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Szazalek";
            this.szazalekosKoltes.Series.Add(series2);
            this.szazalekosKoltes.Size = new System.Drawing.Size(396, 360);
            this.szazalekosKoltes.TabIndex = 12;
            this.szazalekosKoltes.Text = "chart1";
            this.szazalekosKoltes.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            this.szazalekosKoltes.Paint += new System.Windows.Forms.PaintEventHandler(this.szazalekosKoltes_Paint);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl3.Location = new System.Drawing.Point(410, 31);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(152, 17);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "A havi összes kiadása:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl2.Location = new System.Drawing.Point(65, 31);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(157, 17);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "A havi összes bevétele:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1.Location = new System.Drawing.Point(761, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(160, 17);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "A havi aktuális összege:";
            // 
            // lblDiagrHavi
            // 
            this.lblDiagrHavi.AutoSize = true;
            this.lblDiagrHavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDiagrHavi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiagrHavi.Location = new System.Drawing.Point(65, 165);
            this.lblDiagrHavi.Name = "lblDiagrHavi";
            this.lblDiagrHavi.Size = new System.Drawing.Size(147, 17);
            this.lblDiagrHavi.TabIndex = 16;
            this.lblDiagrHavi.Text = "Havi költés diagramm:";
            // 
            // lblDiagrSzaz
            // 
            this.lblDiagrSzaz.AutoSize = true;
            this.lblDiagrSzaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDiagrSzaz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiagrSzaz.Location = new System.Drawing.Point(512, 155);
            this.lblDiagrSzaz.Name = "lblDiagrSzaz";
            this.lblDiagrSzaz.Size = new System.Drawing.Size(180, 17);
            this.lblDiagrSzaz.TabIndex = 17;
            this.lblDiagrSzaz.Text = "Havi százalékos diagramm:";
            // 
            // bunifuGradientPanel3
            // 
            this.bunifuGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel3.BackgroundImage")));
            this.bunifuGradientPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel3.Controls.Add(this.lblKiadas);
            this.bunifuGradientPanel3.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel3.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel3.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel3.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.bunifuGradientPanel3.Location = new System.Drawing.Point(451, 48);
            this.bunifuGradientPanel3.Name = "bunifuGradientPanel3";
            this.bunifuGradientPanel3.Quality = 100;
            this.bunifuGradientPanel3.Size = new System.Drawing.Size(161, 92);
            this.bunifuGradientPanel3.TabIndex = 15;
            // 
            // lblKiadas
            // 
            this.lblKiadas.AutoSize = true;
            this.lblKiadas.BackColor = System.Drawing.Color.Transparent;
            this.lblKiadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKiadas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKiadas.Location = new System.Drawing.Point(32, 28);
            this.lblKiadas.Name = "lblKiadas";
            this.lblKiadas.Size = new System.Drawing.Size(0, 22);
            this.lblKiadas.TabIndex = 11;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.lblBevetel);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(105, 48);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 100;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(161, 89);
            this.bunifuGradientPanel2.TabIndex = 14;
            // 
            // lblBevetel
            // 
            this.lblBevetel.AutoSize = true;
            this.lblBevetel.BackColor = System.Drawing.Color.Transparent;
            this.lblBevetel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBevetel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBevetel.Location = new System.Drawing.Point(39, 21);
            this.lblBevetel.Name = "lblBevetel";
            this.lblBevetel.Size = new System.Drawing.Size(0, 22);
            this.lblBevetel.TabIndex = 0;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.lblAktualis);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(801, 48);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 100;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(161, 89);
            this.bunifuGradientPanel1.TabIndex = 10;
            // 
            // lblAktualis
            // 
            this.lblAktualis.AutoSize = true;
            this.lblAktualis.BackColor = System.Drawing.Color.Transparent;
            this.lblAktualis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAktualis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAktualis.Location = new System.Drawing.Point(27, 21);
            this.lblAktualis.Name = "lblAktualis";
            this.lblAktualis.Size = new System.Drawing.Size(0, 22);
            this.lblAktualis.TabIndex = 0;
            // 
            // AttekintesHaviUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lblDiagrSzaz);
            this.Controls.Add(this.lblDiagrHavi);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.bunifuGradientPanel3);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.szazalekosKoltes);
            this.Controls.Add(this.katKoltes);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "AttekintesHaviUC";
            this.Size = new System.Drawing.Size(1063, 596);
            ((System.ComponentModel.ISupportInitialize)(this.katKoltes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szazalekosKoltes)).EndInit();
            this.bunifuGradientPanel3.ResumeLayout(false);
            this.bunifuGradientPanel3.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAktualis;
        private System.Windows.Forms.Label lbl1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart katKoltes;
        private System.Windows.Forms.DataVisualization.Charting.Chart szazalekosKoltes;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblBevetel;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel3;
        private System.Windows.Forms.Label lblKiadas;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblDiagrHavi;
        private System.Windows.Forms.Label lblDiagrSzaz;
    }
}
