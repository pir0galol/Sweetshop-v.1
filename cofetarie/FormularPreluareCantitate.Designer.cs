namespace cofetarie
{
    partial class FormularPreluareCantitate
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCantitateComandata = new MetroFramework.Controls.MetroTextBox();
            this.lblProdus = new MetroFramework.Controls.MetroLabel();
            this.btnConfirma = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(346, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Introduceti cantitatea comandata pentru produsul:";
            // 
            // txtCantitateComandata
            // 
            this.txtCantitateComandata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(49)))), ((int)(((byte)(63)))));
            // 
            // 
            // 
            this.txtCantitateComandata.CustomButton.Image = null;
            this.txtCantitateComandata.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtCantitateComandata.CustomButton.Name = "";
            this.txtCantitateComandata.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCantitateComandata.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantitateComandata.CustomButton.TabIndex = 1;
            this.txtCantitateComandata.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantitateComandata.CustomButton.UseSelectable = true;
            this.txtCantitateComandata.CustomButton.Visible = false;
            this.txtCantitateComandata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCantitateComandata.Lines = new string[0];
            this.txtCantitateComandata.Location = new System.Drawing.Point(207, 63);
            this.txtCantitateComandata.MaxLength = 32767;
            this.txtCantitateComandata.Name = "txtCantitateComandata";
            this.txtCantitateComandata.PasswordChar = '\0';
            this.txtCantitateComandata.WaterMark = "Cantitate";
            this.txtCantitateComandata.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantitateComandata.SelectedText = "";
            this.txtCantitateComandata.SelectionLength = 0;
            this.txtCantitateComandata.SelectionStart = 0;
            this.txtCantitateComandata.ShortcutsEnabled = true;
            this.txtCantitateComandata.Size = new System.Drawing.Size(104, 23);
            this.txtCantitateComandata.TabIndex = 59;
            this.txtCantitateComandata.UseCustomBackColor = true;
            this.txtCantitateComandata.UseCustomForeColor = true;
            this.txtCantitateComandata.UseSelectable = true;
            this.txtCantitateComandata.WaterMark = "Cantitate";
            this.txtCantitateComandata.WaterMarkColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtCantitateComandata.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantitateComandata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantitateComandata_KeyPress);
            // 
            // lblProdus
            // 
            this.lblProdus.AutoSize = true;
            this.lblProdus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblProdus.ForeColor = System.Drawing.Color.Maroon;
            this.lblProdus.Location = new System.Drawing.Point(373, 27);
            this.lblProdus.Name = "lblProdus";
            this.lblProdus.Size = new System.Drawing.Size(0, 0);
            this.lblProdus.TabIndex = 60;
            this.lblProdus.UseCustomForeColor = true;
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnConfirma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirma.Location = new System.Drawing.Point(207, 90);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(104, 31);
            this.btnConfirma.TabIndex = 66;
            this.btnConfirma.Text = "Confirma";
            this.btnConfirma.UseCustomBackColor = true;
            this.btnConfirma.UseCustomForeColor = true;
            this.btnConfirma.UseSelectable = true;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(313, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(27, 19);
            this.metroLabel2.TabIndex = 67;
            this.metroLabel2.Text = "Kg";
            // 
            // FormularPreluareCantitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 144);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.lblProdus);
            this.Controls.Add(this.txtCantitateComandata);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularPreluareCantitate";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FormularPreluareCantitate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCantitateComandata;
        private MetroFramework.Controls.MetroLabel lblProdus;
        private MetroFramework.Controls.MetroButton btnConfirma;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}