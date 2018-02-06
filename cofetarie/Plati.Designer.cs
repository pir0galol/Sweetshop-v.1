namespace cofetarie
{
    partial class Plati
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
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cboNrFactura = new MetroFramework.Controls.MetroComboBox();
            this.grpFactura = new System.Windows.Forms.GroupBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtDenumireFurnizor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.dtDataScadenta = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtTotalFactura = new MetroFramework.Controls.MetroTextBox();
            this.btnRenunta = new MetroFramework.Controls.MetroButton();
            this.btnPlata = new MetroFramework.Controls.MetroButton();
            this.grpDatePlata = new System.Windows.Forms.GroupBox();
            this.lblInformare = new MetroFramework.Controls.MetroLabel();
            this.grpOrdinPlata = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtIBANBeneficiar = new MetroFramework.Controls.MetroTextBox();
            this.txtIBANPlatitor = new MetroFramework.Controls.MetroTextBox();
            this.txtNrOP = new MetroFramework.Controls.MetroTextBox();
            this.lblTotalPlatit = new MetroFramework.Controls.MetroLabel();
            this.lblRON = new MetroFramework.Controls.MetroLabel();
            this.txtTotalPlatit = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.cboMetodaPlata = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.dtDataPlata = new MetroFramework.Controls.MetroDateTime();
            this.btnPlatesteRestul = new MetroFramework.Controls.MetroButton();
            this.grpFactura.SuspendLayout();
            this.grpDatePlata.SuspendLayout();
            this.grpOrdinPlata.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(18, 30);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(76, 19);
            this.metroLabel7.TabIndex = 67;
            this.metroLabel7.Text = "Nr. factura:";
            // 
            // cboNrFactura
            // 
            this.cboNrFactura.FormattingEnabled = true;
            this.cboNrFactura.ItemHeight = 23;
            this.cboNrFactura.Location = new System.Drawing.Point(18, 52);
            this.cboNrFactura.Name = "cboNrFactura";
            this.cboNrFactura.Size = new System.Drawing.Size(105, 29);
            this.cboNrFactura.TabIndex = 66;
            this.cboNrFactura.UseSelectable = true;
            this.cboNrFactura.DropDown += new System.EventHandler(this.cboNrFactura_DropDown);
            this.cboNrFactura.SelectedIndexChanged += new System.EventHandler(this.cboNrFactura_SelectedIndexChanged);
            // 
            // grpFactura
            // 
            this.grpFactura.BackColor = System.Drawing.Color.Transparent;
            this.grpFactura.Controls.Add(this.metroLabel11);
            this.grpFactura.Controls.Add(this.txtDenumireFurnizor);
            this.grpFactura.Controls.Add(this.metroLabel4);
            this.grpFactura.Controls.Add(this.dtDataScadenta);
            this.grpFactura.Controls.Add(this.metroLabel6);
            this.grpFactura.Controls.Add(this.metroLabel1);
            this.grpFactura.Controls.Add(this.txtTotalFactura);
            this.grpFactura.Controls.Add(this.metroLabel7);
            this.grpFactura.Controls.Add(this.cboNrFactura);
            this.grpFactura.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.grpFactura.Location = new System.Drawing.Point(23, 88);
            this.grpFactura.Name = "grpFactura";
            this.grpFactura.Size = new System.Drawing.Size(198, 265);
            this.grpFactura.TabIndex = 68;
            this.grpFactura.TabStop = false;
            this.grpFactura.Text = "Date factura";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(18, 85);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(132, 19);
            this.metroLabel11.TabIndex = 76;
            this.metroLabel11.Text = "Furnizor (beneficiar):";
            // 
            // txtDenumireFurnizor
            // 
            // 
            // 
            // 
            this.txtDenumireFurnizor.CustomButton.Image = null;
            this.txtDenumireFurnizor.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtDenumireFurnizor.CustomButton.Name = "";
            this.txtDenumireFurnizor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDenumireFurnizor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDenumireFurnizor.CustomButton.TabIndex = 1;
            this.txtDenumireFurnizor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDenumireFurnizor.CustomButton.UseSelectable = true;
            this.txtDenumireFurnizor.CustomButton.Visible = false;
            this.txtDenumireFurnizor.Lines = new string[0];
            this.txtDenumireFurnizor.Location = new System.Drawing.Point(18, 107);
            this.txtDenumireFurnizor.MaxLength = 32767;
            this.txtDenumireFurnizor.Name = "txtDenumireFurnizor";
            this.txtDenumireFurnizor.PasswordChar = '\0';
            this.txtDenumireFurnizor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDenumireFurnizor.SelectedText = "";
            this.txtDenumireFurnizor.SelectionLength = 0;
            this.txtDenumireFurnizor.SelectionStart = 0;
            this.txtDenumireFurnizor.ShortcutsEnabled = true;
            this.txtDenumireFurnizor.Size = new System.Drawing.Size(132, 23);
            this.txtDenumireFurnizor.TabIndex = 75;
            this.txtDenumireFurnizor.UseSelectable = true;
            this.txtDenumireFurnizor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDenumireFurnizor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(18, 137);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(99, 19);
            this.metroLabel4.TabIndex = 74;
            this.metroLabel4.Text = "Data scadenta:";
            // 
            // dtDataScadenta
            // 
            this.dtDataScadenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataScadenta.Location = new System.Drawing.Point(18, 159);
            this.dtDataScadenta.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataScadenta.Name = "dtDataScadenta";
            this.dtDataScadenta.Size = new System.Drawing.Size(105, 29);
            this.dtDataScadenta.TabIndex = 73;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(16, 198);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(103, 19);
            this.metroLabel6.TabIndex = 70;
            this.metroLabel6.Text = "Valoare factura:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(129, 224);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 19);
            this.metroLabel1.TabIndex = 69;
            this.metroLabel1.Text = "RON";
            // 
            // txtTotalFactura
            // 
            // 
            // 
            // 
            this.txtTotalFactura.CustomButton.Image = null;
            this.txtTotalFactura.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtTotalFactura.CustomButton.Name = "";
            this.txtTotalFactura.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalFactura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalFactura.CustomButton.TabIndex = 1;
            this.txtTotalFactura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalFactura.CustomButton.UseSelectable = true;
            this.txtTotalFactura.CustomButton.Visible = false;
            this.txtTotalFactura.Lines = new string[0];
            this.txtTotalFactura.Location = new System.Drawing.Point(18, 220);
            this.txtTotalFactura.MaxLength = 32767;
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.PasswordChar = '\0';
            this.txtTotalFactura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalFactura.SelectedText = "";
            this.txtTotalFactura.SelectionLength = 0;
            this.txtTotalFactura.SelectionStart = 0;
            this.txtTotalFactura.ShortcutsEnabled = true;
            this.txtTotalFactura.Size = new System.Drawing.Size(105, 23);
            this.txtTotalFactura.TabIndex = 68;
            this.txtTotalFactura.UseSelectable = true;
            this.txtTotalFactura.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalFactura.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnRenunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRenunta.Location = new System.Drawing.Point(696, 359);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(114, 38);
            this.btnRenunta.TabIndex = 70;
            this.btnRenunta.Text = "Inchide";
            this.btnRenunta.UseCustomBackColor = true;
            this.btnRenunta.UseCustomForeColor = true;
            this.btnRenunta.UseSelectable = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnPlata
            // 
            this.btnPlata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnPlata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlata.Location = new System.Drawing.Point(576, 359);
            this.btnPlata.Name = "btnPlata";
            this.btnPlata.Size = new System.Drawing.Size(114, 38);
            this.btnPlata.TabIndex = 69;
            this.btnPlata.Text = "Inregistreaza plata";
            this.btnPlata.UseCustomBackColor = true;
            this.btnPlata.UseCustomForeColor = true;
            this.btnPlata.UseSelectable = true;
            this.btnPlata.Click += new System.EventHandler(this.btnPlata_Click);
            // 
            // grpDatePlata
            // 
            this.grpDatePlata.BackColor = System.Drawing.Color.Transparent;
            this.grpDatePlata.Controls.Add(this.btnPlatesteRestul);
            this.grpDatePlata.Controls.Add(this.lblInformare);
            this.grpDatePlata.Controls.Add(this.grpOrdinPlata);
            this.grpDatePlata.Controls.Add(this.lblTotalPlatit);
            this.grpDatePlata.Controls.Add(this.lblRON);
            this.grpDatePlata.Controls.Add(this.txtTotalPlatit);
            this.grpDatePlata.Controls.Add(this.metroLabel9);
            this.grpDatePlata.Controls.Add(this.cboMetodaPlata);
            this.grpDatePlata.Controls.Add(this.metroLabel10);
            this.grpDatePlata.Controls.Add(this.dtDataPlata);
            this.grpDatePlata.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDatePlata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.grpDatePlata.Location = new System.Drawing.Point(227, 88);
            this.grpDatePlata.Name = "grpDatePlata";
            this.grpDatePlata.Size = new System.Drawing.Size(583, 265);
            this.grpDatePlata.TabIndex = 71;
            this.grpDatePlata.TabStop = false;
            this.grpDatePlata.Text = "Date plata";
            // 
            // lblInformare
            // 
            this.lblInformare.AutoSize = true;
            this.lblInformare.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblInformare.Location = new System.Drawing.Point(276, 191);
            this.lblInformare.Name = "lblInformare";
            this.lblInformare.Size = new System.Drawing.Size(0, 0);
            this.lblInformare.TabIndex = 78;
            // 
            // grpOrdinPlata
            // 
            this.grpOrdinPlata.BackColor = System.Drawing.Color.Transparent;
            this.grpOrdinPlata.Controls.Add(this.metroLabel3);
            this.grpOrdinPlata.Controls.Add(this.metroLabel2);
            this.grpOrdinPlata.Controls.Add(this.txtIBANBeneficiar);
            this.grpOrdinPlata.Controls.Add(this.txtIBANPlatitor);
            this.grpOrdinPlata.Controls.Add(this.txtNrOP);
            this.grpOrdinPlata.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrdinPlata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.grpOrdinPlata.Location = new System.Drawing.Point(18, 87);
            this.grpOrdinPlata.Name = "grpOrdinPlata";
            this.grpOrdinPlata.Size = new System.Drawing.Size(230, 162);
            this.grpOrdinPlata.TabIndex = 72;
            this.grpOrdinPlata.TabStop = false;
            this.grpOrdinPlata.Text = "Detalii OP";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(6, 52);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 73;
            this.metroLabel3.Text = "IBAN platitor:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(6, 104);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 19);
            this.metroLabel2.TabIndex = 72;
            this.metroLabel2.Text = "IBAN beneficiar:";
            // 
            // txtIBANBeneficiar
            // 
            // 
            // 
            // 
            this.txtIBANBeneficiar.CustomButton.Image = null;
            this.txtIBANBeneficiar.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txtIBANBeneficiar.CustomButton.Name = "";
            this.txtIBANBeneficiar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIBANBeneficiar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIBANBeneficiar.CustomButton.TabIndex = 1;
            this.txtIBANBeneficiar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIBANBeneficiar.CustomButton.UseSelectable = true;
            this.txtIBANBeneficiar.CustomButton.Visible = false;
            this.txtIBANBeneficiar.Lines = new string[0];
            this.txtIBANBeneficiar.Location = new System.Drawing.Point(6, 126);
            this.txtIBANBeneficiar.MaxLength = 32767;
            this.txtIBANBeneficiar.Name = "txtIBANBeneficiar";
            this.txtIBANBeneficiar.PasswordChar = '\0';
            this.txtIBANBeneficiar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIBANBeneficiar.SelectedText = "";
            this.txtIBANBeneficiar.SelectionLength = 0;
            this.txtIBANBeneficiar.SelectionStart = 0;
            this.txtIBANBeneficiar.ShortcutsEnabled = true;
            this.txtIBANBeneficiar.Size = new System.Drawing.Size(179, 23);
            this.txtIBANBeneficiar.TabIndex = 71;
            this.txtIBANBeneficiar.UseSelectable = true;
            this.txtIBANBeneficiar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIBANBeneficiar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtIBANPlatitor
            // 
            // 
            // 
            // 
            this.txtIBANPlatitor.CustomButton.Image = null;
            this.txtIBANPlatitor.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txtIBANPlatitor.CustomButton.Name = "";
            this.txtIBANPlatitor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIBANPlatitor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIBANPlatitor.CustomButton.TabIndex = 1;
            this.txtIBANPlatitor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIBANPlatitor.CustomButton.UseSelectable = true;
            this.txtIBANPlatitor.CustomButton.Visible = false;
            this.txtIBANPlatitor.Lines = new string[0];
            this.txtIBANPlatitor.Location = new System.Drawing.Point(6, 78);
            this.txtIBANPlatitor.MaxLength = 32767;
            this.txtIBANPlatitor.Name = "txtIBANPlatitor";
            this.txtIBANPlatitor.PasswordChar = '\0';
            this.txtIBANPlatitor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIBANPlatitor.SelectedText = "";
            this.txtIBANPlatitor.SelectionLength = 0;
            this.txtIBANPlatitor.SelectionStart = 0;
            this.txtIBANPlatitor.ShortcutsEnabled = true;
            this.txtIBANPlatitor.Size = new System.Drawing.Size(179, 23);
            this.txtIBANPlatitor.TabIndex = 70;
            this.txtIBANPlatitor.UseSelectable = true;
            this.txtIBANPlatitor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIBANPlatitor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNrOP
            // 
            // 
            // 
            // 
            this.txtNrOP.CustomButton.Image = null;
            this.txtNrOP.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.txtNrOP.CustomButton.Name = "";
            this.txtNrOP.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNrOP.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNrOP.CustomButton.TabIndex = 1;
            this.txtNrOP.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNrOP.CustomButton.UseSelectable = true;
            this.txtNrOP.CustomButton.Visible = false;
            this.txtNrOP.Lines = new string[0];
            this.txtNrOP.Location = new System.Drawing.Point(6, 21);
            this.txtNrOP.MaxLength = 32767;
            this.txtNrOP.Name = "txtNrOP";
            this.txtNrOP.PasswordChar = '\0';
            this.txtNrOP.WaterMark = "Nr. Ordin plata";
            this.txtNrOP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNrOP.SelectedText = "";
            this.txtNrOP.SelectionLength = 0;
            this.txtNrOP.SelectionStart = 0;
            this.txtNrOP.ShortcutsEnabled = true;
            this.txtNrOP.Size = new System.Drawing.Size(179, 23);
            this.txtNrOP.TabIndex = 69;
            this.txtNrOP.UseSelectable = true;
            this.txtNrOP.WaterMark = "Nr. Ordin plata";
            this.txtNrOP.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNrOP.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNrOP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNrOP_KeyPress);
            // 
            // lblTotalPlatit
            // 
            this.lblTotalPlatit.AutoSize = true;
            this.lblTotalPlatit.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotalPlatit.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotalPlatit.Location = new System.Drawing.Point(345, 105);
            this.lblTotalPlatit.Name = "lblTotalPlatit";
            this.lblTotalPlatit.Size = new System.Drawing.Size(109, 25);
            this.lblTotalPlatit.TabIndex = 77;
            this.lblTotalPlatit.Text = "Total platit:";
            this.lblTotalPlatit.UseCustomForeColor = true;
            // 
            // lblRON
            // 
            this.lblRON.AutoSize = true;
            this.lblRON.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRON.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblRON.Location = new System.Drawing.Point(460, 131);
            this.lblRON.Name = "lblRON";
            this.lblRON.Size = new System.Drawing.Size(52, 25);
            this.lblRON.TabIndex = 76;
            this.lblRON.Text = "RON";
            this.lblRON.UseCustomForeColor = true;
            // 
            // txtTotalPlatit
            // 
            // 
            // 
            // 
            this.txtTotalPlatit.CustomButton.Image = null;
            this.txtTotalPlatit.CustomButton.Location = new System.Drawing.Point(83, 1);
            this.txtTotalPlatit.CustomButton.Name = "";
            this.txtTotalPlatit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalPlatit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalPlatit.CustomButton.TabIndex = 1;
            this.txtTotalPlatit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalPlatit.CustomButton.UseSelectable = true;
            this.txtTotalPlatit.CustomButton.Visible = false;
            this.txtTotalPlatit.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTotalPlatit.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtTotalPlatit.Lines = new string[0];
            this.txtTotalPlatit.Location = new System.Drawing.Point(349, 133);
            this.txtTotalPlatit.MaxLength = 32767;
            this.txtTotalPlatit.Name = "txtTotalPlatit";
            this.txtTotalPlatit.PasswordChar = '\0';
            this.txtTotalPlatit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalPlatit.SelectedText = "";
            this.txtTotalPlatit.SelectionLength = 0;
            this.txtTotalPlatit.SelectionStart = 0;
            this.txtTotalPlatit.ShortcutsEnabled = true;
            this.txtTotalPlatit.Size = new System.Drawing.Size(105, 23);
            this.txtTotalPlatit.TabIndex = 75;
            this.txtTotalPlatit.UseSelectable = true;
            this.txtTotalPlatit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalPlatit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalPlatit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalPlatit_KeyPress);
            this.txtTotalPlatit.Leave += new System.EventHandler(this.txtTotalPlatit_Leave);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(15, 30);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(94, 19);
            this.metroLabel9.TabIndex = 74;
            this.metroLabel9.Text = "Metoda plata:";
            // 
            // cboMetodaPlata
            // 
            this.cboMetodaPlata.FormattingEnabled = true;
            this.cboMetodaPlata.ItemHeight = 23;
            this.cboMetodaPlata.Location = new System.Drawing.Point(18, 52);
            this.cboMetodaPlata.Name = "cboMetodaPlata";
            this.cboMetodaPlata.Size = new System.Drawing.Size(105, 29);
            this.cboMetodaPlata.TabIndex = 73;
            this.cboMetodaPlata.UseSelectable = true;
            this.cboMetodaPlata.SelectedIndexChanged += new System.EventHandler(this.cboMetodaPlata_SelectedIndexChanged);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(143, 30);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(75, 19);
            this.metroLabel10.TabIndex = 72;
            this.metroLabel10.Text = "Data plata:";
            // 
            // dtDataPlata
            // 
            this.dtDataPlata.CalendarForeColor = System.Drawing.Color.Red;
            this.dtDataPlata.CalendarMonthBackground = System.Drawing.Color.Red;
            this.dtDataPlata.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.dtDataPlata.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtDataPlata.CalendarTrailingForeColor = System.Drawing.Color.Red;
            this.dtDataPlata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataPlata.Location = new System.Drawing.Point(143, 52);
            this.dtDataPlata.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDataPlata.Name = "dtDataPlata";
            this.dtDataPlata.Size = new System.Drawing.Size(105, 29);
            this.dtDataPlata.Style = MetroFramework.MetroColorStyle.Red;
            this.dtDataPlata.TabIndex = 71;
            this.dtDataPlata.UseStyleColors = true;
            // 
            // btnPlatesteRestul
            // 
            this.btnPlatesteRestul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnPlatesteRestul.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlatesteRestul.Location = new System.Drawing.Point(463, 236);
            this.btnPlatesteRestul.Name = "btnPlatesteRestul";
            this.btnPlatesteRestul.Size = new System.Drawing.Size(114, 23);
            this.btnPlatesteRestul.TabIndex = 79;
            this.btnPlatesteRestul.Text = "Plateste restul";
            this.btnPlatesteRestul.UseCustomBackColor = true;
            this.btnPlatesteRestul.UseCustomForeColor = true;
            this.btnPlatesteRestul.UseSelectable = true;
            this.btnPlatesteRestul.Click += new System.EventHandler(this.btnPlatesteRestul_Click);
            // 
            // Plati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 409);
            this.Controls.Add(this.grpDatePlata);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnPlata);
            this.Controls.Add(this.grpFactura);
            this.Name = "Plati";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Text = "Plati";
            this.Load += new System.EventHandler(this.Plati_Load);
            this.grpFactura.ResumeLayout(false);
            this.grpFactura.PerformLayout();
            this.grpDatePlata.ResumeLayout(false);
            this.grpDatePlata.PerformLayout();
            this.grpOrdinPlata.ResumeLayout(false);
            this.grpOrdinPlata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cboNrFactura;
        private System.Windows.Forms.GroupBox grpFactura;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtTotalFactura;
        private MetroFramework.Controls.MetroButton btnRenunta;
        private MetroFramework.Controls.MetroButton btnPlata;
        private System.Windows.Forms.GroupBox grpDatePlata;
        private MetroFramework.Controls.MetroLabel lblTotalPlatit;
        private MetroFramework.Controls.MetroLabel lblRON;
        private MetroFramework.Controls.MetroTextBox txtTotalPlatit;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroComboBox cboMetodaPlata;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroDateTime dtDataPlata;
        private System.Windows.Forms.GroupBox grpOrdinPlata;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtIBANBeneficiar;
        private MetroFramework.Controls.MetroTextBox txtIBANPlatitor;
        private MetroFramework.Controls.MetroTextBox txtNrOP;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime dtDataScadenta;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtDenumireFurnizor;
        private MetroFramework.Controls.MetroLabel lblInformare;
        private MetroFramework.Controls.MetroButton btnPlatesteRestul;
    }
}