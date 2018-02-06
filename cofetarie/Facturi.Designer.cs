namespace cofetarie
{
    partial class Facturi
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
            this.tabFacturi = new MetroFramework.Controls.MetroTabControl();
            this.pageFacturiFurn = new MetroFramework.Controls.MetroTabPage();
            this.lblExista = new MetroFramework.Controls.MetroLabel();
            this.btnSprePlati = new MetroFramework.Controls.MetroButton();
            this.btnRenunta = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.rbnClienti = new MetroFramework.Controls.MetroRadioButton();
            this.rbnFurn = new MetroFramework.Controls.MetroRadioButton();
            this.grpFactura = new System.Windows.Forms.GroupBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.dtDataScadenta = new MetroFramework.Controls.MetroDateTime();
            this.dtDataFactura = new MetroFramework.Controls.MetroDateTime();
            this.txtTotalFactura = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNrFactura = new MetroFramework.Controls.MetroTextBox();
            this.grpComanda = new System.Windows.Forms.GroupBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.lblden = new MetroFramework.Controls.MetroLabel();
            this.gridDetaliiComanda = new MetroFramework.Controls.MetroGrid();
            this.colNrComanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataComanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataLimita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataLivrare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumeProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPretUnitar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantitate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitateMasura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalProdus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVeziDetaliiComanda = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalComanda = new MetroFramework.Controls.MetroTextBox();
            this.cboNrComanda = new MetroFramework.Controls.MetroComboBox();
            this.txtDenumireFurn = new MetroFramework.Controls.MetroTextBox();
            this.tabFacturi.SuspendLayout();
            this.pageFacturiFurn.SuspendLayout();
            this.grpFactura.SuspendLayout();
            this.grpComanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetaliiComanda)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFacturi
            // 
            this.tabFacturi.Controls.Add(this.pageFacturiFurn);
            this.tabFacturi.Location = new System.Drawing.Point(23, 63);
            this.tabFacturi.Name = "tabFacturi";
            this.tabFacturi.SelectedIndex = 0;
            this.tabFacturi.Size = new System.Drawing.Size(1160, 531);
            this.tabFacturi.TabIndex = 0;
            this.tabFacturi.UseSelectable = true;
            // 
            // pageFacturiFurn
            // 
            this.pageFacturiFurn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageFacturiFurn.Controls.Add(this.lblExista);
            this.pageFacturiFurn.Controls.Add(this.btnSprePlati);
            this.pageFacturiFurn.Controls.Add(this.btnRenunta);
            this.pageFacturiFurn.Controls.Add(this.btnSave);
            this.pageFacturiFurn.Controls.Add(this.rbnClienti);
            this.pageFacturiFurn.Controls.Add(this.rbnFurn);
            this.pageFacturiFurn.Controls.Add(this.grpFactura);
            this.pageFacturiFurn.Controls.Add(this.metroLabel3);
            this.pageFacturiFurn.Controls.Add(this.txtNrFactura);
            this.pageFacturiFurn.Controls.Add(this.grpComanda);
            this.pageFacturiFurn.HorizontalScrollbarBarColor = true;
            this.pageFacturiFurn.HorizontalScrollbarHighlightOnWheel = false;
            this.pageFacturiFurn.HorizontalScrollbarSize = 10;
            this.pageFacturiFurn.Location = new System.Drawing.Point(4, 38);
            this.pageFacturiFurn.Name = "pageFacturiFurn";
            this.pageFacturiFurn.Size = new System.Drawing.Size(1152, 489);
            this.pageFacturiFurn.TabIndex = 0;
            this.pageFacturiFurn.Text = "Furnizori/Clienti";
            this.pageFacturiFurn.VerticalScrollbarBarColor = true;
            this.pageFacturiFurn.VerticalScrollbarHighlightOnWheel = false;
            this.pageFacturiFurn.VerticalScrollbarSize = 10;
            // 
            // lblExista
            // 
            this.lblExista.AutoSize = true;
            this.lblExista.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblExista.ForeColor = System.Drawing.Color.Maroon;
            this.lblExista.Location = new System.Drawing.Point(437, 14);
            this.lblExista.Name = "lblExista";
            this.lblExista.Size = new System.Drawing.Size(13, 19);
            this.lblExista.TabIndex = 67;
            this.lblExista.Text = " ";
            this.lblExista.UseCustomForeColor = true;
            // 
            // btnSprePlati
            // 
            this.btnSprePlati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(124)))));
            this.btnSprePlati.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSprePlati.Location = new System.Drawing.Point(1010, 430);
            this.btnSprePlati.Name = "btnSprePlati";
            this.btnSprePlati.Size = new System.Drawing.Size(127, 38);
            this.btnSprePlati.TabIndex = 35;
            this.btnSprePlati.Text = "Spre plati";
            this.btnSprePlati.UseCustomBackColor = true;
            this.btnSprePlati.UseCustomForeColor = true;
            this.btnSprePlati.UseSelectable = true;
            this.btnSprePlati.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnRenunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRenunta.Location = new System.Drawing.Point(1010, 367);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(127, 42);
            this.btnRenunta.TabIndex = 34;
            this.btnRenunta.Text = "Inchide";
            this.btnRenunta.UseCustomBackColor = true;
            this.btnRenunta.UseCustomForeColor = true;
            this.btnRenunta.UseSelectable = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(877, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 42);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Inregistreaza factura";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbnClienti
            // 
            this.rbnClienti.Location = new System.Drawing.Point(35, 66);
            this.rbnClienti.Name = "rbnClienti";
            this.rbnClienti.Size = new System.Drawing.Size(110, 24);
            this.rbnClienti.TabIndex = 30;
            this.rbnClienti.Text = "Clienti";
            this.rbnClienti.UseSelectable = true;
            this.rbnClienti.CheckedChanged += new System.EventHandler(this.rbnClienti_CheckedChanged);
            // 
            // rbnFurn
            // 
            this.rbnFurn.Location = new System.Drawing.Point(35, 36);
            this.rbnFurn.Name = "rbnFurn";
            this.rbnFurn.Size = new System.Drawing.Size(123, 24);
            this.rbnFurn.TabIndex = 29;
            this.rbnFurn.Text = "Furnizori";
            this.rbnFurn.UseSelectable = true;
            this.rbnFurn.CheckedChanged += new System.EventHandler(this.rbnFurn_CheckedChanged);
            // 
            // grpFactura
            // 
            this.grpFactura.BackColor = System.Drawing.Color.Transparent;
            this.grpFactura.Controls.Add(this.metroLabel4);
            this.grpFactura.Controls.Add(this.metroLabel2);
            this.grpFactura.Controls.Add(this.metroLabel12);
            this.grpFactura.Controls.Add(this.metroLabel11);
            this.grpFactura.Controls.Add(this.dtDataScadenta);
            this.grpFactura.Controls.Add(this.dtDataFactura);
            this.grpFactura.Controls.Add(this.txtTotalFactura);
            this.grpFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.grpFactura.Location = new System.Drawing.Point(204, 367);
            this.grpFactura.Name = "grpFactura";
            this.grpFactura.Size = new System.Drawing.Size(489, 101);
            this.grpFactura.TabIndex = 27;
            this.grpFactura.TabStop = false;
            this.grpFactura.Text = "Detalii factura";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(312, 29);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 25);
            this.metroLabel4.TabIndex = 63;
            this.metroLabel4.Text = "TOTAL:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(416, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(40, 19);
            this.metroLabel2.TabIndex = 60;
            this.metroLabel2.Text = "RON";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(118, 29);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(99, 19);
            this.metroLabel12.TabIndex = 59;
            this.metroLabel12.Text = "Data scadenta:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(6, 29);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(87, 19);
            this.metroLabel11.TabIndex = 58;
            this.metroLabel11.Text = "Data factura:";
            // 
            // dtDataScadenta
            // 
            this.dtDataScadenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataScadenta.Location = new System.Drawing.Point(123, 51);
            this.dtDataScadenta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataScadenta.Name = "dtDataScadenta";
            this.dtDataScadenta.Size = new System.Drawing.Size(94, 29);
            this.dtDataScadenta.TabIndex = 2;
            // 
            // dtDataFactura
            // 
            this.dtDataFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFactura.Location = new System.Drawing.Point(10, 51);
            this.dtDataFactura.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataFactura.Name = "dtDataFactura";
            this.dtDataFactura.Size = new System.Drawing.Size(94, 29);
            this.dtDataFactura.TabIndex = 1;
            // 
            // txtTotalFactura
            // 
            // 
            // 
            // 
            this.txtTotalFactura.CustomButton.Image = null;
            this.txtTotalFactura.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtTotalFactura.CustomButton.Name = "";
            this.txtTotalFactura.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalFactura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalFactura.CustomButton.TabIndex = 1;
            this.txtTotalFactura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalFactura.CustomButton.UseSelectable = true;
            this.txtTotalFactura.CustomButton.Visible = false;
            this.txtTotalFactura.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTotalFactura.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtTotalFactura.Lines = new string[0];
            this.txtTotalFactura.Location = new System.Drawing.Point(317, 57);
            this.txtTotalFactura.MaxLength = 32767;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.PasswordChar = '\0';
            this.txtTotalFactura.WaterMark = "Total factura";
            this.txtTotalFactura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalFactura.SelectedText = "";
            this.txtTotalFactura.SelectionLength = 0;
            this.txtTotalFactura.SelectionStart = 0;
            this.txtTotalFactura.ShortcutsEnabled = true;
            this.txtTotalFactura.Size = new System.Drawing.Size(93, 23);
            this.txtTotalFactura.TabIndex = 0;
            this.txtTotalFactura.UseSelectable = true;
            this.txtTotalFactura.WaterMark = "Total factura";
            this.txtTotalFactura.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalFactura.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(25, 14);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(173, 19);
            this.metroLabel3.TabIndex = 28;
            this.metroLabel3.Text = "Inregistrare factura pentru:";
            // 
            // txtNrFactura
            // 
            this.txtNrFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            // 
            // 
            // 
            this.txtNrFactura.CustomButton.Image = null;
            this.txtNrFactura.CustomButton.Location = new System.Drawing.Point(87, 2);
            this.txtNrFactura.CustomButton.Name = "";
            this.txtNrFactura.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtNrFactura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNrFactura.CustomButton.TabIndex = 1;
            this.txtNrFactura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNrFactura.CustomButton.UseSelectable = true;
            this.txtNrFactura.CustomButton.Visible = false;
            this.txtNrFactura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNrFactura.Lines = new string[0];
            this.txtNrFactura.Location = new System.Drawing.Point(35, 96);
            this.txtNrFactura.MaxLength = 32767;
            this.txtNrFactura.Name = "txtNrFactura";
            this.txtNrFactura.PasswordChar = '\0';
            this.txtNrFactura.WaterMark = "Nr. factura";
            this.txtNrFactura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNrFactura.SelectedText = "";
            this.txtNrFactura.SelectionLength = 0;
            this.txtNrFactura.SelectionStart = 0;
            this.txtNrFactura.ShortcutsEnabled = true;
            this.txtNrFactura.Size = new System.Drawing.Size(109, 24);
            this.txtNrFactura.Style = MetroFramework.MetroColorStyle.White;
            this.txtNrFactura.TabIndex = 26;
            this.txtNrFactura.UseCustomBackColor = true;
            this.txtNrFactura.UseCustomForeColor = true;
            this.txtNrFactura.UseSelectable = true;
            this.txtNrFactura.WaterMark = "Nr. factura";
            this.txtNrFactura.WaterMarkColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNrFactura.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grpComanda
            // 
            this.grpComanda.BackColor = System.Drawing.Color.Transparent;
            this.grpComanda.Controls.Add(this.metroLabel7);
            this.grpComanda.Controls.Add(this.metroLabel6);
            this.grpComanda.Controls.Add(this.lblden);
            this.grpComanda.Controls.Add(this.gridDetaliiComanda);
            this.grpComanda.Controls.Add(this.btnVeziDetaliiComanda);
            this.grpComanda.Controls.Add(this.metroLabel1);
            this.grpComanda.Controls.Add(this.txtTotalComanda);
            this.grpComanda.Controls.Add(this.cboNrComanda);
            this.grpComanda.Controls.Add(this.txtDenumireFurn);
            this.grpComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpComanda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.grpComanda.Location = new System.Drawing.Point(204, 51);
            this.grpComanda.Name = "grpComanda";
            this.grpComanda.Size = new System.Drawing.Size(933, 310);
            this.grpComanda.TabIndex = 25;
            this.grpComanda.TabStop = false;
            this.grpComanda.Text = "Comanda";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(6, 25);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(90, 19);
            this.metroLabel7.TabIndex = 65;
            this.metroLabel7.Text = "Nr. comanda:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(267, 25);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(117, 19);
            this.metroLabel6.TabIndex = 64;
            this.metroLabel6.Text = "Valoare comanda:";
            // 
            // lblden
            // 
            this.lblden.AutoSize = true;
            this.lblden.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblden.Location = new System.Drawing.Point(123, 25);
            this.lblden.Name = "lblden";
            this.lblden.Size = new System.Drawing.Size(123, 19);
            this.lblden.TabIndex = 63;
            this.lblden.Text = "Denumire furnizor:";
            // 
            // gridDetaliiComanda
            // 
            this.gridDetaliiComanda.AllowUserToResizeRows = false;
            this.gridDetaliiComanda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDetaliiComanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDetaliiComanda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDetaliiComanda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetaliiComanda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDetaliiComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDetaliiComanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNrComanda,
            this.colDataComanda,
            this.colDataLimita,
            this.colDataLivrare,
            this.colNumeProdus,
            this.colPretUnitar,
            this.colCantitate,
            this.colUnitateMasura,
            this.colDiscount,
            this.colTVA,
            this.colTotalProdus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDetaliiComanda.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDetaliiComanda.EnableHeadersVisualStyles = false;
            this.gridDetaliiComanda.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDetaliiComanda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDetaliiComanda.Location = new System.Drawing.Point(6, 133);
            this.gridDetaliiComanda.Name = "gridDetaliiComanda";
            this.gridDetaliiComanda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetaliiComanda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridDetaliiComanda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDetaliiComanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetaliiComanda.Size = new System.Drawing.Size(921, 164);
            this.gridDetaliiComanda.TabIndex = 62;
            // 
            // colNrComanda
            // 
            this.colNrComanda.HeaderText = "Nr. Comanda";
            this.colNrComanda.Name = "colNrComanda";
            // 
            // colDataComanda
            // 
            this.colDataComanda.HeaderText = "Data comanda";
            this.colDataComanda.Name = "colDataComanda";
            // 
            // colDataLimita
            // 
            this.colDataLimita.HeaderText = "Data limita";
            this.colDataLimita.Name = "colDataLimita";
            // 
            // colDataLivrare
            // 
            this.colDataLivrare.HeaderText = "Data livrare";
            this.colDataLivrare.Name = "colDataLivrare";
            // 
            // colNumeProdus
            // 
            this.colNumeProdus.HeaderText = "Denumire produs";
            this.colNumeProdus.Name = "colNumeProdus";
            // 
            // colPretUnitar
            // 
            this.colPretUnitar.HeaderText = "Pret unitar";
            this.colPretUnitar.Name = "colPretUnitar";
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
            // 
            // colDiscount
            // 
            this.colDiscount.HeaderText = "Discount";
            this.colDiscount.Name = "colDiscount";
            // 
            // colTVA
            // 
            this.colTVA.HeaderText = "T.V.A";
            this.colTVA.Name = "colTVA";
            // 
            // colTotalProdus
            // 
            this.colTotalProdus.HeaderText = "Total produs";
            this.colTotalProdus.Name = "colTotalProdus";
            // 
            // btnVeziDetaliiComanda
            // 
            this.btnVeziDetaliiComanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnVeziDetaliiComanda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVeziDetaliiComanda.Location = new System.Drawing.Point(6, 103);
            this.btnVeziDetaliiComanda.Name = "btnVeziDetaliiComanda";
            this.btnVeziDetaliiComanda.Size = new System.Drawing.Size(127, 24);
            this.btnVeziDetaliiComanda.TabIndex = 61;
            this.btnVeziDetaliiComanda.Text = "Vezi detalii comanda";
            this.btnVeziDetaliiComanda.UseCustomBackColor = true;
            this.btnVeziDetaliiComanda.UseCustomForeColor = true;
            this.btnVeziDetaliiComanda.UseSelectable = true;
            this.btnVeziDetaliiComanda.Click += new System.EventHandler(this.btnVeziDetaliiComanda_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(383, 47);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 59;
            this.metroLabel1.Text = "RON";
            // 
            // txtTotalComanda
            // 
            // 
            // 
            // 
            this.txtTotalComanda.CustomButton.Image = null;
            this.txtTotalComanda.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txtTotalComanda.CustomButton.Name = "";
            this.txtTotalComanda.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalComanda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalComanda.CustomButton.TabIndex = 1;
            this.txtTotalComanda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalComanda.CustomButton.UseSelectable = true;
            this.txtTotalComanda.CustomButton.Visible = false;
            this.txtTotalComanda.Lines = new string[0];
            this.txtTotalComanda.Location = new System.Drawing.Point(267, 47);
            this.txtTotalComanda.MaxLength = 32767;
            this.txtTotalComanda.Name = "txtTotalComanda";
            this.txtTotalComanda.PasswordChar = '\0';
            this.txtTotalComanda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalComanda.SelectedText = "";
            this.txtTotalComanda.SelectionLength = 0;
            this.txtTotalComanda.SelectionStart = 0;
            this.txtTotalComanda.ShortcutsEnabled = true;
            this.txtTotalComanda.Size = new System.Drawing.Size(112, 23);
            this.txtTotalComanda.TabIndex = 2;
            this.txtTotalComanda.UseSelectable = true;
            this.txtTotalComanda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalComanda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboNrComanda
            // 
            this.cboNrComanda.FormattingEnabled = true;
            this.cboNrComanda.ItemHeight = 23;
            this.cboNrComanda.Location = new System.Drawing.Point(10, 47);
            this.cboNrComanda.Name = "cboNrComanda";
            this.cboNrComanda.Size = new System.Drawing.Size(94, 29);
            this.cboNrComanda.TabIndex = 1;
            this.cboNrComanda.UseSelectable = true;
            this.cboNrComanda.DropDown += new System.EventHandler(this.cboNrComanda_DropDown);
            this.cboNrComanda.SelectedIndexChanged += new System.EventHandler(this.cboNrComanda_SelectedIndexChanged);
            // 
            // txtDenumireFurn
            // 
            // 
            // 
            // 
            this.txtDenumireFurn.CustomButton.Image = null;
            this.txtDenumireFurn.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.txtDenumireFurn.CustomButton.Name = "";
            this.txtDenumireFurn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDenumireFurn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDenumireFurn.CustomButton.TabIndex = 1;
            this.txtDenumireFurn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDenumireFurn.CustomButton.UseSelectable = true;
            this.txtDenumireFurn.CustomButton.Visible = false;
            this.txtDenumireFurn.Lines = new string[0];
            this.txtDenumireFurn.Location = new System.Drawing.Point(123, 47);
            this.txtDenumireFurn.MaxLength = 32767;
            this.txtDenumireFurn.Name = "txtDenumireFurn";
            this.txtDenumireFurn.PasswordChar = '\0';
            this.txtDenumireFurn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDenumireFurn.SelectedText = "";
            this.txtDenumireFurn.SelectionLength = 0;
            this.txtDenumireFurn.SelectionStart = 0;
            this.txtDenumireFurn.ShortcutsEnabled = true;
            this.txtDenumireFurn.Size = new System.Drawing.Size(138, 23);
            this.txtDenumireFurn.TabIndex = 0;
            this.txtDenumireFurn.UseSelectable = true;
            this.txtDenumireFurn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDenumireFurn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Facturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 611);
            this.Controls.Add(this.tabFacturi);
            this.Name = "Facturi";
            this.Resizable = false;
            this.Text = "Facturi";
            this.Load += new System.EventHandler(this.Facturi_Load);
            this.tabFacturi.ResumeLayout(false);
            this.pageFacturiFurn.ResumeLayout(false);
            this.pageFacturiFurn.PerformLayout();
            this.grpFactura.ResumeLayout(false);
            this.grpFactura.PerformLayout();
            this.grpComanda.ResumeLayout(false);
            this.grpComanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetaliiComanda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabFacturi;
        private MetroFramework.Controls.MetroTabPage pageFacturiFurn;
        private MetroFramework.Controls.MetroTextBox txtNrFactura;
        private System.Windows.Forms.GroupBox grpComanda;
        private MetroFramework.Controls.MetroComboBox cboNrComanda;
        private MetroFramework.Controls.MetroTextBox txtDenumireFurn;
        private System.Windows.Forms.GroupBox grpFactura;
        private MetroFramework.Controls.MetroDateTime dtDataScadenta;
        private MetroFramework.Controls.MetroDateTime dtDataFactura;
        private MetroFramework.Controls.MetroTextBox txtTotalFactura;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtTotalComanda;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnVeziDetaliiComanda;
        private MetroFramework.Controls.MetroRadioButton rbnClienti;
        private MetroFramework.Controls.MetroRadioButton rbnFurn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnRenunta;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroGrid gridDetaliiComanda;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNrComanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataComanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataLimita;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataLivrare;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumeProdus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPretUnitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantitate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitateMasura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalProdus;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel lblden;
        private MetroFramework.Controls.MetroButton btnSprePlati;
        private MetroFramework.Controls.MetroLabel lblExista;
    }
}