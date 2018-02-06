using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using Microsoft.Reporting.WinForms;

namespace cofetarie
{
    public partial class RComenziClienti : MetroFramework.Forms.MetroForm
    {
        static string conexiune = @"Server=127.0.0.1;Port=5432;Database=cofetarie;User Id=postgres;
                                                        Password = postgres;";
        NpgsqlConnection conn = new NpgsqlConnection(conexiune);
        int idcomanda { get; set; }

        public RComenziClienti()
        {
            InitializeComponent();

            //Grid restrictii
            gridComenzi.ReadOnly = true;
            gridComenzi.AllowUserToAddRows = false;
            gridComenzi.AllowUserToDeleteRows = false;
            gridComenzi.AllowUserToResizeColumns = false;
            gridComenzi.AllowUserToResizeRows = false;
            gridComenzi.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            gridComenzi.MultiSelect = false;
            gridComenzi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            string query = @"SELECT cc.comandac_id, c.client_nume, c.oras, c.telefon
                                FROM CLIENTI c JOIN COMENZI_CLIENTI cc ON c.client_id = cc.client_id order by 1";
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
                                gridComenzi.Columns[0].DataPropertyName = "comandac_id";
                                gridComenzi.Columns[1].DataPropertyName = "client_nume";
                                gridComenzi.Columns[2].DataPropertyName = "oras";
                                gridComenzi.Columns[3].DataPropertyName = "telefon";
                                gridComenzi.DataSource = dt;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "A aparut o problema:\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RComenziClienti_Load(object sender, EventArgs e)
        {
        }

        private void btnGenereaza_Click(object sender, EventArgs e)
        {
            if (gridComenzi.Rows.Count == 0) return;
            if (gridComenzi.SelectedRows.Count == 1)
            {
                try
                {
                    idcomanda = int.Parse(gridComenzi.CurrentRow.Cells[0].Value.ToString());

                    // Instantiem un nou adapter si un nou dataTable din cadrul dataset-ului creat...
                    DataSet_ComenziClientiTableAdapters.ComenziClientiTableAdapter adapter = new DataSet_ComenziClientiTableAdapters.ComenziClientiTableAdapter();
                    DataSet_ComenziClienti.ComenziClientiDataTable table = new DataSet_ComenziClienti.ComenziClientiDataTable();
                    adapter.Fill(table, idcomanda);

                    DataSet_ComenziClientiTableAdapters.DetaliiComenziClientiTableAdapter adapter_detalii = new DataSet_ComenziClientiTableAdapters.DetaliiComenziClientiTableAdapter();
                    DataSet_ComenziClienti.DetaliiComenziClientiDataTable table_detalii = new DataSet_ComenziClienti.DetaliiComenziClientiDataTable();
                    adapter_detalii.Fill(table_detalii, idcomanda);

                    ReportDataSource source = new ReportDataSource("ComenziClienti", (DataTable)table);
                    ReportDataSource source2 = new ReportDataSource("DetaliiComenziClienti", (DataTable)table_detalii);

                    using (RaportComenziClienti rc = new RaportComenziClienti())
                    {
                        rc.report1.LocalReport.DataSources.Clear();
                        rc.report1.LocalReport.DataSources.Add(source);
                        rc.report1.LocalReport.DataSources.Add(source2);
                        rc.report1.LocalReport.Refresh();
                        rc.report1.RefreshReport();
                        rc.ShowDialog();
                    }
                }
                catch(Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "A aparut o problema:\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
