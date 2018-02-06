namespace cofetarie
{
    partial class RComenziFurnizori
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new cofetarie.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnAfisare = new MetroFramework.Controls.MetroButton();
            this.rbnNelivrate = new MetroFramework.Controls.MetroRadioButton();
            this.rbnLivrate = new MetroFramework.Controls.MetroRadioButton();
            this.DataTable1TableAdapter = new cofetarie.DataSet1TableAdapters.DataTable1TableAdapter();
            this.btnRenunta = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "cofetarie.RComenziFurn.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 162);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(1116, 319);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnAfisare
            // 
            this.btnAfisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnAfisare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAfisare.Location = new System.Drawing.Point(20, 132);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(110, 24);
            this.btnAfisare.TabIndex = 74;
            this.btnAfisare.Text = "Afiseaza";
            this.btnAfisare.UseCustomBackColor = true;
            this.btnAfisare.UseCustomForeColor = true;
            this.btnAfisare.UseSelectable = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // rbnNelivrate
            // 
            this.rbnNelivrate.AutoSize = true;
            this.rbnNelivrate.Location = new System.Drawing.Point(23, 105);
            this.rbnNelivrate.Name = "rbnNelivrate";
            this.rbnNelivrate.Size = new System.Drawing.Size(70, 15);
            this.rbnNelivrate.TabIndex = 75;
            this.rbnNelivrate.Text = "Nelivrate";
            this.rbnNelivrate.UseSelectable = true;
            // 
            // rbnLivrate
            // 
            this.rbnLivrate.AutoSize = true;
            this.rbnLivrate.Location = new System.Drawing.Point(23, 84);
            this.rbnLivrate.Name = "rbnLivrate";
            this.rbnLivrate.Size = new System.Drawing.Size(58, 15);
            this.rbnLivrate.TabIndex = 76;
            this.rbnLivrate.Text = "Livrate";
            this.rbnLivrate.UseSelectable = true;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnRenunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRenunta.Location = new System.Drawing.Point(1026, 132);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(110, 24);
            this.btnRenunta.TabIndex = 78;
            this.btnRenunta.Text = "Inchide";
            this.btnRenunta.UseCustomBackColor = true;
            this.btnRenunta.UseCustomForeColor = true;
            this.btnRenunta.UseSelectable = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // RComenziFurnizori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 504);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.rbnLivrate);
            this.Controls.Add(this.rbnNelivrate);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RComenziFurnizori";
            this.ShowIcon = false;
            this.Text = "Situatia comenzilor furnizorilor";
            this.Load += new System.EventHandler(this.RComenziFurnizori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private MetroFramework.Controls.MetroButton btnAfisare;
        private MetroFramework.Controls.MetroRadioButton rbnNelivrate;
        private MetroFramework.Controls.MetroRadioButton rbnLivrate;
        private MetroFramework.Controls.MetroButton btnRenunta;
    }
}