using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace cofetarie
{
    public partial class RComenziFurnizori : MetroFramework.Forms.MetroForm
    {
        public RComenziFurnizori()
        {
            InitializeComponent();
        }

        private void RComenziFurnizori_Load(object sender, EventArgs e)
        {
            //reportViewer1.RefreshReport();
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            if (rbnLivrate.Checked == false &&
                rbnNelivrate.Checked == false)
                return;
            if (rbnLivrate.Checked == true)
            {
                try
                {
                    DataSet1TableAdapters.DataTable1TableAdapter adapter = new DataSet1TableAdapters.DataTable1TableAdapter();
                    DataSet1.DataTable1DataTable table = new DataSet1.DataTable1DataTable();

                    adapter.Fill(table);

                    ReportDataSource source = new ReportDataSource("ComenziFurnizori", (DataTable)table);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(source);
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "A aparut o problema la incarcarea datelor.\n"+ex,"Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if(rbnNelivrate.Checked == true)
            {
                try
                {
                    DataSet1TableAdapters.DataTable1TableAdapter adapter = new DataSet1TableAdapters.DataTable1TableAdapter();
                    DataSet1.DataTable1DataTable table = new DataSet1.DataTable1DataTable();
                    adapter.FillByNoDelivery(table);

                    ReportDataSource source = new ReportDataSource("ComenziFurnizori", (DataTable)table);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(source);
                    reportViewer1.LocalReport.Refresh();
                    reportViewer1.RefreshReport();
                }
                catch(Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "A aparut o problema la incarcarea datelor.\n"+ex, "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
