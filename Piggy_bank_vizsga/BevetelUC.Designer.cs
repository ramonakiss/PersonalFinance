namespace Piggy_bank_vizsga
{
    partial class BevetelUC
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BevetelUC));
            this.tbBeOsszeg = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbBeMegjegyz = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dgvBevetel = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osszeg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Megjegyzes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Torles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Szerkesztes = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbBeKat = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblKat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBeKatKeres = new System.Windows.Forms.Label();
            this.dtpVegso = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dtpKezdo = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dtpBeDatum = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.btnKeres = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMentes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tbBeKatKeres = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tbBeMegjegyzKer = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblBeMegjegyzKer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBevetel)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBeOsszeg
            // 
            this.tbBeOsszeg.BorderColorFocused = System.Drawing.Color.Teal;
            this.tbBeOsszeg.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.tbBeOsszeg.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.tbBeOsszeg.BorderThickness = 3;
            this.tbBeOsszeg.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbBeOsszeg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBeOsszeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbBeOsszeg.ForeColor = System.Drawing.Color.White;
            this.tbBeOsszeg.isPassword = false;
            this.tbBeOsszeg.Location = new System.Drawing.Point(32, 246);
            this.tbBeOsszeg.Margin = new System.Windows.Forms.Padding(4);
            this.tbBeOsszeg.MaxLength = 32767;
            this.tbBeOsszeg.Name = "tbBeOsszeg";
            this.tbBeOsszeg.Size = new System.Drawing.Size(220, 44);
            this.tbBeOsszeg.TabIndex = 1;
            this.tbBeOsszeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbBeMegjegyz
            // 
            this.tbBeMegjegyz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tbBeMegjegyz.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.tbBeMegjegyz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbBeMegjegyz.ForeColor = System.Drawing.Color.White;
            this.tbBeMegjegyz.Location = new System.Drawing.Point(32, 352);
            this.tbBeMegjegyz.Multiline = true;
            this.tbBeMegjegyz.Name = "tbBeMegjegyz";
            this.tbBeMegjegyz.Size = new System.Drawing.Size(220, 116);
            this.tbBeMegjegyz.TabIndex = 4;
            // 
            // dgvBevetel
            // 
            this.dgvBevetel.AllowCustomTheming = false;
            this.dgvBevetel.AllowUserToAddRows = false;
            this.dgvBevetel.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvBevetel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBevetel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBevetel.BackgroundColor = System.Drawing.Color.Black;
            this.dgvBevetel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBevetel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBevetel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBevetel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBevetel.ColumnHeadersHeight = 40;
            this.dgvBevetel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Kategoria,
            this.Datum,
            this.Osszeg,
            this.Megjegyzes,
            this.Torles,
            this.Szerkesztes});
            this.dgvBevetel.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvBevetel.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvBevetel.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBevetel.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvBevetel.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBevetel.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvBevetel.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvBevetel.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvBevetel.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvBevetel.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBevetel.CurrentTheme.Name = null;
            this.dgvBevetel.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvBevetel.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvBevetel.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBevetel.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvBevetel.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBevetel.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBevetel.EnableHeadersVisualStyles = false;
            this.dgvBevetel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvBevetel.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvBevetel.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvBevetel.HeaderForeColor = System.Drawing.Color.White;
            this.dgvBevetel.Location = new System.Drawing.Point(298, 99);
            this.dgvBevetel.Name = "dgvBevetel";
            this.dgvBevetel.ReadOnly = true;
            this.dgvBevetel.RowHeadersVisible = false;
            this.dgvBevetel.RowTemplate.Height = 40;
            this.dgvBevetel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBevetel.Size = new System.Drawing.Size(566, 405);
            this.dgvBevetel.TabIndex = 6;
            this.dgvBevetel.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.dgvBevetel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBevetel_CellContentClick);
            this.dgvBevetel.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvBevetel_CellPainting);
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
            // cbBeKat
            // 
            this.cbBeKat.BackColor = System.Drawing.Color.Transparent;
            this.cbBeKat.BorderRadius = 3;
            this.cbBeKat.DisabledColor = System.Drawing.Color.Gray;
            this.cbBeKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbBeKat.ForeColor = System.Drawing.Color.White;
            this.cbBeKat.items = new string[] {
        "Fizetés",
        "Nyugdíj",
        "Ösztöndíj",
        "Támogatás",
        "Nyeremény",
        "Egyéb bevétel"};
            this.cbBeKat.Location = new System.Drawing.Point(32, 49);
            this.cbBeKat.Name = "cbBeKat";
            this.cbBeKat.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.cbBeKat.onHoverColor = System.Drawing.Color.Teal;
            this.cbBeKat.selectedIndex = -1;
            this.cbBeKat.Size = new System.Drawing.Size(217, 35);
            this.cbBeKat.TabIndex = 20;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // lblKat
            // 
            this.lblKat.AutoSize = true;
            this.lblKat.BackColor = System.Drawing.Color.Transparent;
            this.lblKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKat.Location = new System.Drawing.Point(18, 31);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(69, 17);
            this.lblKat.TabIndex = 21;
            this.lblKat.Text = "Kategória";
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
            this.label1.TabIndex = 22;
            this.label1.Text = "Dátum";
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
            this.label2.TabIndex = 23;
            this.label2.Text = "Megjegyzés";
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
            this.label3.TabIndex = 24;
            this.label3.Text = "Összeg";
            // 
            // lblBeKatKeres
            // 
            this.lblBeKatKeres.AutoSize = true;
            this.lblBeKatKeres.BackColor = System.Drawing.Color.Transparent;
            this.lblBeKatKeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBeKatKeres.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBeKatKeres.Location = new System.Drawing.Point(869, 28);
            this.lblBeKatKeres.Name = "lblBeKatKeres";
            this.lblBeKatKeres.Size = new System.Drawing.Size(123, 17);
            this.lblBeKatKeres.TabIndex = 28;
            this.lblBeKatKeres.Text = "Kategória keresés";
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
            this.dtpVegso.Location = new System.Drawing.Point(548, 49);
            this.dtpVegso.MinimumSize = new System.Drawing.Size(217, 32);
            this.dtpVegso.Name = "dtpVegso";
            this.dtpVegso.Size = new System.Drawing.Size(220, 32);
            this.dtpVegso.TabIndex = 26;
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
            this.dtpKezdo.Location = new System.Drawing.Point(298, 49);
            this.dtpKezdo.MinimumSize = new System.Drawing.Size(226, 32);
            this.dtpKezdo.Name = "dtpKezdo";
            this.dtpKezdo.Size = new System.Drawing.Size(226, 32);
            this.dtpKezdo.TabIndex = 25;
            // 
            // dtpBeDatum
            // 
            this.dtpBeDatum.BorderRadius = 1;
            this.dtpBeDatum.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.dtpBeDatum.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dtpBeDatum.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtpBeDatum.DisabledColor = System.Drawing.Color.Gray;
            this.dtpBeDatum.DisplayWeekNumbers = false;
            this.dtpBeDatum.DPHeight = 0;
            this.dtpBeDatum.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpBeDatum.FillDatePicker = false;
            this.dtpBeDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpBeDatum.ForeColor = System.Drawing.Color.Black;
            this.dtpBeDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBeDatum.Icon = ((System.Drawing.Image)(resources.GetObject("dtpBeDatum.Icon")));
            this.dtpBeDatum.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.dtpBeDatum.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtpBeDatum.Location = new System.Drawing.Point(32, 147);
            this.dtpBeDatum.MinimumSize = new System.Drawing.Size(217, 32);
            this.dtpBeDatum.Name = "dtpBeDatum";
            this.dtpBeDatum.Size = new System.Drawing.Size(220, 32);
            this.dtpBeDatum.TabIndex = 19;
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
            this.btnKeres.TabIndex = 15;
            this.btnKeres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);
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
            this.btnMentes.Location = new System.Drawing.Point(49, 487);
            this.btnMentes.Margin = new System.Windows.Forms.Padding(5);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(181, 41);
            this.btnMentes.TabIndex = 5;
            this.btnMentes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // tbBeKatKeres
            // 
            this.tbBeKatKeres.BorderColorFocused = System.Drawing.Color.Teal;
            this.tbBeKatKeres.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.tbBeKatKeres.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.tbBeKatKeres.BorderThickness = 3;
            this.tbBeKatKeres.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbBeKatKeres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBeKatKeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbBeKatKeres.ForeColor = System.Drawing.Color.White;
            this.tbBeKatKeres.isPassword = false;
            this.tbBeKatKeres.Location = new System.Drawing.Point(884, 46);
            this.tbBeKatKeres.Margin = new System.Windows.Forms.Padding(4);
            this.tbBeKatKeres.MaxLength = 32767;
            this.tbBeKatKeres.Name = "tbBeKatKeres";
            this.tbBeKatKeres.Size = new System.Drawing.Size(145, 33);
            this.tbBeKatKeres.TabIndex = 41;
            this.tbBeKatKeres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbBeKatKeres.OnValueChanged += new System.EventHandler(this.tbBeKatKeres_OnValueChanged);
            // 
            // tbBeMegjegyzKer
            // 
            this.tbBeMegjegyzKer.BorderColorFocused = System.Drawing.Color.Teal;
            this.tbBeMegjegyzKer.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(222)))), ((int)(((byte)(207)))));
            this.tbBeMegjegyzKer.BorderColorMouseHover = System.Drawing.Color.Teal;
            this.tbBeMegjegyzKer.BorderThickness = 3;
            this.tbBeMegjegyzKer.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbBeMegjegyzKer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBeMegjegyzKer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbBeMegjegyzKer.ForeColor = System.Drawing.Color.White;
            this.tbBeMegjegyzKer.isPassword = false;
            this.tbBeMegjegyzKer.Location = new System.Drawing.Point(884, 104);
            this.tbBeMegjegyzKer.Margin = new System.Windows.Forms.Padding(4);
            this.tbBeMegjegyzKer.MaxLength = 32767;
            this.tbBeMegjegyzKer.Name = "tbBeMegjegyzKer";
            this.tbBeMegjegyzKer.Size = new System.Drawing.Size(145, 33);
            this.tbBeMegjegyzKer.TabIndex = 42;
            this.tbBeMegjegyzKer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbBeMegjegyzKer.OnValueChanged += new System.EventHandler(this.tbBeMegjegyzKer_OnValueChanged);
            // 
            // lblBeMegjegyzKer
            // 
            this.lblBeMegjegyzKer.AutoSize = true;
            this.lblBeMegjegyzKer.BackColor = System.Drawing.Color.Transparent;
            this.lblBeMegjegyzKer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBeMegjegyzKer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBeMegjegyzKer.Location = new System.Drawing.Point(869, 83);
            this.lblBeMegjegyzKer.Name = "lblBeMegjegyzKer";
            this.lblBeMegjegyzKer.Size = new System.Drawing.Size(137, 17);
            this.lblBeMegjegyzKer.TabIndex = 43;
            this.lblBeMegjegyzKer.Text = "Megjegyzés keresés";
            // 
            // BevetelUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.lblBeMegjegyzKer);
            this.Controls.Add(this.tbBeMegjegyzKer);
            this.Controls.Add(this.tbBeKatKeres);
            this.Controls.Add(this.lblBeKatKeres);
            this.Controls.Add(this.dtpVegso);
            this.Controls.Add(this.dtpKezdo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKat);
            this.Controls.Add(this.cbBeKat);
            this.Controls.Add(this.dtpBeDatum);
            this.Controls.Add(this.btnKeres);
            this.Controls.Add(this.dgvBevetel);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.tbBeMegjegyz);
            this.Controls.Add(this.tbBeOsszeg);
            this.Name = "BevetelUC";
            this.Size = new System.Drawing.Size(1063, 596);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBevetel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMetroTextbox tbBeOsszeg;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox tbBeMegjegyz;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMentes;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvBevetel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKeres;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpBeDatum;
        private Bunifu.Framework.UI.BunifuDropdown cbBeKat;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label lblKat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpKezdo;
        private Bunifu.UI.WinForms.BunifuDatePicker dtpVegso;
        private System.Windows.Forms.Label lblBeKatKeres;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbBeKatKeres;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osszeg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Megjegyzes;
        private System.Windows.Forms.DataGridViewButtonColumn Torles;
        private System.Windows.Forms.DataGridViewButtonColumn Szerkesztes;
        private Bunifu.Framework.UI.BunifuMetroTextbox tbBeMegjegyzKer;
        private System.Windows.Forms.Label lblBeMegjegyzKer;
    }
}
