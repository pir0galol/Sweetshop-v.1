namespace cofetarie
{
    partial class ComenziF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chkLivrata = new MetroFramework.Controls.MetroCheckBox();
            this.cboAlegeFurnizor = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.cboAlegeAngajat = new MetroFramework.Controls.MetroComboBox();
            this.txtNrComanda = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.dtDataLivrare = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.dtDataComanda = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.dtDataLimita = new MetroFramework.Controls.MetroDateTime();
            this.grpDetaliiComanda = new System.Windows.Forms.GroupBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnTotal = new MetroFramework.Controls.MetroButton();
            this.cboAlegeProdus = new System.Windows.Forms.ComboBox();
            this.grpProduseComandate = new System.Windows.Forms.GroupBox();
            this.gridProduse = new MetroFramework.Controls.MetroGrid();
            this.colNumeProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPretUnitar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitateMasura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TotalComanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRenunta = new MetroFramework.Controls.MetroButton();
            this.btnSaveComanda = new MetroFramework.Controls.MetroButton();
            this.btnSpreFacturi = new MetroFramework.Controls.MetroButton();
            this.groupBox4.SuspendLayout();
            this.grpDetaliiComanda.SuspendLayout();
            this.grpProduseComandate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProduse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metroLabel1);
            this.groupBox4.Controls.Add(this.chkLivrata);
            this.groupBox4.Controls.Add(this.cboAlegeFurnizor);
            this.groupBox4.Controls.Add(this.metroLabel13);
            this.groupBox4.Controls.Add(this.cboAlegeAngajat);
            this.groupBox4.Controls.Add(this.txtNrComanda);
            this.groupBox4.Controls.Add(this.metroLabel14);
            this.groupBox4.Controls.Add(this.dtDataLivrare);
            this.groupBox4.Controls.Add(this.metroLabel12);
            this.groupBox4.Controls.Add(this.dtDataComanda);
            this.groupBox4.Controls.Add(this.metroLabel11);
            this.groupBox4.Controls.Add(this.dtDataLimita);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.groupBox4.Location = new System.Drawing.Point(23, 85);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 333);
            this.groupBox4.TabIndex = 41;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Date comanda";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 130);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 62;
            this.metroLabel1.Text = "Pentru furnizorul:";
            // 
            // chkLivrata
            // 
            this.chkLivrata.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkLivrata.AutoSize = true;
            this.chkLivrata.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.chkLivrata.ForeColor = System.Drawing.Color.Black;
            this.chkLivrata.Location = new System.Drawing.Point(217, 263);
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
            // cboAlegeFurnizor
            // 
            this.cboAlegeFurnizor.FormattingEnabled = true;
            this.cboAlegeFurnizor.ItemHeight = 23;
            this.cboAlegeFurnizor.Location = new System.Drawing.Point(10, 152);
            this.cboAlegeFurnizor.Name = "cboAlegeFurnizor";
            this.cboAlegeFurnizor.PromptText = "Alege furnizor";
            this.cboAlegeFurnizor.Size = new System.Drawing.Size(174, 29);
            this.cboAlegeFurnizor.TabIndex = 42;
            this.cboAlegeFurnizor.UseSelectable = true;
            this.cboAlegeFurnizor.DropDown += new System.EventHandler(this.cboAlegeFurnizor_DropDown);
            this.cboAlegeFurnizor.SelectedIndexChanged += new System.EventHandler(this.cboAlegeFurnizor_SelectedIndexChanged);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(157, 206);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(79, 19);
            this.metroLabel13.TabIndex = 58;
            this.metroLabel13.Text = "Data livrare:";
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
            // dtDataLivrare
            // 
            this.dtDataLivrare.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataLivrare.Location = new System.Drawing.Point(157, 228);
            this.dtDataLivrare.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataLivrare.Name = "dtDataLivrare";
            this.dtDataLivrare.Size = new System.Drawing.Size(121, 29);
            this.dtDataLivrare.TabIndex = 2;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(10, 260);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(75, 19);
            this.metroLabel12.TabIndex = 57;
            this.metroLabel12.Text = "Data limita:";
            // 
            // dtDataComanda
            // 
            this.dtDataComanda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataComanda.Location = new System.Drawing.Point(10, 228);
            this.dtDataComanda.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataComanda.Name = "dtDataComanda";
            this.dtDataComanda.Size = new System.Drawing.Size(121, 29);
            this.dtDataComanda.TabIndex = 0;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(10, 206);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(98, 19);
            this.metroLabel11.TabIndex = 56;
            this.metroLabel11.Text = "Data comanda:";
            // 
            // dtDataLimita
            // 
            this.dtDataLimita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataLimita.Location = new System.Drawing.Point(10, 282);
            this.dtDataLimita.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataLimita.Name = "dtDataLimita";
            this.dtDataLimita.Size = new System.Drawing.Size(121, 29);
            this.dtDataLimita.TabIndex = 1;
            // 
            // grpDetaliiComanda
            // 
            this.grpDetaliiComanda.Controls.Add(this.metroLabel2);
            this.grpDetaliiComanda.Controls.Add(this.btnTotal);
            this.grpDetaliiComanda.Controls.Add(this.cboAlegeProdus);
            this.grpDetaliiComanda.Controls.Add(this.grpProduseComandate);
            this.grpDetaliiComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grpDetaliiComanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.grpDetaliiComanda.Location = new System.Drawing.Point(343, 85);
            this.grpDetaliiComanda.Name = "grpDetaliiComanda";
            this.grpDetaliiComanda.Size = new System.Drawing.Size(898, 282);
            this.grpDetaliiComanda.TabIndex = 61;
            this.grpDetaliiComanda.TabStop = false;
            this.grpDetaliiComanda.Text = "Detalii comanda";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(21, 37);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 19);
            this.metroLabel2.TabIndex = 65;
            this.metroLabel2.Text = "Cautati produsul:";
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTotal.Location = new System.Drawing.Point(782, 66);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(92, 23);
            this.btnTotal.TabIndex = 60;
            this.btnTotal.Text = "Generare total";
            this.btnTotal.UseCustomBackColor = true;
            this.btnTotal.UseCustomForeColor = true;
            this.btnTotal.UseSelectable = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // cboAlegeProdus
            // 
            this.cboAlegeProdus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboAlegeProdus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAlegeProdus.FormattingEnabled = true;
            this.cboAlegeProdus.Location = new System.Drawing.Point(21, 59);
            this.cboAlegeProdus.Name = "cboAlegeProdus";
            this.cboAlegeProdus.Size = new System.Drawing.Size(121, 23);
            this.cboAlegeProdus.TabIndex = 64;
            this.cboAlegeProdus.SelectedIndexChanged += new System.EventHandler(this.cboAlegeProdus_SelectedIndexChanged);
            this.cboAlegeProdus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboAlegeProdus_KeyDown);
            // 
            // grpProduseComandate
            // 
            this.grpProduseComandate.Controls.Add(this.gridProduse);
            this.grpProduseComandate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.grpProduseComandate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.grpProduseComandate.Location = new System.Drawing.Point(21, 95);
            this.grpProduseComandate.Name = "grpProduseComandate";
            this.grpProduseComandate.Size = new System.Drawing.Size(853, 172);
            this.grpProduseComandate.TabIndex = 60;
            this.grpProduseComandate.TabStop = false;
            this.grpProduseComandate.Text = "Produse comandate";
            // 
            // gridProduse
            // 
            this.gridProduse.AllowUserToResizeColumns = false;
            this.gridProduse.AllowUserToResizeRows = false;
            this.gridProduse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProduse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProduse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridProduse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProduse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProduse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumeProdus,
            this.colPretUnitar,
            this.colCantitate,
            this.colUnitateMasura,
            this.colDiscount,
            this.colTVA,
            this.colTotalProdus,
            this.col_TotalComanda});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridProduse.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridProduse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProduse.EnableHeadersVisualStyles = false;
            this.gridProduse.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridProduse.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridProduse.Location = new System.Drawing.Point(3, 17);
            this.gridProduse.MultiSelect = false;
            this.gridProduse.Name = "gridProduse";
            this.gridProduse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridProduse.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridProduse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridProduse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProduse.Size = new System.Drawing.Size(847, 152);
            this.gridProduse.TabIndex = 59;
            this.gridProduse.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gridProduse_EditingControlShowing);
            this.gridProduse.EnabledChanged += new System.EventHandler(this.gridProduse_EnabledChanged);
            this.gridProduse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridProduse_KeyDown);
            // 
            // colNumeProdus
            // 
            this.colNumeProdus.HeaderText = "Denumire produs";
            this.colNumeProdus.Name = "colNumeProdus";
            this.colNumeProdus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNumeProdus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPretUnitar
            // 
            this.colPretUnitar.HeaderText = "Pret unitar (RON)";
            this.colPretUnitar.Name = "colPretUnitar";
            this.colPretUnitar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPretUnitar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCantitate
            // 
            this.colCantitate.HeaderText = "Cantitate";
            this.colCantitate.Name = "colCantitate";
            // 
            // colUnitateMasura
            // 
            this.colUnitateMasura.HeaderText = "Unitate masura";
            this.colUnitateMasura.Name = "colUnitateMasura";
            this.colUnitateMasura.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUnitateMasura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "Discount (%)";
            this.colDiscount.Name = "colDiscount";
            // 
            // colTVA
            // 
            this.colTVA.HeaderText = "T.V.A (%)";
            this.colTVA.Name = "colTVA";
            // 
            // colTotalProdus
            // 
            this.colTotalProdus.HeaderText = "Total produs (RON)";
            this.colTotalProdus.Name = "colTotalProdus";
            // 
            // col_TotalComanda
            // 
            this.col_TotalComanda.HeaderText = "TOTAL (RON)";
            this.col_TotalComanda.Name = "col_TotalComanda";
            this.col_TotalComanda.ReadOnly = true;
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnRenunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRenunta.Location = new System.Drawing.Point(1114, 376);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(127, 42);
            this.btnRenunta.TabIndex = 64;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseCustomBackColor = true;
            this.btnRenunta.UseCustomForeColor = true;
            this.btnRenunta.UseSelectable = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnSaveComanda
            // 
            this.btnSaveComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnSaveComanda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveComanda.Location = new System.Drawing.Point(981, 376);
            this.btnSaveComanda.Name = "btnSaveComanda";
            this.btnSaveComanda.Size = new System.Drawing.Size(127, 42);
            this.btnSaveComanda.TabIndex = 63;
            this.btnSaveComanda.Text = "Inregistreaza comanda";
            this.btnSaveComanda.UseCustomBackColor = true;
            this.btnSaveComanda.UseCustomForeColor = true;
            this.btnSaveComanda.UseSelectable = true;
            this.btnSaveComanda.Click += new System.EventHandler(this.btnSaveComanda_Click);
            // 
            // btnSpreFacturi
            // 
            this.btnSpreFacturi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(124)))));
            this.btnSpreFacturi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpreFacturi.Location = new System.Drawing.Point(848, 376);
            this.btnSpreFacturi.Name = "btnSpreFacturi";
            this.btnSpreFacturi.Size = new System.Drawing.Size(127, 42);
            this.btnSpreFacturi.TabIndex = 81;
            this.btnSpreFacturi.Text = "Spre facturi";
            this.btnSpreFacturi.UseCustomBackColor = true;
            this.btnSpreFacturi.UseCustomForeColor = true;
            this.btnSpreFacturi.UseSelectable = true;
            this.btnSpreFacturi.Click += new System.EventHandler(this.btnSpreFacturi_Click);
            // 
            // ComenziF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 437);
            this.Controls.Add(this.btnSpreFacturi);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnSaveComanda);
            this.Controls.Add(this.grpDetaliiComanda);
            this.Controls.Add(this.groupBox4);
            this.Name = "ComenziF";
            this.Resizable = false;
            this.Text = "Comenzi Furnizori";
            this.Load += new System.EventHandler(this.ComenziF_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpDetaliiComanda.ResumeLayout(false);
            this.grpDetaliiComanda.PerformLayout();
            this.grpProduseComandate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProduse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroComboBox cboAlegeFurnizor;
        private MetroFramework.Controls.MetroComboBox cboAlegeAngajat;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox txtNrComanda;
        private System.Windows.Forms.GroupBox grpDetaliiComanda;
        private MetroFramework.Controls.MetroCheckBox chkLivrata;
        private MetroFramework.Controls.MetroButton btnTotal;
        private System.Windows.Forms.GroupBox grpProduseComandate;
        private MetroFramework.Controls.MetroGrid gridProduse;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroDateTime dtDataLivrare;
        private MetroFramework.Controls.MetroDateTime dtDataLimita;
        private MetroFramework.Controls.MetroDateTime dtDataComanda;
        private MetroFramework.Controls.MetroButton btnRenunta;
        private MetroFramework.Controls.MetroButton btnSaveComanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPretUnitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitateMasura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TotalComanda;
        private System.Windows.Forms.ComboBox cboAlegeProdus;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSpreFacturi;
    }
}