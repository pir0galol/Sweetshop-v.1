using System;
using System.Windows.Forms;


namespace cofetarie
{
    public partial class FormularPreluareCantitate : MetroFramework.Forms.MetroForm
    {

        public int cantitate { get; set; }
        public FormularPreluareCantitate()
        {
            InitializeComponent();
        }

        private void txtCantitateComandata_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCantitateComandata.MaxLength = 3;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCantitateComandata.Text) || txtCantitateComandata.Text == "0")
            {
                MetroFramework.MetroMessageBox.Show(this, "Inserati o valoare. (diferita de 0)", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                cantitate = int.Parse(txtCantitateComandata.Text);
                if (cantitate > ComenziC.pestoc)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Cantitatea introdusa este prea mare.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Close();
                }
            }
        }

        private void FormularPreluareCantitate_Load(object sender, EventArgs e)
        {
            lblProdus.Text = ComenziC.nume_produs;
        }
    }
}
