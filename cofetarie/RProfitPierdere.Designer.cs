namespace cofetarie
{
    partial class RProfitPierdere
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnRenunta = new MetroFramework.Controls.MetroButton();
            this.btnAfisare = new MetroFramework.Controls.MetroButton();
            this.cboLuna = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "cofetarie.ProfitPierdere.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 122);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.Size = new System.Drawing.Size(611, 385);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnRenunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRenunta.Location = new System.Drawing.Point(524, 92);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(110, 24);
            this.btnRenunta.TabIndex = 79;
            this.btnRenunta.Text = "Inchide";
            this.btnRenunta.UseCustomBackColor = true;
            this.btnRenunta.UseCustomForeColor = true;
            this.btnRenunta.UseSelectable = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnAfisare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAfisare.Location = new System.Drawing.Point(150, 92);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(110, 24);
            this.btnAfisare.TabIndex = 78;
            this.btnAfisare.Text = "Afisare ";
            this.btnAfisare.UseCustomBackColor = true;
            this.btnAfisare.UseCustomForeColor = true;
            this.btnAfisare.UseSelectable = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // cboLuna
            // 
            this.cboLuna.FormattingEnabled = true;
            this.cboLuna.ItemHeight = 23;
            this.cboLuna.Location = new System.Drawing.Point(23, 87);
            this.cboLuna.Name = "cboLuna";
            this.cboLuna.PromptText = "Luna";
            this.cboLuna.Size = new System.Drawing.Size(121, 29);
            this.cboLuna.TabIndex = 80;
            this.cboLuna.UseSelectable = true;
            this.cboLuna.DropDown += new System.EventHandler(this.cboLuna_DropDown);
            // 
            // RProfitPierdere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 538);
            this.Controls.Add(this.cboLuna);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RProfitPierdere";
            this.Resizable = false;
            this.Text = "Situatie profit/pierdere";
            this.Load += new System.EventHandler(this.RProfitPierdere_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MetroFramework.Controls.MetroButton btnRenunta;
        private MetroFramework.Controls.MetroButton btnAfisare;
        private MetroFramework.Controls.MetroComboBox cboLuna;
    }
}