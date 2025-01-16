using System;
using System.Windows.Forms;

namespace Timer_v1
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TimerDataBaseDataSet.tableTimer' table. You can move, or remove it, as needed.
            //string num = txtReportTimerNumber.Text;
            //this.tableTimerTableAdapter.Fill(this.TimerDataBaseDataSet.tableTimer,num);
            //this.reportViewer1.RefreshReport();
        }



        private void frmReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            // reportViewer1.LocalReport.ReleaseSandboxAppDomain();
            // Environment.Exit(0);
        }
    }
}
