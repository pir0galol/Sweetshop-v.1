using System;
using System.Windows.Forms;

namespace cofetarie
{
    public partial class MenuPrincipal:MetroFramework.Forms.MetroForm
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

      

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void furnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Furnizori load_furn = new Furnizori())
            {
                load_furn.ShowDialog();
  
            }
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Clienti clienti = new Clienti())
            {
                clienti.ShowDialog();
                              
            }

        }

        private void angajatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Angajati Formular_Angajati = new Angajati())
            {
                Formular_Angajati.ShowDialog();
            }
        }

        private void furnizoriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (ComenziF comenziFurn = new ComenziF())
            {
                comenziFurn.ShowDialog();
            }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MetroFramework.MetroMessageBox.Show(this, "Iesire din aplicatie?", "Iesire", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void facturiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Facturi facturi = new Facturi())
            {
                facturi.ShowDialog();
            }
        }


        private void clientiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (ComenziC c = new ComenziC())
            {
                c.ShowDialog();
            }
        }

        private void platiFurnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Plati plati = new Plati())
            {
                plati.ShowDialog();
            }
        }

        private void platiClientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PlatiClienti platiclienti = new PlatiClienti())
            {
                platiclienti.ShowDialog();
            }
        }

        private void situatiaComenzilorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (RComenziFurnizori r = new RComenziFurnizori())
                {
                    r.ShowDialog();
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void situatiaComenzilorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (RComenziClienti rc = new RComenziClienti())
            {
                rc.ShowDialog();
            }
        }

        private void situatieStocuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (RStocuri s = new RStocuri())
            {
                s.ShowDialog();
            }
        }

        private void profitPierdereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (RProfitPierdere rpp = new RProfitPierdere())
            {
                rpp.ShowDialog();
            }
        }
    }
    
}
