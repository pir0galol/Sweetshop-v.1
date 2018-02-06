using System;

namespace cofetarie
{
    public partial class RaportComenziClienti : MetroFramework.Forms.MetroForm
    {
        public RaportComenziClienti()
        {
            InitializeComponent();
        }

        private void RaportComenziClienti_Load(object sender, EventArgs e)
        {

            this.report1.RefreshReport();
        }
    }
}
