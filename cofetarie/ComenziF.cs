using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace cofetarie
{
    public partial class ComenziF : MetroFramework.Forms.MetroForm
    {
        static string conexiune = @"Server=127.0.0.1;Port=5432;Database=cofetarie;User Id=postgres;
                                                        Password = postgres;";
        NpgsqlConnection conn = new NpgsqlConnection(conexiune);
        bool valid;
        string iSelectat { get; set; }
        List<string> materii_prime = new List<string>();
        List<string> lichide = new List<string>();
        List<string> bucati = new List<string>();
        List<string> kg = new List<string>();

        public ComenziF()
        {
            InitializeComponent();
        }
        private void ComenziF_Load(object sender, EventArgs e)
        {
            disableFields();
        }
        void disableFields()
        {
            //txtTelefon.Enabled = false;
            //txtFax.Enabled = false;
            //txtWebPage.Enabled = false;
            dtDataComanda.Enabled = false;
            dtDataLimita.Enabled = false;
            dtDataLivrare.Enabled = false;
            chkLivrata.Enabled = false;
            cboAlegeProdus.Enabled = false;
            gridProduse.Enabled = false;
            btnSaveComanda.Enabled = false;
            btnTotal.Enabled = false;

        }
        void populeazaFurnizori()
        {
            string query = @"SELECT furnizor_nume FROM Furnizori";
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
                                    cboAlegeFurnizor.Items.Add(row[0].ToString());
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu se pot incarca furnizorii.\nA aparut o eroare.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu se pot incarca angajatii.\nA aparut o problema:\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //void populeazaDateFurnizori()
        //{
        //    string query = @"SELECT telefon, fax, paginaweb 
        //                    FROM Furnizori
        //                    WHERE furnizor_nume=@nume";
        //    try
        //    {
        //        using (conn = new NpgsqlConnection(conexiune))
        //        {
        //            conn.Open();
        //            using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
        //            {
        //                comanda.Parameters.AddWithValue("@nume", cboAlegeFurnizor.SelectedItem.ToString());
        //                comanda.CommandType = CommandType.Text;
        //                comanda.ExecuteNonQuery();
        //                using (DataTable dt = new DataTable())
        //                {
        //                    using (NpgsqlDataReader reader = comanda.ExecuteReader())
        //                    {
        //                        dt.Load(reader);
        //                        foreach (DataRow row in dt.Rows)
        //                        {
        //                            txtTelefon.Text = row["telefon"].ToString();
        //                            txtFax.Text = row["fax"].ToString();
        //                            txtWebPage.Text = row["paginaweb"].ToString();
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MetroFramework.MetroMessageBox.Show(this, "A aparut o problema:\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private void txtNrComanda_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNrComanda.MaxLength = 3;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void cboAlegeFurnizor_DropDown(object sender, EventArgs e)
        {
            cboAlegeFurnizor.Items.Clear();
            populeazaFurnizori();
        }
        private void cboAlegeAngajat_DropDown(object sender, EventArgs e)
        {
            cboAlegeAngajat.Items.Clear();
            populeazaAngajati();
        }
        private void cboAlegeFurnizor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Apelam metoda "populeazaDateFurnizori()" pentru
            // popularea campurilor cu datele specifice fiecarui
            // furnizor
            //populeazaDateFurnizori();
            // Dupa selectarea unui furnizor, ii acordam utilizatorului
            // dreptul de merge mai departe, alegand datele comenzii
            activeazaDateComanda();
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
        void activeazaGridPartial()
        {
            gridProduse.Enabled = true;
            colNumeProdus.ReadOnly = true;
            colUnitateMasura.ReadOnly = true;
            colTotalProdus.ReadOnly = true;
            col_TotalComanda.ReadOnly = true;
        }
        void activeazaDateComanda()
        {
            dtDataComanda.Enabled = true;
            dtDataLimita.Enabled = true;
            chkLivrata.Enabled = true;
            activeazaGridPartial();
            cboAlegeProdus.Enabled = true;
            btnTotal.Enabled = true;
        }
        private void restrictiiCampuriGrid()
        {
            colPretUnitar.MaxInputLength = 5;
            colCantitate.MaxInputLength = 6;
            colDiscount.MaxInputLength = 4;
            colTVA.MaxInputLength = 4;
            gridProduse.Rows[0].ReadOnly = true;
        }
        private void gridProduse_EnabledChanged(object sender, EventArgs e)
        {
            if (gridProduse.Enabled == true)
            {
                restrictiiCampuriGrid();
                populareCuMateriiPrime();
                asignareUnitatiMasuraCorespunzatoare();
            }
            else
            {
                gridProduse.DataSource = null;
                cboAlegeProdus.DataSource = null;
            }

        }
        private void btnRenunta_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void populareCuMateriiPrime()
        {
            gridProduse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            string query = "SELECT denumire from Materii_Prime";
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
                                    materii_prime.Add(row[0].ToString());
                                }
                            }
                        }
                    }
                }
                foreach (string mp in materii_prime)
                {
                    cboAlegeProdus.Items.Add(mp);
                    cboAlegeProdus.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "A aparut o problema:\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gridProduse_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // Coloana pret unitar
            e.Control.KeyPress -= new KeyPressEventHandler(colPretUnitar_KeyPress);
            if (gridProduse.CurrentCell.ColumnIndex == 1) // Coloana pretului unitar
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(colPretUnitar_KeyPress);
                }
            }
            // Coloana cantitate
            e.Control.KeyPress -= new KeyPressEventHandler(colCantitate_KeyPress);
            if (gridProduse.CurrentCell.ColumnIndex == 2) // Coloana pretului unitar
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(colCantitate_KeyPress);
                }
            }
            // Discount
            e.Control.KeyPress -= new KeyPressEventHandler(colDiscount_KeyPress);
            if (gridProduse.CurrentCell.ColumnIndex == 4) // Coloana pretului unitar
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(colDiscount_KeyPress);
                }
            }
            // TVA
            e.Control.KeyPress -= new KeyPressEventHandler(colTVA_KeyPress);
            if (gridProduse.CurrentCell.ColumnIndex == 5) // Coloana pretului unitar
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(colTVA_KeyPress);
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
        private void colDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void colCantitate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void colPretUnitar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void cboAlegeProdus_KeyDown(object sender, KeyEventArgs e)
        {
            cboAlegeProdus.DroppedDown = false;
        }
        void asignareUnitatiMasuraCorespunzatoare()
        {
            foreach (string item in materii_prime)
            {
                if (item.Contains("Ulei") ||
                    item.Contains("Smantana") ||
                    item.Contains("Lapte"))
                {
                    lichide.Add(item);                  // Inseram produsele corespunzatoare in lista de "lichide";
                }
                if (item.Contains("Oua"))
                {
                    bucati.Add(item);                   // Inseram produsele corespunzatorare in lista de "bucati";
                }
                if (item.Contains("Faina") ||
                    item.Contains("Arahide") ||
                    item.Contains("Cacao") ||
                    item.Contains("Zahar") ||
                    item.Contains("Sare") ||
                    item.Contains("Ciocolata") ||
                    item.Contains("Gem") ||
                    item.Contains("Bomboane") ||
                    item.Contains("Caramel") ||
                    item.Contains("Dulceata"))
                {
                    kg.Add(item);                       // Inseram produsele corespunzatorare in lista cu "kg";
                }
            }
        }
        private void cboAlegeProdus_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cboAlegeProdus.Items.Count;)
            {
                iSelectat = cboAlegeProdus.SelectedItem.ToString();
                insertProdusInGrid();
                materii_prime.Remove(iSelectat);
                repopulareCombobox();
                break;
            }
        }
        void repopulareCombobox()
        {
            cboAlegeProdus.Items.Clear();
            cboAlegeProdus.ResetText();
            foreach (string item in materii_prime)
            {
                cboAlegeProdus.Items.Add(item);
            }
        }
        void insertProdusInGrid()
        {
            gridProduse.Rows.Add(null, null, null, null, null, null, null, null);
            for (int i = 0; i < gridProduse.Rows.Count - 1; ++i)
            {
                if (gridProduse.Rows[i].Cells[0].Value == null)
                {
                    gridProduse[0, i].Value = iSelectat;
                    if (lichide.Contains(iSelectat))
                    {
                        gridProduse[3, i].Value = "L";
                    }
                    else
                    {
                        if (kg.Contains(iSelectat))
                        {
                            gridProduse[3, i].Value = "kg";
                        }
                        else
                        {
                            if (bucati.Contains(iSelectat))
                            {
                                gridProduse[3, i].Value = "buc";
                            }
                        }
                    }
                    break;
                }
            }
        }
        void checkGrid()
        {
            try
            {
                for (int i = 0; i < gridProduse.Rows.Count - 1; ++i)
                {
                    if (gridProduse.Rows[i].Cells[6].Value == null ||
                        gridProduse.Rows[i].Cells[6].Value.ToString().Length == 0 ||
                        gridProduse.Rows[i].Cells[6].Value.ToString() == 0.ToString())
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Verificati lista de produse.\nHint: Posibil sa fi omis calculul unui total.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Verificati lista de produse. (err din try-catch)", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        void checkAllFieldsBeforeInsert()
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
                    if (cboAlegeFurnizor.SelectedIndex == -1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Inserati numele furnizorului.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        valid = false;
                    }
                    else
                    {
                        if (dtDataComanda.Value > dtDataLimita.Value)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Verificati data comenzii.\nHint: Data comenzii nu poate fi mai mare decat data limita a acesteia.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            valid = false;
                        }
                        else
                        {
                            if (chkLivrata.Checked == false)
                            {
                                checkGrid();
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
                                    checkGrid();
                                }
                            }
                        }
                    }
                }
            }
        }
        private double function(double x, double y)
        {
            double z = x * y;
            return z;
        }
        private double function_2(double m, double n)
        {
            double p = m - n;
            return p;
        }
        private double function_3(double r, double s)
        {
            double q = r + s;
            return q;
        }
        private double generareTotal(double pret_unitar, double cantitate, double discount, double tva)
        {
            double pret_fara_discount = function(pret_unitar, cantitate);
            double pret_cu_discount = function_2(pret_fara_discount, function(pret_fara_discount, discount));
            double pret_final = function_3(pret_cu_discount, function(pret_cu_discount, tva));
            return pret_final;
        }
        void updateTotal()
        {
            // Initializam totalul general cu valoarea 0
            double total_general = 0.0;
            double pret_unitar, cantitate, discount, tva, total_produs;
            // Custom font (BOLD) pentru total general
            //gridProduse[7, 0].Style.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold);
            try
            {


                for (int i = 0; i < gridProduse.Rows.Count - 1; ++i)
                {
                    pret_unitar = 0.0;
                    cantitate = 0.0;
                    discount = 0.0;
                    tva = 0.0;
                    // Pretul unitar
                    if (gridProduse.Rows[i].Cells[1].Value != null)
                    {
                        if (gridProduse.Rows[i].Cells[1].Value.ToString().Length != 0)
                        {
                            pret_unitar = double.Parse(gridProduse.Rows[i].Cells[1].Value.ToString());
                        }
                    }
                    // Cantitatea
                    if (gridProduse.Rows[i].Cells[2].Value != null)
                    {
                        if (gridProduse.Rows[i].Cells[2].Value.ToString().Length != 0)
                        {
                            cantitate = double.Parse(gridProduse.Rows[i].Cells[2].Value.ToString());
                        }
                    }
                    // Discount-ul
                    if (gridProduse.Rows[i].Cells[4].Value != null)
                    {
                        if (gridProduse.Rows[i].Cells[4].Value.ToString().Length != 0)
                        {
                            discount = double.Parse(gridProduse.Rows[i].Cells[4].Value.ToString());
                        }
                    }
                    else
                    {
                        discount = 0.0;
                        gridProduse[4, i].Value = discount.ToString();
                    }
                    // TVA
                    if (gridProduse.Rows[i].Cells[5].Value != null)
                    {
                        if (gridProduse.Rows[i].Cells[5].Value.ToString().Length != 0)
                        {
                            tva = double.Parse(gridProduse.Rows[i].Cells[5].Value.ToString());
                        }
                    }
                    // Calculam totalul per produs (cu 2 zecimale)
                    total_produs = Math.Truncate(generareTotal(pret_unitar, cantitate, discount, tva) * 100) / 100;
                    // Inseram totalul per produs in grid
                    gridProduse.Rows[i].Cells[6].Value = total_produs.ToString();
                    // Calculam totalul general
                    total_general += total_produs;
                    // Introducem totalul general in grid si ii setam un font specific
                    gridProduse.Rows[0].Cells[7].Value = total_general.ToString();
                    gridProduse.Rows[0].Cells[7].Style.Font = new Font("Times New Roman", 8.25F, FontStyle.Bold);
                    // Total per produs: Blocam randul curent daca exista deja un total calculat per produs
                    if (gridProduse.Rows[i].Cells[6].Value != null)
                    {
                        if (gridProduse.Rows[i].Cells[6].Value.ToString().Length != 0)
                        {
                            if (gridProduse.Rows[i].Cells[6].Value.ToString() != "0")
                            {
                                gridProduse.CurrentRow.ReadOnly = true;
                            }
                        }
                    }

                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Ati inserat o valoare necorespunzatoare.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void gridProduse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46 && gridProduse.SelectedRows.Count == 1)
            {
                try
                {
                    int idx = gridProduse.CurrentRow.Index;
                    string item_sters = gridProduse.Rows[idx].Cells[0].Value.ToString();
                    gridProduse.Rows.RemoveAt(idx);
                    if (gridProduse.Rows.Count < 1)
                    {
                        gridProduse.Rows.Add(null, null, null, null, null, null, null, null);
                    }
                    materii_prime.Add(item_sters);
                    repopulareCombobox();
                    updateTotal();
                    e.Handled = true;
                }
                catch (Exception)
                {

                }
            }
            else e.Handled = false;
        }
        bool EnableOrDisableSaveButton()
        {
            try
            {
                foreach (DataGridViewRow row in gridProduse.Rows)
                {
                    bool isEnabled;
                    if (row.Cells[6].Value != null &&
                        row.Cells[6].Value.ToString() != "0")
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
        private int genereazaIDFurnizor(string xdenumire)
        {
            string query = "SELECT furnizor_id from furnizori where furnizor_nume='" + xdenumire + "'";
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
                                    int furnizor_id = int.Parse(row["furnizor_id"].ToString());
                                    return furnizor_id;
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
        private int genereazaIDAngajat(string xdenumire)
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
        private int genereazaIDMateriePrima(string xdenumire)
        {
            string query = "SELECT mp_id from materii_prime where denumire='" + xdenumire + "'";
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
                                    int id_mp = int.Parse(row["mp_id"].ToString());
                                    return id_mp;
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

        private void btnSpreFacturi_Click(object sender, EventArgs e)
        {
            using (Facturi f = new Facturi())
            {
                f.ShowDialog();
            }
        }

        private void btnSaveComanda_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Comenzi_Furnizori (comandaf_id, furnizor_id, angajat_id, datacomanda, datalimita, datalivrare) 
                                VALUES (@codcomanda, @codfurnizor, @codangajat, @datacomanda, @datalimita, @datalivrare)";
            string query_detalii = @"INSERT INTO Detalii_ComandaF (comandaf_id, mp_id, pret_unitar, cantitate, unitate_masura, discount, tva, total)
                                    VALUES (@codcomandaf, @mpid, @pretunitar, @cantitate, @unitatemasura, @discount, @tva, @total)";
            NpgsqlConnection conn = new NpgsqlConnection(conexiune);
            NpgsqlCommand comanda_detalii = new NpgsqlCommand(query_detalii, conn);
            NpgsqlCommand comanda = new NpgsqlCommand(query, conn);

            checkAllFieldsBeforeInsert();
            if (valid == true && gridProduse.Rows.Count>0)
            {
                try
                {
                    conn.Open();

                    comanda.Parameters.Clear();
                    comanda.Parameters.AddWithValue("@codcomanda", int.Parse(txtNrComanda.Text));
                    comanda.Parameters.AddWithValue("@codfurnizor", genereazaIDFurnizor(cboAlegeFurnizor.SelectedItem.ToString()));
                    comanda.Parameters.AddWithValue("@codangajat", genereazaIDAngajat(cboAlegeAngajat.SelectedItem.ToString()));
                    comanda.Parameters.AddWithValue("@datacomanda", dtDataComanda.Value);
                    comanda.Parameters.AddWithValue("@datalimita", dtDataLimita.Value);
                    if (chkLivrata.Checked == true)
                    {
                        comanda.Parameters.AddWithValue("@datalivrare", dtDataLivrare.Value);
                    }
                    else
                    {
                        comanda.Parameters.AddWithValue("@datalivrare", DBNull.Value);
                    }
                    comanda.CommandType = CommandType.Text;
                    comanda.ExecuteNonQuery();
                    // Detaliile comenzii
                    for (int i = 0; i < gridProduse.Rows.Count - 1; ++i)
                    {
                        comanda_detalii.Parameters.Clear();
                        comanda_detalii.Parameters.AddWithValue("@codcomandaf", int.Parse(txtNrComanda.Text));
                        comanda_detalii.Parameters.AddWithValue("@mpid", genereazaIDMateriePrima(gridProduse[0, i].Value.ToString()));
                        comanda_detalii.Parameters.AddWithValue("@pretunitar", double.Parse(gridProduse[1, i].Value.ToString()));
                        comanda_detalii.Parameters.AddWithValue("@cantitate", double.Parse(gridProduse[2, i].Value.ToString()));
                        comanda_detalii.Parameters.AddWithValue("@unitatemasura", gridProduse[3, i].Value.ToString());
                        comanda_detalii.Parameters.AddWithValue("@discount", double.Parse(gridProduse[4, i].Value.ToString()));
                        comanda_detalii.Parameters.AddWithValue("@tva", double.Parse(gridProduse[5, i].Value.ToString()));
                        comanda_detalii.Parameters.AddWithValue("@total", double.Parse(gridProduse[6, i].Value.ToString()));
                        comanda_detalii.CommandType = CommandType.Text;
                        comanda_detalii.ExecuteNonQuery();
                    }
                    conn.Close();
                    DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, @"Comanda cu nr. " + txtNrComanda.Text +
                                            " a fost inregistrata cu succes!\nDoriti sa inregistrati alta comanda?",
                                            "Comanda inregistrata", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        using (ComenziF comenzif = new ComenziF())
                        {
                            Hide();
                            comenzif.ShowDialog();
                        }
                    }
                    else
                    {
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nu s-a putut realiza inregistrarea comenzii.\n" + ex, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
