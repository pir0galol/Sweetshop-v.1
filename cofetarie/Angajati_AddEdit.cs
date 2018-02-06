using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.Text.RegularExpressions;

namespace cofetarie
{
    public partial class Angajati_AddEdit : MetroFramework.Forms.MetroForm
    {
        // Instantiate new npgsql connection
        NpgsqlConnection conn = new NpgsqlConnection(@"Server=127.0.0.1;Port=5432;Database=cofetarie;User Id=postgres;
                                                        Password = postgres;");
        bool valid;
        DataTable dt_edit = new DataTable();


        #region Only numbers for some txtboxes
        private void txtCodAngajat_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSalariu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtEditCodPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtEditTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtEditSalariu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
        public Angajati_AddEdit()
        {
            InitializeComponent();

            if (tabAddEdit.SelectedIndex == 1)
            {
                restrictFields();
                populareCboAngajati();
            }


        }
        private void Angajati_AddEdit_Load(object sender, EventArgs e)
        {
            formatCampuri();
            lungimeMaxima();
            populareCbo();
        }
        private void formatCampuri()
        {
            //Adaugare
            Regex.IsMatch(txtCodAngajat.Text, "[^0-9]");
            Regex.IsMatch(txtNumeAngajat.Text, @"^[a-z A-Z]+$");
            Regex.IsMatch(txtPrenumeAngajat.Text, @"^[a-z A-Z]+$");
            Regex.IsMatch(txtCodPostal.Text, "[^0-9]");
            Regex.IsMatch(txtTelefon.Text, "[^0-9]");
            Regex.IsMatch(txtSalariu.Text, "[^0-9]");

            //Editare
            Regex.IsMatch(txtEditNume.Text, @"^[a-z A-Z]+$");
            Regex.IsMatch(txtEditPrenume.Text, @"^[a-z A-Z]+$");
            Regex.IsMatch(txtEditCodPostal.Text, "[^0-9]");
            Regex.IsMatch(txtEditTel.Text, "[^0-9]");
            Regex.IsMatch(txtEditSalariu.Text, "[^0-9]");

        }
        private void lungimeMaxima()
        {
            //Adaugare
            txtCodAngajat.MaxLength = 3;
            txtNumeAngajat.MaxLength = 40;
            txtPrenumeAngajat.MaxLength = 40;
            txtAdresa.MaxLength = 50;
            cboOras.MaxLength = 50;
            cboRegiune.MaxLength = 50;
            txtCodPostal.MaxLength = 6;
            cboTara.MaxLength = 15;
            txtTelefon.MaxLength = 10;
            txtEmail.MaxLength = 40;
            cboFunctie.MaxLength = 15;
            cboSex.MaxLength = 8;
            txtSalariu.MaxLength = 5;

            //Editare           
            txtEditNume.MaxLength = 40;
            txtEditPrenume.MaxLength = 40;
            txtEditAdresa.MaxLength = 50;
            cboEditOras.MaxLength = 50;
            cboEditRegiune.MaxLength = 50;
            txtEditCodPostal.MaxLength = 6;
            cboEditTara.MaxLength = 15;
            txtEditTel.MaxLength = 10;
            txtEditCodPostal.MaxLength = 40;
            cboEditFunctie.MaxLength = 15;
            cboEditSex.MaxLength = 8;
            txtEditSalariu.MaxLength = 5;
        }
        private void populareCbo()
        {
            //Orase
            cboOras.Items.Clear();
            cboOras.Items.Add("Botosani");
            cboOras.Items.Add("Suceava");
            cboOras.Items.Add("Iasi");
            cboOras.Items.Add("Vaslui");
            cboOras.Items.Add("Botosani");
            cboOras.Items.Add("Galati");
            cboOras.Items.Add("Bucuresti");
            cboOras.Items.Add("Pitesti");
            cboOras.Items.Add("Craiova");
            cboOras.Items.Add("Targoviste");
            cboOras.Items.Add("Timisoara");
            cboOras.Items.Add("Arad");
            cboOras.Items.Add("ClujNapoca");
            cboOras.Items.Add("Brasov");
            cboOras.Items.Add("Sibiu");
            cboOras.Sorted = true;

            //Editare orase
            cboEditOras.Items.Clear();
            cboEditOras.Items.Add("Botosani");
            cboEditOras.Items.Add("Suceava");
            cboEditOras.Items.Add("Iasi");
            cboEditOras.Items.Add("Vaslui");
            cboEditOras.Items.Add("Botosani");
            cboEditOras.Items.Add("Galati");
            cboEditOras.Items.Add("Bucuresti");
            cboEditOras.Items.Add("Pitesti");
            cboEditOras.Items.Add("Craiova");
            cboEditOras.Items.Add("Targoviste");
            cboEditOras.Items.Add("Timisoara");
            cboEditOras.Items.Add("Arad");
            cboEditOras.Items.Add("ClujNapoca");
            cboEditOras.Items.Add("Brasov");
            cboEditOras.Items.Add("Sibiu");
            cboEditOras.Sorted = true;

            //Regiuni
            cboRegiune.Items.Clear();
            cboRegiune.Items.Add("Bucovina");
            cboRegiune.Items.Add("Moldova");
            cboRegiune.Items.Add("Dobrogea");
            cboRegiune.Items.Add("Muntenia");
            cboRegiune.Items.Add("Oltenia");
            cboRegiune.Items.Add("Transilvania");
            cboRegiune.Items.Add("Banat");
            cboRegiune.Items.Add("Crisana");
            cboRegiune.Items.Add("Maramures");
            cboRegiune.Sorted = true;

            //Editare regiuni
            cboEditRegiune.Items.Clear();
            cboEditRegiune.Items.Add("Bucovina");
            cboEditRegiune.Items.Add("Moldova");
            cboEditRegiune.Items.Add("Dobrogea");
            cboEditRegiune.Items.Add("Muntenia");
            cboEditRegiune.Items.Add("Oltenia");
            cboEditRegiune.Items.Add("Transilvania");
            cboEditRegiune.Items.Add("Banat");
            cboEditRegiune.Items.Add("Crisana");
            cboEditRegiune.Items.Add("Maramures");
            cboEditRegiune.Sorted = true;

            //Tara
            cboTara.Items.Add("Romania");
            cboEditTara.Items.Add("Romania");

            //Sex
            cboSex.Items.Add("masculin");
            cboSex.Items.Add("feminin");
            cboSex.Items.Add("?");
            cboEditSex.Items.Add("masculin");
            cboEditSex.Items.Add("feminin");
            cboEditSex.Items.Add("?");

            //Functii
            cboFunctie.Items.Add("economist");
            cboFunctie.Items.Add("informatician");
            cboFunctie.Items.Add("muncitor");
            cboFunctie.Items.Add("sofer");
            cboFunctie.Items.Add("director");
            cboFunctie.Items.Add("consilier juridic");
            cboFunctie.Items.Add("contabil");
            cboFunctie.Sorted = true;

            //Editare functii
            cboEditFunctie.Items.Add("economist");
            cboEditFunctie.Items.Add("informatician");
            cboEditFunctie.Items.Add("muncitor");
            cboEditFunctie.Items.Add("sofer");
            cboEditFunctie.Items.Add("director");
            cboEditFunctie.Items.Add("consilier juridic");
            cboEditFunctie.Items.Add("contabil");
            cboEditFunctie.Sorted = true;

        }
        private void validariNullorEmpty()
        {
            //Adaugare
            if (string.IsNullOrWhiteSpace(txtCodAngajat.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati inserat codul angajatului.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumeAngajat.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati inserat numele angajatului.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrenumeAngajat.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati inserat prenumele angajatului.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboSex.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati selectat sexul angajatului.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(dtDataNasterii.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati ales data nasterii.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati completat adresa angajatului.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(cboOras.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati selectat orasul.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboRegiune.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati selectat regiunea.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboTara.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati selectat tara.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCodPostal.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati introdus codul postal.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(cboFunctie.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati introdus functia.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(dtDataAngajare.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati introdus data angajarii.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSalariu.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati completat salariul.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            valid = true;
        }
        private void validariNullorEmpty_Edit()
        {
            //Editare angajat
            if (string.IsNullOrWhiteSpace(txtEditNume.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati inserat numele angajatului.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEditPrenume.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati inserat prenumele angajatului.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboEditSex.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati selectat sexul angajatului.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(dtEditDataNasterii.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati ales data nasterii.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEditAdresa.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati completat adresa angajatului.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(cboEditOras.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati selectat orasul.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else if (string.IsNullOrWhiteSpace(cboEditRegiune.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati selectat regiunea.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboEditTara.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati selectat tara.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEditCodPostal.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati introdus codul postal.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(cboEditFunctie.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati introdus functia.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(dtEditDataAngajare.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati introdus data angajarii.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEditSalariu.Text))  //not empty
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu ati completat salariul.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            valid = true;
        }
        private void Clear()
        {
            txtCodAngajat.Text = "";
            txtNumeAngajat.Text = "";
            txtPrenumeAngajat.Text = "";
            txtCodPostal.Text = "";
            cboSex.Text = "";
            dtDataNasterii.Text = "";
            txtAdresa.Text = "";
            cboOras.Text = "";
            cboRegiune.Text = "";
            cboTara.Text = "";
            txtCodPostal.Text = "";
            txtTelefon.Text = "";
            txtEmail.Text = "";
            cboFunctie.Text = "";
            txtTelefon.Text = "";
            dtDataAngajare.Text = "";
            txtSalariu.Text = "";


            txtCodAngajat.Focus();
        }
        private void permiteEditare()
        {
            txtEditNume.Enabled = true;
            txtEditNume.ReadOnly = false;

            txtEditPrenume.Enabled = true;
            txtEditPrenume.ReadOnly = false;

            txtEditAdresa.Enabled = true;
            txtEditAdresa.ReadOnly = false;

            txtEditCodPostal.Enabled = true;
            txtEditCodPostal.ReadOnly = false;

            cboEditOras.Enabled = true;
            cboEditRegiune.Enabled = true;
            cboEditTara.Enabled = true;
            cboEditFunctie.Enabled = true;

            txtEditTel.Enabled = true;
            txtEditTel.ReadOnly = false;
            txtEditEmail.Enabled = true;
            txtEditEmail.ReadOnly = false;
            txtEditSalariu.Enabled = true;
            txtEditSalariu.ReadOnly = false;



        }
        private void btnRenunta_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql = @"INSERT INTO Angajati (angajat_id, nume, prenume, functie, datanasterii, dataangajare, adresa, oras, regiune, codpostal, tara, telefon, email, sex, salariu) 
                                                    VALUES (@id, @nume, @prenume, @functie, @datanasterii, @dataangajare, @adresa, @oras, @regiune, @codpostal, @tara, @telefon, @email, @sex, @salariu)";
            //Verificam nulitatea campurilor
            validariNullorEmpty();

            if (valid == true)
                try
                {
                    NpgsqlCommand cmd_insert = new NpgsqlCommand(sql, conn);

                    cmd_insert.Parameters.AddWithValue("@id", int.Parse(txtCodAngajat.Text));
                    cmd_insert.Parameters.AddWithValue("@nume", txtNumeAngajat.Text);
                    cmd_insert.Parameters.AddWithValue("@prenume", txtPrenumeAngajat.Text);
                    cmd_insert.Parameters.AddWithValue("@functie", cboFunctie.SelectedItem.ToString());
                    cmd_insert.Parameters.AddWithValue("@datanasterii", dtDataNasterii.Value);
                    cmd_insert.Parameters.AddWithValue("@dataangajare", dtDataAngajare.Value);
                    cmd_insert.Parameters.AddWithValue("@adresa", txtAdresa.Text);
                    cmd_insert.Parameters.AddWithValue("@oras", cboOras.SelectedItem.ToString());
                    cmd_insert.Parameters.AddWithValue("@regiune", cboRegiune.SelectedItem.ToString());
                    cmd_insert.Parameters.AddWithValue("@codpostal", int.Parse(txtCodPostal.Text));
                    cmd_insert.Parameters.AddWithValue("@tara", cboTara.SelectedItem.ToString());
                    cmd_insert.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                    cmd_insert.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd_insert.Parameters.AddWithValue("@sex", cboSex.SelectedItem.ToString());
                    cmd_insert.Parameters.AddWithValue("@salariu", int.Parse(txtSalariu.Text));

                    conn.Open();
                    cmd_insert.CommandType = CommandType.Text;
                    cmd_insert.ExecuteNonQuery();
                    conn.Close();

                    MetroFramework.MetroMessageBox.Show(this, "Angajatul" + " " + txtNumeAngajat.Text + " " + txtPrenumeAngajat.Text + " " + "a fost adaugat.", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Clear();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
        }

        //Region Editare angajat
        private void restrictFields()
        {
            txtEditCod.Enabled = false;
            txtEditCod.ReadOnly = true;
            txtEditNume.ReadOnly = true;
            txtEditNume.Enabled = false;
            txtEditPrenume.ReadOnly = true;
            txtEditPrenume.Enabled = false;
            txtEditAdresa.ReadOnly = true;
            txtEditAdresa.Enabled = false;
            txtEditCodPostal.ReadOnly = true;
            txtEditCodPostal.Enabled = false;
            txtEditSalariu.ReadOnly = true;
            txtEditSalariu.Enabled = false;
            txtEditEmail.ReadOnly = true;
            txtEditEmail.Enabled = false;
            txtEditTel.ReadOnly = true;
            txtEditTel.Enabled = false;
            cboEditFunctie.Enabled = false;
            cboEditOras.Enabled = false;
            cboEditRegiune.Enabled = false;
            cboEditSex.Enabled = false;
            cboEditTara.Enabled = false;
            dtEditDataAngajare.Enabled = false;
            dtEditDataNasterii.Enabled = false;
        }
        private void populareCboAngajati()
        {
            try
            {
                string query = "SELECT * FROM Angajati";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                conn.Open();
                adapter.Fill(dt_edit);
                conn.Close();

                foreach (DataRow row in dt_edit.Rows)
                {
                    string nume = row["nume"].ToString();
                    string prenume = row["prenume"].ToString();
                    cboAlegeAngajat.Items.Add(nume + " " + prenume);
                }


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n" + ex, "Problema!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        private void cboAlegeAngajat_SelectedIndexChanged(object sender, EventArgs e)
        {

            int idx = cboAlegeAngajat.SelectedIndex;
            permiteEditare();

            foreach (DataRow row in dt_edit.Rows)
            {
                int currentRowIndex = dt_edit.Rows.IndexOf(row);

                if (currentRowIndex == idx)
                {
                    txtEditCod.Text = row["angajat_id"].ToString();
                    txtEditNume.Text = row["nume"].ToString();
                    txtEditPrenume.Text = row["prenume"].ToString();
                    cboEditSex.Text = row["sex"].ToString();
                    cboEditSex.ValueMember = row["sex"].ToString();
                    dtEditDataNasterii.Text = row["datanasterii"].ToString();
                    txtEditAdresa.Text = row["adresa"].ToString();
                    txtEditCodPostal.Text = row["codpostal"].ToString();
                    cboEditOras.Text = row["oras"].ToString();
                    cboEditRegiune.Text = row["regiune"].ToString();
                    cboEditTara.Text = row["tara"].ToString();
                    txtEditTel.Text = row["telefon"].ToString();
                    txtEditEmail.Text = row["email"].ToString();
                    dtEditDataAngajare.Text = row["dataangajare"].ToString();
                    cboEditFunctie.Text = row["functie"].ToString();
                    txtEditSalariu.Text = row["salariu"].ToString();
                }
            }
        }
        private void btnRenuntaEdit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE Angajati SET nume=@nume, prenume=@prenume, functie=@functie, 
                            adresa=@adresa, oras=@oras, regiune=@regiune, codpostal=@codpostal, tara=@tara, telefon=@telefon, email=@email, salariu=@salariu 
                            WHERE angajat_id=@id";
            validariNullorEmpty_Edit();

            if (valid == true)
                try
                {
                    NpgsqlCommand comanda = new NpgsqlCommand(query, conn);

                    comanda.Parameters.AddWithValue("@nume", txtEditNume.Text);
                    comanda.Parameters.AddWithValue("@prenume", txtEditPrenume.Text);
                    comanda.Parameters.AddWithValue("@functie", cboEditFunctie.SelectedItem.ToString());
                    // comanda.Parameters.AddWithValue("@datanasterii", Convert.ToDateTime(dtEditDataNasterii.Value.ToString()));
                    comanda.Parameters.AddWithValue("@adresa", txtEditAdresa.Text);
                    comanda.Parameters.AddWithValue("@oras", cboEditOras.SelectedItem.ToString());
                    comanda.Parameters.AddWithValue("@regiune", cboEditRegiune.SelectedItem.ToString());
                    comanda.Parameters.AddWithValue("@codpostal", int.Parse(txtEditCodPostal.Text));
                    comanda.Parameters.AddWithValue("@tara", cboEditTara.SelectedItem.ToString());
                    comanda.Parameters.AddWithValue("@telefon", int.Parse(txtEditTel.Text));
                    comanda.Parameters.AddWithValue("@email", txtEditEmail.Text);
                    comanda.Parameters.AddWithValue("@salariu", int.Parse(txtEditSalariu.Text));
                    comanda.Parameters.AddWithValue("@id", int.Parse(txtEditCod.Text));

                    comanda.CommandType = CommandType.Text;
                    conn.Open();
                    comanda.ExecuteNonQuery();
                    conn.Close();

                    MetroFramework.MetroMessageBox.Show(this, "Angajatul" + " " + txtEditNume.Text + " " + txtEditPrenume.Text + " " + "a fost modificat.", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
        }
    }
}
