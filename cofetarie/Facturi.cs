using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace cofetarie
{
    public partial class Facturi : MetroFramework.Forms.MetroForm
    {
        static string conexiune = @"Server=127.0.0.1;Port=5432;Database=cofetarie;User Id=postgres;
                                                        Password = postgres;";
        NpgsqlConnection conn = new NpgsqlConnection(conexiune);
        bool valid;
        bool Furnizor_checked;
        bool Client_checked;
        bool exista_factura;
        private void dezactiveazaCampuri()
        {
            rbnClienti.Checked = false;
            rbnFurn.Checked = false;
            txtNrFactura.Enabled = false;
            cboNrComanda.Enabled = false;
            txtDenumireFurn.Enabled = false;
            txtTotalComanda.Enabled = false;
            btnVeziDetaliiComanda.Enabled = false;
            gridDetaliiComanda.ReadOnly = true;
            gridDetaliiComanda.AutoGenerateColumns = false;
            dtDataFactura.Enabled = false;
            dtDataScadenta.Enabled = false;
            txtTotalFactura.Enabled = false;
            btnSave.Enabled = false;
            lblExista.Visible = false;
        }
        private void activeazaNrFactAndNrComanda()
        {
            txtNrFactura.Enabled = true;
            cboNrComanda.Enabled = true;
        }
        void activeazaDateleFacturii()
        {
            dtDataFactura.Enabled = true;
            dtDataScadenta.Enabled = true;
        }
        private void genereazaNrComenziFurnizori()
        {
            cboNrComanda.Items.Clear();
            string query = "SELECT comandaf_id FROM Comenzi_Furnizori";
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
                            foreach (DataRow row in dt.Rows)
                            {
                                cboNrComanda.Items.Add(row[0].ToString());
                            }
                        }
                    }
                }
            } catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu s-au putut genera comenzile.\nMotiv:\n" + ex, "A aparut o problema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void generareNrComenziClienti ()
        {
            cboNrComanda.Items.Clear();
            string query = "SELECT comandac_id FROM Comenzi_Clienti";
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
                            foreach (DataRow row in dt.Rows)
                            {
                                cboNrComanda.Items.Add(row[0].ToString());
                            }
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu s-au putut genera comenzile.\nMotiv:\n" + ex, "A aparut o problema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Clear()
        {
            txtNrFactura.Text = "";
            // Comanda
            cboNrComanda.ResetText();
            cboNrComanda.Items.Clear();
            cboNrComanda.Refresh();
            txtDenumireFurn.Text = "";
            txtTotalComanda.Text = "";
            // Factura
            dtDataFactura.Value = DateTime.Now;
            dtDataScadenta.Value = DateTime.Now;
            txtTotalFactura.Text = "";
            txtTotalFactura.Clear();
            // Grid detalii
            gridDetaliiComanda.DataSource = null;
            gridDetaliiComanda.Refresh();

        }
        void veziDetalii()
        {
            string query = @"select cf.comandaf_id, f.furnizor_nume, cf.datacomanda, cf.datalimita, cf.datalivrare, mp.denumire, dcf.pret_unitar, dcf.cantitate, dcf.unitate_masura, dcf.discount, dcf.tva, dcf.total
                            from comenzi_furnizori cf inner join furnizori f on f.furnizor_id=cf.furnizor_id
                            inner join detalii_comandaf dcf on dcf.comandaf_id=cf.comandaf_id
                            inner join materii_prime mp on mp.mp_id=dcf.mp_id
                            where cf.comandaf_id=@id";
            string query_cl = @"select cc.comandac_id, c.client_nume, cc.datacomanda, cc.datalimita, cc.datalivrare, pf.denumire, dcc.pretperkg, dcc.cantitate, dcc.tva, dcc.total
                            from comenzi_clienti cc inner join clienti c on c.client_id=cc.client_id
                            inner join detalii_comanda dcc on dcc.comandac_id=cc.comandac_id
                            inner join produse_finite pf on pf.produs_id=dcc.produs_id
                            where cc.comandac_id=@id";
            if (Furnizor_checked == true)
            {
                try
                {
                    using (conn = new NpgsqlConnection(conexiune))
                    {
                        conn.Open();
                        {
                            using (DataTable dt = new DataTable())
                            {
                                using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                                {
                                    comanda.Parameters.AddWithValue("@id", int.Parse(cboNrComanda.SelectedItem.ToString()));
                                    comanda.CommandType = CommandType.Text;
                                    comanda.ExecuteNonQuery();
                                    using (NpgsqlDataReader reader = comanda.ExecuteReader())
                                    {
                                        dt.Load(reader);
                                        gridDetaliiComanda.DataSource = dt;
                                        gridDetaliiComanda.Columns[0].DataPropertyName = "comandaf_id";
                                        gridDetaliiComanda.Columns[1].DataPropertyName = "datacomanda";
                                        gridDetaliiComanda.Columns[2].DataPropertyName = "datalimita";
                                        gridDetaliiComanda.Columns[3].DataPropertyName = "datalivrare";
                                        gridDetaliiComanda.Columns[4].DataPropertyName = "denumire";
                                        gridDetaliiComanda.Columns[5].DataPropertyName = "pret_unitar";
                                        gridDetaliiComanda.Columns[6].DataPropertyName = "cantitate";
                                        gridDetaliiComanda.Columns[7].DataPropertyName = "unitate_masura";
                                        gridDetaliiComanda.Columns[8].DataPropertyName = "discount";
                                        gridDetaliiComanda.Columns[9].DataPropertyName = "tva";
                                        gridDetaliiComanda.Columns[10].DataPropertyName = "total";
                                        btnSave.Enabled = true;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (Client_checked == true)
                {
                    try
                    {
                        using (conn = new NpgsqlConnection(conexiune))
                        {
                            conn.Open();
                            {
                                using (DataTable dt = new DataTable())
                                {
                                    using (NpgsqlCommand comanda = new NpgsqlCommand(query_cl, conn))
                                    {
                                        comanda.Parameters.AddWithValue("@id", int.Parse(cboNrComanda.SelectedItem.ToString()));
                                        comanda.CommandType = CommandType.Text;
                                        comanda.ExecuteNonQuery();
                                        using (NpgsqlDataReader reader = comanda.ExecuteReader())
                                        {
                                            dt.Load(reader);
                                            gridDetaliiComanda.DataSource = dt;
                                            gridDetaliiComanda.Columns[0].DataPropertyName = "comandac_id";
                                            gridDetaliiComanda.Columns[1].DataPropertyName = "datacomanda";
                                            gridDetaliiComanda.Columns[2].DataPropertyName = "datalimita";
                                            gridDetaliiComanda.Columns[3].DataPropertyName = "datalivrare";
                                            gridDetaliiComanda.Columns[4].DataPropertyName = "denumire";
                                            gridDetaliiComanda.Columns[5].DataPropertyName = "pretperkg";
                                            gridDetaliiComanda.Columns[6].DataPropertyName = "cantitate";
                                            gridDetaliiComanda.Columns[9].DataPropertyName = "tva";
                                            gridDetaliiComanda.Columns[10].DataPropertyName = "total";
                                            btnSave.Enabled = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public Facturi()
        {
            InitializeComponent();
        }
        void resetIndexDetails ()
        {
            gridDetaliiComanda.DataSource = null;
            btnVeziDetaliiComanda.Enabled = false;
            dtDataFactura.ResetText();
            dtDataScadenta.ResetText();
            btnSave.Enabled = false;
        }
        void checkBeforeInsert()
        {
            if (string.IsNullOrWhiteSpace(txtNrFactura.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Inserati numarul facturii.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (cboNrComanda.SelectedItem == null)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Alegeti comanda pe baza careia inregistrati factura.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (dtDataFactura.Value < Convert.ToDateTime(gridDetaliiComanda[1, 0].Value))
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Atentie!\nData facturii nu poate fi mai mica decat data comenzii propriu-zise!", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (dtDataScadenta.Value <= dtDataFactura.Value)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "1) Data scadentei facturii nu poate fi aceeasi cu data eliberarii facturii.\n2) Data facturarii nu poate fi mai mare decat data scadentei facturii.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            valid = true;
                        }
                    }
                }
            }
        }
        void insertFurnizori()
        {
            string query = @"INSERT INTO Facturi (factura_id, data_factura, datascadenta, comandaf_id, valoarefactura) 
                                                    VALUES (@factid, @datafact, @datascad, @idcomandaf, @valfact)";
            DialogResult dialog = new DialogResult();
            checkBeforeInsert();
            if (valid == true)
            {
                try
                {
                    using (conn = new NpgsqlConnection(conexiune))
                    {
                        conn.Open();
                        using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                        {
                            comanda.Parameters.AddWithValue("@factid", int.Parse(txtNrFactura.Text));
                            comanda.Parameters.AddWithValue("@datafact", dtDataFactura.Value);
                            comanda.Parameters.AddWithValue("@datascad", dtDataScadenta.Value);
                            comanda.Parameters.AddWithValue("@idcomandaf", int.Parse(cboNrComanda.SelectedItem.ToString()));
                            comanda.Parameters.AddWithValue("@valfact", double.Parse(txtTotalFactura.Text));
                            comanda.CommandType = CommandType.Text;
                            comanda.ExecuteNonQuery();
                        }
                        dialog = MetroFramework.MetroMessageBox.Show(this, @"Factura aferenta comenzii cu nr. " + cboNrComanda.SelectedItem.ToString() +
                                                                            " a furnizorului " + txtDenumireFurn.Text +
                                                                            " in valoare de " + txtTotalFactura.Text + " RON" +
                                                                            " a fost inregistrata cu succes!\nInregistrati alta factura?",
                                                                            "Succes!", MessageBoxButtons.YesNo,
                                                                                       MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            using (Facturi fact = new Facturi())
                            {
                                Hide();
                                fact.ShowDialog();
                            }
                        }
                        else
                        {
                            Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void insertClienti()
        {
            string query = @"INSERT INTO Facturi (factura_id, data_factura, datascadenta, comandac_id, valoarefactura) 
                                                    VALUES (@factid, @datafact, @datascad, @idcomandac, @valfact)";
            DialogResult dialog = new DialogResult();
            checkBeforeInsert();
            if (valid == true)
            {
                try
                {
                    using (conn = new NpgsqlConnection(conexiune))
                    {
                        conn.Open();
                        using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                        {
                            comanda.Parameters.AddWithValue("@factid", int.Parse(txtNrFactura.Text));
                            comanda.Parameters.AddWithValue("@datafact", dtDataFactura.Value);
                            comanda.Parameters.AddWithValue("@datascad", dtDataScadenta.Value);
                            comanda.Parameters.AddWithValue("@idcomandac", int.Parse(cboNrComanda.SelectedItem.ToString()));
                            comanda.Parameters.AddWithValue("@valfact", double.Parse(txtTotalFactura.Text));
                            comanda.CommandType = CommandType.Text;
                            comanda.ExecuteNonQuery();
                        }
                        dialog = MetroFramework.MetroMessageBox.Show(this, @"Factura aferenta comenzii cu nr. " + cboNrComanda.SelectedItem.ToString() +
                                                                            " a clientului " + txtDenumireFurn.Text +
                                                                            " in valoare de " + txtTotalFactura.Text + " RON" +
                                                                            " a fost inregistrata cu succes!\nInregistrati alta factura?",
                                                                            "Succes!", MessageBoxButtons.YesNo,
                                                                                       MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            using (Facturi fact = new Facturi())
                            {
                                Hide();
                                fact.ShowDialog();
                            }
                        }
                        else
                        {
                            Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        void verificaExistentaFacturii ()
        {
            int nr_comanda_selectata = int.Parse(cboNrComanda.SelectedItem.ToString());
            string query = "SELECT * FROM facturi WHERE comandaf_id=@id";
            string query_cl = "SELECT * FROM facturi where comandac_id=@id";
            if (Furnizor_checked == true)
            {
                try
                {
                    using (conn = new NpgsqlConnection(conexiune))
                    {
                        conn.Open();
                        using (DataTable dt = new DataTable())
                        {
                            using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                            {
                                comanda.Parameters.AddWithValue("@id", nr_comanda_selectata);
                                comanda.CommandType = CommandType.Text;
                                comanda.ExecuteNonQuery();
                                using (NpgsqlDataReader reader = comanda.ExecuteReader())
                                {
                                    dt.Load(reader);
                                    if (dt.Rows.Count == 0)
                                    {
                                        exista_factura = false;
                                        lblExista.Visible = false;
                                        lblExista.ResetText();
                                    }
                                    else
                                    {
                                        exista_factura = true;
                                        lblExista.Visible = true;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (Client_checked == true)
                {
                    try
                    {
                        using (conn = new NpgsqlConnection(conexiune))
                        {
                            conn.Open();
                            using (DataTable dt = new DataTable())
                            {
                                using (NpgsqlCommand comanda = new NpgsqlCommand(query_cl, conn))
                                {
                                    comanda.Parameters.AddWithValue("@id", nr_comanda_selectata);
                                    comanda.CommandType = CommandType.Text;
                                    comanda.ExecuteNonQuery();
                                    using (NpgsqlDataReader reader = comanda.ExecuteReader())
                                    {
                                        dt.Load(reader);
                                        if (dt.Rows.Count == 0)
                                        {
                                            exista_factura = false;
                                            lblExista.Visible = false;
                                            lblExista.ResetText();
                                        }
                                        else
                                        {
                                            exista_factura = true;
                                            lblExista.Visible = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void Facturi_Load(object sender, EventArgs e)
        {
            dezactiveazaCampuri();
        }
        private void btnRenunta_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void rbnFurn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnFurn.Checked == true)
            {
                Clear();
                Client_checked = false;
                Furnizor_checked = true;
                rbnFurn.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
                activeazaNrFactAndNrComanda();
                lblden.Text = "Denumire furnizor";
            }
        }
        private void rbnClienti_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnClienti.Checked == true)
            {
                Clear();
                Furnizor_checked = false;
                Client_checked = true;
                rbnClienti.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
                activeazaNrFactAndNrComanda();
                lblden.Text = "Denumire client:";
            }

        }
        private void cboNrComanda_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nr_comanda_selectata = int.Parse(cboNrComanda.SelectedItem.ToString());
            resetIndexDetails();
            verificaExistentaFacturii();
            string query = @"SELECT furnizor_nume, SUM(total) AS TotalC FROM Comenzi_Furnizori cf 
                            INNER JOIN Furnizori f ON cf.Furnizor_ID=f.Furnizor_ID 
                            INNER JOIN Detalii_ComandaF dcf ON dcf.ComandaF_ID=cf.ComandaF_ID WHERE dcf.comandaf_id=" + nr_comanda_selectata + "GROUP BY 1";
            string query_cl = @"SELECT client_nume, SUM(total) AS TotalC FROM Comenzi_Clienti cf 
                            INNER JOIN Clienti f ON cf.Client_ID=f.Client_ID 
                            INNER JOIN Detalii_Comanda dcf ON dcf.ComandaC_ID=cf.ComandaC_ID WHERE dcf.comandac_id=" + nr_comanda_selectata + "GROUP BY 1";
            if (Furnizor_checked == true)
            {
                if (exista_factura == false)
                {
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
                                    foreach (DataRow row in dt.Rows)
                                    {
                                        txtDenumireFurn.Text = row["furnizor_nume"].ToString();
                                        txtTotalComanda.Text = row["TotalC"].ToString();
                                        txtTotalFactura.Text = txtTotalComanda.Text;
                                        btnVeziDetaliiComanda.Enabled = true;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    lblExista.Text = "Exista deja o factura inregistrata pe baza comenzii cu nr. " + nr_comanda_selectata + ". Va rugam sa alegeti alt numar de comanda.";
                }
            }
            else
            {
                if (Client_checked == true)
                {
                    if (exista_factura == false)
                    {
                        try
                        {
                            using (conn = new NpgsqlConnection(conexiune))
                            {
                                conn.Open();
                                using (DataTable dt = new DataTable())
                                {
                                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query_cl, conn))
                                    {
                                        adapter.Fill(dt);
                                        foreach (DataRow row in dt.Rows)
                                        {
                                            txtDenumireFurn.Text = row["client_nume"].ToString();
                                            txtTotalComanda.Text = row["TotalC"].ToString();
                                            txtTotalFactura.Text = txtTotalComanda.Text;
                                            btnVeziDetaliiComanda.Enabled = true;
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        lblExista.Text = "Exista deja o factura inregistrata pe baza comenzii cu nr. " + nr_comanda_selectata + ". Va rugam sa alegeti alt numar de comanda.";
                    }
                }
            }
        }
        private void btnVeziDetaliiComanda_Click(object sender, EventArgs e)
        {
            if (cboNrComanda.SelectedItem == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Alegeti un numar de comanda.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                veziDetalii();
                activeazaDateleFacturii();
            }
        }
        private void cboNrComanda_DropDown(object sender, EventArgs e)
        {
            if (Furnizor_checked == true)
            {
                genereazaNrComenziFurnizori();
            }
            else if (Client_checked == true)
            {
                generareNrComenziClienti();
            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Furnizor_checked == true)
            {
                insertFurnizori();
            }
            else if (Client_checked == true)
            {
                insertClienti();
            }
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (Plati plati = new Plati())
            {
                plati.ShowDialog();
            }
        }
    }
}
