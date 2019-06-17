namespace Piggy_bank_vizsga
{
    partial class KezdolapUC
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
            this.lblUdv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUdv
            // 
            this.lblUdv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUdv.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUdv.Location = new System.Drawing.Point(0, 0);
            this.lblUdv.Name = "lblUdv";
            this.lblUdv.Size = new System.Drawing.Size(1063, 596);
            this.lblUdv.TabIndex = 0;
            this.lblUdv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KezdolapUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lblUdv);
            this.Name = "KezdolapUC";
            this.Size = new System.Drawing.Size(1063, 596);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblUdv;
    }
}
