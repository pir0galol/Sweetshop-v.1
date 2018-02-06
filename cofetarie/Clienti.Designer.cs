namespace cofetarie
{
    partial class Clienti
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
            this.btnAdauga = new MetroFramework.Controls.MetroButton();
            this.btnModifica = new MetroFramework.Controls.MetroButton();
            this.btnSterge = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.btnRenunta = new MetroFramework.Controls.MetroButton();
            this.btnSalvare = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdresa = new MetroFramework.Controls.MetroTextBox();
            this.cboOras = new MetroFramework.Controls.MetroComboBox();
            this.txtRegiune = new MetroFramework.Controls.MetroTextBox();
            this.txtCodPostal = new MetroFramework.Controls.MetroTextBox();
            this.txtTara = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboBanca = new MetroFramework.Controls.MetroComboBox();
            this.txtIBAN = new MetroFramework.Controls.MetroTextBox();
            this.txtFax = new MetroFramework.Controls.MetroTextBox();
            this.txtTelefon = new MetroFramework.Controls.MetroTextBox();
            this.txtCUI = new MetroFramework.Controls.MetroTextBox();
            this.txtPersContact = new MetroFramework.Controls.MetroTextBox();
            this.txtDenumireClient = new MetroFramework.Controls.MetroTextBox();
            this.txtCodClient = new MetroFramework.Controls.MetroTextBox();
            this.gridClienti = new MetroFramework.Controls.MetroGrid();
            this.btnSpreComenzi = new MetroFramework.Controls.MetroButton();
            this.col_CodFurnizor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Denumire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Banca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PersContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Oras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CodPostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Regiune = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Tara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClienti)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnAdauga.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdauga.Location = new System.Drawing.Point(500, 306);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(110, 42);
            this.btnAdauga.TabIndex = 78;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseCustomBackColor = true;
            this.btnAdauga.UseCustomForeColor = true;
            this.btnAdauga.UseSelectable = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnModifica.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifica.Location = new System.Drawing.Point(616, 306);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(110, 42);
            this.btnModifica.TabIndex = 77;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseCustomBackColor = true;
            this.btnModifica.UseCustomForeColor = true;
            this.btnModifica.UseSelectable = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))));
            this.btnSterge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSterge.Location = new System.Drawing.Point(732, 306);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(110, 42);
            this.btnSterge.TabIndex = 76;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseCustomBackColor = true;
            this.btnSterge.UseCustomForeColor = true;
            this.btnSterge.UseSelectable = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(33, 523);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 42);
            this.btnRefresh.TabIndex = 75;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseCustomBackColor = true;
            this.btnRefresh.UseCustomForeColor = true;
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnRenunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRenunta.Location = new System.Drawing.Point(732, 523);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(110, 42);
            this.btnRenunta.TabIndex = 74;
            this.btnRenunta.Text = "Inchide";
            this.btnRenunta.UseCustomBackColor = true;
            this.btnRenunta.UseCustomForeColor = true;
            this.btnRenunta.UseSelectable = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnSalvare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvare.Location = new System.Drawing.Point(616, 523);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(110, 42);
            this.btnSalvare.TabIndex = 73;
            this.btnSalvare.Text = "Salveaza";
            this.btnSalvare.UseCustomBackColor = true;
            this.btnSalvare.UseCustomForeColor = true;
            this.btnSalvare.UseSelectable = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdresa);
            this.groupBox2.Controls.Add(this.cboOras);
            this.groupBox2.Controls.Add(this.txtRegiune);
            this.groupBox2.Controls.Add(this.txtCodPostal);
            this.groupBox2.Controls.Add(this.txtTara);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.groupBox2.Location = new System.Drawing.Point(214, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 213);
            this.groupBox2.TabIndex = 72;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Localizare";
            // 
            // txtAdresa
            // 
            // 
            // 
            // 
            this.txtAdresa.CustomButton.Image = null;
            this.txtAdresa.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.txtAdresa.CustomButton.Name = "";
            this.txtAdresa.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtAdresa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdresa.CustomButton.TabIndex = 1;
            this.txtAdresa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdresa.CustomButton.UseSelectable = true;
            this.txtAdresa.CustomButton.Visible = false;
            this.txtAdresa.Lines = new string[0];
            this.txtAdresa.Location = new System.Drawing.Point(6, 22);
            this.txtAdresa.MaxLength = 32767;
            this.txtAdresa.Multiline = true;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.PasswordChar = '\0';
            this.txtAdresa.WaterMark = "Adresa";
            this.txtAdresa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdresa.SelectedText = "";
            this.txtAdresa.SelectionLength = 0;
            this.txtAdresa.SelectionStart = 0;
            this.txtAdresa.ShortcutsEnabled = true;
            this.txtAdresa.Size = new System.Drawing.Size(208, 44);
            this.txtAdresa.TabIndex = 4;
            this.txtAdresa.UseSelectable = true;
            this.txtAdresa.WaterMark = "Adresa";
            this.txtAdresa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdresa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdresa_KeyPress);
            // 
            // cboOras
            // 
            this.cboOras.FormattingEnabled = true;
            this.cboOras.ItemHeight = 23;
            this.cboOras.Location = new System.Drawing.Point(6, 72);
            this.cboOras.Name = "cboOras";
            this.cboOras.PromptText = "Oras";
            this.cboOras.Size = new System.Drawing.Size(127, 29);
            this.cboOras.TabIndex = 6;
            this.cboOras.UseSelectable = true;
            this.cboOras.SelectedIndexChanged += new System.EventHandler(this.cboOras_SelectedIndexChanged);
            // 
            // txtRegiune
            // 
            // 
            // 
            // 
            this.txtRegiune.CustomButton.Image = null;
            this.txtRegiune.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtRegiune.CustomButton.Name = "";
            this.txtRegiune.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRegiune.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRegiune.CustomButton.TabIndex = 1;
            this.txtRegiune.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRegiune.CustomButton.UseSelectable = true;
            this.txtRegiune.CustomButton.Visible = false;
            this.txtRegiune.Lines = new string[0];
            this.txtRegiune.Location = new System.Drawing.Point(6, 138);
            this.txtRegiune.MaxLength = 32767;
            this.txtRegiune.Name = "txtRegiune";
            this.txtRegiune.PasswordChar = '\0';
            this.txtRegiune.WaterMark = "Regiune";
            this.txtRegiune.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRegiune.SelectedText = "";
            this.txtRegiune.SelectionLength = 0;
            this.txtRegiune.SelectionStart = 0;
            this.txtRegiune.ShortcutsEnabled = true;
            this.txtRegiune.Size = new System.Drawing.Size(127, 23);
            this.txtRegiune.TabIndex = 5;
            this.txtRegiune.UseSelectable = true;
            this.txtRegiune.WaterMark = "Regiune";
            this.txtRegiune.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRegiune.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCodPostal
            // 
            // 
            // 
            // 
            this.txtCodPostal.CustomButton.Image = null;
            this.txtCodPostal.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtCodPostal.CustomButton.Name = "";
            this.txtCodPostal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodPostal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodPostal.CustomButton.TabIndex = 1;
            this.txtCodPostal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodPostal.CustomButton.UseSelectable = true;
            this.txtCodPostal.CustomButton.Visible = false;
            this.txtCodPostal.Lines = new string[0];
            this.txtCodPostal.Location = new System.Drawing.Point(6, 109);
            this.txtCodPostal.MaxLength = 32767;
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.PasswordChar = '\0';
            this.txtCodPostal.WaterMark = "Cod postal";
            this.txtCodPostal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodPostal.SelectedText = "";
            this.txtCodPostal.SelectionLength = 0;
            this.txtCodPostal.SelectionStart = 0;
            this.txtCodPostal.ShortcutsEnabled = true;
            this.txtCodPostal.Size = new System.Drawing.Size(127, 23);
            this.txtCodPostal.TabIndex = 8;
            this.txtCodPostal.UseSelectable = true;
            this.txtCodPostal.WaterMark = "Cod postal";
            this.txtCodPostal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodPostal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodPostal_KeyPress);
            // 
            // txtTara
            // 
            // 
            // 
            // 
            this.txtTara.CustomButton.Image = null;
            this.txtTara.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtTara.CustomButton.Name = "";
            this.txtTara.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTara.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTara.CustomButton.TabIndex = 1;
            this.txtTara.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTara.CustomButton.UseSelectable = true;
            this.txtTara.CustomButton.Visible = false;
            this.txtTara.Lines = new string[0];
            this.txtTara.Location = new System.Drawing.Point(6, 167);
            this.txtTara.MaxLength = 32767;
            this.txtTara.Name = "txtTara";
            this.txtTara.PasswordChar = '\0';
            this.txtTara.WaterMark = "Tara";
            this.txtTara.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTara.SelectedText = "";
            this.txtTara.SelectionLength = 0;
            this.txtTara.SelectionStart = 0;
            this.txtTara.ShortcutsEnabled = true;
            this.txtTara.Size = new System.Drawing.Size(127, 23);
            this.txtTara.TabIndex = 7;
            this.txtTara.UseSelectable = true;
            this.txtTara.WaterMark = "Tara";
            this.txtTara.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTara.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboBanca);
            this.groupBox1.Controls.Add(this.txtIBAN);
            this.groupBox1.Controls.Add(this.txtFax);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtCUI);
            this.groupBox1.Controls.Add(this.txtPersContact);
            this.groupBox1.Controls.Add(this.txtDenumireClient);
            this.groupBox1.Controls.Add(this.txtCodClient);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            this.groupBox1.Location = new System.Drawing.Point(33, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 273);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date client";
            // 
            // cboBanca
            // 
            this.cboBanca.FormattingEnabled = true;
            this.cboBanca.ItemHeight = 23;
            this.cboBanca.Location = new System.Drawing.Point(6, 109);
            this.cboBanca.Name = "cboBanca";
            this.cboBanca.PromptText = "Banca";
            this.cboBanca.Size = new System.Drawing.Size(127, 29);
            this.cboBanca.TabIndex = 13;
            this.cboBanca.UseSelectable = true;
            // 
            // txtIBAN
            // 
            // 
            // 
            // 
            this.txtIBAN.CustomButton.Image = null;
            this.txtIBAN.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtIBAN.CustomButton.Name = "";
            this.txtIBAN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIBAN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIBAN.CustomButton.TabIndex = 1;
            this.txtIBAN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIBAN.CustomButton.UseSelectable = true;
            this.txtIBAN.CustomButton.Visible = false;
            this.txtIBAN.Lines = new string[0];
            this.txtIBAN.Location = new System.Drawing.Point(6, 144);
            this.txtIBAN.MaxLength = 32767;
            this.txtIBAN.Name = "txtIBAN";
            this.txtIBAN.PasswordChar = '\0';
            this.txtIBAN.WaterMark = "IBAN";
            this.txtIBAN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIBAN.SelectedText = "";
            this.txtIBAN.SelectionLength = 0;
            this.txtIBAN.SelectionStart = 0;
            this.txtIBAN.ShortcutsEnabled = true;
            this.txtIBAN.Size = new System.Drawing.Size(127, 23);
            this.txtIBAN.TabIndex = 12;
            this.txtIBAN.UseSelectable = true;
            this.txtIBAN.WaterMark = "IBAN";
            this.txtIBAN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIBAN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIBAN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIBAN_KeyPress);
            // 
            // txtFax
            // 
            // 
            // 
            // 
            this.txtFax.CustomButton.Image = null;
            this.txtFax.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtFax.CustomButton.Name = "";
            this.txtFax.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFax.CustomButton.TabIndex = 1;
            this.txtFax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFax.CustomButton.UseSelectable = true;
            this.txtFax.CustomButton.Visible = false;
            this.txtFax.Lines = new string[0];
            this.txtFax.Location = new System.Drawing.Point(6, 231);
            this.txtFax.MaxLength = 32767;
            this.txtFax.Name = "txtFax";
            this.txtFax.PasswordChar = '\0';
            this.txtFax.WaterMark = "Fax";
            this.txtFax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFax.SelectedText = "";
            this.txtFax.SelectionLength = 0;
            this.txtFax.SelectionStart = 0;
            this.txtFax.ShortcutsEnabled = true;
            this.txtFax.Size = new System.Drawing.Size(127, 23);
            this.txtFax.TabIndex = 10;
            this.txtFax.UseSelectable = true;
            this.txtFax.WaterMark = "Fax";
            this.txtFax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFax_KeyPress);
            // 
            // txtTelefon
            // 
            // 
            // 
            // 
            this.txtTelefon.CustomButton.Image = null;
            this.txtTelefon.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtTelefon.CustomButton.Name = "";
            this.txtTelefon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelefon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelefon.CustomButton.TabIndex = 1;
            this.txtTelefon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelefon.CustomButton.UseSelectable = true;
            this.txtTelefon.CustomButton.Visible = false;
            this.txtTelefon.Lines = new string[0];
            this.txtTelefon.Location = new System.Drawing.Point(6, 202);
            this.txtTelefon.MaxLength = 32767;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.PasswordChar = '\0';
            this.txtTelefon.WaterMark = "Telefon";
            this.txtTelefon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelefon.SelectedText = "";
            this.txtTelefon.SelectionLength = 0;
            this.txtTelefon.SelectionStart = 0;
            this.txtTelefon.ShortcutsEnabled = true;
            this.txtTelefon.Size = new System.Drawing.Size(127, 23);
            this.txtTelefon.TabIndex = 9;
            this.txtTelefon.UseSelectable = true;
            this.txtTelefon.WaterMark = "Telefon";
            this.txtTelefon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelefon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefon_KeyPress);
            // 
            // txtCUI
            // 
            // 
            // 
            // 
            this.txtCUI.CustomButton.Image = null;
            this.txtCUI.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtCUI.CustomButton.Name = "";
            this.txtCUI.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCUI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCUI.CustomButton.TabIndex = 1;
            this.txtCUI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCUI.CustomButton.UseSelectable = true;
            this.txtCUI.CustomButton.Visible = false;
            this.txtCUI.Lines = new string[0];
            this.txtCUI.Location = new System.Drawing.Point(6, 80);
            this.txtCUI.MaxLength = 32767;
            this.txtCUI.Name = "txtCUI";
            this.txtCUI.PasswordChar = '\0';
            this.txtCUI.WaterMark = "C.U.I";
            this.txtCUI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCUI.SelectedText = "";
            this.txtCUI.SelectionLength = 0;
            this.txtCUI.SelectionStart = 0;
            this.txtCUI.ShortcutsEnabled = true;
            this.txtCUI.Size = new System.Drawing.Size(127, 23);
            this.txtCUI.TabIndex = 3;
            this.txtCUI.UseSelectable = true;
            this.txtCUI.WaterMark = "C.U.I";
            this.txtCUI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCUI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUI_KeyPress);
            // 
            // txtPersContact
            // 
            // 
            // 
            // 
            this.txtPersContact.CustomButton.Image = null;
            this.txtPersContact.CustomButton.Location = new System.Drawing.Point(105, 1);
            this.txtPersContact.CustomButton.Name = "";
            this.txtPersContact.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPersContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPersContact.CustomButton.TabIndex = 1;
            this.txtPersContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPersContact.CustomButton.UseSelectable = true;
            this.txtPersContact.CustomButton.Visible = false;
            this.txtPersContact.Lines = new string[0];
            this.txtPersContact.Location = new System.Drawing.Point(6, 173);
            this.txtPersContact.MaxLength = 32767;
            this.txtPersContact.Name = "txtPersContact";
            this.txtPersContact.PasswordChar = '\0';
            this.txtPersContact.WaterMark = "Persoana contact";
            this.txtPersContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPersContact.SelectedText = "";
            this.txtPersContact.SelectionLength = 0;
            this.txtPersContact.SelectionStart = 0;
            this.txtPersContact.ShortcutsEnabled = true;
            this.txtPersContact.Size = new System.Drawing.Size(127, 23);
            this.txtPersContact.TabIndex = 2;
            this.txtPersContact.UseSelectable = true;
            this.txtPersContact.WaterMark = "Persoana contact";
            this.txtPersContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPersContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPersContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersContact_KeyPress);
            // 
            // txtDenumireClient
            // 
            // 
            // 
            // 
            this.txtDenumireClient.CustomButton.Image = null;
            this.txtDenumireClient.CustomButton.Location = new System.Drawing.Point(138, 1);
            this.txtDenumireClient.CustomButton.Name = "";
            this.txtDenumireClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDenumireClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDenumireClient.CustomButton.TabIndex = 1;
            this.txtDenumireClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDenumireClient.CustomButton.UseSelectable = true;
            this.txtDenumireClient.CustomButton.Visible = false;
            this.txtDenumireClient.Lines = new string[0];
            this.txtDenumireClient.Location = new System.Drawing.Point(6, 51);
            this.txtDenumireClient.MaxLength = 32767;
            this.txtDenumireClient.Name = "txtDenumireClient";
            this.txtDenumireClient.PasswordChar = '\0';
            this.txtDenumireClient.WaterMark = "Denumire client";
            this.txtDenumireClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDenumireClient.SelectedText = "";
            this.txtDenumireClient.SelectionLength = 0;
            this.txtDenumireClient.SelectionStart = 0;
            this.txtDenumireClient.ShortcutsEnabled = true;
            this.txtDenumireClient.Size = new System.Drawing.Size(160, 23);
            this.txtDenumireClient.TabIndex = 1;
            this.txtDenumireClient.UseSelectable = true;
            this.txtDenumireClient.WaterMark = "Denumire client";
            this.txtDenumireClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDenumireClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDenumireClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDenumireClient_KeyPress);
            // 
            // txtCodClient
            // 
            // 
            // 
            // 
            this.txtCodClient.CustomButton.Image = null;
            this.txtCodClient.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.txtCodClient.CustomButton.Name = "";
            this.txtCodClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodClient.CustomButton.TabIndex = 1;
            this.txtCodClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodClient.CustomButton.UseSelectable = true;
            this.txtCodClient.CustomButton.Visible = false;
            this.txtCodClient.Lines = new string[0];
            this.txtCodClient.Location = new System.Drawing.Point(6, 22);
            this.txtCodClient.MaxLength = 32767;
            this.txtCodClient.Name = "txtCodClient";
            this.txtCodClient.PasswordChar = '\0';
            this.txtCodClient.WaterMark = "Cod client";
            this.txtCodClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodClient.SelectedText = "";
            this.txtCodClient.SelectionLength = 0;
            this.txtCodClient.SelectionStart = 0;
            this.txtCodClient.ShortcutsEnabled = true;
            this.txtCodClient.Size = new System.Drawing.Size(119, 23);
            this.txtCodClient.TabIndex = 0;
            this.txtCodClient.UseSelectable = true;
            this.txtCodClient.WaterMark = "Cod client";
            this.txtCodClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodClient_KeyPress);
            // 
            // gridClienti
            // 
            this.gridClienti.AllowUserToAddRows = false;
            this.gridClienti.AllowUserToResizeRows = false;
            this.gridClienti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridClienti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridClienti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridClienti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClienti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClienti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_CodFurnizor,
            this.col_Denumire,
            this.col_CUI,
            this.col_IBAN,
            this.col_Banca,
            this.col_PersContact,
            this.col_Telefon,
            this.col_Fax,
            this.col_Adresa,
            this.col_Oras,
            this.col_CodPostal,
            this.col_Regiune,
            this.col_Tara});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridClienti.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridClienti.EnableHeadersVisualStyles = false;
            this.gridClienti.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridClienti.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridClienti.Location = new System.Drawing.Point(33, 354);
            this.gridClienti.MultiSelect = false;
            this.gridClienti.Name = "gridClienti";
            this.gridClienti.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridClienti.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridClienti.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridClienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClienti.Size = new System.Drawing.Size(809, 163);
            this.gridClienti.TabIndex = 70;
            // 
            // btnSpreComenzi
            // 
            this.btnSpreComenzi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(124)))));
            this.btnSpreComenzi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpreComenzi.Location = new System.Drawing.Point(500, 523);
            this.btnSpreComenzi.Name = "btnSpreComenzi";
            this.btnSpreComenzi.Size = new System.Drawing.Size(110, 42);
            this.btnSpreComenzi.TabIndex = 79;
            this.btnSpreComenzi.Text = "Spre comenzi";
            this.btnSpreComenzi.UseCustomBackColor = true;
            this.btnSpreComenzi.UseCustomForeColor = true;
            this.btnSpreComenzi.UseSelectable = true;
            this.btnSpreComenzi.Click += new System.EventHandler(this.btnSprePlati_Click);
            // 
            // col_CodFurnizor
            // 
            this.col_CodFurnizor.HeaderText = "Cod client";
            this.col_CodFurnizor.Name = "col_CodFurnizor";
            // 
            // col_Denumire
            // 
            this.col_Denumire.HeaderText = "Denumire";
            this.col_Denumire.Name = "col_Denumire";
            // 
            // col_CUI
            // 
            this.col_CUI.HeaderText = "C.U.I";
            this.col_CUI.Name = "col_CUI";
            // 
            // col_IBAN
            // 
            this.col_IBAN.HeaderText = "IBAN";
            this.col_IBAN.Name = "col_IBAN";
            // 
            // col_Banca
            // 
            this.col_Banca.HeaderText = "Banca";
            this.col_Banca.Name = "col_Banca";
            // 
            // col_PersContact
            // 
            this.col_PersContact.HeaderText = "Persoana contact";
            this.col_PersContact.Name = "col_PersContact";
            // 
            // col_Telefon
            // 
            this.col_Telefon.HeaderText = "Telefon";
            this.col_Telefon.Name = "col_Telefon";
            // 
            // col_Fax
            // 
            this.col_Fax.HeaderText = "Fax";
            this.col_Fax.Name = "col_Fax";
            // 
            // col_Adresa
            // 
            this.col_Adresa.HeaderText = "Adresa";
            this.col_Adresa.Name = "col_Adresa";
            // 
            // col_Oras
            // 
            this.col_Oras.HeaderText = "Oras";
            this.col_Oras.Name = "col_Oras";
            // 
            // col_CodPostal
            // 
            this.col_CodPostal.HeaderText = "Cod postal";
            this.col_CodPostal.Name = "col_CodPostal";
            // 
            // col_Regiune
            // 
            this.col_Regiune.HeaderText = "Regiune";
            this.col_Regiune.Name = "col_Regiune";
            // 
            // col_Tara
            // 
            this.col_Tara.HeaderText = "Tara";
            this.col_Tara.Name = "col_Tara";
            // 
            // Clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 583);
            this.Controls.Add(this.btnSpreComenzi);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridClienti);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Clienti";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Clienti";
            this.Load += new System.EventHandler(this.Clienti_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnAdauga;
        private MetroFramework.Controls.MetroButton btnModifica;
        private MetroFramework.Controls.MetroButton btnSterge;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroButton btnRenunta;
        private MetroFramework.Controls.MetroButton btnSalvare;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox txtAdresa;
        private MetroFramework.Controls.MetroComboBox cboOras;
        private MetroFramework.Controls.MetroTextBox txtRegiune;
        private MetroFramework.Controls.MetroTextBox txtCodPostal;
        private MetroFramework.Controls.MetroTextBox txtTara;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox cboBanca;
        private MetroFramework.Controls.MetroTextBox txtIBAN;
        private MetroFramework.Controls.MetroTextBox txtFax;
        private MetroFramework.Controls.MetroTextBox txtTelefon;
        private MetroFramework.Controls.MetroTextBox txtCUI;
        private MetroFramework.Controls.MetroTextBox txtPersContact;
        private MetroFramework.Controls.MetroTextBox txtDenumireClient;
        private MetroFramework.Controls.MetroTextBox txtCodClient;
        private MetroFramework.Controls.MetroGrid gridClienti;
        private MetroFramework.Controls.MetroButton btnSpreComenzi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CodFurnizor;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Denumire;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Banca;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PersContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Oras;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CodPostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Regiune;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Tara;
    }
}