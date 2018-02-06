using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace cofetarie
{
    public partial class ComenziC : MetroFramework.Forms.MetroForm
    {
        static string conexiune = @"Server=127.0.0.1;Port=5432;Database=cofetarie;User Id=postgres;
                                                        Password = postgres;";
        NpgsqlConnection conn = new NpgsqlConnection(conexiune);
        public static string nume_produs;
        public static int pestoc;
        bool valid;

        public ComenziC()
        {
            InitializeComponent();
            loadProperties();
        }
        void loadProperties()
        {
            // GridProduseStoc -proprietati-
            gridProduseStoc.MultiSelect = false;
            gridProduseStoc.AllowUserToResizeColumns = false;
            gridProduseStoc.AllowUserToResizeRows = false;
            gridProduseStoc.AllowUserToAddRows = false;
            colDenumire.ReadOnly = true;
            colPretPerKg.ReadOnly = true;
            colPeStoc.ReadOnly = true;
            gridProduseStoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            gridProduseStoc.SelectionMode = DataGridViewSelectionMode.CellSelect;
            // Data livrare
            dtDataLivrare.Enabled = false;
            cboMetodaLivrare.Enabled = true;
            // Button Save
            btnSaveComanda.Enabled = false;
            // Grid comanda
            //Inseram un rand nou in gridComanda (intrucat am restrictionat userul sa adauge el)
            gridComanda.Rows.Add(null, null, null, null, null, null);
            colNumeProdus.ReadOnly = true;
            colPretUnitar.ReadOnly = true;
            colCantitate.ReadOnly = true;
            colTotalProdus.ReadOnly = true;
            col_TotalComanda.ReadOnly = true;
            colTVA.MaxInputLength = 4;
            gridComanda.AllowUserToAddRows = false;
            gridComanda.AllowUserToDeleteRows = false;
            gridComanda.MultiSelect = false;
            gridComanda.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }
        void populeazaAngajati()
        {
            string query = "SELECT nume, prenume FROM Angajati";
            try
            {
                using (conn = new NpgsqlConnection(conexiune))
                {
                    conn.Open();
                    using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            using (NpgsqlDataReader reader = comanda.ExecuteReader())
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    cboAlegeAngajat.Items.Add(row[0].ToString() + " " + row[1].ToString());
                                }
                            }
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu se pot incarca angajatii.\nA aparut o problema:\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void populeazaClienti()
        {
            string query = @"SELECT client_nume FROM Clienti";
            try
            {
                using (conn = new NpgsqlConnection(conexiune))
                {
                    conn.Open();
                    using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                    {
                        comanda.CommandType = CommandType.Text;
                        comanda.ExecuteNonQuery();
                        using (DataTable dt = new DataTable())
                        {
                            using (NpgsqlDataReader reader = comanda.ExecuteReader())
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    cboAlegeClient.Items.Add(row[0].ToString());
                                }
                            }
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu se pot incarca clientii.\nA aparut o eroare.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void populeazaMetodeLivrare()
        {
            string query = @"SELECT metodalivrare FROM metodelivrare";
            try
            {
                using (conn = new NpgsqlConnection(conexiune))
                {
                    conn.Open();
                    using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                    {
                        comanda.CommandType = CommandType.Text;
                        comanda.ExecuteNonQuery();
                        using (DataTable dt = new DataTable())
                        {
                            using (NpgsqlDataReader reader = comanda.ExecuteReader())
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    cboMetodaLivrare.Items.Add(row[0].ToString());
                                }
                            }
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu se pot incarca modalitatile de livrare.\nA aparut o eroare.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void fromGrid1ToGrid2()
        {
            try
            {
                // Verificam intai daca exista vreun item in gridProduseStoc;
                if (gridProduseStoc.Rows.Count > 0)
                {
                    // Verificam daca am selectat deja un rand din acel grid;
                    if (gridProduseStoc.SelectedCells.Count == 1)
                    {
                        // Retinem in variabile indexul curent al randului, numele produsului si pretul;
                        int idx = gridProduseStoc.CurrentRow.Index;
                        nume_produs = gridProduseStoc.Rows[idx].Cells[0].Value.ToString();
                        pestoc = int.Parse(gridProduseStoc.Rows[idx].Cells[1].Value.ToString());
                        int pretperkg = int.Parse(gridProduseStoc.Rows[idx].Cells[2].Value.ToString());
                        // Daca avem pe stoc produsul (Kg pe stoc > 0)
                        if (int.Parse(gridProduseStoc.Rows[idx].Cells[1].Value.ToString()) > 0)
                        {
                            // Se va introduce Q comandata
                            using (FormularPreluareCantitate preluareQ = new FormularPreluareCantitate())
                            {
                                preluareQ.ShowDialog();
                                if (preluareQ.cantitate == 0)
                                {
                                    //
                                }
                                else
                                {
                                    // Aflam cantitatea ramasa pe stoc
                                    int cantitate_ramasa = pestoc - preluareQ.cantitate;
                                    // Actualizam grid-ul
                                    gridProduseStoc.Rows[idx].Cells[1].Value = cantitate_ramasa;
                                    gridProduseStoc.Refresh();
                                    //Actualizam BD
                                    actualizeazaStoc(cantitate_ramasa, genereazaCodProdus(nume_produs));


                                    // Iteram grid-ul gridComanda si inseram variabilele anterioare in randul liber
                                    for (int i = 0; i < gridComanda.Rows.Count; ++i)
                                    {
                                        if (gridComanda.Rows[i].Cells[0].Value != null)
                                        {
                                            if (gridComanda.Rows[i].Cells[0].Value.ToString() == nume_produs)
                                            {
                                                gridComanda.Rows[i].Cells[1].Value = int.Parse(gridComanda.Rows[i].Cells[1].Value.ToString()) + preluareQ.cantitate;
                                                updateTotal();
                                                break;
                                            }
                                        }
                                        else
                                        {
                                            if (gridComanda.Rows[i].Cells[0].Value == null)
                                            {
                                                //Inseram un rand nou in gridComanda (intrucat am restrictionat userul sa adauge el)
                                                gridComanda.Rows.Add(null, null, null, null, null, null);
                                                gridComanda.Rows[i].Cells[0].Value = nume_produs;
                                                gridComanda.Rows[i].Cells[1].Value = preluareQ.cantitate;
                                                gridComanda.Rows[i].Cells[2].Value = pretperkg;
                                                break;

                                            }
                                        }


                                    }

                                }
                            }
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Produsul " + nume_produs + " nu mai este pe stoc.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "S-a produs o problema:\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void fromGrid2ToGrid1()
        {
            try
            {
                if (gridComanda.Rows.Count > 0)
                {
                    if (gridComanda.SelectedCells.Count == 1)
                    {
                        // Indexul randului si elementele randului (nume produs, cantitate, total)
                        int idx = gridComanda.CurrentRow.Index;
                        string nume_produs = gridComanda.Rows[idx].Cells[0].Value.ToString();
                        int q = int.Parse(gridComanda.Rows[idx].Cells[1].Value.ToString());
                        if (gridComanda.Rows[idx].Cells[4].Value == null)
                        {
                            // Inseamna ca nu avem calculat inca totalurile
                            // caz in care putem elimina (daca dorim) randul curent
                            // reactualizand stocul initial
                            foreach (DataGridViewRow row in gridProduseStoc.Rows)
                            {
                                if (nume_produs == row.Cells[0].Value.ToString())
                                {
                                    row.Cells[1].Value = int.Parse(row.Cells[1].Value.ToString()) + q;
                                    int valoare = int.Parse(row.Cells[1].Value.ToString());
                                    // Actualizam BD
                                    actualizeazaStoc(valoare, genereazaCodProdus(nume_produs));
                                    // Stergem randul curent
                                    gridComanda.Rows.RemoveAt(idx);
                                    gridComanda.Refresh();
                                }
                            }
                        }
                        else
                        {
                            // Daca exista totaluri calculate in grid (inseamna ca 
                            // a fost introdusa o valoare de TVA si s-au calculat
                            // totalurile - produs/general)
                            double total_produs = double.Parse(gridComanda.Rows[idx].Cells[4].Value.ToString());
                            if (idx == 0)
                            {
                                double total_produs_pe_idx_0 = double.Parse(gridComanda.Rows[0].Cells[4].Value.ToString());
                                foreach (DataGridViewRow row in gridProduseStoc.Rows)
                                {
                                    if (nume_produs == row.Cells[0].Value.ToString())
                                    {
                                        row.Cells[1].Value = int.Parse(row.Cells[1].Value.ToString()) + q;
                                        int valoare = int.Parse(row.Cells[1].Value.ToString());
                                        // Actualizam BD
                                        actualizeazaStoc(valoare, genereazaCodProdus(nume_produs));
                                        // Actualizam totalul general
                                        gridComanda.Rows[0].Cells[5].Value = double.Parse(gridComanda.Rows[0].Cells[5].Value.ToString()) - total_produs_pe_idx_0;
                                        // Stergem randul curent
                                        gridComanda.Rows.RemoveAt(idx);
                                        gridComanda.Refresh();
                                        updateTotal();
                                        if (gridComanda.Rows.Count == 0) btnSaveComanda.Enabled = false;
                                    }
                                }
                            }
                            else
                            {
                                // Iteram gridStoc pentru a reactualiza stocul pentru produsul selectat
                                foreach (DataGridViewRow row in gridProduseStoc.Rows)
                                {
                                    if (nume_produs == row.Cells[0].Value.ToString())
                                    {
                                        row.Cells[1].Value = int.Parse(row.Cells[1].Value.ToString()) + q;
                                        int valoare = int.Parse(row.Cells[1].Value.ToString());
                                        // Actualizam BD
                                        actualizeazaStoc(valoare, genereazaCodProdus(nume_produs));
                                        // Actualizam totalul general
                                        gridComanda.Rows[0].Cells[5].Value = double.Parse(gridComanda.Rows[0].Cells[5].Value.ToString()) - total_produs;
                                        // Stergem randul curent
                                        gridComanda.Rows.RemoveAt(idx);
                                        gridComanda.Refresh();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "A aparut o problema cu preluarea datelor.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        void checkBeforeInsert()
        {
            if (string.IsNullOrWhiteSpace(txtNrComanda.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Numarul comenzii nu este introdus/valid.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valid = false;
            }
            else
            {
                if (cboAlegeAngajat.SelectedIndex == -1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Inserati numele angajatului raspunzator. >:)", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    valid = false;
                }
                else
                {
                    if (cboAlegeClient.SelectedIndex == -1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Inserati numele clientului.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        valid = false;
                    }
                    else
                    {
                        if (cboMetodaLivrare.SelectedIndex == -1)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Inserati metoda de livrare.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            valid = false;
                        }
                        else
                        {
                            if (dtDataComanda.Value > dtDataLimita.Value)
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Data comenzii nu poate fi mai mare decat data limita a acesteia.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                valid = false;
                            }
                            else
                            {
                                if (chkLivrata.Checked == false)
                                {
                                    checkGridBeforeInsert();
                                }
                                else
                                {
                                    if (dtDataComanda.Value > dtDataLivrare.Value)
                                    {
                                        MetroFramework.MetroMessageBox.Show(this, "Verificati data comenzii.\nHint: Data comenzii nu poate fi mai mare decat data livrarii acesteia.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        valid = false;
                                    }
                                    else
                                    {
                                        checkGridBeforeInsert();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        void checkGridBeforeInsert()
        {
            if (gridComanda.Rows.Count > 0)
            {
                try
                {
                    for (int i = 0; i < gridComanda.Rows.Count - 1; ++i)
                    {
                        if (gridComanda.Rows[i].Cells[0] != null)
                        {
                            if (gridComanda.Rows[i].Cells[3].Value == null)
                            {
                                valid = false;
                            }
                            else
                            {
                                if (gridComanda.Rows[i].Cells[4].Value == null)
                                {
                                    valid = false;
                                }
                                else
                                {
                                    valid = true;
                                }
                            }
                        }
                    }
                }
                catch (ArgumentNullException)
                {
                    //
                }
                catch (FormatException)
                {
                    //
                }
            }
        }
        void updateTotal()
        {
            // Initializam totalul general cu 0
            double total_general = 0;
            double cantitate, pret, tva, total_produs;
            try
            {
                for (int i = 0; i < gridComanda.Rows.Count; ++i)
                {
                    cantitate = 0;
                    pret = 0;
                    tva = 0;
                    // TVA
                    if (gridComanda.Rows[i].Cells[3].Value != null)
                    {
                        if (gridComanda.Rows[i].Cells[3].Value.ToString().Length != 0)
                        {
                            // As vrea sa preiau datele din grid doar daca este tva completat
                            // de aceea voi asigna variabilelor declarate anterior
                            // valorile din grid at. cand tva este introdus si valid
                            tva = double.Parse(gridComanda.Rows[i].Cells[3].Value.ToString());
                        }
                    }
                    else
                    {
                        return;
                    }
                    pret = double.Parse(gridComanda.Rows[i].Cells[2].Value.ToString());
                    cantitate = double.Parse(gridComanda.Rows[i].Cells[1].Value.ToString());
                    // Calculam totalul per produs
                    total_produs = Math.Truncate(generareTotalProdus(cantitate, pret, tva) * 100) / 100;
                    // Inseram totalul produsului in grid
                    gridComanda.Rows[i].Cells[4].Value = total_produs.ToString();
                    // Calculam totalul general
                    total_general = total_general + total_produs;
                    // Inseram totalul general in grid si ii acordam un font specific
                    gridComanda.Rows[0].Cells[5].Value = total_general.ToString();
                    gridComanda.Rows[0].Cells[5].Style.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold);
                }
            }
            catch (NullReferenceException)
            {
                //
            }
            catch (Exception)
            {
                //
            }
        }
        void actualizeazaStoc(int xvaloare, int xcodprodus)
        {
            string query = @"update produse_finite set pestoc=" + xvaloare + " where produs_id=" + xcodprodus;
            try
            {
                using (conn = new NpgsqlConnection(conexiune))
                {
                    conn.Open();
                    using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                    {
                        comanda.CommandType = CommandType.Text;
                        comanda.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Eroare la actualizarea stocului.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        bool EnableOrDisableSaveButton()
        {
            try
            {
                foreach (DataGridViewRow row in gridComanda.Rows)
                {
                    bool isEnabled;
                    if (row.Cells[4].Value != null &&
                        row.Cells[4].Value.ToString() != "0")
                    {
                        isEnabled = true;
                        return isEnabled;
                    }
                    else
                    {
                        isEnabled = false;
                        return isEnabled;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        int genereazaCodProdus(string xdenumire)
        {
            string query = "select produs_id from produse_finite where denumire='" + xdenumire + "'";
            try
            {
                using (conn = new NpgsqlConnection(conexiune))
                {
                    conn.Open();
                    using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                    {
                        comanda.CommandType = CommandType.Text;
                        comanda.ExecuteNonQuery();
                        using (DataTable dt = new DataTable())
                        {
                            using (NpgsqlDataReader reader = comanda.ExecuteReader())
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    int cod_produs = int.Parse(row["produs_id"].ToString());
                                    return cod_produs;
                                }
                            }
                        }
                    }
                }
                return -1;
            }
            catch (NpgsqlException)
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu s-a putut prelua codul produsului.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return -1;
            }
        }
        int genereazaIDProdus(string xdenumire)
        {
            string query = "SELECT produs_id from produse_finite where denumire='" + xdenumire + "'";
            try
            {
                using (conn = new NpgsqlConnection(conexiune))
                {
                    conn.Open();
                    using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                    {
                        comanda.CommandType = CommandType.Text;
                        comanda.ExecuteNonQuery();
                        using (DataTable dt = new DataTable())
                        {
                            using (NpgsqlDataReader reader = comanda.ExecuteReader())
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    int id_produs = int.Parse(row["produs_id"].ToString());
                                    return id_produs;
                                }
                                return -1;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        int genereazaIDAngajat(string xdenumire)
        {
            string query = "select angajat_id, nume ||' '|| prenume as numeprenume from angajati";
            try
            {
                using (conn = new NpgsqlConnection(conexiune))
                {
                    conn.Open();
                    using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                    {
                        comanda.CommandType = CommandType.Text;
                        comanda.ExecuteNonQuery();
                        using (DataTable dt = new DataTable())
                        {
                            using (NpgsqlDataReader reader = comanda.ExecuteReader())
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    if (xdenumire == row["numeprenume"].ToString())
                                    {
                                        int angajat_id = int.Parse(row["angajat_id"].ToString());
                                        return angajat_id;
                                    }
                                }
                                return -1;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        int genereazaIDClient(string xdenumire)
        {
            string query = "SELECT client_id from clienti where client_nume='" + xdenumire + "'";
            try
            {
                using (conn = new NpgsqlConnection(conexiune))
                {
                    conn.Open();
                    using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                    {
                        comanda.CommandType = CommandType.Text;
                        comanda.ExecuteNonQuery();
                        using (DataTable dt = new DataTable())
                        {
                            using (NpgsqlDataReader reader = comanda.ExecuteReader())
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    int client_id = int.Parse(row["client_id"].ToString());
                                    return client_id;
                                }
                                return -1;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }
        int genereazaIDMetodaLivrare(string xdenumire)
        {
            string query = "select metodalivrare_id from metodelivrare where metodalivrare='" + xdenumire + "'";
            try
            {
                using (conn = new NpgsqlConnection(conexiune))
                {
                    conn.Open();
                    using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                    {
                        comanda.CommandType = CommandType.Text;
                        comanda.ExecuteNonQuery();
                        using (DataTable dt = new DataTable())
                        {
                            using (NpgsqlDataReader reader = comanda.ExecuteReader())
                            {
                                dt.Load(reader);
                                foreach (DataRow row in dt.Rows)
                                {
                                    int metoda_id = int.Parse(row["metodalivrare_id"].ToString());
                                    return metoda_id;
                                }
                                return -1;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                //
                return -1;
            }
        }
        double generareTotalProdus(double xcantitate, double xpret, double xtva)
        {
            try
            {
                double total_produs = (xcantitate * xpret) + (xcantitate * xpret) * xtva;
                return total_produs;
            }
            catch (FormatException)
            {
                MessageBox.Show("Format incorect.");
                return 0.0;
            }
        }
        private void txtNrComanda_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNrComanda.MaxLength = 3;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cboAlegeAngajat_DropDown(object sender, EventArgs e)
        {
            cboAlegeAngajat.Items.Clear();
            populeazaAngajati();
        }
        private void cboAlegeClient_DropDown(object sender, EventArgs e)
        {
            cboAlegeClient.Items.Clear();
            populeazaClienti();
        }
        private void cboMetodaLivrare_DropDown(object sender, EventArgs e)
        {
            cboMetodaLivrare.Items.Clear();
            populeazaMetodeLivrare();
        }
        private void chkLivrata_CheckedChanged(object sender, EventArgs e)
        {
            // Destul de intuitiv: daca este livrata comanda, "dtDataLivrare" 
            // va fi activa pentru introducerea datei livrarii; daca nu, nu;
            if (chkLivrata.Checked == true)
            {
                dtDataLivrare.Enabled = true;
            }
            else
            {
                dtDataLivrare.Enabled = false;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string query = @"select denumire, pestoc, pretperkg from produse_finite order by 1";
            try
            {
                using (conn = new NpgsqlConnection(conexiune))
                {
                    conn.Open();
                    using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            using (NpgsqlDataReader reader = comanda.ExecuteReader())
                            {
                                dt.Load(reader);
                                gridProduseStoc.Columns[0].DataPropertyName = "denumire";
                                gridProduseStoc.Columns[1].DataPropertyName = "pestoc";
                                gridProduseStoc.Columns[2].DataPropertyName = "pretperkg";
                                gridProduseStoc.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu se poate incarca lista.\nProblema:\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnRenunta_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void gridProduseStoc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fromGrid1ToGrid2();
        }
        private void gridComanda_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fromGrid2ToGrid1();
        }
        private void btnTotal_Click(object sender, EventArgs e)
        {
            updateTotal();
            bool result = EnableOrDisableSaveButton();
            if (result == true)
            {
                btnSaveComanda.Enabled = true;
            }
            else
            {
                btnSaveComanda.Enabled = false;
            }
        }
        private void gridComanda_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Coloana TVA
            e.Control.KeyPress -= new KeyPressEventHandler(colTVA_KeyPress);
            if (gridComanda.CurrentCell.ColumnIndex == 1) // Coloana pretului unitar
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(colTVA_KeyPress);
                }
            }
        }
        private void btnSaveComanda_Click(object sender, EventArgs e)
        {
            string query = @"insert into comenzi_clienti (comandac_id, client_id, angajat_id, metodalivrare_id, datacomanda, datalimita, datalivrare) 
                                values (@comandaid, @clientid, @angajatid, @metodaid, @datac, @datalim, @dataliv)";
            string query_detalii = @"insert into detalii_comanda (comandac_id, produs_id, pretperkg, cantitate, tva, total) 
                                          values (@comandaid, @produsid, @pret, @q, @tva, @total)";
            NpgsqlConnection conn = new NpgsqlConnection(conexiune);
            NpgsqlCommand comanda_detalii = new NpgsqlCommand(query_detalii, conn);
            NpgsqlCommand comanda = new NpgsqlCommand(query, conn);
            if (gridComanda.Rows.Count - 1 == 0)
            {
                valid = false;
            }
            checkBeforeInsert();
            MessageBox.Show("Valid?" + valid);
            if (valid == true)
            {
                try
                {
                    conn.Open();
                    comanda.Parameters.Clear();
                    comanda.Parameters.AddWithValue("@comandaid", int.Parse(txtNrComanda.Text));
                    comanda.Parameters.AddWithValue("@clientid", genereazaIDClient(cboAlegeClient.SelectedItem.ToString()));
                    comanda.Parameters.AddWithValue("@angajatid", genereazaIDAngajat(cboAlegeAngajat.SelectedItem.ToString()));
                    comanda.Parameters.AddWithValue("@metodaid", genereazaIDMetodaLivrare(cboMetodaLivrare.SelectedItem.ToString()));
                    comanda.Parameters.AddWithValue("@datac", dtDataComanda.Value);
                    comanda.Parameters.AddWithValue("@datalim", dtDataLimita.Value);
                    if (chkLivrata.Checked == false)
                    {
                        comanda.Parameters.AddWithValue("@dataliv", dtDataLivrare.Value);
                    }
                    else
                    {
                        comanda.Parameters.AddWithValue("@dataliv", DBNull.Value);
                    }
                    comanda.CommandType = CommandType.Text;
                    comanda.ExecuteNonQuery();
                    // Detaliile comenzii
                    for (int i = 0; i < gridComanda.Rows.Count -1; ++i)
                    {
                        comanda_detalii.Parameters.Clear();
                        comanda_detalii.Parameters.AddWithValue("@comandaid", int.Parse(txtNrComanda.Text));
                        comanda_detalii.Parameters.AddWithValue("@produsid", genereazaIDProdus(gridComanda[0, i].Value.ToString()));
                        comanda_detalii.Parameters.AddWithValue("@q", double.Parse(gridComanda[1, i].Value.ToString()));
                        comanda_detalii.Parameters.AddWithValue("@pret", double.Parse(gridComanda[2,i].Value.ToString()));
                        comanda_detalii.Parameters.AddWithValue("@tva", double.Parse(gridComanda[3, i].Value.ToString()));
                        comanda_detalii.Parameters.AddWithValue("@total", double.Parse(gridComanda[4, i].Value.ToString()));
                        comanda_detalii.CommandType = CommandType.Text;
                        comanda_detalii.ExecuteNonQuery();
                    }
                    conn.Close();
                    DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, @"Comanda cu nr. " + txtNrComanda.Text +
                                            " a fost inregistrata cu succes!\nDoriti sa inregistrati alta comanda?",
                                            "Comanda inregistrata", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        using (ComenziC comenzic = new ComenziC())
                        {
                            Hide();
                            comenzic.ShowDialog();
                        }
                    }
                    else
                    {
                        Close();
                    }

                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("O mica eroare a intervenit:\n" + ex);
                }
            }
        }
        private void colTVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnSpreFacturi_Click(object sender, EventArgs e)
        {
            using (Facturi f = new Facturi())
            {
                f.ShowDialog();
            }
        }
    }
}
