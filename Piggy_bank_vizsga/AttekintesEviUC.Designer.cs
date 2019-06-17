namespace Piggy_bank_vizsga
{
    partial class AttekintesEviUC
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
            this.evesBontasKi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblEvesTeljesHavi = new System.Windows.Forms.Label();
            this.evesBontasBe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.evesBontasKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evesBontasBe)).BeginInit();
            this.SuspendLayout();
            // 
            // evesBontasKi
            // 
            chartArea1.Name = "ChartArea1";
            this.evesBontasKi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.evesBontasKi.Legends.Add(legend1);
            this.evesBontasKi.Location = new System.Drawing.Point(25, 124);
            this.evesBontasKi.Name = "evesBontasKi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Havi teljes költés";
            this.evesBontasKi.Series.Add(series1);
            this.evesBontasKi.Size = new System.Drawing.Size(505, 340);
            this.evesBontasKi.TabIndex = 0;
            this.evesBontasKi.Text = "chart1";
            this.evesBontasKi.Paint += new System.Windows.Forms.PaintEventHandler(this.evesBontas_Paint);
            // 
            // lblEvesTeljesHavi
            // 
            this.lblEvesTeljesHavi.AutoSize = true;
            this.lblEvesTeljesHavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEvesTeljesHavi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEvesTeljesHavi.Location = new System.Drawing.Point(22, 99);
            this.lblEvesTeljesHavi.Name = "lblEvesTeljesHavi";
            this.lblEvesTeljesHavi.Size = new System.Drawing.Size(192, 17);
            this.lblEvesTeljesHavi.TabIndex = 1;
            this.lblEvesTeljesHavi.Text = "Havi teljes költése az évben: ";
            // 
            // evesBontasBe
            // 
            chartArea2.Name = "ChartArea1";
            this.evesBontasBe.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.evesBontasBe.Legends.Add(legend2);
            this.evesBontasBe.Location = new System.Drawing.Point(536, 124);
            this.evesBontasBe.Name = "evesBontasBe";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Havi teljes bevétel";
            this.evesBontasBe.Series.Add(series2);
            this.evesBontasBe.Size = new System.Drawing.Size(505, 340);
            this.evesBontasBe.TabIndex = 2;
            this.evesBontasBe.Text = "chart1";
            this.evesBontasBe.Paint += new System.Windows.Forms.PaintEventHandler(this.evesBontasBe_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(533, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Havi teljes bevétele az évben: ";
            // 
            // AttekintesEviUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evesBontasBe);
            this.Controls.Add(this.lblEvesTeljesHavi);
            this.Controls.Add(this.evesBontasKi);
            this.Name = "AttekintesEviUC";
            this.Size = new System.Drawing.Size(1063, 596);
            ((System.ComponentModel.ISupportInitialize)(this.evesBontasKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evesBontasBe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart evesBontasKi;
        private System.Windows.Forms.Label lblEvesTeljesHavi;
        private System.Windows.Forms.DataVisualization.Charting.Chart evesBontasBe;
        private System.Windows.Forms.Label label1;
    }
}
