namespace Piggy_bank_vizsga
{
    partial class PBForm
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlFelso = new System.Windows.Forms.Panel();
            this.pbKilep = new System.Windows.Forms.PictureBox();
            this.pbLecsuk = new System.Windows.Forms.PictureBox();
            this.pnlOldal = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlGombok = new System.Windows.Forms.Panel();
            this.btnEvi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHavi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pbKijelent = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBe = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKezdo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlFelso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKilep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLecsuk)).BeginInit();
            this.pnlOldal.SuspendLayout();
            this.pnlGombok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKijelent)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlFelso
            // 
            this.pnlFelso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.pnlFelso.Controls.Add(this.pbKilep);
            this.pnlFelso.Controls.Add(this.pbLecsuk);
            this.pnlFelso.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFelso.Location = new System.Drawing.Point(0, 0);
            this.pnlFelso.Name = "pnlFelso";
            this.pnlFelso.Size = new System.Drawing.Size(1251, 33);
            this.pnlFelso.TabIndex = 0;
            // 
            // pbKilep
            // 
            this.pbKilep.BackColor = System.Drawing.Color.Transparent;
            this.pbKilep.Image = global::Piggy_bank_vizsga.Properties.Resources.XF;
            this.pbKilep.Location = new System.Drawing.Point(1222, 4);
            this.pbKilep.Name = "pbKilep";
            this.pbKilep.Size = new System.Drawing.Size(26, 26);
            this.pbKilep.TabIndex = 2;
            this.pbKilep.TabStop = false;
            this.pbKilep.Click += new System.EventHandler(this.pbKilep_Click);
            // 
            // pbLecsuk
            // 
            this.pbLecsuk.Image = global::Piggy_bank_vizsga.Properties.Resources.LecsukF;
            this.pbLecsuk.Location = new System.Drawing.Point(1190, 13);
            this.pbLecsuk.Name = "pbLecsuk";
            this.pbLecsuk.Size = new System.Drawing.Size(26, 20);
            this.pbLecsuk.TabIndex = 2;
            this.pbLecsuk.TabStop = false;
            this.pbLecsuk.Click += new System.EventHandler(this.pbLecsuk_Click);
            // 
            // pnlOldal
            // 
            this.pnlOldal.BackColor = System.Drawing.Color.Black;
            this.pnlOldal.Controls.Add(this.bunifuSeparator1);
            this.pnlOldal.Controls.Add(this.pnlGombok);
            this.pnlOldal.Controls.Add(this.pbKijelent);
            this.pnlOldal.Controls.Add(this.btnAt);
            this.pnlOldal.Controls.Add(this.btnBe);
            this.pnlOldal.Controls.Add(this.btnKi);
            this.pnlOldal.Controls.Add(this.btnKezdo);
            this.pnlOldal.Location = new System.Drawing.Point(0, 33);
            this.pnlOldal.Name = "pnlOldal";
            this.pnlOldal.Size = new System.Drawing.Size(204, 629);
            this.pnlOldal.TabIndex = 1;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(194, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 561);
            this.bunifuSeparator1.TabIndex = 8;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // pnlGombok
            // 
            this.pnlGombok.Controls.Add(this.btnEvi);
            this.pnlGombok.Controls.Add(this.btnHavi);
            this.pnlGombok.Location = new System.Drawing.Point(0, 278);
            this.pnlGombok.Name = "pnlGombok";
            this.pnlGombok.Size = new System.Drawing.Size(202, 0);
            this.pnlGombok.TabIndex = 7;
            // 
            // btnEvi
            // 
            this.btnEvi.Active = false;
            this.btnEvi.Activecolor = System.Drawing.Color.Teal;
            this.btnEvi.BackColor = System.Drawing.Color.Black;
            this.btnEvi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEvi.BorderRadius = 4;
            this.btnEvi.ButtonText = "Éves";
            this.btnEvi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvi.DisabledColor = System.Drawing.Color.Transparent;
            this.btnEvi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEvi.Iconimage = global::Piggy_bank_vizsga.Properties.Resources.attekintesEv;
            this.btnEvi.Iconimage_right = null;
            this.btnEvi.Iconimage_right_Selected = null;
            this.btnEvi.Iconimage_Selected = null;
            this.btnEvi.IconMarginLeft = 0;
            this.btnEvi.IconMarginRight = 0;
            this.btnEvi.IconRightVisible = true;
            this.btnEvi.IconRightZoom = 0D;
            this.btnEvi.IconVisible = true;
            this.btnEvi.IconZoom = 90D;
            this.btnEvi.IsTab = false;
            this.btnEvi.Location = new System.Drawing.Point(22, 74);
            this.btnEvi.Name = "btnEvi";
            this.btnEvi.Normalcolor = System.Drawing.Color.Black;
            this.btnEvi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.btnEvi.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEvi.selected = false;
            this.btnEvi.Size = new System.Drawing.Size(172, 58);
            this.btnEvi.TabIndex = 6;
            this.btnEvi.Text = "Éves";
            this.btnEvi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvi.Textcolor = System.Drawing.Color.White;
            this.btnEvi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvi.Click += new System.EventHandler(this.btnEvi_Click);
            // 
            // btnHavi
            // 
            this.btnHavi.Active = false;
            this.btnHavi.Activecolor = System.Drawing.Color.Teal;
            this.btnHavi.BackColor = System.Drawing.Color.Black;
            this.btnHavi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHavi.BorderRadius = 4;
            this.btnHavi.ButtonText = "Havi";
            this.btnHavi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHavi.DisabledColor = System.Drawing.Color.Transparent;
            this.btnHavi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHavi.Iconimage = global::Piggy_bank_vizsga.Properties.Resources.Attekintes;
            this.btnHavi.Iconimage_right = null;
            this.btnHavi.Iconimage_right_Selected = null;
            this.btnHavi.Iconimage_Selected = null;
            this.btnHavi.IconMarginLeft = 0;
            this.btnHavi.IconMarginRight = 0;
            this.btnHavi.IconRightVisible = true;
            this.btnHavi.IconRightZoom = 0D;
            this.btnHavi.IconVisible = true;
            this.btnHavi.IconZoom = 90D;
            this.btnHavi.IsTab = false;
            this.btnHavi.Location = new System.Drawing.Point(22, 10);
            this.btnHavi.Name = "btnHavi";
            this.btnHavi.Normalcolor = System.Drawing.Color.Black;
            this.btnHavi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.btnHavi.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnHavi.selected = false;
            this.btnHavi.Size = new System.Drawing.Size(172, 58);
            this.btnHavi.TabIndex = 5;
            this.btnHavi.Text = "Havi";
            this.btnHavi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHavi.Textcolor = System.Drawing.Color.White;
            this.btnHavi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHavi.Click += new System.EventHandler(this.btnHavi_Click);
            // 
            // pbKijelent
            // 
            this.pbKijelent.Image = global::Piggy_bank_vizsga.Properties.Resources.Kijelentkezes;
            this.pbKijelent.ImageActive = null;
            this.pbKijelent.Location = new System.Drawing.Point(68, 475);
            this.pbKijelent.Name = "pbKijelent";
            this.pbKijelent.Size = new System.Drawing.Size(54, 47);
            this.pbKijelent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKijelent.TabIndex = 6;
            this.pbKijelent.TabStop = false;
            this.pbKijelent.Zoom = 10;
            this.pbKijelent.Click += new System.EventHandler(this.pbKijelent_Click);
            // 
            // btnAt
            // 
            this.btnAt.Active = false;
            this.btnAt.Activecolor = System.Drawing.Color.Teal;
            this.btnAt.BackColor = System.Drawing.Color.Black;
            this.btnAt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAt.BorderRadius = 4;
            this.btnAt.ButtonText = "Áttekintés";
            this.btnAt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAt.DisabledColor = System.Drawing.Color.Transparent;
            this.btnAt.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAt.Iconimage = global::Piggy_bank_vizsga.Properties.Resources.menu;
            this.btnAt.Iconimage_right = null;
            this.btnAt.Iconimage_right_Selected = null;
            this.btnAt.Iconimage_Selected = null;
            this.btnAt.IconMarginLeft = 0;
            this.btnAt.IconMarginRight = 0;
            this.btnAt.IconRightVisible = true;
            this.btnAt.IconRightZoom = 0D;
            this.btnAt.IconVisible = true;
            this.btnAt.IconZoom = 90D;
            this.btnAt.IsTab = false;
            this.btnAt.Location = new System.Drawing.Point(0, 229);
            this.btnAt.Name = "btnAt";
            this.btnAt.Normalcolor = System.Drawing.Color.Black;
            this.btnAt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.btnAt.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAt.selected = false;
            this.btnAt.Size = new System.Drawing.Size(194, 58);
            this.btnAt.TabIndex = 4;
            this.btnAt.Text = "Áttekintés";
            this.btnAt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAt.Textcolor = System.Drawing.Color.White;
            this.btnAt.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAt.Click += new System.EventHandler(this.btnAt_Click);
            // 
            // btnBe
            // 
            this.btnBe.Active = false;
            this.btnBe.Activecolor = System.Drawing.Color.Teal;
            this.btnBe.BackColor = System.Drawing.Color.Black;
            this.btnBe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBe.BorderRadius = 5;
            this.btnBe.ButtonText = "Bevétel";
            this.btnBe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBe.DisabledColor = System.Drawing.Color.Gray;
            this.btnBe.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBe.Iconimage = global::Piggy_bank_vizsga.Properties.Resources.Bevetel;
            this.btnBe.Iconimage_right = null;
            this.btnBe.Iconimage_right_Selected = null;
            this.btnBe.Iconimage_Selected = null;
            this.btnBe.IconMarginLeft = 0;
            this.btnBe.IconMarginRight = 0;
            this.btnBe.IconRightVisible = true;
            this.btnBe.IconRightZoom = 0D;
            this.btnBe.IconVisible = true;
            this.btnBe.IconZoom = 90D;
            this.btnBe.IsTab = false;
            this.btnBe.Location = new System.Drawing.Point(0, 110);
            this.btnBe.Name = "btnBe";
            this.btnBe.Normalcolor = System.Drawing.Color.Black;
            this.btnBe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.btnBe.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnBe.selected = false;
            this.btnBe.Size = new System.Drawing.Size(194, 58);
            this.btnBe.TabIndex = 2;
            this.btnBe.Text = "Bevétel";
            this.btnBe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBe.Textcolor = System.Drawing.Color.White;
            this.btnBe.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBe.Click += new System.EventHandler(this.btnBe_Click);
            // 
            // btnKi
            // 
            this.btnKi.Active = false;
            this.btnKi.Activecolor = System.Drawing.Color.Teal;
            this.btnKi.BackColor = System.Drawing.Color.Black;
            this.btnKi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKi.BorderRadius = 5;
            this.btnKi.ButtonText = "Kiadás";
            this.btnKi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKi.DisabledColor = System.Drawing.Color.Gray;
            this.btnKi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKi.Iconimage = global::Piggy_bank_vizsga.Properties.Resources.Kiadas;
            this.btnKi.Iconimage_right = null;
            this.btnKi.Iconimage_right_Selected = null;
            this.btnKi.Iconimage_Selected = null;
            this.btnKi.IconMarginLeft = 0;
            this.btnKi.IconMarginRight = 0;
            this.btnKi.IconRightVisible = true;
            this.btnKi.IconRightZoom = 0D;
            this.btnKi.IconVisible = true;
            this.btnKi.IconZoom = 90D;
            this.btnKi.IsTab = false;
            this.btnKi.Location = new System.Drawing.Point(0, 174);
            this.btnKi.Name = "btnKi";
            this.btnKi.Normalcolor = System.Drawing.Color.Black;
            this.btnKi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(209)))));
            this.btnKi.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKi.selected = false;
            this.btnKi.Size = new System.Drawing.Size(194, 58);
            this.btnKi.TabIndex = 3;
            this.btnKi.Text = "Kiadás";
            this.btnKi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKi.Textcolor = System.Drawing.Color.White;
            this.btnKi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKi.Click += new System.EventHandler(this.btnKi_Click);
            // 
            // btnKezdo
            // 
            this.btnKezdo.Active = false;
            this.btnKezdo.Activecolor = System.Drawing.Color.Teal;
            this.btnKezdo.BackColor = System.Drawing.Color.Black;
            this.btnKezdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKezdo.BorderRadius = 0;
            this.btnKezdo.ButtonText = "Kezdőlap";
            this.btnKezdo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKezdo.DisabledColor = System.Drawing.Color.Gray;
            this.btnKezdo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnKezdo.Iconimage = global::Piggy_bank_vizsga.Properties.Resources.Kezdolap;
            this.btnKezdo.Iconimage_right = null;
            this.btnKezdo.Iconimage_right_Selected = null;
            this.btnKezdo.Iconimage_Selected = null;
            this.btnKezdo.IconMarginLeft = 0;
            this.btnKezdo.IconMarginRight = 0;
            this.btnKezdo.IconRightVisible = true;
            this.btnKezdo.IconRightZoom = 0D;
            this.btnKezdo.IconVisible = true;
            this.btnKezdo.IconZoom = 90D;
            this.btnKezdo.IsTab = false;
            this.btnKezdo.Location = new System.Drawing.Point(0, 46);
            this.btnKezdo.Name = "btnKezdo";
            this.btnKezdo.Normalcolor = System.Drawing.Color.Black;
            this.btnKezdo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.btnKezdo.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnKezdo.selected = false;
            this.btnKezdo.Size = new System.Drawing.Size(194, 58);
            this.btnKezdo.TabIndex = 1;
            this.btnKezdo.Text = "Kezdőlap";
            this.btnKezdo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKezdo.Textcolor = System.Drawing.Color.White;
            this.btnKezdo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKezdo.Click += new System.EventHandler(this.btnKezdo_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlFelso;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 597);
            this.Controls.Add(this.pnlOldal);
            this.Controls.Add(this.pnlFelso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PBForm";
            this.Opacity = 0.95D;
            this.Text = "PBForm";
            this.pnlFelso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbKilep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLecsuk)).EndInit();
            this.pnlOldal.ResumeLayout(false);
            this.pnlGombok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbKijelent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlFelso;
        private System.Windows.Forms.Panel pnlOldal;
        private Bunifu.Framework.UI.BunifuFlatButton btnAt;
        private Bunifu.Framework.UI.BunifuFlatButton btnBe;
        private Bunifu.Framework.UI.BunifuFlatButton btnKi;
        private Bunifu.Framework.UI.BunifuFlatButton btnKezdo;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pbLecsuk;
        private System.Windows.Forms.PictureBox pbKilep;
        private Bunifu.Framework.UI.BunifuImageButton pbKijelent;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel pnlGombok;
        private Bunifu.Framework.UI.BunifuFlatButton btnEvi;
        private Bunifu.Framework.UI.BunifuFlatButton btnHavi;
        private System.Windows.Forms.Timer timer;
    }
}