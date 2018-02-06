namespace cofetarie
{
    partial class RaportComenziClienti
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
            this.report1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // report1
            // 
            this.report1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.report1.LocalReport.ReportEmbeddedResource = "cofetarie.Report_ComenziC.rdlc";
            this.report1.Location = new System.Drawing.Point(20, 60);
            this.report1.Name = "report1";
            this.report1.ServerReport.BearerToken = null;
            this.report1.Size = new System.Drawing.Size(636, 514);
            this.report1.TabIndex = 0;
            // 
            // RaportComenziClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 594);
            this.Controls.Add(this.report1);
            this.Name = "RaportComenziClienti";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.RaportComenziClienti_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer report1;
    }
}