using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace cofetarie
{
    public partial class Clienti : MetroFramework.Forms.MetroForm
    {
        static string conexiune = @"Server=127.0.0.1;Port=5432;Database=cofetarie;User Id=postgres;
                                                        Password = postgres;";
        NpgsqlConnection conn = new NpgsqlConnection(conexiune);
        bool mod_adaugare, mod_editare;
        bool ok_to_add;
        bool ok_to_edit;
        List<string> regiuni = new List<string>();
        List<string> moldova = new List<string>();
        List<string> muntenia = new List<string>();
        List<string> oltenia = new List<string>();
        List<string> banat = new List<string>();
        List<string> bucovina = new List<string>();
        List<string> transilvania = new List<string>();

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Activam si butoanele de editare si stergere
            btnModifica.Enabled = true;
            btnSterge.Enabled = true;
            // Query-ul de inserare
            string query = @"select client_id, client_nume, cui, iban, 
                            banca, persoana_contact, telefon, fax, adresa, 
                            oras, codpostal, regiune, tara  from clienti
                            order by 1";
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
                                gridClienti.DataSource = dt;
                                gridClienti.Columns[0].DataPropertyName = "client_id";
                                gridClienti.Columns[1].DataPropertyName = "client_nume";
                                gridClienti.Columns[2].DataPropertyName = "cui";
                                gridClienti.Columns[3].DataPropertyName = "iban";
                                gridClienti.Columns[4].DataPropertyName = "banca";
                                gridClienti.Columns[5].DataPropertyName = "persoana_contact";
                                gridClienti.Columns[6].DataPropertyName = "telefon";
                                gridClienti.Columns[7].DataPropertyName = "fax";
                                gridClienti.Columns[8].DataPropertyName = "adresa";
                                gridClienti.Columns[9].DataPropertyName = "oras";
                                gridClienti.Columns[10].DataPropertyName = "codpostal";
                                gridClienti.Columns[11].DataPropertyName = "regiune";
                                gridClienti.Columns[12].DataPropertyName = "tara";
                            }
                        }
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw new InvalidOperationException("Conexiunea la baza de date a esuat.", ex);
            }
        }
        public Clienti()
        {
            InitializeComponent();
            // Banci
            populeazaCuBanci(cboBanca);
            // Orase
            populeazaCuOrase(cboOras);
            // Populam lista de regiuni
            regiuni.Clear();
            regiuni.Add("Bucovina");
            regiuni.Add("Moldova");
            regiuni.Add("Dobrogea");
            regiuni.Add("Muntenia");
            regiuni.Add("Oltenia");
            regiuni.Add("Transilvania");
            regiuni.Add("Banat");
            regiuni.Add("Crisana");
            regiuni.Add("Maramures");
            // Oras per regiune
            foreach (string item in cboOras.Items)
            {
                if (item == "Botosani" ||
                    item == "Iasi" ||
                    item == "Vaslui" ||
                    item == "Galati")
                {
                    moldova.Add(item);
                }
                else
                {
                    if (item == "Suceava")
                    {
                        bucovina.Add(item);
                    }
                    else
                    {
                        if (item == "Bucuresti" ||
                        item == "Pitesti" ||
                        item == "Targoviste")
                        {
                            muntenia.Add(item);
                        }
                        else
                        {
                            if (item == "Craiova")
                            {
                                oltenia.Add(item);
                            }
                            else
                            {
                                if (item == "Timisoara" || item == "Arad")
                                {
                                    banat.Add(item);
                                }
                                else
                                {
                                    if (item == "Brasov" || item == "Sibiu" || item == "Cluj-Napoca")
                                    {
                                        transilvania.Add(item);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        void loadItems()
        {
            // Date clienti
            txtCodClient.Enabled = false;
            txtDenumireClient.Enabled = false;
            txtCUI.Enabled = false;
            txtIBAN.Enabled = false;
            txtPersContact.Enabled = false;
            cboBanca.Enabled = false;
            txtTelefon.Enabled = false;
            txtFax.Enabled = false;
            txtAdresa.Enabled = false;
            cboOras.Enabled = false;
            txtCodPostal.Enabled = false;
            txtRegiune.Enabled = false;
            txtTara.Enabled = false;
            // Butoane
            btnModifica.Enabled = false;
            btnSterge.Enabled = false;
            btnSalvare.Enabled = false;
            // Grid
            gridClienti.AutoGenerateColumns = false;
            gridClienti.ReadOnly = true;

        }
        void restrictiiCampuri()
        {
            txtCodClient.MaxLength = 3;
            txtDenumireClient.MaxLength = 40;
            txtPersContact.MaxLength = 40;
            txtCUI.MaxLength = 10;
            txtAdresa.MaxLength = 50;
            cboOras.MaxLength = 15;
            txtRegiune.MaxLength = 12;
            txtCodPostal.MaxLength = 6;
            txtTara.MaxLength = 15;
            txtTelefon.MaxLength = 10;
            txtFax.MaxLength = 10;
            txtIBAN.MaxLength = 24;
            cboBanca.MaxLength = 25;
        }
        void disableButtons()
        {
            btnSterge.Enabled = false;
            btnModifica.Enabled = false;
            btnSalvare.Enabled = false;
            btnRefresh.Enabled = false;
            btnRenunta.Enabled = false;
        }
        void enableFields()
        {
            txtCodClient.Enabled = true;
            txtDenumireClient.Enabled = true;
            txtCUI.Enabled = true;
            txtIBAN.Enabled = true;
            txtPersContact.Enabled = true;
            cboBanca.Enabled = true;
            txtTelefon.Enabled = true;
            txtFax.Enabled = true;
            txtAdresa.Enabled = true;
            cboOras.Enabled = true;
            txtCodPostal.Enabled = true;
        }
        void disableFields()
        {
            txtCodClient.Enabled = false;
            txtDenumireClient.Enabled = false;
            txtCUI.Enabled = false;
            txtIBAN.Enabled = false;
            txtPersContact.Enabled = false;
            cboBanca.Enabled = false;
            txtTelefon.Enabled = false;
            txtFax.Enabled = false;
            txtAdresa.Enabled = false;
            cboOras.Enabled = false;
            txtCodPostal.Enabled = false;
            txtRegiune.Enabled = false;
            txtTara.Enabled = false;
        }
        void resetFields()
        {
            txtCodClient.ResetText();
            txtDenumireClient.ResetText();
            txtCUI.ResetText();
            txtIBAN.ResetText();
            txtPersContact.ResetText();
            cboBanca.SelectedIndex = -1;
            txtTelefon.ResetText();
            txtFax.ResetText();
            txtAdresa.ResetText();
            cboOras.SelectedIndex = -1;
            txtCodPostal.ResetText();
            txtRegiune.ResetText();
            txtTara.ResetText();
        }
        void enableButtons_Adaugare()
        {
            btnSterge.Enabled = true;
            btnModifica.Enabled = true;
            btnSalvare.Enabled = true;
        }
        void disableButtons_Adaugare()
        {
            btnSterge.Enabled = false;
            btnModifica.Enabled = false;
            btnSalvare.Enabled = false;
        }
        void populeazaCuBanci(ComboBox cbo)
        {
            cbo.Items.Clear();
            List<string> banci = new List<string>();
            banci.Add("Banca Transilvania");
            banci.Add("BCR");
            banci.Add("BRD");
            banci.Add("CEC Bank");
            banci.Add("Raiffeisen Bank");
            banci.Add("Alpha Bank");
            banci.Add("Banca Romaneasca");
            banci.Add("Bancpost");
            banci.Add("ING Bank");
            foreach (string item in banci)
            {
                cbo.Items.Add(item);
                cbo.Sorted = true;
            }
        }
        void populeazaCuOrase(ComboBox cbo)
        {
            cbo.Items.Clear();
            List<string> orase = new List<string>();
            orase.Add("Botosani");
            orase.Add("Suceava");
            orase.Add("Iasi");
            orase.Add("Vaslui");
            orase.Add("Galati");
            orase.Add("Bucuresti");
            orase.Add("Pitesti");
            orase.Add("Craiova");
            orase.Add("Targoviste");
            orase.Add("Timisoara");
            orase.Add("Arad");
            orase.Add("Cluj-Napoca");
            orase.Add("Brasov");
            orase.Add("Sibiu");
            foreach (string item in orase)
            {
                cbo.Items.Add(item);
                cbo.Sorted = true;
            }
        }
        bool checkBeforeAdd()
        {
            // Se poate realiza validarea si cu o metoda dar
            // preferam sa anuntam utilizatorul mereu cand nu a completat
            // un anumit camp chiar daca nu evitam o mica redundanta
            if (string.IsNullOrWhiteSpace(txtCodClient.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Codul clientului nu este completat.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDenumireClient.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Denumirea clientului nu este completata.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCUI.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Codul unic de inregistrare nu este completat.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIBAN.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Completati IBAN-ul clientului.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (cboBanca.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Alegeti banca.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPersContact.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Persoana de contact trebuie introdusa.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Adresa clientului nu este introdusa.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (cboOras.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Alegeti orasul.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            ok_to_add = true;
            return ok_to_add;
        }
        bool checkBeforeEdit()
        {
            if (string.IsNullOrWhiteSpace(txtDenumireClient.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Denumirea clientului nu este completata.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (cboBanca.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Alegeti banca.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPersContact.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Persoana de contact trebuie introdusa.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Adresa clientului nu este introdusa.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCodPostal.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Introduceti codul postal.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (cboOras.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Alegeti orasul.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            ok_to_edit = true;
            return ok_to_edit;
        }
        void resetAfterEdit()
        {
            mod_editare = false;
            btnSalvare.Enabled = false;
            btnRefresh.Enabled = true;
            btnAdauga.Enabled = true;
            btnSterge.Enabled = true;
            gridClienti.Enabled = true;
            btnModifica.Text = "Modifica";
            resetFields();
            disableFields();
        }
        void enableEditFields()
        {
            txtCodClient.Enabled = false; ;
            txtDenumireClient.Enabled = true;
            txtCUI.Enabled = false;
            txtIBAN.Enabled = false;
            txtPersContact.Enabled = true;
            cboBanca.Enabled = true;
            txtTelefon.Enabled = true;
            txtFax.Enabled = true;
            txtAdresa.Enabled = true;
            cboOras.Enabled = true;
            txtCodPostal.Enabled = true;
        }
        void preluareDateGrid()
        {
            if (gridClienti.Rows.Count > 0)
            {
                try
                {
                    foreach (DataGridViewRow row in gridClienti.SelectedRows)
                    {
                        txtCodClient.Text = row.Cells[0].Value.ToString();
                        txtDenumireClient.Text = row.Cells[1].Value.ToString();
                        txtCUI.Text = row.Cells[2].Value.ToString();
                        txtIBAN.Text = row.Cells[3].Value.ToString();
                        cboBanca.Text = row.Cells[4].Value.ToString();
                        txtPersContact.Text = row.Cells[5].Value.ToString();
                        txtTelefon.Text = row.Cells[6].Value.ToString();
                        txtFax.Text = row.Cells[7].Value.ToString();
                        txtAdresa.Text = row.Cells[8].Value.ToString();
                        cboOras.Text = row.Cells[9].Value.ToString();
                        txtCodPostal.Text = row.Cells[10].Value.ToString();
                        txtRegiune.Text = row.Cells[11].Value.ToString();
                        txtTara.Text = row.Cells[12].Value.ToString();
                    }
                }
                catch (Exception ex)
                {
                    string a = ex.Source;
                    MetroFramework.MetroMessageBox.Show(this, "Problema: " + a);
                }
            }
        }
        private void Clienti_Load(object sender, EventArgs e)
        {
            loadItems();
            restrictiiCampuri();
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (!mod_adaugare)
            {
                mod_adaugare = true;
                btnSalvare.Enabled = true;
                btnRefresh.Enabled = false;
                btnModifica.Enabled = false;
                btnSterge.Enabled = false;
                btnAdauga.Text = "Anuleaza";
                enableFields();
                txtCodClient.Focus();
            }
            else
            {
                mod_adaugare = false;
                btnSalvare.Enabled = false;
                btnRefresh.Enabled = true;
                btnModifica.Enabled = true;
                btnSterge.Enabled = true;
                btnAdauga.Text = "Adauga";
                resetFields();
                disableFields();
            }
        }
        private void btnSalvare_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Clienti 
                                (client_id, client_nume, persoana_contact, cui, adresa, oras, regiune, codpostal, tara, telefon, fax, iban, banca) 
                                                    VALUES (@id, @nume, @persoana, @cui, @adresa, @oras, @regiune, @codpostal, @tara, @telefon, @fax, @iban, @banca)";
            DialogResult dialog;
            // Adaugare
            if (mod_adaugare == true)
            {
                try
                {
                    checkBeforeAdd();
                    if (ok_to_add == true)
                    {
                        using (conn = new NpgsqlConnection(conexiune))
                        {
                            conn.Open();
                            using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                            {
                                comanda.Parameters.AddWithValue("@id", int.Parse(txtCodClient.Text));
                                comanda.Parameters.AddWithValue("@nume", txtDenumireClient.Text);
                                comanda.Parameters.AddWithValue("@persoana", txtPersContact.Text);
                                comanda.Parameters.AddWithValue("@cui", long.Parse(txtCUI.Text));
                                comanda.Parameters.AddWithValue("@adresa", txtAdresa.Text);
                                comanda.Parameters.AddWithValue("@oras", cboOras.SelectedItem.ToString());
                                comanda.Parameters.AddWithValue("@regiune", txtRegiune.Text);
                                // Cod postal
                                if (txtCodPostal.Text.ToString().Length > 0)
                                {
                                    comanda.Parameters.AddWithValue("@codpostal", int.Parse(txtCodPostal.Text));
                                }
                                else
                                {
                                    comanda.Parameters.AddWithValue("@codpostal", DBNull.Value);
                                }
                                // Tara
                                comanda.Parameters.AddWithValue("@tara", txtTara.Text);
                                // Telefon
                                if (txtTelefon.Text.ToString().Length > 0)
                                {
                                    comanda.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                                }
                                else
                                {
                                    comanda.Parameters.AddWithValue("@telefon", DBNull.Value);
                                }
                                // Faxul
                                if (txtFax.Text.ToString().Length > 0)
                                {
                                    comanda.Parameters.AddWithValue("@fax", txtFax.Text);
                                }
                                else
                                {
                                    comanda.Parameters.AddWithValue("@fax", DBNull.Value);
                                }
                                // Iban si Banca
                                comanda.Parameters.AddWithValue("@iban", txtIBAN.Text);
                                comanda.Parameters.AddWithValue("@banca", cboBanca.SelectedItem.ToString());
                                comanda.CommandType = CommandType.Text;
                                comanda.ExecuteNonQuery();
                            }
                            dialog = MetroFramework.MetroMessageBox.Show(this, "Clientul " + txtDenumireClient.Text + " a fost inregistrat.\nRealizati alta inregistrare?", "Succes!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialog == DialogResult.Yes)
                            {
                                using (Clienti c = new Clienti())
                                {
                                    Hide();
                                    c.ShowDialog();
                                }
                            }
                            else
                            {
                                Close();
                            }
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nu se poate adauga.\nMotiv:\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            // Ne ocupam de modificare acum
            string query_edit = @"UPDATE Clienti SET client_nume=@nume, banca=@banca, persoana_contact=@persoana, adresa=@adresa, oras=@oras,
                                            codpostal=@codpostal, tara=@tara, telefon=@telefon, fax=@fax
                                            WHERE client_id=@id";
            if (mod_editare == true)
            {
                try
                {
                    checkBeforeEdit();
                    if (ok_to_edit == true)
                    {
                        using (conn = new NpgsqlConnection(conexiune))
                        {
                            conn.Open();
                            using (NpgsqlCommand comanda = new NpgsqlCommand(query_edit, conn))
                            {
                                comanda.Parameters.AddWithValue("@nume", txtDenumireClient.Text);
                                comanda.Parameters.AddWithValue("@banca", cboBanca.SelectedItem.ToString());
                                comanda.Parameters.AddWithValue("@persoana", txtPersContact.Text);
                                comanda.Parameters.AddWithValue("@adresa", txtAdresa.Text);
                                comanda.Parameters.AddWithValue("@oras", cboOras.SelectedItem.ToString());
                                comanda.Parameters.AddWithValue("@codpostal", int.Parse(txtCodPostal.Text));
                                comanda.Parameters.AddWithValue("@tara", txtTara.Text);
                                comanda.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                                comanda.Parameters.AddWithValue("@fax", txtFax.Text);
                                comanda.Parameters.AddWithValue("@id", int.Parse(txtCodClient.Text));
                                comanda.CommandType = CommandType.Text;
                                comanda.ExecuteNonQuery();
                            }
                            dialog = MetroFramework.MetroMessageBox.Show(this, "Datele clientului " + txtDenumireClient.Text + " au fost modificate.", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            resetAfterEdit();
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Nu se poate edita.\nMotiv:\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btnSterge_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Clienti WHERE client_id=@id";
            if (gridClienti.SelectedRows.Count == 1)
            {
                int id_del = int.Parse(gridClienti.CurrentRow.Cells[0].Value.ToString());
                DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "Stergeti acest client?", "Stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        using (conn = new NpgsqlConnection(conexiune))
                        {
                            conn.Open();
                            using (NpgsqlCommand comanda = new NpgsqlCommand(query, conn))
                            {
                                comanda.Parameters.AddWithValue("@id", id_del);
                                comanda.CommandType = CommandType.Text;
                                comanda.ExecuteNonQuery();
                                gridClienti.Rows.RemoveAt(gridClienti.CurrentRow.Index);
                                MetroFramework.MetroMessageBox.Show(this, "Clientul " + gridClienti.CurrentRow.Cells[1].Value.ToString() + " a fost sters complet din baza de date.", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Nu s-a putut sterge.\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    //
                }
            }
        }
        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (gridClienti.SelectedRows.Count == 1)
            {
                if (!mod_editare)
                {
                    mod_editare = true;
                    btnSalvare.Enabled = true;
                    btnRefresh.Enabled = false;
                    btnAdauga.Enabled = false;
                    btnSterge.Enabled = false;
                    gridClienti.Enabled = false;
                    preluareDateGrid();
                    btnModifica.Text = "Anuleaza";
                    enableEditFields();
                }
                else
                {
                    mod_editare = false;
                    btnSalvare.Enabled = false;
                    btnRefresh.Enabled = true;
                    btnAdauga.Enabled = true;
                    btnSterge.Enabled = true;
                    gridClienti.Enabled = true;
                    btnModifica.Text = "Modifica";
                    resetFields();
                    disableFields();
                }
            }
        }
        private void cboOras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboOras.SelectedIndex > -1)
            {
                txtTara.Text = "Romania";
                string oras = cboOras.SelectedItem.ToString();
                if (moldova.Contains(oras))
                {
                    txtRegiune.Text = "Moldova";
                }
                else
                {
                    if (bucovina.Contains(oras))
                    {
                        txtRegiune.Text = "Bucovina";
                    }
                    else
                    {
                        if (muntenia.Contains(oras))
                        {
                            txtRegiune.Text = "Muntenia";
                        }
                        else
                        {
                            if (oltenia.Contains(oras))
                            {
                                txtRegiune.Text = "Oltenia";
                            }
                            else
                            {
                                if (banat.Contains(oras))
                                {
                                    txtRegiune.Text = "Banat";
                                }
                                else
                                {
                                    if (transilvania.Contains(oras))
                                    {
                                        txtRegiune.Text = "Transilvania";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void txtCodClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDenumireClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtCUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtIBAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void txtPersContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only letters and white space
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        private void txtAdresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsWhiteSpace(e.KeyChar) &&
              !char.IsLetter(e.KeyChar) &&
              !char.IsControl(e.KeyChar) &&
              !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
                e.Handled = true;
        }
        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtFax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCodPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnSprePlati_Click(object sender, EventArgs e)
        {
            using (ComenziC cc = new ComenziC())
            {
                cc.ShowDialog();
            }
        }
        private void btnRenunta_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
