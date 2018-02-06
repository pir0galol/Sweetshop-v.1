using Microsoft.Reporting.WinForms;
using System;
using System.Data;

namespace cofetarie
{
    public partial class RStocuri : MetroFramework.Forms.MetroForm
    {
        private string _txt
        {
            get
            {
                return txtProdus.Text;
            }   
        }
        
        public RStocuri()
        {
            InitializeComponent();
            txtProdus.MaxLength = 18;
        }

        private void RStocuri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_Stocuri.StocProduseFinite' table. You can move, or remove it, as needed.
            this.StocProduseFiniteTableAdapter.Fill(this.DataSet_Stocuri.StocProduseFinite);

            //this.reportStocuri.RefreshReport();
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            if (txtProdus.Text.ToString().Length != 0)
            {
                DataSet_StocuriTableAdapters.StocProduseFiniteTableAdapter adapter = new DataSet_StocuriTableAdapters.StocProduseFiniteTableAdapter();
                DataSet_Stocuri.StocProduseFiniteDataTable table = new DataSet_Stocuri.StocProduseFiniteDataTable();
                adapter.FillByDenumire(table, _txt);

                ReportDataSource reportDataSource = new ReportDataSource("StocProduseFinite", (DataTable)table);
                reportStocuri.LocalReport.DataSources.Clear();
                reportStocuri.LocalReport.DataSources.Add(reportDataSource);
                reportStocuri.LocalReport.Refresh();
                reportStocuri.RefreshReport();
            }
            else
            {
                DataSet_StocuriTableAdapters.StocProduseFiniteTableAdapter adapter = new DataSet_StocuriTableAdapters.StocProduseFiniteTableAdapter();
                DataSet_Stocuri.StocProduseFiniteDataTable table = new DataSet_Stocuri.StocProduseFiniteDataTable();
                adapter.Fill(table);

                ReportDataSource reportDataSource = new ReportDataSource("StocProduseFinite", (DataTable)table);
                reportStocuri.LocalReport.DataSources.Clear();
                reportStocuri.LocalReport.DataSources.Add(reportDataSource);
                reportStocuri.LocalReport.Refresh();
                reportStocuri.RefreshReport();
            }

        }
    }
}
