namespace cofetarie
{
    partial class RComenziClienti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridComenzi = new MetroFramework.Controls.MetroGrid();
            this.colNrComanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDenClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenereaza = new MetroFramework.Controls.MetroButton();
            this.btnAfisare = new MetroFramework.Controls.MetroButton();
            this.btnRenunta = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridComenzi)).BeginInit();
            this.SuspendLayout();
            // 
            // gridComenzi
            // 
            this.gridComenzi.AllowUserToResizeRows = false;
            this.gridComenzi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridComenzi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridComenzi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridComenzi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridComenzi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.gridComenzi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridComenzi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNrComanda,
            this.colDenClient,
            this.colOras,
            this.colTelefon});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridComenzi.DefaultCellStyle = dataGridViewCellStyle14;
            this.gridComenzi.EnableHeadersVisualStyles = false;
            this.gridComenzi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridComenzi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridComenzi.Location = new System.Drawing.Point(23, 121);
            this.gridComenzi.Name = "gridComenzi";
            this.gridComenzi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridComenzi.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.gridComenzi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridComenzi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridComenzi.Size = new System.Drawing.Size(444, 335);
            this.gridComenzi.TabIndex = 0;
            // 
            // colNrComanda
            // 
            this.colNrComanda.HeaderText = "Nr. comanda";
            this.colNrComanda.Name = "colNrComanda";
            // 
            // colDenClient
            // 
            this.colDenClient.HeaderText = "Denumire client";
            this.colDenClient.Name = "colDenClient";
            // 
            // colOras
            // 
            this.colOras.HeaderText = "Oras";
            this.colOras.Name = "colOras";
            // 
            // colTelefon
            // 
            this.colTelefon.HeaderText = "Nr. telefon";
            this.colTelefon.Name = "colTelefon";
            // 
            // btnGenereaza
            // 
            this.btnGenereaza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnGenereaza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenereaza.Location = new System.Drawing.Point(139, 91);
            this.btnGenereaza.Name = "btnGenereaza";
            this.btnGenereaza.Size = new System.Drawing.Size(110, 24);
            this.btnGenereaza.TabIndex = 76;
            this.btnGenereaza.Text = "Genereaza raport";
            this.btnGenereaza.UseCustomBackColor = true;
            this.btnGenereaza.UseCustomForeColor = true;
            this.btnGenereaza.UseSelectable = true;
            this.btnGenereaza.Click += new System.EventHandler(this.btnGenereaza_Click);
            // 
            // btnAfisare
            // 
            this.btnAfisare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btnAfisare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAfisare.Location = new System.Drawing.Point(23, 91);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(110, 24);
            this.btnAfisare.TabIndex = 75;
            this.btnAfisare.Text = "Afisare comenzi";
            this.btnAfisare.UseCustomBackColor = true;
            this.btnAfisare.UseCustomForeColor = true;
            this.btnAfisare.UseSelectable = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(48)))));
            this.btnRenunta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRenunta.Location = new System.Drawing.Point(354, 91);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(110, 24);
            this.btnRenunta.TabIndex = 77;
            this.btnRenunta.Text = "Inchide";
            this.btnRenunta.UseCustomBackColor = true;
            this.btnRenunta.UseCustomForeColor = true;
            this.btnRenunta.UseSelectable = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // RComenziClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 493);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnGenereaza);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.gridComenzi);
            this.Name = "RComenziClienti";
            this.Resizable = false;
            this.Text = "Raport comenzi clienti";
            this.Load += new System.EventHandler(this.RComenziClienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridComenzi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridComenzi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNrComanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDenClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOras;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefon;
        private MetroFramework.Controls.MetroButton btnGenereaza;
        private MetroFramework.Controls.MetroButton btnAfisare;
        private MetroFramework.Controls.MetroButton btnRenunta;
    }
}