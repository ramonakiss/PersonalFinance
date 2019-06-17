namespace Piggy_bank_vizsga
{
    partial class Bejelentkezes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bejelentkezes));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlFelso = new System.Windows.Forms.Panel();
            this.pnlAlso = new System.Windows.Forms.Panel();
            this.lblReg = new System.Windows.Forms.LinkLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbJelszo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbFelhasznalo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBejel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pbJelszo = new System.Windows.Forms.PictureBox();
            this.pbFelhasznalo = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbLecsuk = new System.Windows.Forms.PictureBox();
            this.pbKilep = new System.Windows.Forms.PictureBox();
            this.pnlFelso.SuspendLayout();
            this.pnlAlso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJelszo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFelhasznalo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLecsuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKilep)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlFelso
            // 
            this.pnlFelso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlFelso.Controls.Add(this.pbLecsuk);
            this.pnlFelso.Controls.Add(this.pbKilep);
            this.pnlFelso.Location = new System.Drawing.Point(0, -1);
            this.pnlFelso.Name = "pnlFelso";
            this.pnlFelso.Size = new System.Drawing.Size(344, 33);
            this.pnlFelso.TabIndex = 0;
            // 
            // pnlAlso
            // 
            this.pnlAlso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlAlso.Controls.Add(this.pictureBox1);
            this.pnlAlso.Controls.Add(this.lblReg);
            this.pnlAlso.Controls.Add(this.bunifuCustomLabel1);
            this.pnlAlso.Controls.Add(this.btnBejel);
            this.pnlAlso.Controls.Add(this.pbJelszo);
            this.pnlAlso.Controls.Add(this.pbFelhasznalo);
            this.pnlAlso.Controls.Add(this.tbJelszo);
            this.pnlAlso.Controls.Add(this.tbFelhasznalo);
            this.pnlAlso.Controls.Add(this.pbLogo);
            this.pnlAlso.Location = new System.Drawing.Point(0, 28);
            this.pnlAlso.Name = "pnlAlso";
            this.pnlAlso.Size = new System.Drawing.Size(344, 455);
            this.pnlAlso.TabIndex = 1;
            // 
            // lblReg
            // 
            this.lblReg.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.lblReg.AutoSize = true;
            this.lblReg.LinkColor = System.Drawing.Color.White;
            this.lblReg.Location = new System.Drawing.Point(136, 418);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(65, 13);
            this.lblReg.TabIndex = 8;
            this.lblReg.TabStop = true;
            this.lblReg.Text = "Regisztráció";
            this.lblReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblReg_LinkClicked);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(123, 189);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(103, 13);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "bunifuCustomLabel1";
            // 
            // tbJelszo
            // 
            this.tbJelszo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbJelszo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbJelszo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbJelszo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbJelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbJelszo.ForeColor = System.Drawing.Color.White;
            this.tbJelszo.HintForeColor = System.Drawing.Color.Empty;
            this.tbJelszo.HintText = "";
            this.tbJelszo.isPassword = true;
            this.tbJelszo.LineFocusedColor = System.Drawing.Color.Teal;
            this.tbJelszo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.tbJelszo.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.tbJelszo.LineThickness = 3;
            this.tbJelszo.Location = new System.Drawing.Point(57, 287);
            this.tbJelszo.Margin = new System.Windows.Forms.Padding(4);
            this.tbJelszo.MaxLength = 32767;
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.Size = new System.Drawing.Size(260, 37);
            this.tbJelszo.TabIndex = 2;
            this.tbJelszo.Text = "Jelszo";
            this.tbJelszo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbFelhasznalo
            // 
            this.tbFelhasznalo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbFelhasznalo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbFelhasznalo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbFelhasznalo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFelhasznalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbFelhasznalo.ForeColor = System.Drawing.Color.White;
            this.tbFelhasznalo.HintForeColor = System.Drawing.Color.Empty;
            this.tbFelhasznalo.HintText = "";
            this.tbFelhasznalo.isPassword = false;
            this.tbFelhasznalo.LineFocusedColor = System.Drawing.Color.Teal;
            this.tbFelhasznalo.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.tbFelhasznalo.LineMouseHoverColor = System.Drawing.Color.Teal;
            this.tbFelhasznalo.LineThickness = 3;
            this.tbFelhasznalo.Location = new System.Drawing.Point(57, 222);
            this.tbFelhasznalo.Margin = new System.Windows.Forms.Padding(4);
            this.tbFelhasznalo.MaxLength = 32767;
            this.tbFelhasznalo.Name = "tbFelhasznalo";
            this.tbFelhasznalo.Size = new System.Drawing.Size(260, 37);
            this.tbFelhasznalo.TabIndex = 1;
            this.tbFelhasznalo.Text = "Felhasználónév";
            this.tbFelhasznalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlFelso;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Piggy_bank_vizsga.Properties.Resources.Piggy;
            this.pictureBox1.Location = new System.Drawing.Point(68, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 52);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnBejel
            // 
            this.btnBejel.ActiveBorderThickness = 1;
            this.btnBejel.ActiveCornerRadius = 20;
            this.btnBejel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.btnBejel.ActiveForecolor = System.Drawing.Color.Black;
            this.btnBejel.ActiveLineColor = System.Drawing.Color.Black;
            this.btnBejel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBejel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBejel.BackgroundImage")));
            this.btnBejel.ButtonText = "BEJELENTKEZÉS";
            this.btnBejel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBejel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBejel.ForeColor = System.Drawing.Color.White;
            this.btnBejel.IdleBorderThickness = 1;
            this.btnBejel.IdleCornerRadius = 20;
            this.btnBejel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.btnBejel.IdleForecolor = System.Drawing.Color.White;
            this.btnBejel.IdleLineColor = System.Drawing.Color.White;
            this.btnBejel.Location = new System.Drawing.Point(83, 352);
            this.btnBejel.Margin = new System.Windows.Forms.Padding(5);
            this.btnBejel.Name = "btnBejel";
            this.btnBejel.Size = new System.Drawing.Size(181, 41);
            this.btnBejel.TabIndex = 5;
            this.btnBejel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBejel.Click += new System.EventHandler(this.btnBejel_Click);
            // 
            // pbJelszo
            // 
            this.pbJelszo.Image = global::Piggy_bank_vizsga.Properties.Resources.Jelszo;
            this.pbJelszo.Location = new System.Drawing.Point(12, 287);
            this.pbJelszo.Name = "pbJelszo";
            this.pbJelszo.Size = new System.Drawing.Size(37, 37);
            this.pbJelszo.TabIndex = 4;
            this.pbJelszo.TabStop = false;
            // 
            // pbFelhasznalo
            // 
            this.pbFelhasznalo.Image = global::Piggy_bank_vizsga.Properties.Resources.Profil;
            this.pbFelhasznalo.Location = new System.Drawing.Point(12, 222);
            this.pbFelhasznalo.Name = "pbFelhasznalo";
            this.pbFelhasznalo.Size = new System.Drawing.Size(37, 37);
            this.pbFelhasznalo.TabIndex = 3;
            this.pbFelhasznalo.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Piggy_bank_vizsga.Properties.Resources.malac1;
            this.pbLogo.Location = new System.Drawing.Point(110, 10);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(128, 137);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pbLecsuk
            // 
            this.pbLecsuk.Image = global::Piggy_bank_vizsga.Properties.Resources.Lecsuk;
            this.pbLecsuk.Location = new System.Drawing.Point(283, 10);
            this.pbLecsuk.Name = "pbLecsuk";
            this.pbLecsuk.Size = new System.Drawing.Size(26, 20);
            this.pbLecsuk.TabIndex = 0;
            this.pbLecsuk.TabStop = false;
            this.pbLecsuk.Click += new System.EventHandler(this.pbLecsuk_Click);
            // 
            // pbKilep
            // 
            this.pbKilep.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbKilep.Image = global::Piggy_bank_vizsga.Properties.Resources.XK;
            this.pbKilep.Location = new System.Drawing.Point(315, 4);
            this.pbKilep.Name = "pbKilep";
            this.pbKilep.Size = new System.Drawing.Size(26, 26);
            this.pbKilep.TabIndex = 1;
            this.pbKilep.TabStop = false;
            this.pbKilep.Click += new System.EventHandler(this.pbKilep_Click);
            // 
            // Bejelentkezes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(345, 483);
            this.Controls.Add(this.pnlAlso);
            this.Controls.Add(this.pnlFelso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Bejelentkezes";
            this.Opacity = 0.95D;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bejelentkezes_KeyDown);
            this.pnlFelso.ResumeLayout(false);
            this.pnlAlso.ResumeLayout(false);
            this.pnlAlso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJelszo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFelhasznalo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLecsuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKilep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlAlso;
        private System.Windows.Forms.Panel pnlFelso;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBejel;
        private System.Windows.Forms.PictureBox pbJelszo;
        private System.Windows.Forms.PictureBox pbFelhasznalo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbJelszo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbFelhasznalo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbLecsuk;
        private System.Windows.Forms.PictureBox pbKilep;
        private System.Windows.Forms.LinkLabel lblReg;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

