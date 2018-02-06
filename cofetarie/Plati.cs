using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace cofetarie
{
    public partial class Plati : MetroFramework.Forms.MetroForm
    {
        static string conexiune = @"Server=127.0.0.1;Port=5432;Database=cofetarie;User Id=postgres;
                                                        Password = postgres;";

        NpgsqlConnection conn = new NpgsqlConnection(conexiune);
        public int id_fact_selectat { get; set; }
        private int id_metoda_plata { get; set; }
        public string iban { get; set; }
        private string rest_plata { get; set; }
        private bool valid { get; set; }
        bool exista_plata { get; set; }
        private double suma_platita { get; set; }
        private void Plati_Load(object sender, EventArgs e)
        {
            load_form();     
        }
        public Plati()
        {
            InitializeComponent();
        }
        void dezactiveazaCampuri ()
        {
            txtDenumireFurnizor.Enabled = false;
            txtTotalFactura.Enabled = false;
            dtDataScadenta.Enabled = false;
            cboMetodaPlata.Enabled = false;
            dtDataPlata.Enabled = false;
            txtTotalPlatit.Enabled = false;
            txtNrOP.Enabled = false;
            txtIBANBeneficiar.Enabled = false;
            txtIBANPlatitor.Enabled = false;
            lblInformare.Visible = false;
            btnPlatesteRestul.Visible = false;
        }
        void restrictiiLungime ()
        {
            txtIBANBeneficiar.MaxLength = 24;
            txtIBANPlatitor.MaxLength = 24;
            txtNrOP.MaxLength = 10;
            txtTotalPlatit.MaxLength = 9;
        }
        void load_form()
        {
            dezactiveazaCampuri();
            restrictiiLungime();
            populeazaCuMetodePlata();
        }
        void populeazaCuFacturi()
        {
            cboNrFactura.Items.Clear();
            string query = "select factura_id from facturi f join comenzi_furnizori cf on f.comandaf_id = cf.comandaf_id";
            DataTable dt = new DataTable();
            try
            {
                using (conn = new NpgsqlConnection(conexiune))
                {
                    conn.Open();
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            cboNrFactura.Items.Add(row["factura_id"].ToString());
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        void populeazaCuMetodePlata()
        {
            cboMetodaPlata.Items.Clear();
            string query = "SELECT * FROM MetodePlati";
            DataTable dt = new DataTable();
            try
            {
                using (conn = new NpgsqlConnection(conexiune))
                {
                    conn.Open();
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            cboMetodaPlata.Items.Add(row["metodaplata"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

        }
        void dezactiveazaCampuriCandExistaPlata ()
        {
            txtDenumireFurnizor.Enabled = false;
            txtTotalFactura.Enabled = false;
            dtDataScadenta.Enabled = false;
            cboMetodaPlata.Enabled = false;
            dtDataPlata.Enabled = false;
            txtTotalPlatit.Enabled = false;
            txtNrOP.Enabled = false;
            txtIBANBeneficiar.Enabled = false;
            txtIBANPlatitor.Enabled = false;
        }
        void populareDateFacturaFaraPlata()
        {
            // Preluam valoarea id-ului din cboNrFactura
            id_fact_selectat = int.Parse(cboNrFactura.SelectedItem.ToString());
            // Query-ul de selectie
            string query = @"SELECT f.furnizor_nume,
                                    f.iban,
                                    fact.datascadenta,
                                    fact.valoarefactura
                            FROM FURNIZORI f INNER JOIN COMENZI_FURNIZORI cf ON f.furnizor_id = cf.furnizor_id
		                                     INNER JOIN FACTURI fact ON fact.comandaf_id = cf.comandaf_id
                            WHERE fact.factura_id =" + id_fact_selectat;
            try
            {
                using (conn = new NpgsqlConnection(conexiune))
                {
                    conn.Open();
                    using (DataTable dt = new DataTable())
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                    {
                        adapter.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            txtDenumireFurnizor.Text = row["furnizor_nume"].ToString();
                            iban = row["iban"].ToString();
                            dtDataScadenta.Value = Convert.ToDateTime(row["datascadenta"].ToString());
                            txtTotalFactura.Text = row["valoarefactura"].ToString();
                            if (cboMetodaPlata.SelectedIndex == -1) return;
                            else if (cboMetodaPlata.SelectedItem.ToString() == "ordin plata")
                            {
                                populareIBANCorespunzator(iban, "RO99BNR00112233445566778");
                            }
                            else return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        void activareDatePlata()
        {
            cboMetodaPlata.Enabled = true;
            dtDataPlata.Enabled = true;
            txtTotalPlatit.Enabled = true;
        }
        void populareDateFacturaCuPlata()
        {
            id_fact_selectat = int.Parse(cboNrFactura.Text.ToString());
            string query_total = @"SELECT fact.factura_id,
                                            fact.valoarefactura,
                                            fact.datascadenta, 
                                            f.furnizor_nume, 
                                            f.iban, 
                                            mp.metodaplata, 
                                            p.dataplata,
                                            p.nrordinplata
                                    FROM PLATI p INNER JOIN METODEPLATI mp ON p.metodaplata_id = mp.metodaplata_id
	                                             INNER JOIN FACTURI fact ON fact.factura_id = p.factura_id
	                                             INNER JOIN COMENZI_FURNIZORI cf ON cf.comandaf_id = fact.comandaf_id
	                                             INNER JOIN FURNIZORI f ON f.furnizor_id = cf.furnizor_id
                                    WHERE fact.factura_id =" + id_fact_selectat;
            try
            {
                using (conn = new NpgsqlConnection(conexiune))
                {
                        conn.Open();
                        using (DataTable dt = new DataTable())
                                {
                                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query_total, conn))
                                    {
                                        adapter.Fill(dt);
                                        foreach (DataRow row in dt.Rows)
                                        {
                                            txtDenumireFurnizor.Text = row["furnizor_nume"].ToString();
                                            dtDataScadenta.Value = Convert.ToDateTime(row["datascadenta"].ToString());
                                            txtTotalFactura.Text = row["valoarefactura"].ToString();
                                            cboMetodaPlata.Text = row["metodaplata"].ToString();                             
                                            dtDataPlata.Text = row["dataplata"].ToString();
                                            if (cboMetodaPlata.SelectedItem.ToString() == "ordin plata")
                                {
                                    txtNrOP.Text = row["nrordinplata"].ToString();
                                    txtIBANBeneficiar.Text = row["iban"].ToString();
                                    txtIBANPlatitor.Text = "RO99BNR00112233445566778";
                                }
                                           
                                            txtTotalPlatit.Text = suma_platita.ToString();
                                        }
                                    }
                                }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        void reseteazaIBANuri ()
        {
            txtIBANBeneficiar.Text = "";
            txtIBANPlatitor.Text = "";
        }
        void verificareExistentaPlata()
        {
            id_fact_selectat = int.Parse(cboNrFactura.Text.ToString());
            string query = "SELECT SUM(valoare) AS valoaretotala FROM Plati WHERE Factura_Id=" + id_fact_selectat;
            try
            { 
                using (conn = new NpgsqlConnection(conexiune))
                {
                    conn.Open();
                    using (DataTable dt = new DataTable())
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                        {
                            adapter.Fill(dt);
                            if (dt.Rows[0][0] != DBNull.Value)
                            {
                                exista_plata = true;
                                suma_platita = Convert.ToDouble(dt.Rows[0][0].ToString());
                            }
                            else exista_plata = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        void activeazaCampuriPentruPlata2 ()
        {
            cboMetodaPlata.Enabled = true;
            dtDataPlata.Enabled = true;
            if (cboMetodaPlata.SelectedItem.ToString() == "ordin plata")
            {
                txtNrOP.Enabled = true;
                txtNrOP.Text = "";
            }
        }
        void activeazaDetaliiOP()
        {
            txtNrOP.Enabled = true;
            txtIBANBeneficiar.Enabled = false;
            txtIBANPlatitor.Enabled = false;
        }
        void dezactiveazaDetaliiOP()
        {
            txtNrOP.Enabled = false;
            txtIBANBeneficiar.Enabled = false;
            txtIBANPlatitor.Enabled = false;
            txtNrOP.ResetText();
            txtIBANBeneficiar.ResetText();
            txtIBANPlatitor.ResetText();
        }
        void checkBeforeInsert()
        {
            if (cboNrFactura.SelectedItem == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Alegeti numarul facturii pe baza careia inregistrati plata.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (cboMetodaPlata.SelectedItem == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Alegeti metoda de plata.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (cboMetodaPlata.SelectedItem.ToString() == "ordin plata")
                    {
                        if (string.IsNullOrWhiteSpace(txtNrOP.Text))
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Introduceti numarul ordinului de plata.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            if (string.IsNullOrWhiteSpace(txtTotalPlatit.Text))
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Introduceti valoarea platita.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else valid = true;
                        }
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(txtTotalPlatit.Text))
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Introduceti valoarea platita.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else valid = true;
                    }
                }
            }
        }
        void populareIBANCorespunzator(string x, string y)
        {
            txtIBANBeneficiar.Text = x;
            txtIBANPlatitor.Text = y;
        }
        string validare_2_zecimale(string x)
        {
            double val = Convert.ToDouble(x);
            x = val.ToString("F");
            txtTotalPlatit.Text = x;
            return x;

        }
        int genereazaIDMetodaPlata(string metoda_plata)
        {
            string query = "SELECT metodaplata_id FROM MetodePlati WHERE MetodaPlata='" + metoda_plata + "'";
            DataTable dt = new DataTable();
            using (conn = new NpgsqlConnection(conexiune))
            {
                conn.Open();
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        id_metoda_plata = int.Parse(row["metodaplata_id"].ToString());
                        return id_metoda_plata;
                    }
                    return id_metoda_plata;
                }
            }
        }
        void color_green()
        {
            lblTotalPlatit.UseCustomForeColor = true;
            lblRON.UseCustomForeColor = true;
            txtTotalPlatit.UseCustomForeColor = true;
            lblTotalPlatit.ForeColor = Color.Green;
            lblRON.ForeColor = Color.Green;
            txtTotalPlatit.ForeColor = Color.Green;
            lblInformare.UseCustomForeColor = true;
            lblInformare.ForeColor = Color.Green;
        }
        void color_red()
        {
            lblTotalPlatit.UseCustomForeColor = true;
            lblRON.UseCustomForeColor = true;
            txtTotalPlatit.UseCustomForeColor = true;
            txtTotalPlatit.ForeColor = Color.Red;
            lblTotalPlatit.ForeColor = Color.Red;
            lblRON.ForeColor = Color.Red;
            lblInformare.UseCustomForeColor = true;
            lblInformare.ForeColor = Color.Red;
        }
        void defaultColor()
        {
            lblTotalPlatit.UseCustomForeColor = false;
            lblTotalPlatit.ForeColor = Color.Black;
            lblRON.UseCustomForeColor = false;
            lblRON.ForeColor = SystemColors.Highlight;
            txtTotalPlatit.UseCustomForeColor = false;
            txtTotalPlatit.ForeColor = Color.Transparent;
        }
        void hide_informare_and_button()
        {
            lblInformare.Visible = false;
            btnPlatesteRestul.Visible = false;
        }
        void show_informare_integral()
        {
            lblInformare.Visible = true;
            lblInformare.Text = "Factura cu nr. " + cboNrFactura.SelectedItem + " a fost platita integral.";
            btnPlatesteRestul.Visible = false;
        }
        void show_informare_partial()
        {
            double z = double.Parse(txtTotalFactura.Text) - double.Parse(txtTotalPlatit.Text);
            rest_plata = z.ToString("#.##");
            lblInformare.Visible = true;
            lblInformare.Text = @"Factura cu nr. " + cboNrFactura.SelectedItem + " a fost platita partial.\n" +
                                "Au mai ramas de plata: " + rest_plata + " RON";
            btnPlatesteRestul.Visible = true;
            btnPlatesteRestul.Enabled = true;
        }
        void resetFields()
        {
            txtDenumireFurnizor.Text = "";
            dtDataScadenta.ResetText();
            txtTotalFactura.Text = "";
            cboMetodaPlata.Items.Clear();
            txtNrOP.Text = "";
            txtIBANBeneficiar.Text = "";
            txtIBANPlatitor.Text = "";
            txtTotalPlatit.ResetText();
        }
        private void cboNrFactura_DropDown(object sender, EventArgs e)
        {
            populeazaCuFacturi();
        }
        private void cboNrFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            verificareExistentaPlata();
            if (exista_plata == false)
            {
                resetFields();
                populareDateFacturaFaraPlata();
                populeazaCuMetodePlata();
                activareDatePlata();
                defaultColor();
                hide_informare_and_button();
                btnPlata.Enabled = true;
            }
            else 
            {         
                populareDateFacturaCuPlata();
                dezactiveazaCampuriCandExistaPlata();
                btnPlata.Enabled = false;  
                if (suma_platita < Convert.ToDouble(txtTotalFactura.Text))
                {
                    activeazaCampuriPentruPlata2();
                    color_red();
                    show_informare_partial();
                }
                else
                {
                    if (suma_platita == Convert.ToDouble(txtTotalFactura.Text))
                    {
                        color_green();
                        show_informare_integral();
                    }
                }                             
            }
        }
        private void cboMetodaPlata_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMetodaPlata.SelectedItem.ToString() == "ordin plata" && exista_plata == false)
            {
                activeazaDetaliiOP();
                populareIBANCorespunzator(iban,"RO99BNR00112233445566778");
            }
            else 
            {
                dezactiveazaDetaliiOP();
                reseteazaIBANuri();
            }
        }
        private void txtTotalPlatit_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTotalPlatit.Text))
            {
                //MetroFramework.MetroMessageBox.Show(this, "Introduceti suma platita.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            validare_2_zecimale(txtTotalPlatit.Text);
        }
        private void txtTotalPlatit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificam daca exista un caracter "." si previne introducerea altuia
            if (e.KeyChar == 46 && txtTotalPlatit.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }
            // Previne introducerea literelor si a altor caractere
            // exceptand cifrele si caracterul "."
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void btnPlata_Click(object sender, EventArgs e)
        {
            string insert = @"INSERT INTO Plati (factura_id, valoare, dataplata, metodaplata_id, nrordinplata, ibanplatitor, ibanbeneficiar) 
                                    VALUES (@id, @val, @data, @idmetoda, @nrordin, @ibanp, @ibanb)";
            DialogResult dialog = new DialogResult();
            checkBeforeInsert();
            if (valid == true)
            {
                try
                {
                    using (conn = new NpgsqlConnection(conexiune))
                    {
                        conn.Open();
                        using (NpgsqlCommand comanda = new NpgsqlCommand(insert, conn))
                        {
                            comanda.Parameters.AddWithValue("@id", int.Parse(cboNrFactura.SelectedItem.ToString()));
                            comanda.Parameters.AddWithValue("@val", double.Parse(txtTotalPlatit.Text));
                            comanda.Parameters.AddWithValue("@data", dtDataPlata.Value);
                            comanda.Parameters.AddWithValue("@idmetoda", genereazaIDMetodaPlata(cboMetodaPlata.SelectedItem.ToString()));
                            if (cboMetodaPlata.SelectedItem.ToString() == "ordin plata")
                            {
                                comanda.Parameters.AddWithValue("@nrordin", int.Parse(txtNrOP.Text));
                                comanda.Parameters.AddWithValue("@ibanp", txtIBANPlatitor.Text);
                                comanda.Parameters.AddWithValue("@ibanb", txtIBANBeneficiar.Text);
                            }
                            else
                            {
                                comanda.Parameters.AddWithValue("@nrordin", DBNull.Value);
                                comanda.Parameters.AddWithValue("@ibanp", DBNull.Value);
                                comanda.Parameters.AddWithValue("@ibanb", DBNull.Value);
                            }
                            comanda.CommandType = CommandType.Text;
                            comanda.ExecuteNonQuery();
                            dialog = MetroFramework.MetroMessageBox.Show(this, "Plata inregistrata cu succes!\nInregistrati alta plata?", "Succes!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        }
                    }
                    if (dialog == DialogResult.Yes)
                    {
                        using (Plati plati = new Plati())
                        {
                            Hide();
                            plati.ShowDialog();
                        }
                    }
                    else Close();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }
        private void btnRenunta_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtNrOP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnPlatesteRestul_Click(object sender, EventArgs e)
        {
            string plateste_restul = @"insert into plati (factura_id, valoare, dataplata, metodaplata_id, nrordinplata, ibanplatitor, ibanbeneficiar) 
                                        VALUES (@idfact, @val, @dataplata, @metodaid, @nrordin, @ibanplatitor, @ibanbeneficiar)";
            double rest_de_plata = Convert.ToDouble(rest_plata);
            DateTime current_date = DateTime.Now;
            DialogResult dialog = new DialogResult();
            dialog = MetroFramework.MetroMessageBox.Show(this, "Sunteti pe cale sa platiti restul de "+rest_de_plata+" RON.\nMetoda de plata aleasa este: "+cboMetodaPlata.SelectedItem.ToString()+"."+"\nData platii: "+dtDataPlata.Value.ToString()+"."+"\nContinuati spre inregistrarea platii?", "Confirmare plata", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                checkBeforeInsert();
            }
            if (valid == true)
            {
                try
                {
                    using (conn = new NpgsqlConnection(conexiune))
                    {
                        conn.Open();
                        using (NpgsqlCommand comanda = new NpgsqlCommand(plateste_restul, conn))
                        {
                            comanda.Parameters.AddWithValue("@idfact", int.Parse(cboNrFactura.SelectedItem.ToString()));
                            comanda.Parameters.AddWithValue("@val", rest_de_plata);
                            comanda.Parameters.AddWithValue("@dataplata", current_date);
                            comanda.Parameters.AddWithValue("@metodaid", genereazaIDMetodaPlata(cboMetodaPlata.SelectedItem.ToString()));
                            if (cboMetodaPlata.SelectedItem.ToString() == "ordin plata")
                            {
                                comanda.Parameters.AddWithValue("@nrordin", int.Parse(txtNrOP.Text));
                                comanda.Parameters.AddWithValue("@ibanplatitor", txtIBANPlatitor.Text);
                                comanda.Parameters.AddWithValue("@ibanbeneficiar", txtIBANBeneficiar.Text);
                            }
                            else
                            {
                                comanda.Parameters.AddWithValue("@nrordin", DBNull.Value);
                                comanda.Parameters.AddWithValue("@ibanplatitor", DBNull.Value);
                                comanda.Parameters.AddWithValue("@ibanbeneficiar", DBNull.Value);
                            }
                            comanda.CommandType = CommandType.Text;
                            comanda.ExecuteNonQuery();
                        }
                    }
                    dialog = MetroFramework.MetroMessageBox.Show(this, "Plata a fost inregistrata.", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        using (Plati plati = new Plati())
                        {
                            Hide();
                            plati.ShowDialog();
                        }
                    }
                    else
                    {
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }
    }
}
