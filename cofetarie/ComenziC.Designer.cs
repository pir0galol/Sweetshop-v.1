namespace cofetarie
{
    partial class ComenziC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cboMetodaLivrare = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cboAlegeClient = new MetroFramework.Controls.MetroComboBox();
            this.cboAlegeAngajat = new MetroFramework.Controls.MetroComboBox();
            this.chkLivrata = new MetroFramework.Controls.MetroCheckBox();
            this.txtNrComanda = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.dtDataComanda = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.dtDataLimita = new MetroFramework.Controls.MetroDateTime();
            this.dtDataLivrare = new MetroFramework.Controls.MetroDateTime();
            this.grpDetaliiComanda = new System.Windows.Forms.GroupBox();
            this.gridComanda = new MetroFramework.Controls.MetroGrid();
            this.colNumeProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPretUnitar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TotalComanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRenunta = new MetroFramework.Controls.MetroButton();
            this.btnSaveComanda = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridProduseStoc = new MetroFramework.Controls.MetroGrid();
            this.colDenumire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeStoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPretPerKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.btnTotal = new MetroFramework.Controls.MetroButton();
            this.btnSpreFacturi = new MetroFramework.Controls.MetroButton();
            this.groupBox4.SuspendLayout();
            this.grpDetaliiComanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridComanda)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduseStoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cboMetodaLivrare);
            this.groupBox4.Controls.Add(this.metroLabel1);
            this.groupBox4.Controls.Add(this.cboAlegeClient);
            this.groupBox4.Controls.Add(this.cboAlegeAngajat);
            this.groupBox4.Controls.Add(this.chkLivrata);
            this.groupBox4.Controls.Add(this.txtNrComanda);
            this.groupBox4.Controls.Add(this.metroLabel14);
            this.groupBox4.Controls.Add(this.metroLabel12);
            this.groupBox4.Controls.Add(this.metroLabel13);
            this.groupBox4.Controls.Add(this.dtDataComanda);
            this.groupBox4.Controls.Add(this.metroLabel11);
            this.groupBox4.Controls.Add(this.dtDataLimita);
            this.groupBox4.Controls.Add(this.dtDataLivrare);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.groupBox4.Location = new System.Drawing.Point(23, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 398);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Date comanda";
            // 
            // cboMetodaLivrare
            // 
            this.cboMetodaLivrare.FormattingEnabled = true;
            this.cboMetodaLivrare.ItemHeight = 23;
            this.cboMetodaLivrare.Location = new System.Drawing.Point(10, 185);
            this.cboMetodaLivrare.Name = "cboMetodaLivrare";
            this.cboMetodaLivrare.PromptText = "Metoda livrare";
            this.cboMetodaLivrare.Size = new System.Drawing.Size(174, 29);
            this.cboMetodaLivrare.TabIndex = 63;
            this.cboMetodaLivrare.UseSelectable = true;
            this.cboMetodaLivrare.DropDown += new System.EventHandler(this.cboMetodaLivrare_DropDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 126);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 62;
            this.metroLabel1.Text = "Pentru clientul:";
            // 
            // cboAlegeClient
            // 
            this.cboAlegeClient.FormattingEnabled = true;
            this.cboAlegeClient.ItemHeight = 23;
            this.cboAlegeClient.Location = new System.Drawing.Point(10, 148);
            this.cboAlegeClient.Name = "cboAlegeClient";
            this.cboAlegeClient.PromptText = "Alege client";
            this.cboAlegeClient.Size = new System.Drawing.Size(174, 29);
            this.cboAlegeClient.TabIndex = 42;
            this.cboAlegeClient.UseSelectable = true;
            this.cboAlegeClient.DropDown += new System.EventHandler(this.cboAlegeClient_DropDown);
            // 
            // cboAlegeAngajat
            // 
            this.cboAlegeAngajat.BackColor = System.Drawing.SystemColors.Window;
            this.cboAlegeAngajat.FormattingEnabled = true;
            this.cboAlegeAngajat.ItemHeight = 23;
            this.cboAlegeAngajat.Location = new System.Drawing.Point(10, 88);
            this.cboAlegeAngajat.Name = "cboAlegeAngajat";
            this.cboAlegeAngajat.PromptText = "Alege angajat";
            this.cboAlegeAngajat.Size = new System.Drawing.Size(174, 29);
            this.cboAlegeAngajat.TabIndex = 60;
            this.cboAlegeAngajat.UseSelectable = true;
            this.cboAlegeAngajat.DropDown += new System.EventHandler(this.cboAlegeAngajat_DropDown);
            // 
            // chkLivrata
            // 
            this.chkLivrata.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkLivrata.AutoSize = true;
            this.chkLivrata.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkLivrata.ForeColor = System.Drawing.Color.Black;
            this.chkLivrata.Location = new System.Drawing.Point(95, 334);
            this.chkLivrata.Name = "chkLivrata";
            this.chkLivrata.Size = new System.Drawing.Size(61, 15);
            this.chkLivrata.TabIndex = 61;
            this.chkLivrata.Text = "Livrata";
            this.chkLivrata.UseCustomBackColor = true;
            this.chkLivrata.UseCustomForeColor = true;
            this.chkLivrata.UseSelectable = true;
            this.chkLivrata.UseStyleColors = true;
            this.chkLivrata.CheckedChanged += new System.EventHandler(this.chkLivrata_CheckedChanged);
            // 
            // txtNrComanda
            // 
            this.txtNrComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.txtNrComanda.CustomButton.Image = null;
            this.txtNrComanda.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtNrComanda.CustomButton.Name = "";
            this.txtNrComanda.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNrComanda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNrComanda.CustomButton.TabIndex = 1;
            this.txtNrComanda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNrComanda.CustomButton.UseSelectable = true;
            this.txtNrComanda.CustomButton.Visible = false;
            this.txtNrComanda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNrComanda.Lines = new string[0];
            this.txtNrComanda.Location = new System.Drawing.Point(10, 28);
            this.txtNrComanda.MaxLength = 32767;
            this.txtNrComanda.Name = "txtNrComanda";
            this.txtNrComanda.PasswordChar = '\0';
            this.txtNrComanda.WaterMark = "Nr. comanda";
            this.txtNrComanda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNrComanda.SelectedText = "";
            this.txtNrComanda.SelectionLength = 0;
            this.txtNrComanda.SelectionStart = 0;
            this.txtNrComanda.ShortcutsEnabled = true;
            this.txtNrComanda.Size = new System.Drawing.Size(104, 23);
            this.txtNrComanda.TabIndex = 58;
            this.txtNrComanda.UseCustomBackColor = true;
            this.txtNrComanda.UseCustomForeColor = true;
            this.txtNrComanda.UseSelectable = true;
            this.txtNrComanda.WaterMark = "Nr. comanda";
            this.txtNrComanda.WaterMarkColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNrComanda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNrComanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNrComanda_KeyPress);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(10, 66);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(153, 19);
            this.metroLabel14.TabIndex = 59;
            this.metroLabel14.Text = "Inregistrata de angajatul:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(10, 273);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(75, 19);
            this.metroLabel12.TabIndex = 57;
            this.metroLabel12.Text = "Data limita:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(10, 333);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(79, 19);
            this.metroLabel13.TabIndex = 58;
            this.metroLabel13.Text = "Data livrare:";
            // 
            // dtDataComanda
            // 
            this.dtDataComanda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataComanda.Location = new System.Drawing.Point(10, 239);
            this.dtDataComanda.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataComanda.Name = "dtDataComanda";
            this.dtDataComanda.Size = new System.Drawing.Size(121, 29);
            this.dtDataComanda.TabIndex = 0;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(10, 217);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(98, 19);
            this.metroLabel11.TabIndex = 56;
            this.metroLabel11.Text = "Data comanda:";
            // 
            // dtDataLimita
            // 
            this.dtDataLimita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataLimita.Location = new System.Drawing.Point(10, 295);
            this.dtDataLimita.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataLimita.Name = "dtDataLimita";
            this.dtDataLimita.Size = new System.Drawing.Size(121, 29);
            this.dtDataLimita.TabIndex = 1;
            // 
            // dtDataLivrare
            // 
            this.dtDataLivrare.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataLivrare.Location = new System.Drawing.Point(10, 355);
            this.dtDataLivrare.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataLivrare.Name = "dtDataLivrare";
            this.dtDataLivrare.Size = new System.Drawing.Size(121, 29);
            this.dtDataLivrare.TabIndex = 2;
            // 
            // grpDetaliiComanda
            // 
            this.grpDetaliiComanda.Controls.Add(this.gridComanda);
            this.grpDetaliiComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grpDetaliiComanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.grpDetaliiComanda.Location = new System.Drawing.Point(544, 90);
            this.grpDetaliiComanda.Name = "grpDetaliiComanda";
            this.grpDetaliiComanda.Size = new System.Drawing.Size(559, 304);
            this.grpDetaliiComanda.TabIndex = 62;
            this.grpDetaliiComanda.TabStop = false;
            this.grpDetaliiComanda.Text = "Detalii comanda";
            // 
            // gridComanda
            // 
            this.gridComanda.AllowUserToResizeColumns = false;
            this.gridComanda.AllowUserToResizeRows = false;
            this.gridComanda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridComanda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridComanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridComanda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridComanda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridComanda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumeProdus,
            this.colCantitate,
            this.colPretUnitar,
            this.colTVA,
            this.colTotalProdus,
            this.col_TotalComanda});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridComanda.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridComanda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridComanda.EnableHeadersVisualStyles = false;
            this.gridComanda.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridComanda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridComanda.Location = new System.Drawing.Point(3, 17);
            this.gridComanda.MultiSelect = false;
            this.gridComanda.Name = "gridComanda";
            this.gridComanda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridComanda.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridComanda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridComanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridComanda.Size = new System.Drawing.Size(553, 284);
            this.gridComanda.TabIndex = 61;
            this.gridComanda.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridComanda_CellContentDoubleClick);
            this.gridComanda.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridComanda_EditingControlShowing);
            // 
            // colNumeProdus
            // 
            this.colNumeProdus.HeaderText = "Denumire produs";
            this.colNumeProdus.Name = "colNumeProdus";
            this.colNumeProdus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNumeProdus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNumeProdus.Width = 91;
            // 
            // colCantitate
            // 
            this.colCantitate.HeaderText = "Cantitate";
            this.colCantitate.Name = "colCantitate";
            this.colCantitate.Width = 77;
            // 
            // colPretUnitar
            // 
            this.colPretUnitar.HeaderText = "Pret/kg (RON)";
            this.colPretUnitar.Name = "colPretUnitar";
            this.colPretUnitar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPretUnitar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPretUnitar.Width = 73;
            // 
            // colTVA
            // 
            this.colTVA.HeaderText = "T.V.A (%)";
            this.colTVA.Name = "colTVA";
            this.colTVA.Width = 67;
            // 
            // colTotalProdus
            // 
            this.colTotalProdus.HeaderText = "Total produs (RON)";
            this.colTotalProdus.Name = "colTotalProdus";
            this.colTotalProdus.Width = 116;
            // 
            // col_TotalComanda
            // 
            this.col_TotalComanda.HeaderText = "TOTAL (RON)";
            this.col_TotalComanda.Name = "col_TotalComanda";
            this.col_TotalComanda.ReadOnly = true;
            this.col_TotalComanda.Width = 85;
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnRenunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRenunta.Location = new System.Drawing.Point(976, 400);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(127, 42);
            this.btnRenunta.TabIndex = 66;
            this.btnRenunta.Text = "Inchide";
            this.btnRenunta.UseCustomBackColor = true;
            this.btnRenunta.UseCustomForeColor = true;
            this.btnRenunta.UseSelectable = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnSaveComanda
            // 
            this.btnSaveComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnSaveComanda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveComanda.Location = new System.Drawing.Point(843, 400);
            this.btnSaveComanda.Name = "btnSaveComanda";
            this.btnSaveComanda.Size = new System.Drawing.Size(127, 42);
            this.btnSaveComanda.TabIndex = 65;
            this.btnSaveComanda.Text = "Inregistreaza comanda";
            this.btnSaveComanda.UseCustomBackColor = true;
            this.btnSaveComanda.UseCustomForeColor = true;
            this.btnSaveComanda.UseSelectable = true;
            this.btnSaveComanda.Click += new System.EventHandler(this.btnSaveComanda_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridProduseStoc);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.groupBox1.Location = new System.Drawing.Point(239, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 304);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produse stoc";
            // 
            // gridProduseStoc
            // 
            this.gridProduseStoc.AllowUserToResizeColumns = false;
            this.gridProduseStoc.AllowUserToResizeRows = false;
            this.gridProduseStoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridProduseStoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProduseStoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProduseStoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridProduseStoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProduseStoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gridProduseStoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduseStoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDenumire,
            this.colPeStoc,
            this.colPretPerKg});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProduseStoc.DefaultCellStyle = dataGridViewCellStyle11;
            this.gridProduseStoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProduseStoc.EnableHeadersVisualStyles = false;
            this.gridProduseStoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridProduseStoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProduseStoc.Location = new System.Drawing.Point(3, 17);
            this.gridProduseStoc.MultiSelect = false;
            this.gridProduseStoc.Name = "gridProduseStoc";
            this.gridProduseStoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProduseStoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gridProduseStoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProduseStoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduseStoc.Size = new System.Drawing.Size(293, 284);
            this.gridProduseStoc.TabIndex = 61;
            this.gridProduseStoc.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProduseStoc_CellContentDoubleClick);
            // 
            // colDenumire
            // 
            this.colDenumire.HeaderText = "Denumire produs";
            this.colDenumire.Name = "colDenumire";
            this.colDenumire.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDenumire.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDenumire.Width = 91;
            // 
            // colPeStoc
            // 
            this.colPeStoc.HeaderText = "Kg/stoc";
            this.colPeStoc.Name = "colPeStoc";
            this.colPeStoc.Width = 68;
            // 
            // colPretPerKg
            // 
            this.colPretPerKg.HeaderText = "Pret/kg (RON)";
            this.colPretPerKg.Name = "colPretPerKg";
            this.colPretPerKg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPretPerKg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPretPerKg.Width = 73;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroButton1.Location = new System.Drawing.Point(782, 66);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(92, 23);
            this.metroButton1.TabIndex = 60;
            this.metroButton1.Text = "Generare total";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(428, 398);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 42);
            this.btnRefresh.TabIndex = 68;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseCustomBackColor = true;
            this.btnRefresh.UseCustomForeColor = true;
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTotal.Location = new System.Drawing.Point(1011, 63);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(92, 23);
            this.btnTotal.TabIndex = 69;
            this.btnTotal.Text = "Generare total";
            this.btnTotal.UseCustomBackColor = true;
            this.btnTotal.UseCustomForeColor = true;
            this.btnTotal.UseSelectable = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnSpreFacturi
            // 
            this.btnSpreFacturi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(124)))));
            this.btnSpreFacturi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpreFacturi.Location = new System.Drawing.Point(710, 400);
            this.btnSpreFacturi.Name = "btnSpreFacturi";
            this.btnSpreFacturi.Size = new System.Drawing.Size(127, 42);
            this.btnSpreFacturi.TabIndex = 80;
            this.btnSpreFacturi.Text = "Spre facturi";
            this.btnSpreFacturi.UseCustomBackColor = true;
            this.btnSpreFacturi.UseCustomForeColor = true;
            this.btnSpreFacturi.UseSelectable = true;
            this.btnSpreFacturi.Click += new System.EventHandler(this.btnSpreFacturi_Click);
            // 
            // ComenziC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 533);
            this.Controls.Add(this.btnSpreFacturi);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnSaveComanda);
            this.Controls.Add(this.grpDetaliiComanda);
            this.Controls.Add(this.groupBox4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComenziC";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Comenzi Clienti";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpDetaliiComanda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridComanda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduseStoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox chkLivrata;
        private MetroFramework.Controls.MetroComboBox cboAlegeClient;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroComboBox cboAlegeAngajat;
        private MetroFramework.Controls.MetroTextBox txtNrComanda;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroDateTime dtDataLivrare;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroDateTime dtDataComanda;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroDateTime dtDataLimita;
        private System.Windows.Forms.GroupBox grpDetaliiComanda;
        private MetroFramework.Controls.MetroButton btnRenunta;
        private MetroFramework.Controls.MetroButton btnSaveComanda;
        private MetroFramework.Controls.MetroGrid gridComanda;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroGrid gridProduseStoc;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cboMetodaLivrare;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDenumire;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeStoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPretPerKg;
        private MetroFramework.Controls.MetroButton btnTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPretUnitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TotalComanda;
        private MetroFramework.Controls.MetroButton btnSpreFacturi;
    }
}