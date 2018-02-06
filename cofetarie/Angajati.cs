using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace cofetarie
{
    public partial class Angajati : MetroFramework.Forms.MetroForm
    {

        NpgsqlConnection conn = new NpgsqlConnection(@"Server=127.0.0.1;Port=5432;Database=cofetarie;User Id=postgres;
                                                        Password = postgres;");
        private void populeazaGridAngajati()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM Angajati ORDER BY 1", conn);
                adapter.Fill(dt);
                grdAngajati.Columns[0].DataPropertyName = "angajat_id";
                grdAngajati.Columns[1].DataPropertyName = "nume";
                grdAngajati.Columns[2].DataPropertyName = "prenume";
                grdAngajati.Columns[3].DataPropertyName = "functie";
                grdAngajati.Columns[4].DataPropertyName = "datanasterii";
                grdAngajati.Columns[5].DataPropertyName = "dataangajare";
                grdAngajati.Columns[6].DataPropertyName = "adresa";
                grdAngajati.Columns[7].DataPropertyName = "oras";
                grdAngajati.Columns[8].DataPropertyName = "regiune";
                grdAngajati.Columns[9].DataPropertyName = "codpostal";
                grdAngajati.Columns[10].DataPropertyName = "tara";
                grdAngajati.Columns[11].DataPropertyName = "telefon";
                grdAngajati.Columns[12].DataPropertyName = "email";
                grdAngajati.Columns[13].DataPropertyName = "sex";
                grdAngajati.Columns[14].DataPropertyName = "salariu";
                grdAngajati.DataSource = dt;
                conn.Close();
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "A aparaut o problema.\n\n" + ex, "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                // Optional sortare functie de o coloana din grid (am pus order by 1 in query, deci nu mai e necesar)
                //grdAngajati.Sort(grdAngajati.Columns["angajat_id"], ListSortDirection.Ascending);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populeazaGridAngajati();
        }
        private void btnCauta_Click(object sender, EventArgs e)
        {

     //Extragem numele si prenumele
     //din textbox in 2 variabile
     // !!!! Mai trebuie sa restrictionam inceperea
     //txt-ului cu caracterul "spatiu"
            string angajat_cautat = txtCauta.Text;
            int spatiul = angajat_cautat.IndexOf(" ");
            int lungime = angajat_cautat.Length;
            BindingSource bs = new BindingSource();
            bs.DataSource = grdAngajati.DataSource;
            grdAngajati.DataSource = bs;

            try
            {
                if (angajat_cautat == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "Va rugam inserati numele.", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (spatiul == -1)
                {
                    bs.Filter = "nume LIKE '%" + angajat_cautat + "%'";
                }
                              
                //  else if (spatiul > 0)
                // {
                // Aici trebuie sa luam cazul cand
                // se introduce si un spatiu pt a 
                // cauta si prenumele, nu doar numele
                //  };
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n\n" +ex, "Problema!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            using (Angajati_AddEdit ang_add_edit = new Angajati_AddEdit())
            {
                ang_add_edit.ShowDialog();
            }
        }
        private void btnSterge_Click(object sender, EventArgs e)
        {
            bool exception_thrown = false;
            //Verificam daca avem selectat vreun item din grid
            if (grdAngajati.Rows.Count == 0) return;

            if (grdAngajati.SelectedRows.Count == 1)
            {
                DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "Stergeti acest angajat?", "Atentie!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dialog == DialogResult.Yes)
                {
                    //Obtinem id-ul itemului curent
                    string delete_id = grdAngajati.Rows[grdAngajati.SelectedRows[0].Index].Cells["angajat_id"].Value.ToString();
                    string nume_angajat = grdAngajati.Rows[grdAngajati.SelectedRows[0].Index].Cells["nume"].Value.ToString();
                    string prenume_angajat = grdAngajati.Rows[grdAngajati.SelectedRows[0].Index].Cells["prenume"].Value.ToString();
                    int id = int.Parse(delete_id);
                    string sql_del_ang = "DELETE FROM Angajati WHERE angajat_id = @id";
                 
                    //Stergem din BD
                    try
                    {
                        NpgsqlCommand cmd = new NpgsqlCommand(sql_del_ang, conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "A aparut o problema.\n\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                        exception_thrown = true;   
                    }
                    finally
                    {
                        if (exception_thrown == false)
                        {
                            //Stergem din grid
                            foreach (DataGridViewRow item in grdAngajati.SelectedRows)
                            {
                                grdAngajati.Rows.RemoveAt(item.Index);
                            }
                            MetroFramework.MetroMessageBox.Show(this, "Angajatul " + nume_angajat + " " + prenume_angajat + " " + " a fost sters.", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                }
            }  
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Nu aveti ce sterge.", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnInchide_Click(object sender, EventArgs e)
        {
            Close();
        }
        public Angajati()
        {
            InitializeComponent();
        }
        private void Angajati_Load(object sender, EventArgs e)
        {
            grdAngajati.ReadOnly = true;
            grdAngajati.MultiSelect = false;
            grdAngajati.AllowUserToAddRows = false;
        }
    }
}
