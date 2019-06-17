namespace Piggy_bank_vizsga
{
    partial class KiadasUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KiadasUC));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKat = new System.Windows.Forms.Label();
            this.cbKiKat = new Bunifu.Framework.UI.BunifuDropdown();
            this.dgvKi = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Megjegyzes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Torles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Szerkesztes = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tbKiMegjegyz = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.tbKiOsszeg = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbKiKatKer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblKiKatKeres = new System.Windows.Forms.Label();
            this.tbKiMegjegyzKer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMentes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtpVegso = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dtpKezdo = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dtpKiDatum = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.btnKeres = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKi)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Összeg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Megjegyzés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Dátum";
            // 
            // lblKat
            // 
            this.lblKat.AutoSize = true;
            this.lblKat.BackColor = System.Drawing.Color.Transparent;
            this.lblKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKat.Location = new System.Drawing.Point(17, 31);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(69, 17);
            this.lblKat.TabIndex = 33;
            this.lblKat.Text = "Kategória";
            // 
            // cbKiKat
            // 
            this.cbKiKat.BackColor = System.Drawing.Color.Transparent;
            this.cbKiKat.BorderRadius = 3;
            this.cbKiKat.DisabledColor = System.Drawing.Color.Gray;
            this.cbKiKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbKiKat.ForeColor = System.Drawing.Color.White;
            this.cbKiKat.items = new string[] {
        "Albérlet",
        "Autó",
        "Állat",
        "Egészség",
        "Élelmiszer",
        "Gyermek ",
        "Háztartás",
        "Hitel",
        "Közlekedés",
        "Közművek",
        "Ruha",
        "Szórakozás",
        "Utazás",
        "Egyéb"};
            this.cbKiKat.Location = new System.Drawing.Point(32, 49);
            this.cbKiKat.Name = "cbKiKat";
            this.cbKiKat.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.cbKiKat.onHoverColor = System.Drawing.Color.Teal;
            this.cbKiKat.selectedIndex = -1;
            this.cbKiKat.Size = new System.Drawing.Size(220, 35);
            this.cbKiKat.TabIndex = 32;
            // 
            // dgvKi
            // 
            this.dgvKi.AllowCustomTheming = false;
            this.dgvKi.AllowUserToAddRows = false;
            this.dgvKi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvKi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKi.BackgroundColor = System.Drawing.Color.Black;
            this.dgvKi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKi.ColumnHeadersHeight = 40;
            this.dgvKi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Kategoria,
            this.Datum,
            this.Osszeg,
            this.Megjegyzes,
            this.Torles,
            this.Szerkesztes});
            this.dgvKi.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvKi.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvKi.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKi.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvKi.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvKi.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvKi.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvKi.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvKi.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvKi.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKi.CurrentTheme.Name = null;
            this.dgvKi.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvKi.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvKi.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKi.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvKi.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKi.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKi.EnableHeadersVisualStyles = false;
            this.dgvKi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvKi.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvKi.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvKi.HeaderForeColor = System.Drawing.Color.White;
            this.dgvKi.Location = new System.Drawing.Point(297, 101);
            this.dgvKi.Name = "dgvKi";
            this.dgvKi.ReadOnly = true;
            this.dgvKi.RowHeadersVisible = false;
            this.dgvKi.RowTemplate.Height = 40;
            this.dgvKi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKi.Size = new System.Drawing.Size(566, 405);
            this.dgvKi.TabIndex = 29;
            this.dgvKi.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.dgvKi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKi_CellContentClick);
            this.dgvKi.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvKi_CellPainting);
            // 
            // id
            // 
            this.id.FillWeight = 35.533F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Kategoria
            // 
            this.Kategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Kategoria.FillWeight = 33.72929F;
            this.Kategoria.HeaderText = "Kategória";
            this.Kategoria.MinimumWidth = 130;
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.ReadOnly = true;
            this.Kategoria.Width = 130;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Datum.FillWeight = 67.13236F;
            this.Datum.HeaderText = "Dátum";
            this.Datum.MinimumWidth = 120;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 120;
            // 
            // Osszeg
            // 
            this.Osszeg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Osszeg.FillWeight = 353.4436F;
            this.Osszeg.HeaderText = "Összeg";
            this.Osszeg.MinimumWidth = 120;
            this.Osszeg.Name = "Osszeg";
            this.Osszeg.ReadOnly = true;
            this.Osszeg.Width = 120;
            // 
            // Megjegyzes
            // 
            this.Megjegyzes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Megjegyzes.FillWeight = 177.0156F;
            this.Megjegyzes.HeaderText = "Megjegyzés";
            this.Megjegyzes.MinimumWidth = 120;
            this.Megjegyzes.Name = "Megjegyzes";
            this.Megjegyzes.ReadOnly = true;
            this.Megjegyzes.Width = 120;
            // 
            // Torles
            // 
            this.Torles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Torles.FillWeight = 16.5459F;
            this.Torles.HeaderText = "";
            this.Torles.MinimumWidth = 30;
            this.Torles.Name = "Torles";
            this.Torles.ReadOnly = true;
            this.Torles.Width = 30;
            // 
            // Szerkesztes
            // 
            this.Szerkesztes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Szerkesztes.FillWeight = 16.60022F;
            this.Szerkesztes.HeaderText = "";
            this.Szerkesztes.MinimumWidth = 30;
            this.Szerkesztes.Name = "Szerkesztes";
            this.Szerkesztes.ReadOnly = true;
            this.Szerkesztes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Szerkesztes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Szerkesztes.Width = 30;
            // 
            // tbKiMegjegyz
            // 
            this.tbKiMegjegyz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tbKiMegjegyz.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.tbKiMegjegyz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKiMegjegyz.ForeColor = System.Drawing.Color.White;
            this.tbKiMegjegyz.Location = new System.Drawing.Point(32, 352);
            this.tbKiMegjegyz.Multiline = true;
            this.tbKiMegjegyz.Name = "tbKiMegjegyz";
            this.tbKiMegjegyz.Size = new System.Drawing.Size(220, 116);
            this.tbKiMegjegyz.TabIndex = 28;
            // 
            // tbKiOsszeg
            // 
            this.tbKiOsszeg.BorderColorFocused = System.Drawing.Color.Teal;
            this.tbKiOsszeg.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.tbKiOsszeg.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.tbKiOsszeg.BorderThickness = 3;
            this.tbKiOsszeg.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbKiOsszeg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKiOsszeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbKiOsszeg.ForeColor = System.Drawing.Color.White;
            this.tbKiOsszeg.isPassword = false;
            this.tbKiOsszeg.Location = new System.Drawing.Point(29, 246);
            this.tbKiOsszeg.Margin = new System.Windows.Forms.Padding(4);
            this.tbKiOsszeg.MaxLength = 32767;
            this.tbKiOsszeg.Name = "tbKiOsszeg";
            this.tbKiOsszeg.Size = new System.Drawing.Size(220, 44);
            this.tbKiOsszeg.TabIndex = 27;
            this.tbKiOsszeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbKiKatKer
            // 
            this.tbKiKatKer.BorderColorFocused = System.Drawing.Color.Teal;
            this.tbKiKatKer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.tbKiKatKer.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.tbKiKatKer.BorderThickness = 3;
            this.tbKiKatKer.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbKiKatKer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKiKatKer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbKiKatKer.ForeColor = System.Drawing.Color.White;
            this.tbKiKatKer.isPassword = false;
            this.tbKiKatKer.Location = new System.Drawing.Point(884, 46);
            this.tbKiKatKer.Margin = new System.Windows.Forms.Padding(4);
            this.tbKiKatKer.MaxLength = 32767;
            this.tbKiKatKer.Name = "tbKiKatKer";
            this.tbKiKatKer.Size = new System.Drawing.Size(145, 33);
            this.tbKiKatKer.TabIndex = 40;
            this.tbKiKatKer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbKiKatKer.OnValueChanged += new System.EventHandler(this.tbKiKat_OnValueChanged);
            // 
            // lblKiKatKeres
            // 
            this.lblKiKatKeres.AutoSize = true;
            this.lblKiKatKeres.BackColor = System.Drawing.Color.Transparent;
            this.lblKiKatKeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKiKatKeres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKiKatKeres.Location = new System.Drawing.Point(869, 28);
            this.lblKiKatKeres.Name = "lblKiKatKeres";
            this.lblKiKatKeres.Size = new System.Drawing.Size(123, 17);
            this.lblKiKatKeres.TabIndex = 41;
            this.lblKiKatKeres.Text = "Kategória keresés";
            // 
            // tbKiMegjegyzKer
            // 
            this.tbKiMegjegyzKer.BorderColorFocused = System.Drawing.Color.Teal;
            this.tbKiMegjegyzKer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.tbKiMegjegyzKer.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.tbKiMegjegyzKer.BorderThickness = 3;
            this.tbKiMegjegyzKer.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbKiMegjegyzKer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbKiMegjegyzKer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbKiMegjegyzKer.ForeColor = System.Drawing.Color.White;
            this.tbKiMegjegyzKer.isPassword = false;
            this.tbKiMegjegyzKer.Location = new System.Drawing.Point(884, 101);
            this.tbKiMegjegyzKer.Margin = new System.Windows.Forms.Padding(4);
            this.tbKiMegjegyzKer.MaxLength = 32767;
            this.tbKiMegjegyzKer.Name = "tbKiMegjegyzKer";
            this.tbKiMegjegyzKer.Size = new System.Drawing.Size(145, 33);
            this.tbKiMegjegyzKer.TabIndex = 42;
            this.tbKiMegjegyzKer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbKiMegjegyzKer.OnValueChanged += new System.EventHandler(this.tbKiMegjegyzKer_OnValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(869, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Megjegyzés keresés";
            // 
            // btnMentes
            // 
            this.btnMentes.ActiveBorderThickness = 1;
            this.btnMentes.ActiveCornerRadius = 20;
            this.btnMentes.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnMentes.ActiveForecolor = System.Drawing.Color.Black;
            this.btnMentes.ActiveLineColor = System.Drawing.Color.Black;
            this.btnMentes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMentes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMentes.BackgroundImage")));
            this.btnMentes.ButtonText = "Hozzáad";
            this.btnMentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMentes.ForeColor = System.Drawing.Color.White;
            this.btnMentes.IdleBorderThickness = 1;
            this.btnMentes.IdleCornerRadius = 20;
            this.btnMentes.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.btnMentes.IdleForecolor = System.Drawing.Color.White;
            this.btnMentes.IdleLineColor = System.Drawing.Color.White;
            this.btnMentes.Location = new System.Drawing.Point(51, 486);
            this.btnMentes.Margin = new System.Windows.Forms.Padding(5);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(181, 41);
            this.btnMentes.TabIndex = 39;
            this.btnMentes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // dtpVegso
            // 
            this.dtpVegso.BorderRadius = 1;
            this.dtpVegso.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.dtpVegso.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dtpVegso.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpVegso.DisabledColor = System.Drawing.Color.Gray;
            this.dtpVegso.DisplayWeekNumbers = false;
            this.dtpVegso.DPHeight = 0;
            this.dtpVegso.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpVegso.FillDatePicker = false;
            this.dtpVegso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpVegso.ForeColor = System.Drawing.Color.Black;
            this.dtpVegso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVegso.Icon = ((System.Drawing.Image)(resources.GetObject("dtpVegso.Icon")));
            this.dtpVegso.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.dtpVegso.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpVegso.Location = new System.Drawing.Point(546, 47);
            this.dtpVegso.MinimumSize = new System.Drawing.Size(217, 32);
            this.dtpVegso.Name = "dtpVegso";
            this.dtpVegso.Size = new System.Drawing.Size(220, 32);
            this.dtpVegso.TabIndex = 38;
            // 
            // dtpKezdo
            // 
            this.dtpKezdo.BorderRadius = 1;
            this.dtpKezdo.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.dtpKezdo.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dtpKezdo.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpKezdo.DisabledColor = System.Drawing.Color.Gray;
            this.dtpKezdo.DisplayWeekNumbers = false;
            this.dtpKezdo.DPHeight = 0;
            this.dtpKezdo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpKezdo.FillDatePicker = false;
            this.dtpKezdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpKezdo.ForeColor = System.Drawing.Color.Black;
            this.dtpKezdo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKezdo.Icon = ((System.Drawing.Image)(resources.GetObject("dtpKezdo.Icon")));
            this.dtpKezdo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.dtpKezdo.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpKezdo.Location = new System.Drawing.Point(297, 49);
            this.dtpKezdo.MinimumSize = new System.Drawing.Size(226, 32);
            this.dtpKezdo.Name = "dtpKezdo";
            this.dtpKezdo.Size = new System.Drawing.Size(226, 32);
            this.dtpKezdo.TabIndex = 37;
            // 
            // dtpKiDatum
            // 
            this.dtpKiDatum.BorderRadius = 1;
            this.dtpKiDatum.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.dtpKiDatum.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dtpKiDatum.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpKiDatum.DisabledColor = System.Drawing.Color.Gray;
            this.dtpKiDatum.DisplayWeekNumbers = false;
            this.dtpKiDatum.DPHeight = 0;
            this.dtpKiDatum.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpKiDatum.FillDatePicker = false;
            this.dtpKiDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpKiDatum.ForeColor = System.Drawing.Color.Black;
            this.dtpKiDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKiDatum.Icon = ((System.Drawing.Image)(resources.GetObject("dtpKiDatum.Icon")));
            this.dtpKiDatum.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.dtpKiDatum.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpKiDatum.Location = new System.Drawing.Point(32, 147);
            this.dtpKiDatum.MinimumSize = new System.Drawing.Size(217, 32);
            this.dtpKiDatum.Name = "dtpKiDatum";
            this.dtpKiDatum.Size = new System.Drawing.Size(220, 32);
            this.dtpKiDatum.TabIndex = 31;
            // 
            // btnKeres
            // 
            this.btnKeres.ActiveBorderThickness = 1;
            this.btnKeres.ActiveCornerRadius = 20;
            this.btnKeres.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnKeres.ActiveForecolor = System.Drawing.Color.Black;
            this.btnKeres.ActiveLineColor = System.Drawing.Color.Black;
            this.btnKeres.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKeres.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKeres.BackgroundImage")));
            this.btnKeres.ButtonText = "Keresés";
            this.btnKeres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeres.ForeColor = System.Drawing.Color.White;
            this.btnKeres.IdleBorderThickness = 1;
            this.btnKeres.IdleCornerRadius = 20;
            this.btnKeres.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.btnKeres.IdleForecolor = System.Drawing.Color.White;
            this.btnKeres.IdleLineColor = System.Drawing.Color.White;
            this.btnKeres.Location = new System.Drawing.Point(776, 43);
            this.btnKeres.Margin = new System.Windows.Forms.Padding(5);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(72, 41);
            this.btnKeres.TabIndex = 30;
            this.btnKeres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click_1);
            // 
            // KiadasUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKiMegjegyzKer);
            this.Controls.Add(this.lblKiKatKeres);
            this.Controls.Add(this.tbKiKatKer);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.dtpVegso);
            this.Controls.Add(this.dtpKezdo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKat);
            this.Controls.Add(this.cbKiKat);
            this.Controls.Add(this.dtpKiDatum);
            this.Controls.Add(this.btnKeres);
            this.Controls.Add(this.dgvKi);
            this.Controls.Add(this.tbKiMegjegyz);
            this.Controls.Add(this.tbKiOsszeg);
            this.Location = new System.Drawing.Point(29, 285);
            this.Name = "KiadasUC";
            this.Size = new System.Drawing.Size(1063, 596);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDatePicker dtpVegso;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpKezdo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKat;
        private Bunifu.Framework.UI.BunifuDropdown cbKiKat;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpKiDatum;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKeres;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvKi;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbKiMegjegyz;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbKiOsszeg;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMentes;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbKiKatKer;
        private System.Windows.Forms.Label lblKiKatKeres;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Megjegyzes;
        private System.Windows.Forms.DataGridViewButtonColumn Torles;
        private System.Windows.Forms.DataGridViewButtonColumn Szerkesztes;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbKiMegjegyzKer;
        private System.Windows.Forms.Label label4;
    }
}
