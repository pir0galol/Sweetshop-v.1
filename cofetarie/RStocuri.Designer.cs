namespace cofetarie
{
    partial class RStocuri
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.StocProduseFiniteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet_Stocuri = new cofetarie.DataSet_Stocuri();
            this.reportStocuri = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnRenunta = new MetroFramework.Controls.MetroButton();
            this.btnAfisare = new MetroFramework.Controls.MetroButton();
            this.StocProduseFiniteTableAdapter = new cofetarie.DataSet_StocuriTableAdapters.StocProduseFiniteTableAdapter();
            this.txtProdus = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StocProduseFiniteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Stocuri)).BeginInit();
            this.SuspendLayout();
            // 
            // StocProduseFiniteBindingSource
            // 
            this.StocProduseFiniteBindingSource.DataMember = "StocProduseFinite";
            this.StocProduseFiniteBindingSource.DataSource = this.DataSet_Stocuri;
            // 
            // DataSet_Stocuri
            // 
            this.DataSet_Stocuri.DataSetName = "DataSet_Stocuri";
            this.DataSet_Stocuri.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportStocuri
            // 
            reportDataSource1.Name = "StocProduseFinite";
            reportDataSource1.Value = this.StocProduseFiniteBindingSource;
            this.reportStocuri.LocalReport.DataSources.Add(reportDataSource1);
            this.reportStocuri.LocalReport.ReportEmbeddedResource = "cofetarie.Raport_Stocuri.rdlc";
            this.reportStocuri.Location = new System.Drawing.Point(23, 104);
            this.reportStocuri.Name = "reportStocuri";
            this.reportStocuri.ServerReport.BearerToken = null;
            this.reportStocuri.ShowFindControls = false;
            this.reportStocuri.Size = new System.Drawing.Size(667, 563);
            this.reportStocuri.TabIndex = 0;
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnRenunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRenunta.Location = new System.Drawing.Point(580, 75);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(110, 24);
            this.btnRenunta.TabIndex = 76;
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
            this.btnAfisare.Location = new System.Drawing.Point(158, 75);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(110, 22);
            this.btnAfisare.TabIndex = 75;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseCustomBackColor = true;
            this.btnAfisare.UseCustomForeColor = true;
            this.btnAfisare.UseSelectable = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // StocProduseFiniteTableAdapter
            // 
            this.StocProduseFiniteTableAdapter.ClearBeforeFill = true;
            // 
            // txtProdus
            // 
            // 
            // 
            // 
            this.txtProdus.CustomButton.Image = null;
            this.txtProdus.CustomButton.Location = new System.Drawing.Point(107, 1);
            this.txtProdus.CustomButton.Name = "";
            this.txtProdus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProdus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProdus.CustomButton.TabIndex = 1;
            this.txtProdus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProdus.CustomButton.UseSelectable = true;
            this.txtProdus.CustomButton.Visible = false;
            this.txtProdus.Lines = new string[0];
            this.txtProdus.Location = new System.Drawing.Point(23, 74);
            this.txtProdus.MaxLength = 32767;
            this.txtProdus.Name = "txtProdus";
            this.txtProdus.PasswordChar = '\0';
            this.txtProdus.WaterMark = "Cauta produs";
            this.txtProdus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProdus.SelectedText = "";
            this.txtProdus.SelectionLength = 0;
            this.txtProdus.SelectionStart = 0;
            this.txtProdus.ShortcutsEnabled = true;
            this.txtProdus.Size = new System.Drawing.Size(129, 23);
            this.txtProdus.TabIndex = 77;
            this.txtProdus.UseSelectable = true;
            this.txtProdus.WaterMark = "Cauta produs";
            this.txtProdus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProdus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RStocuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 690);
            this.Controls.Add(this.txtProdus);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.reportStocuri);
            this.Name = "RStocuri";
            this.Resizable = false;
            this.Text = "Situatie stocuri produse finite";
            this.Load += new System.EventHandler(this.RStocuri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StocProduseFiniteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet_Stocuri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportStocuri;
        private MetroFramework.Controls.MetroButton btnRenunta;
        private MetroFramework.Controls.MetroButton btnAfisare;
        private System.Windows.Forms.BindingSource StocProduseFiniteBindingSource;
        private DataSet_Stocuri DataSet_Stocuri;
        private DataSet_StocuriTableAdapters.StocProduseFiniteTableAdapter StocProduseFiniteTableAdapter;
        private MetroFramework.Controls.MetroTextBox txtProdus;
    }
}