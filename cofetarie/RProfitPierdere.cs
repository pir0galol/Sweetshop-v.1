using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace cofetarie
{
    public partial class RProfitPierdere : MetroFramework.Forms.MetroForm
    {
        private DateTime dtInceput;
        private DateTime dtSfarsit;

        public RProfitPierdere()
        {
            InitializeComponent();
        }

        private void aflareLuna()
        {
            if (cboLuna.SelectedIndex == -1) return;
            if (cboLuna.SelectedItem.ToString() == "Ianuarie")
            {
                dtInceput = new DateTime(2017, 01, 01);
                dtSfarsit = new DateTime(2017, 01, 31);
                return;
            }
            if (cboLuna.SelectedItem.ToString() == "Februarie")
            {
                dtInceput = new DateTime(2017, 02, 01);
                dtSfarsit = new DateTime(2017, 02, 28);
                return;
            }
            if (cboLuna.SelectedItem.ToString() == "Martie")
            {
                dtInceput = new DateTime(2017, 03, 01);
                dtSfarsit = new DateTime(2017, 03, 31);
                return;
            }
            if (cboLuna.SelectedItem.ToString() == "Aprilie")
            {
                dtInceput = new DateTime(2017, 04, 01);
                dtSfarsit = new DateTime(2017, 04, 30);
                return;
            }
            if (cboLuna.SelectedItem.ToString() == "Mai")
            {
                dtInceput = new DateTime(2017, 05, 01);
                dtSfarsit = new DateTime(2017, 05, 31);
                return;
            }
            if (cboLuna.SelectedItem.ToString() == "Iunie")
            {
                dtInceput = new DateTime(2017, 06, 01);
                dtSfarsit = new DateTime(2017, 06, 30);
                return;
            }
            if (cboLuna.SelectedItem.ToString() == "Iulie")
            {
                dtInceput = new DateTime(2017, 07, 01);
                dtSfarsit = new DateTime(2017, 07, 31);
                return;
            }
            if (cboLuna.SelectedItem.ToString() == "August")
            {
                dtInceput = new DateTime(2017, 08, 01);
                dtSfarsit = new DateTime(2017, 08, 31);
                return;
            }
            if (cboLuna.SelectedItem.ToString() == "Septembrie")
            {
                dtInceput = new DateTime(2017, 09, 01);
                dtSfarsit = new DateTime(2017, 09, 30);
                return;
            }
            if (cboLuna.SelectedItem.ToString() == "Octombrie")
            {
                dtInceput = new DateTime(2017, 10, 01);
                dtSfarsit = new DateTime(2017, 10, 31);
                return;
            }
            if (cboLuna.SelectedItem.ToString() == "Noiembrie")
            {
                dtInceput = new DateTime(2017, 11, 01);
                dtSfarsit = new DateTime(2017, 11, 30);
                return;
            }
            if (cboLuna.SelectedItem.ToString() == "Decembrie")
            {
                dtInceput = new DateTime(2017, 12, 01);
                dtSfarsit = new DateTime(2017, 12, 31);
                return;
            }
        }
        void populareCbos ()
        {
            cboLuna.Items.Clear();
            cboLuna.ResetText();
            cboLuna.Items.Add("Ianuarie");
            cboLuna.Items.Add("Februarie");
            cboLuna.Items.Add("Martie");
            cboLuna.Items.Add("Aprilie");
            cboLuna.Items.Add("Mai");
            cboLuna.Items.Add("Iunie");
            cboLuna.Items.Add("Iulie");
            cboLuna.Items.Add("August");
            cboLuna.Items.Add("Septembrie");
            cboLuna.Items.Add("Octombrie");
            cboLuna.Items.Add("Noiembrie");
            cboLuna.Items.Add("Decembrie");
        }

        private void RProfitPierdere_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            if (cboLuna.SelectedIndex != -1)
            {
                aflareLuna();
                try
                {
                    DataSet_ProfitPierdereTableAdapters.TotalAchizitiiPerLunaTableAdapter adapter_achiztii = new DataSet_ProfitPierdereTableAdapters.TotalAchizitiiPerLunaTableAdapter();
                    DataSet_ProfitPierdere.TotalAchizitiiPerLunaDataTable table_achizitii = new DataSet_ProfitPierdere.TotalAchizitiiPerLunaDataTable();
                    adapter_achiztii.FillByDates(table_achizitii, dtInceput, dtSfarsit);

                    DataSet_ProfitPierdereTableAdapters.TotalVanzariPerLunaTableAdapter adapter_vanzari = new DataSet_ProfitPierdereTableAdapters.TotalVanzariPerLunaTableAdapter();
                    DataSet_ProfitPierdere.TotalVanzariPerLunaDataTable table_vanzari = new DataSet_ProfitPierdere.TotalVanzariPerLunaDataTable();
                    adapter_vanzari.FillByDates(table_vanzari, dtInceput, dtSfarsit);

                    ReportDataSource source_achiztii = new ReportDataSource("TotalAchizitiiPerLuna", (DataTable)table_achizitii);
                    ReportDataSource source_vanzari = new ReportDataSource("TotalVanzariPerLuna", (DataTable)table_vanzari);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(source_achiztii);
                    reportViewer1.LocalReport.DataSources.Add(source_vanzari);
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "A aparut o problema:\n" + ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void cboLuna_DropDown(object sender, EventArgs e)
        {
            populareCbos();
        }
    }
}
