using System;
using System.Data;
using System.Data.OleDb;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

namespace Timer_v1
{
    public partial class frmMain : Form
    {

        #region Declaration


        

        int sec1, sec2, sec3, sec4, sec5, sec6, sec7, sec8, sec9, sec10 = 00;
        int min1, min2, min3, min4, min5, min6, min7, min8, min9, min10 = 00;
        int hrs1, hrs2, hrs3, hrs4, hrs5, hrs6, hrs7, hrs8, hrs9, hrs10 = 00;
        int flagT1, flagT2, flagT3, flagT4, flagT5, flagT6, flagT7, flagT8, flagT9, flagT10 = 0;
        // bool paused;
        SerialPort sp;
        int spFlag = 0;
        int recdata;
        #endregion //Declaration

        #region Constructor

        public frmMain()
        {
            InitializeComponent();
        }

        #endregion //Constructor

        #region Events

        private void frmMain_Load(object sender, EventArgs e)
        {
            getSerialPortDetails();
            panelTimer1.Enabled = false;
            panelTimer2.Enabled = false;
            panelTimer3.Enabled = false;
            panelTimer4.Enabled = false;
            panelTimer5.Enabled = false;
            panelTimer6.Enabled = false;
            panelTimer7.Enabled = false;
            panelTimer8.Enabled = false;
            panelTimer9.Enabled = false;
            panelTimer10.Enabled = false;
        }

        private void getSerialPortDetails()
        {
            string[] portName = SerialPort.GetPortNames();
            if (portName.Length > 0)
            {
                for (int i = 0; i < portName.Length; i++)
                {
                    comboBoxPortName.Items.Add(portName[i]);
                }
            }
            else
            {
                lblT1ErrMsg.Text = "Error 1001: Not Connected";
            }
        }

        private void timerT1_Tick(object sender, EventArgs e)
        {
            sec1 = sec1 + 1;
            txtT1SWTime.Text = hrs1.ToString() + " : " + min1.ToString() + " : " + sec1.ToString();
            if (sec1 == 59)
            {
                sec1 = 0;
                min1 = min1 + 1;
                txtT1SWTime.Text = hrs1.ToString() + " : " + min1.ToString() + " : " + sec1.ToString();
                if (min1 == 59)
                {
                    min1 = 0;
                    hrs1 = hrs1 + 1;
                    txtT1SWTime.Text = hrs1.ToString() + " : " + min1.ToString() + " : " + sec1.ToString();
                }
            }
        }

        private void timerT2_Tick(object sender, EventArgs e)
        {
            sec2 = sec2 + 1;
            txtT2SWTime.Text = hrs2.ToString() + " : " + min2.ToString() + " : " + sec2.ToString();
            if (sec2 == 59)
            {
                sec2 = 0;
                min2 = min2 + 1;
                txtT2SWTime.Text = hrs2.ToString() + " : " + min2.ToString() + " : " + sec2.ToString();
                if (min2 == 59)
                {
                    min2 = 0;
                    hrs2 = hrs2 + 1;
                    txtT2SWTime.Text = hrs2.ToString() + " : " + min2.ToString() + " : " + sec2.ToString();
                }
            }
        }

        private void timerT3_Tick(object sender, EventArgs e)
        {
            sec3 = sec3 + 1;
            txtT3SWTime.Text = hrs3.ToString() + " : " + min3.ToString() + " : " + sec3.ToString();
            if (sec3 == 59)
            {
                sec3 = 0;
                min3 = min3 + 1;
                txtT3SWTime.Text = hrs3.ToString() + " : " + min3.ToString() + " : " + sec3.ToString();
                if (min3 == 59)
                {
                    min3 = 0;
                    hrs3 = hrs3 + 1;
                    txtT3SWTime.Text = hrs3.ToString() + " : " + min3.ToString() + " : " + sec3.ToString();
                }
            }
        }

        private void timerT4_Tick(object sender, EventArgs e)
        {
            sec4 = sec4 + 1;
            txtT4SWTime.Text = hrs4.ToString() + " : " + min4.ToString() + " : " + sec4.ToString();
            if (sec4 == 59)
            {
                sec4 = 0;
                min4 = min4 + 1;
                txtT4SWTime.Text = hrs4.ToString() + " : " + min4.ToString() + " : " + sec4.ToString();
                if (min4 == 59)
                {
                    min4 = 0;
                    hrs4 = hrs4 + 1;
                    txtT4SWTime.Text = hrs4.ToString() + " : " + min4.ToString() + " : " + sec4.ToString();
                }
            }
        }

        private void timerT5_Tick(object sender, EventArgs e)
        {
            sec5 = sec5 + 1;
            txtT5SWTime.Text = hrs5.ToString() + " : " + min5.ToString() + " : " + sec5.ToString();
            if (sec5 == 59)
            {
                sec5 = 0;
                min5 = min5 + 1;
                txtT5SWTime.Text = hrs5.ToString() + " : " + min5.ToString() + " : " + sec5.ToString();
                if (min5 == 59)
                {
                    min5 = 0;
                    hrs5 = hrs5 + 1;
                    txtT5SWTime.Text = hrs5.ToString() + " : " + min5.ToString() + " : " + sec5.ToString();
                }
            }
        }

        private void timerT6_Tick(object sender, EventArgs e)
        {
            sec6 = sec6 + 1;
            txtT6SWTime.Text = hrs6.ToString() + " : " + min6.ToString() + " : " + sec6.ToString();
            if (sec6 == 59)
            {
                sec6 = 0;
                min6 = min6 + 1;
                txtT6SWTime.Text = hrs6.ToString() + " : " + min6.ToString() + " : " + sec6.ToString();
                if (min6 == 59)
                {
                    min6 = 0;
                    hrs6 = hrs6 + 1;
                    txtT6SWTime.Text = hrs6.ToString() + " : " + min6.ToString() + " : " + sec6.ToString();
                }
            }
        }

        private void timerT7_Tick(object sender, EventArgs e)
        {
            sec7 = sec7 + 1;
            txtT7SWTime.Text = hrs7.ToString() + " : " + min7.ToString() + " : " + sec7.ToString();
            if (sec7 == 59)
            {
                sec7 = 0;
                min7 = min7 + 1;
                txtT7SWTime.Text = hrs7.ToString() + " : " + min7.ToString() + " : " + sec7.ToString();
                if (min7 == 59)
                {
                    min7 = 0;
                    hrs7 = hrs7 + 1;
                    txtT7SWTime.Text = hrs7.ToString() + " : " + min7.ToString() + " : " + sec7.ToString();
                }
            }
        }

        private void timerT8_Tick(object sender, EventArgs e)
        {
            sec8 = sec8 + 1;
            txtT8SWTime.Text = hrs8.ToString() + " : " + min8.ToString() + " : " + sec8.ToString();
            if (sec8 == 59)
            {
                sec8 = 0;
                min8 = min8 + 1;
                txtT8SWTime.Text = hrs8.ToString() + " : " + min8.ToString() + " : " + sec8.ToString();
                if (min8 == 59)
                {
                    min8 = 0;
                    hrs8 = hrs8 + 1;
                    txtT8SWTime.Text = hrs8.ToString() + " : " + min8.ToString() + " : " + sec8.ToString();
                }
            }
        }

        private void timerT9_Tick(object sender, EventArgs e)
        {
            sec9 = sec9 + 1;
            txtT9SWTime.Text = hrs9.ToString() + " : " + min9.ToString() + " : " + sec9.ToString();
            if (sec9 == 59)
            {
                sec9 = 0;
                min9 = min9 + 1;
                txtT9SWTime.Text = hrs9.ToString() + " : " + min9.ToString() + " : " + sec9.ToString();
                if (min9 == 59)
                {
                    min9 = 0;
                    hrs9 = hrs9 + 1;
                    txtT9SWTime.Text = hrs9.ToString() + " : " + min9.ToString() + " : " + sec9.ToString();
                }
            }
        }

        private void timerT10_Tick(object sender, EventArgs e)
        {
            sec10 = sec10 + 1;
            txtT10SWTime.Text = hrs10.ToString() + " : " + min10.ToString() + " : " + sec10.ToString();
            if (sec10 == 59)
            {
                sec10 = 0;
                min10 = min10 + 1;
                txtT10SWTime.Text = hrs10.ToString() + " : " + min10.ToString() + " : " + sec10.ToString();
                if (min10 == 59)
                {
                    min10 = 0;
                    hrs10 = hrs10 + 1;
                    txtT10SWTime.Text = hrs10.ToString() + " : " + min10.ToString() + " : " + sec10.ToString();
                }
            }
        }

        private void btnT1Reset_Click_1(object sender, EventArgs e)
        {
            ClearControlT1_1();
        }

        private void btnT2Reset_Click_1(object sender, EventArgs e)
        {
            ClearControlT2_1();
        }

        private void btnT3Reset_Click_3(object sender, EventArgs e)
        {
            ClearControlT3_1();
        }

        private void btnT4Reset_Click(object sender, EventArgs e)
        {
            ClearControlT4_1();
        }

        private void btnT5Reset_Click(object sender, EventArgs e)
        {
            ClearControlT5_1();
        }

        private void btnT6Reset_Click(object sender, EventArgs e)
        {
            ClearControlT6_1();
        }

        private void btnT7Reset_Click(object sender, EventArgs e)
        {
            ClearControlT7_1();
        }

        private void btnT8Reset_Click(object sender, EventArgs e)
        {
            ClearControlT8_1();
        }

        private void btnT9Reset_Click(object sender, EventArgs e)
        {
            ClearControlT9_1();
        }

        private void btnT10Reset_Click(object sender, EventArgs e)
        {
            ClearControlT10_1();
        }

        private void btnMasterReset_Click(object sender, EventArgs e)
        {
            ClearControlT1_1();
            ClearControlT2_1();
            ClearControlT3_1();
            ClearControlT4_1();
            ClearControlT5_1();
            ClearControlT6_1();
            ClearControlT7_1();
            ClearControlT8_1();
            ClearControlT9_1();
            ClearControlT10_1();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
            timerT1.Stop();
            timerT2.Stop();
            timerT3.Stop();
            timerT4.Stop();
            timerT5.Stop();
            timerT6.Stop();
            timerT7.Stop();
            timerT8.Stop();
            timerT9.Stop();
            timerT10.Stop();
            string message = "Do you want to Exit";
            string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (spFlag == 1)
                {
                    sp.Close();
                }
                Environment.Exit(0);
            }
        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "TimerDataBase.accdb";
            string strProvider = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", path);

            string query = "SELECT TimerAssemblyNumber, TestNumber, SW1Time, SW2Time, TestDate " +
                          " FROM tableTimer" +
                          " WHERE  TimerAssemblyNumber='" + txtSearchAssemblyNum.Text + "'";
            //TestDate=# + dateTimePicker1.Value.ToShortDateString() + #

            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            try
            {
                cmd.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable tableData = new DataTable();
                da.Fill(tableData);
                dgvTimerTestDetails.DataSource = tableData;
            }
            /* catch (Exception ex)
             {
                 lblErrorMsg.Text = ex.ToString();
             }*/
            finally
            {
                con.Close();
            }
        }

        private void btnConnectPort_Click(object sender, EventArgs e)
        {
            serialport_Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartControlT1();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            StartControlT2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartControlT3();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StartControlT4();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StartControlT5();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StartControlT6();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StartControlT7();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            StartControlT8();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            StartControlT9();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            StartControlT10();
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            frmReport rept = new frmReport();
            this.Hide();
            rept.Show();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TimerDataBaseDataSet.tableTimer' table. You can move, or remove it, as needed.
            string num = txtReportTimerNumber.Text;
            this.tableTimerTableAdapter.Fill(this.TimerDataBaseDataSet.tableTimer, num);
            this.reportViewer1.RefreshReport();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            if (spFlag == 1)
            {
                sp.Close();
            }
        }

        private void btnT1New_Click(object sender, EventArgs e)
        {
            try
            {
                timerT1.Stop();
                txtT1SWTime.Text = "00 : 00 : 00";
                lblT1SW1.Text = "00 : 00 : 00";
                lblT1SW2.Text = "00 : 00 : 00";
                txtT1TimerNum.Text = "";
                numericUpDownT1TestNum.Value = 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnT2New_Click_1(object sender, EventArgs e)
        {
            try
            {
                timerT2.Stop();
                txtT2SWTime.Text = "00 : 00 : 00";
                lblT2SW1.Text = "00 : 00 : 00";
                lblT2SW2.Text = "00 : 00 : 00";
                txtT2TimerNum.Text = "";
                numericUpDownT2TestNum.Value = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnT3New_Click(object sender, EventArgs e)
        {
            try
            {
                timerT3.Stop();
                txtT3SWTime.Text = "00 : 00 : 00";
                lblT3SW1.Text = "00 : 00 : 00";
                lblT3SW2.Text = "00 : 00 : 00";
                txtT3TimerNum.Text = "";
                numericUpDownT3TestNum.Value = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnT4New_Click(object sender, EventArgs e)
        {
            try
            {
                timerT4.Stop();
                txtT4SWTime.Text = "00 : 00 : 00";
                lblT4SW1.Text = "00 : 00 : 00";
                lblT4SW2.Text = "00 : 00 : 00";
                txtT4TimerNum.Text = "";
                numericUpDownT4TestNum.Value = 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnT5New_Click(object sender, EventArgs e)
        {
            try
            {
                timerT5.Stop();
                txtT5SWTime.Text = "00 : 00 : 00";
                lblT5SW1.Text = "00 : 00 : 00";
                lblT5SW2.Text = "00 : 00 : 00";
                txtT5TimerNum.Text = "";
                numericUpDownT5TestNum.Value = 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnT6New_Click(object sender, EventArgs e)
        {
            try
            {
                txtT6SWTime.Text = "00 : 00 : 00";
                lblT6SW1.Text = "00 : 00 : 00";
                lblT6SW2.Text = "00 : 00 : 00";
                txtT6TimerNum.Text = "";
                numericUpDownT6TestNum.Value = 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnT7New_Click(object sender, EventArgs e)
        {
            try
            {
                txtT7SWTime.Text = "00 : 00 : 00";
                lblT7SW1.Text = "00 : 00 : 00";
                lblT7SW2.Text = "00 : 00 : 00";
                txtT7TimerNum.Text = "";
                numericUpDownT7TestNum.Value = 1;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnT8New_Click(object sender, EventArgs e)
        {
            try
            {
                txtT8SWTime.Text = "00 : 00 : 00";
                lblT8SW1.Text = "00 : 00 : 00";
                lblT8SW2.Text = "00 : 00 : 00";
                txtT8TimerNum.Text = "";
                numericUpDownT8TestNum.Value = 1;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnT9New_Click(object sender, EventArgs e)
        {
            try
            {
                txtT9SWTime.Text = "00 : 00 : 00";
                lblT9SW1.Text = "00 : 00 : 00";
                lblT9SW2.Text = "00 : 00 : 00";
                txtT9TimerNum.Text = "";
                numericUpDownT9TestNum.Value = 1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lblT5SW1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPortName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownT1TestNum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTimer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDownT1TestNum_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPortName_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnConnectPort_Click_1(object sender, EventArgs e)
        {
            serialport_Connect();
        }

        private void TxtT1TimerNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnT1New_Click_1(object sender, EventArgs e)
        {
            try
            {
                timerT1.Stop();
                txtT1SWTime.Text = "00 : 00 : 00";
                lblT1SW1.Text = "00 : 00 : 00";
                lblT1SW2.Text = "00 : 00 : 00";
                txtT1TimerNum.Text = "";
                numericUpDownT1TestNum.Value = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StartControlT1();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "TimerDataBase.accdb";
            string strProvider = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", path);

            string query = "SELECT TimerAssemblyNumber, TestNumber, SW1Time, SW2Time, TestDate " +
                          " FROM tableTimer" +
                          " WHERE  TimerAssemblyNumber='" + txtSearchAssemblyNum.Text + "'";
            //TestDate=# + dateTimePicker1.Value.ToShortDateString() + #

            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(query, con);
            con.Open();
            try
            {
                cmd.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable tableData = new DataTable();
                da.Fill(tableData);
                dgvTimerTestDetails.DataSource = tableData;
            }
            /* catch (Exception ex)
             {
                 lblErrorMsg.Text = ex.ToString();
             }*/
            finally
            {
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxT1Reset_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void btnT2New_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxT3Reset_Click(object sender, EventArgs e)
        {
            ClearControlT3_1();
        }

        private void btnT3New_Click_1(object sender, EventArgs e)
        {
            try
            {
                timerT3.Stop();
                txtT3SWTime.Text = "00 : 00 : 00";
                lblT3SW1.Text = "00 : 00 : 00";
                lblT3SW2.Text = "00 : 00 : 00";
                txtT3TimerNum.Text = "";
                numericUpDownT3TestNum.Value = 0;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            StartControlT3();
        }

        private void btnT4New_Click_1(object sender, EventArgs e)
        {
            try
            {
                timerT4.Stop();
                txtT4SWTime.Text = "00 : 00 : 00";
                lblT4SW1.Text = "00 : 00 : 00";
                lblT4SW2.Text = "00 : 00 : 00";
                txtT4TimerNum.Text = "";
                numericUpDownT4TestNum.Value = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            StartControlT4();
        }

        private void btnT5New_Click_1(object sender, EventArgs e)
        {
            try
            {
                timerT5.Stop();
                txtT5SWTime.Text = "00 : 00 : 00";
                lblT5SW1.Text = "00 : 00 : 00";
                lblT5SW2.Text = "00 : 00 : 00";
                txtT5TimerNum.Text = "";
                numericUpDownT5TestNum.Value = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            StartControlT5();
        }

        private void btnT6New_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtT6SWTime.Text = "00 : 00 : 00";
                lblT6SW1.Text = "00 : 00 : 00";
                lblT6SW2.Text = "00 : 00 : 00";
                txtT6TimerNum.Text = "";
                numericUpDownT6TestNum.Value = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            StartControlT6();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ClearControlT1_1();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClearControlT2_1();
        }

        private void pictureBoxT4Reset_Click(object sender, EventArgs e)
        {
            ClearControlT4_1();
        }

        private void pictureBoxT5Reset_Click(object sender, EventArgs e)
        {
            ClearControlT5_1();
        }

        private void pictureBoxT6Reset_Click(object sender, EventArgs e)
        {
            ClearControlT6_1();
        }

        private void btnT7New_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtT7SWTime.Text = "00 : 00 : 00";
                lblT7SW1.Text = "00 : 00 : 00";
                lblT7SW2.Text = "00 : 00 : 00";
                txtT7TimerNum.Text = "";
                numericUpDownT7TestNum.Value = 0;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            StartControlT7();
        }

        private void pictureBoxT7Reset_Click(object sender, EventArgs e)
        {
            ClearControlT7_1();
        }

        private void btnT8New_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtT8SWTime.Text = "00 : 00 : 00";
                lblT8SW1.Text = "00 : 00 : 00";
                lblT8SW2.Text = "00 : 00 : 00";
                txtT8TimerNum.Text = "";
                numericUpDownT8TestNum.Value = 0;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            StartControlT8();
        }

        private void pictureBoxT8Reset_Click(object sender, EventArgs e)
        {
            ClearControlT8_1();
        }

        private void btnT9New_Click_1(object sender, EventArgs e)
        {
            try
            {
                txtT9SWTime.Text = "00 : 00 : 00";
                lblT9SW1.Text = "00 : 00 : 00";
                lblT9SW2.Text = "00 : 00 : 00";
                txtT9TimerNum.Text = "";
                numericUpDownT9TestNum.Value = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            StartControlT9();
        }

        private void pictureBoxT9Reset_Click(object sender, EventArgs e)
        {
            ClearControlT9_1();
        }

        private void btnT10New_Click(object sender, EventArgs e)
        {
            try
            {
                txtT10SWTime.Text = "00 : 00 : 00";
                lblT10SW1.Text = "00 : 00 : 00";
                lblT10SW2.Text = "00 : 00 : 00";
                txtT10TimerNum.Text = "";
                numericUpDownT10TestNum.Value = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            StartControlT10();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            serialport_Connect();
        }

        private void button1_Click_3(object sender, EventArgs e)
        {

        }

        private void btnGenerateReport_Click_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'TimerDataBaseDataSet.tableTimer' table. You can move, or remove it, as needed.
            string num = txtReportTimerNumber.Text;
            this.tableTimerTableAdapter.Fill(this.TimerDataBaseDataSet.tableTimer, num);
            this.reportViewer1.RefreshReport();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTimer5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSerachTimerNum_Click(object sender, EventArgs e)
        {

        }

        private void lblTimerHeading2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchAssemblyNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvTimerTestDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblT1SW1_Click(object sender, EventArgs e)
        {

        }

        private void lblTimerHeading1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (spFlag == 1)
            {
                sp.Close();
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblReportTimerNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnConnectPort_Click_2(object sender, EventArgs e)
        {
            serialport_Connect();
        }

        private void btnMasterReset_Click_1(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
            timerT1.Stop();
            timerT2.Stop();
            timerT3.Stop();
            timerT4.Stop();
            timerT5.Stop();
            timerT6.Stop();
            timerT7.Stop();
            timerT8.Stop();
            timerT9.Stop();
            timerT10.Stop();
            string message = "Do you want to Exit";
            string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (spFlag == 1)
                {
                    sp.Close();
                }
                Environment.Exit(0);
            }
        }

        private void pictureBoxT10Reset_Click(object sender, EventArgs e)
        {
            ClearControlT9_1();
        }


        #endregion //Events

        #region Methods

        //Serial Port Connection Code

        private void serialport_Connect()
        {

            if (comboBoxPortName.SelectedIndex >= 0)
            {
                string port = comboBoxPortName.Text;
                sp = new SerialPort(port);

                sp.BaudRate = 9600;
                sp.Parity = Parity.None;
                sp.DataBits = 8;
                sp.StopBits = StopBits.One;
                sp.DtrEnable = true;

                sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                numericUpDownT1TestNum.Value = 0;
                numericUpDownT2TestNum.Value = 0;
                numericUpDownT3TestNum.Value = 0;
                numericUpDownT4TestNum.Value = 0;
                numericUpDownT5TestNum.Value = 0;
                numericUpDownT6TestNum.Value = 0;
                numericUpDownT7TestNum.Value = 0;
                numericUpDownT8TestNum.Value = 0;
                numericUpDownT9TestNum.Value = 0;
                numericUpDownT10TestNum.Value = 0;
                try
                {
                    if (sp.IsOpen)
                    {
                        sp.Close();
                    }
                    else
                    {
                        sp.Open();
                        spFlag = 1;
                        panelTimer1.Enabled = true;
                        panelTimer2.Enabled = true;
                        panelTimer3.Enabled = true;
                        panelTimer4.Enabled = true;
                        panelTimer5.Enabled = true;
                        panelTimer6.Enabled = true;
                        panelTimer7.Enabled = true;
                        panelTimer8.Enabled = true;
                        panelTimer9.Enabled = true;
                        panelTimer10.Enabled = true;
                        txtT1SWTime.Focus();
                        MessageBox.Show("Please enter timer number then proceed further", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    //if (spFlag == 1)
                    //{
                    //    sp.Write("CHK");
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Please Select Port");
            }
        }

        //Code to received data from Serial Port

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] data = new byte[1];

            new Thread(() =>
            {
                try
                {
                    sp.Read(data, 0, data.Length);
                    while (data.Length > 0)
                    {
                        if (InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(delegate
                            {
                                recdata = data[0];
                               

                                //StringBuilder stringBuilder = new StringBuilder(System.Environment.NewLine + Encoding.Default.GetString(data));
                                //recdata = stringBuilder.ToString();
                                //txtT2TimerNum.Text = recdata.ToString(); //stringBuilder.ToString();
                                checkRecData(recdata);
                            }));
                            return;
                        }


                    }
                }
                catch (Exception)
                {

                }
            }).Start();
        }

        private void checkRecData(int recdata)
        {
            int switchCase = 0;

            try
            {
                if (recdata >= 64 && recdata <= 67)
                {
                    switchCase = 1;
                }
                if (recdata >= 68 && recdata <= 70)
                {
                    switchCase = 2;
                }
                if (recdata >= 71 && recdata <= 73)
                {
                    switchCase = 3;
                }
                if (recdata >= 74 && recdata <= 76)
                {
                    switchCase = 4;
                }
                if (recdata >= 77 && recdata <= 79)
                {
                    switchCase = 5;
                }
                if (recdata >= 80 && recdata <= 82)
                {
                    switchCase = 6;
                }
                if (recdata >= 83 && recdata <= 85)
                {
                    switchCase = 7;
                }
                if (recdata >= 86 && recdata <= 88)
                {
                    switchCase = 8;
                }
                if (recdata == 89 || recdata == 90 || recdata == 97)
                {
                    switchCase = 9;
                }
                if (recdata >= 98 && recdata <= 100)
                {
                    switchCase = 10;
                }
               
                switch (switchCase)
                {
                    
                    /////////////////// TIMER 1 /////////////////////////////////
                    case 1:
                        if (recdata == 65 && txtT1TimerNum.Text != "")
                        {
                            //connectDB(txtT1TimerNum.Text, numericUpDownT1TestNum.Value, lblT1SW1.Text, lblT1SW2.Text); 
                            ClearControlT1();
                            timerT1.Enabled = true;
                            timerT1.Start();
                            numericUpDownT1TestNum.Value = numericUpDownT1TestNum.Value + 1;
                        }
                        else if (recdata == 66 && txtT1TimerNum.Text != "")
                        {
                            lblT1SW1.Text = txtT1SWTime.Text;
                            flagT1 = 1;
                           // if((lblT1SW1.Equals("00:04:0"))||(lblT1SW1.Equals("00:24:59")))
                           // {
                            //    lblT1SW1.ForeColor = System.Drawing.Color.Red;

                            //}
                           // else { 
                            //    lblT1SW1.ForeColor = System.Drawing.Color.Green;
                          //  }
                        }
                        else if (recdata == 67 && txtT1TimerNum.Text != "")
                        {

                            timerT1.Enabled = false;
                            lblT1SW2.Text = txtT1SWTime.Text;
                            if (flagT1 == 1)
                            {
                                connectDB(txtT1TimerNum.Text, numericUpDownT1TestNum.Value.ToString(), lblT1SW1.Text, lblT1SW2.Text, "NO", "NC", "NO", "NC");
                            }
                            else
                            {
                                connectDB(txtT1TimerNum.Text, numericUpDownT1TestNum.Value.ToString(), lblT1SW1.Text, lblT1SW2.Text, "NC", "NO", "NO", "NC");
                            }
                            flagT1 = 0;
                        }
                        else
                        {
                            lblT1ErrMsg.Text = "Info : Please put Timer Number";
                        }
                        break;


                    /////////////////// TIMER 2 /////////////////////////////////
                    case 2:
                        if (recdata == 68 && txtT2TimerNum.Text != "")
                        {
                            ClearControlT2();
                            timerT2.Enabled = true;
                            timerT2.Start();
                            numericUpDownT2TestNum.Value = numericUpDownT2TestNum.Value + 1;
                        }
                        else if (recdata == 69 && txtT2TimerNum.Text != "")
                        {
                            lblT2SW1.Text = txtT2SWTime.Text;
                            flagT2 = 1;
                        }
                        else if (recdata == 70 && txtT2TimerNum.Text != "")
                        {
                            timerT2.Enabled = false;
                            lblT2SW2.Text = txtT2SWTime.Text;
                            if (flagT2 == 1)
                            {
                                connectDB(txtT2TimerNum.Text, numericUpDownT2TestNum.Value.ToString(), lblT2SW1.Text, lblT2SW2.Text, "NO", "NC", "NO", "NC");
                            }
                            else
                            {
                                connectDB(txtT2TimerNum.Text, numericUpDownT2TestNum.Value.ToString(), lblT2SW1.Text, lblT2SW2.Text, "NC", "NO", "NO", "NC");
                            }
                            flagT2 = 0;
                        }
                        else
                        {
                            lblT2ErrMsg.Text = "Info : Please put Timer Number";
                        }
                        break;




                    /////////////////// TIMER 3 /////////////////////////////////
                    case 3:
                        if (recdata == 71 && txtT3TimerNum.Text != "")
                        {
                            //connectDB(txtT3TimerNum.Text, numericUpDownT3TestNum.Value, lblT3SW1.Text, lblT3SW2.Text);
                            ClearControlT3();
                            timerT3.Enabled = true;
                            timerT3.Start();
                            numericUpDownT3TestNum.Value = numericUpDownT3TestNum.Value + 1;
                        }
                        else if (recdata == 72 && txtT3TimerNum.Text != "")
                        {
                            lblT3SW1.Text = txtT3SWTime.Text;
                            flagT3 = 1;
                        }
                        else if (recdata == 73 && txtT3TimerNum.Text != "")
                        {
                            timerT3.Enabled = false;
                            lblT3SW2.Text = txtT3SWTime.Text;
                            if (flagT3 == 1)
                            {
                                connectDB(txtT3TimerNum.Text, numericUpDownT3TestNum.Value.ToString(), lblT3SW1.Text, lblT3SW2.Text, "NO", "NC", "NO", "NC");
                            }
                            else
                            {
                                connectDB(txtT3TimerNum.Text, numericUpDownT3TestNum.Value.ToString(), lblT3SW1.Text, lblT3SW2.Text, "NC", "NO", "NO", "NC");
                            }
                            flagT3 = 0;
                        }
                        else
                        {
                            lblT3ErrMsg.Text = "Info : Please put Timer Number";
                        }
                        break;




                    /////////////////// TIMER 4 /////////////////////////////////
                    case 4:
                        if (recdata == 74 && txtT4TimerNum.Text != "")
                        {
                            //connectDB(txtT4TimerNum.Text, numericUpDownT4TestNum.Value, lblT4SW1.Text, lblT4SW2.Text);
                            ClearControlT4();
                            timerT4.Enabled = true;
                            timerT4.Start();
                            numericUpDownT4TestNum.Value = numericUpDownT4TestNum.Value + 1;

                        }
                        else if (recdata == 75 && txtT4TimerNum.Text != "")
                        {
                            lblT4SW1.Text = txtT4SWTime.Text;
                            flagT4 = 1;
                        }
                        else if (recdata == 76 && txtT4TimerNum.Text != "")
                        {
                            timerT4.Enabled = false;
                            lblT4SW2.Text = txtT4SWTime.Text;
                            if (flagT4 == 1)
                            {
                                connectDB(txtT4TimerNum.Text, numericUpDownT4TestNum.Value.ToString(), lblT4SW1.Text, lblT4SW2.Text, "NO", "NC", "NO", "NC");
                            }
                            else
                            {
                                connectDB(txtT4TimerNum.Text, numericUpDownT4TestNum.Value.ToString(), lblT4SW1.Text, lblT4SW2.Text, "NC", "NO", "NO", "NC");
                            }
                            flagT4 = 0;
                        }
                        else
                        {
                            lblT4ErrMsg.Text = "Info : Please put Timer Number";
                        }
                        break;


                    /////////////////// TIMER 5 /////////////////////////////////
                    case 5:
                        if (recdata == 77 && txtT5TimerNum.Text != "")
                        {
                            //connectDB(txtT5TimerNum.Text, numericUpDownT5TestNum.Value, lblT5SW1.Text, lblT5SW2.Text); 
                            ClearControlT5();
                            timerT5.Enabled = true;
                            timerT5.Start();
                            numericUpDownT5TestNum.Value = numericUpDownT5TestNum.Value + 1;

                        }
                        else if (recdata == 78 && txtT5TimerNum.Text != "")
                        {
                            lblT5SW1.Text = txtT5SWTime.Text;
                            flagT5 = 1;
                        }
                        else if (recdata == 79 && txtT5TimerNum.Text != "")
                        {
                            timerT5.Enabled = false;
                            lblT5SW2.Text = txtT5SWTime.Text;
                            if (flagT5 == 1)
                            {
                                connectDB(txtT5TimerNum.Text, numericUpDownT5TestNum.Value.ToString(), lblT5SW1.Text, lblT5SW2.Text, "NO", "NC", "NO", "NC");
                            }
                            else
                            {
                                connectDB(txtT5TimerNum.Text, numericUpDownT5TestNum.Value.ToString(), lblT5SW1.Text, lblT5SW2.Text, "NC", "NO", "NO", "NC");
                            }
                            flagT5 = 0;
                        }
                        else
                        {
                            lblT5ErrMsg.Text = "Info : Please put Timer Number";
                        }
                        break;



                    /////////////////// TIMER 6 /////////////////////////////////
                    case 6:
                        if (recdata == 80 && txtT6TimerNum.Text != "")
                        {
                            //connectDB(txtT6TimerNum.Text, numericUpDownT6TestNum.Value, lblT6SW1.Text, lblT6SW2.Text);
                            ClearControlT6();
                            timerT6.Enabled = true;
                            timerT6.Start();
                            numericUpDownT6TestNum.Value = numericUpDownT6TestNum.Value + 1;

                        }
                        else if (recdata == 81 && txtT6TimerNum.Text != "")
                        {
                            lblT6SW1.Text = txtT6SWTime.Text;
                            flagT6 = 1;
                        }
                        else if (recdata == 82 && txtT6TimerNum.Text != "")
                        {
                            timerT6.Enabled = false;
                            lblT6SW2.Text = txtT6SWTime.Text;
                            if (flagT6 == 1)
                            {
                                connectDB(txtT6TimerNum.Text, numericUpDownT6TestNum.Value.ToString(), lblT6SW1.Text, lblT6SW2.Text, "NO", "NC", "NO", "NC");
                            }
                            else
                            {
                                connectDB(txtT6TimerNum.Text, numericUpDownT6TestNum.Value.ToString(), lblT6SW1.Text, lblT6SW2.Text, "NC", "NO", "NO", "NC");
                            }
                            flagT6 = 0;
                        }
                        else
                        {
                            lblT6ErrMsg.Text = "Info : Please put Timer Number";
                        }
                        break;


                    /////////////////// TIMER 7 /////////////////////////////////
                    case 7:
                        if (recdata == 83 && txtT7TimerNum.Text != "")
                        {
                            //connectDB(txtT7TimerNum.Text, numericUpDownT7TestNum.Value, lblT7SW1.Text, lblT7SW2.Text);
                            ClearControlT7();
                            timerT7.Enabled = true;
                            timerT7.Start();
                            numericUpDownT7TestNum.Value = numericUpDownT7TestNum.Value + 1;
                        }
                        else if (recdata == 84 && txtT7TimerNum.Text != "")
                        {
                            lblT7SW1.Text = txtT7SWTime.Text;
                            flagT7 = 1;
                        }
                        else if (recdata == 85 && txtT7TimerNum.Text != "")
                        {
                            timerT7.Enabled = false;
                            lblT7SW2.Text = txtT7SWTime.Text;
                            if (flagT7 == 1)
                            {
                                connectDB(txtT7TimerNum.Text, numericUpDownT7TestNum.Value.ToString(), lblT7SW1.Text, lblT7SW2.Text, "NO", "NC", "NO", "NC");
                            }
                            else
                            {
                                connectDB(txtT7TimerNum.Text, numericUpDownT7TestNum.Value.ToString(), lblT7SW1.Text, lblT7SW2.Text, "NC", "NO", "NO", "NC");
                            }
                            flagT7 = 0;
                        }
                        else
                        {
                            lblT7ErrMsg.Text = "Info : Please put Timer Number";
                        }
                        break;


                    /////////////////// TIMER 8 /////////////////////////////////
                    case 8:
                        if (recdata == 86 && txtT8TimerNum.Text != "")
                        {
                            //connectDB(txtT8TimerNum.Text, numericUpDownT8TestNum.Value, lblT8SW1.Text, lblT8SW2.Text);
                            ClearControlT8();
                            timerT8.Enabled = true;
                            timerT8.Start();
                            numericUpDownT8TestNum.Value = numericUpDownT8TestNum.Value + 1;
                        }
                        else if (recdata == 87 && txtT8TimerNum.Text != "")
                        {
                            lblT8SW1.Text = txtT8SWTime.Text;
                            flagT8 = 1;
                        }
                        else if (recdata == 88 && txtT8TimerNum.Text != "")
                        {
                            timerT8.Enabled = false;
                            lblT8SW2.Text = txtT8SWTime.Text;
                            if (flagT8 == 1)
                            {
                                connectDB(txtT8TimerNum.Text, numericUpDownT8TestNum.Value.ToString(), lblT8SW1.Text, lblT8SW2.Text, "NO", "NC", "NO", "NC");
                            }
                            else
                            {
                                connectDB(txtT8TimerNum.Text, numericUpDownT8TestNum.Value.ToString(), lblT8SW1.Text, lblT8SW2.Text, "NC", "NO", "NO", "NC");
                            }
                            flagT8 = 0;
                        }
                        else
                        {
                            lblT8ErrMsg.Text = "Info : Please put Timer Number";
                        }
                        break;


                    /////////////////// TIMER 9 /////////////////////////////////
                    case 9:
                        if (recdata == 89 && txtT9TimerNum.Text != "")
                        {
                            //connectDB(txtT9TimerNum.Text, numericUpDownT9TestNum.Value, lblT9SW1.Text, lblT9SW2.Text);
                            ClearControlT9();
                            timerT9.Enabled = true;
                            timerT9.Start();
                            numericUpDownT9TestNum.Value = numericUpDownT9TestNum.Value + 1;

                        }
                        else if (recdata == 90 && txtT9TimerNum.Text != "")
                        {
                            lblT9SW1.Text = txtT9SWTime.Text;
                            flagT9 = 1;
                        }
                        else if (recdata == 97 && txtT9TimerNum.Text != "")
                        {
                            timerT9.Enabled = false;
                            lblT9SW2.Text = txtT9SWTime.Text;
                            if (flagT9 == 1)
                            {
                                connectDB(txtT9TimerNum.Text, numericUpDownT9TestNum.Value.ToString(), lblT9SW1.Text, lblT9SW2.Text, "NO", "NC", "NO", "NC");
                            }
                            else
                            {
                                connectDB(txtT9TimerNum.Text, numericUpDownT9TestNum.Value.ToString(), lblT9SW1.Text, lblT9SW2.Text, "NC", "NO", "NO", "NC");
                            }
                            flagT9 = 0;
                        }
                        else
                        {
                            lblT9ErrMsg.Text = "Info : Please put Timer Number";
                        }
                        break;



                    /////////////////// TIMER 10 /////////////////////////////////
                    case 10:
                        if (recdata == 98 && txtT10TimerNum.Text != "")
                        {
                            //connectDB(txtT10TimerNum.Text, numericUpDownT10TestNum.Value, lblT10SW1.Text, lblT10SW2.Text);
                            ClearControlT10();
                            timerT10.Enabled = true;
                            timerT10.Start();
                            numericUpDownT10TestNum.Value = numericUpDownT10TestNum.Value + 1;

                        }
                        else if (recdata == 99 && txtT10TimerNum.Text != "")
                        {
                            lblT10SW1.Text = txtT10SWTime.Text;
                            flagT10 = 1;
                        }
                        else if (recdata == 100 && txtT10TimerNum.Text != "")
                        {
                            timerT10.Enabled = false;
                            lblT10SW2.Text = txtT10SWTime.Text;
                            if (flagT10 == 1)
                            {
                                connectDB(txtT10TimerNum.Text, numericUpDownT10TestNum.Value.ToString(), lblT10SW1.Text, lblT10SW2.Text, "NO", "NC", "NO", "NC");
                            }
                            else
                            {
                                connectDB(txtT10TimerNum.Text, numericUpDownT10TestNum.Value.ToString(), lblT10SW1.Text, lblT10SW2.Text, "NC", "NO", "NO", "NC");
                            }
                            flagT10 = 0;
                        }
                        else
                        {
                            lblT10ErrMsg.Text = "Info : Please put Timer Number";
                        }
                        break;

                    default:
                        break;
                }
            }
            catch (Exception)
            {

            }
        }
 private void connectDB()
        {
            DateTime date = DateTime.Now.Date;
            string path = AppDomain.CurrentDomain.BaseDirectory + "TimerDataBase.accdb";
            string strProvider = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", path);

            string query = "INSERT INTO tableTimer (TimerAssemblyNumber, TestNumber, SW1Time, SW2Time, TestDate) VALUES ('" + txtT1TimerNum.Text.Trim() + "','" + numericUpDownT1TestNum.Value.ToString() + "','" + lblT1SW1.Text.Trim() + "','" + lblT1SW2.Text.Trim() + "','" + DateTime.Now.ToString() + "'); ";

            query += "INSERT INTO tableTimer (TimerAssemblyNumber,TestNumber,SW1Time,SW2Time,TestDate) VALUES ('" + txtT2TimerNum.Text.Trim() + "','" + numericUpDownT2TestNum.Value.ToString() + "','" + lblT2SW1.Text.Trim() + "','" + lblT2SW2.Text.Trim() + "','" + DateTime.Now.Date + "'); ";
            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                //cmd.CommandType = CommandType.Text;
                //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                //DataTable tableData = new DataTable();
                //OleDbDataReader reader = cmd.ExecuteReader();
                //if (reader.Read())
                //{
                //    txtFCSVelocity.Text = reader["Velocity"].ToString();
                //    txtHeaderReqElev.Text = reader["Elev_Angle_Degree"].ToString();
                //    // string text=txtFCSVelocity.Text + " " + txtHeaderReqElev.Text;
                //    // File.WriteAllText("C:\\Users\\bfl\\Desktop\\Bharat52\\Bharat52\\Data.txt",text);
                //}
            }
            catch (Exception ex)
            {
                lblT1ErrMsg.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }
        }

        private void ClearControlT1()
        {
            timerT1.Stop();
            txtT1SWTime.Text = "00 : 00 : 00";
            lblT1SW1.Text = "00 : 00 : 00";
            lblT1SW2.Text = "00 : 00 : 00";
            //txtT1TimerNum.Text = "";
            //numericUpDownT1TestNum.Value = 0;
            sec1 = 0;
            min1 = 0;
            hrs1 = 0;
        }

        private void ClearControlT1_1()
        {
            timerT1.Stop();
            if (txtT1TimerNum.Text != "")
            {
                if (flagT1 == 1)
                {
                    connectDB(txtT1TimerNum.Text, numericUpDownT1TestNum.Value.ToString(), lblT1SW1.Text, lblT1SW2.Text, "NO", "NC", "NC", "NO");
                    flagT1 = 0;
                }
                else
                {
                    connectDB(txtT1TimerNum.Text, numericUpDownT1TestNum.Value.ToString(), lblT1SW1.Text, lblT1SW2.Text, "NC", "NO", "NC", "NO");
                }
            }
            txtT1SWTime.Text = "00 : 00 : 00";
            lblT1SW1.Text = "00 : 00 : 00";
            lblT1SW2.Text = "00 : 00 : 00";
            txtT1TimerNum.Text = "";
            numericUpDownT1TestNum.Value = 0;

            sec1 = 0;
            min1 = 0;
            hrs1 = 0;
        }

        public void ClearControlT2()
        {
            timerT2.Stop();
            txtT2SWTime.Text = "00 : 00 : 00";
            lblT2SW1.Text = "00 : 00 : 00";
            lblT2SW2.Text = "00 : 00 : 00";
            //txtT2TimerNum.Text = "";
            //numericUpDownT2TestNum.Value = 0;
            sec2 = 0;
            min2 = 0;
            hrs2 = 0;
        }

        public void ClearControlT2_1()
        {
            timerT2.Stop();
            if (txtT2TimerNum.Text != "")
            {
                if (flagT2 == 1)
                {
                    connectDB(txtT2TimerNum.Text, numericUpDownT2TestNum.Value.ToString(), lblT2SW1.Text, lblT2SW2.Text, "NO", "NC", "NC", "NO");
                    flagT2 = 0;
                }
                else
                {
                    connectDB(txtT2TimerNum.Text, numericUpDownT2TestNum.Value.ToString(), lblT2SW1.Text, lblT2SW2.Text, "NC", "NO", "NC", "NO");
                }
            }
            txtT2SWTime.Text = "00 : 00 : 00";
            lblT2SW1.Text = "00 : 00 : 00";
            lblT2SW2.Text = "00 : 00 : 00";
            txtT2TimerNum.Text = "";
            numericUpDownT2TestNum.Value = 0;
            sec2 = 0;
            min2 = 0;
            hrs2 = 0;
        }

        private void ClearControlT3()
        {
            timerT3.Stop();
            txtT3SWTime.Text = "00 : 00 : 00";
            lblT3SW1.Text = "00 : 00 : 00";
            lblT3SW2.Text = "00 : 00 : 00";
            //txtT3TimerNum.Text = "";
            //numericUpDownT3TestNum.Value = 0;
            sec3 = 0;
            min3 = 0;
            hrs3 = 0;
        }

        private void ClearControlT3_1()
        {
            timerT3.Stop();
            if (txtT3TimerNum.Text != "")
            {
                if (flagT3 == 1)
                {
                    connectDB(txtT3TimerNum.Text, numericUpDownT3TestNum.Value.ToString(), lblT3SW1.Text, lblT3SW2.Text, "NO", "NC", "NC", "NO");
                    flagT3 = 0;
                }
                else
                {
                    connectDB(txtT3TimerNum.Text, numericUpDownT3TestNum.Value.ToString(), lblT3SW1.Text, lblT3SW2.Text, "NC", "NO", "NC", "NO");
                }
            }
            txtT3SWTime.Text = "00 : 00 : 00";
            lblT3SW1.Text = "00 : 00 : 00";
            lblT3SW2.Text = "00 : 00 : 00";
            txtT3TimerNum.Text = "";
            numericUpDownT3TestNum.Value = 0;
            sec3 = 0;
            min3 = 0;
            hrs3 = 0;
        }

        private void ClearControlT4()
        {
            timerT4.Stop();
            txtT4SWTime.Text = "00 : 00 : 00";
            lblT4SW1.Text = "00 : 00 : 00";
            lblT4SW2.Text = "00 : 00 : 00";
            //txtT4TimerNum.Text = "";
            //numericUpDownT4TestNum.Value = 0;
            sec4 = 0;
            min4 = 0;
            hrs4 = 0;
        }

        private void ClearControlT4_1()
        {
            timerT4.Stop();
            if (txtT4TimerNum.Text != "")
            {
                if (flagT4 == 1)
                {
                    connectDB(txtT4TimerNum.Text, numericUpDownT4TestNum.Value.ToString(), lblT4SW1.Text, lblT4SW2.Text, "NO", "NC", "NC", "NO");
                    flagT4 = 0;
                }
                else
                {
                    connectDB(txtT4TimerNum.Text, numericUpDownT4TestNum.Value.ToString(), lblT4SW1.Text, lblT4SW2.Text, "NC", "NO", "NC", "NO");
                }
            }
            txtT4SWTime.Text = "00 : 00 : 00";
            lblT4SW1.Text = "00 : 00 : 00";
            lblT4SW2.Text = "00 : 00 : 00";
            txtT4TimerNum.Text = "";
            numericUpDownT4TestNum.Value = 0;
            sec4 = 0;
            min4 = 0;
            hrs4 = 0;
        }

        private void ClearControlT5()
        {
            timerT5.Stop();
            txtT5SWTime.Text = "00 : 00 : 00";
            lblT5SW1.Text = "00 : 00 : 00";
            lblT5SW2.Text = "00 : 00 : 00";
            //txtT5TimerNum.Text = "";
            //numericUpDownT5TestNum.Value = 1;
            sec5 = 0;
            min5 = 0;
            hrs5 = 0;
        }

        private void ClearControlT5_1()
        {
            timerT5.Stop();
            if (txtT5TimerNum.Text != "")
            {
                if (flagT5 == 1)
                {
                    connectDB(txtT5TimerNum.Text, numericUpDownT5TestNum.Value.ToString(), lblT5SW1.Text, lblT5SW2.Text, "NO", "NC", "NC", "NO");
                    flagT5 = 0;
                }
                else
                {
                    connectDB(txtT5TimerNum.Text, numericUpDownT5TestNum.Value.ToString(), lblT5SW1.Text, lblT5SW2.Text, "NC", "NO", "NC", "NO");
                }
            }
            txtT5SWTime.Text = "00 : 00 : 00";
            lblT5SW1.Text = "00 : 00 : 00";
            lblT5SW2.Text = "00 : 00 : 00";
            txtT5TimerNum.Text = "";
            numericUpDownT5TestNum.Value = 0;
            sec5 = 0;
            min5 = 0;
            hrs5 = 0;
        }

        private void ClearControlT6()
        {
            timerT6.Stop();
            txtT6SWTime.Text = "00 : 00 : 00";
            lblT6SW1.Text = "00 : 00 : 00";
            lblT6SW2.Text = "00 : 00 : 00";
            //txtT6TimerNum.Text = "";
            //numericUpDownT6TestNum.Value = 0;
            sec6 = 0;
            min6 = 0;
            hrs6 = 0;
        }

        private void ClearControlT6_1()
        {
            timerT6.Stop();
            if (txtT6TimerNum.Text != "")
            {
                if (flagT6 == 1)
                {
                    connectDB(txtT6TimerNum.Text, numericUpDownT6TestNum.Value.ToString(), lblT6SW1.Text, lblT6SW2.Text, "NO", "NC", "NC", "NO");
                    flagT6 = 0;
                }
                else
                {
                    connectDB(txtT6TimerNum.Text, numericUpDownT6TestNum.Value.ToString(), lblT6SW1.Text, lblT6SW2.Text, "NC", "NO", "NC", "NO");
                }
            }
            txtT6SWTime.Text = "00 : 00 : 00";
            lblT6SW1.Text = "00 : 00 : 00";
            lblT6SW2.Text = "00 : 00 : 00";
            txtT6TimerNum.Text = "";
            numericUpDownT6TestNum.Value = 0;
            sec6 = 0;
            min6 = 0;
            hrs6 = 0;
        }

        private void ClearControlT7()
        {
            timerT7.Stop();
            txtT7SWTime.Text = "00 : 00 : 00";
            lblT7SW1.Text = "00 : 00 : 00";
            lblT7SW2.Text = "00 : 00 : 00";
            //txtT7TimerNum.Text = "";
            //numericUpDownT7TestNum.Value = 0;
            sec7 = 0;
            min7 = 0;
            hrs7 = 0;
        }

        private void ClearControlT7_1()
        {
            timerT7.Stop();
            if (txtT7TimerNum.Text != "")
            {
                if (flagT7 == 1)
                {
                    connectDB(txtT7TimerNum.Text, numericUpDownT7TestNum.Value.ToString(), lblT7SW1.Text, lblT7SW2.Text, "NO", "NC", "NC", "NO");
                    flagT7 = 0;
                }
                else
                {
                    connectDB(txtT7TimerNum.Text, numericUpDownT7TestNum.Value.ToString(), lblT7SW1.Text, lblT7SW2.Text, "NC", "NO", "NC", "NO");
                }
            }
            txtT7SWTime.Text = "00 : 00 : 00";
            lblT7SW1.Text = "00 : 00 : 00";
            lblT7SW2.Text = "00 : 00 : 00";
            txtT7TimerNum.Text = "";
            numericUpDownT7TestNum.Value = 0;
            sec7 = 0;
            min7 = 0;
            hrs7 = 0;
        }

        private void ClearControlT8()
        {
            timerT8.Stop();
            txtT8SWTime.Text = "00 : 00 : 00";
            lblT8SW1.Text = "00 : 00 : 00";
            lblT8SW2.Text = "00 : 00 : 00";
            //txtT8TimerNum.Text = "";
            //numericUpDownT8TestNum.Value = 0;
            sec8 = 0;
            min8 = 0;
            hrs8 = 0;
        }

        private void ClearControlT8_1()
        {
            timerT8.Stop();
            if (txtT8TimerNum.Text != "")
            {
                if (flagT8 == 1)
                {
                    connectDB(txtT8TimerNum.Text, numericUpDownT8TestNum.Value.ToString(), lblT8SW1.Text, lblT8SW2.Text, "NO", "NC", "NC", "NO");
                    flagT8 = 0;
                }
                else
                {
                    connectDB(txtT8TimerNum.Text, numericUpDownT8TestNum.Value.ToString(), lblT8SW1.Text, lblT8SW2.Text, "NC", "NO", "NC", "NO");
                }
            }
            txtT8SWTime.Text = "00 : 00 : 00";
            lblT8SW1.Text = "00 : 00 : 00";
            lblT8SW2.Text = "00 : 00 : 00";
            txtT8TimerNum.Text = "";
            numericUpDownT8TestNum.Value = 0;
            sec8 = 0;
            min8 = 0;
            hrs8 = 0;
        }

        private void ClearControlT9()
        {
            timerT9.Stop();
            txtT9SWTime.Text = "00 : 00 : 00";
            lblT9SW1.Text = "00 : 00 : 00";
            lblT9SW2.Text = "00 : 00 : 00";
            //txtT9TimerNum.Text = "";
            //numericUpDownT9TestNum.Value = 0;
            sec9 = 0;
            min9 = 0;
            hrs9 = 0;
        }

        private void ClearControlT9_1()
        {
            timerT9.Stop();
            if (txtT9TimerNum.Text != "")
            {
                if (flagT9 == 1)
                {
                    connectDB(txtT9TimerNum.Text, numericUpDownT9TestNum.Value.ToString(), lblT9SW1.Text, lblT9SW2.Text, "NO", "NC", "NC", "NO");
                    flagT9 = 0;
                }
                else
                {
                    connectDB(txtT9TimerNum.Text, numericUpDownT9TestNum.Value.ToString(), lblT9SW1.Text, lblT9SW2.Text, "NC", "NO", "NC", "NO");
                }
            }
            txtT9SWTime.Text = "00 : 00 : 00";
            lblT9SW1.Text = "00 : 00 : 00";
            lblT9SW2.Text = "00 : 00 : 00";
            txtT9TimerNum.Text = "";
            numericUpDownT9TestNum.Value = 0;
            sec9 = 0;
            min9 = 0;
            hrs9 = 0;
        }

        private void ClearControlT10()
        {
            timerT10.Stop();
            txtT10SWTime.Text = "00 : 00 : 00";
            lblT10SW1.Text = "00 : 00 : 00";
            lblT10SW2.Text = "00 : 00 : 00";
            //txtT10TimerNum.Text = "";
            //numericUpDownT10TestNum.Value = 0;
            sec10 = 0;
            min10 = 0;
            hrs10 = 0;
        }

        private void ClearControlT10_1()
        {
            timerT10.Stop();
            if (txtT10TimerNum.Text != "")
            {
                if (flagT10 == 1)
                {
                    connectDB(txtT10TimerNum.Text, numericUpDownT10TestNum.Value.ToString(), lblT10SW1.Text, lblT10SW2.Text, "NO", "NC", "NC", "NO");
                    flagT10 = 0;
                }
                else
                {
                    connectDB(txtT10TimerNum.Text, numericUpDownT10TestNum.Value.ToString(), lblT10SW1.Text, lblT10SW2.Text, "NC", "NO", "NC", "NO");
                }
            }
            txtT10SWTime.Text = "00 : 00 : 00";
            lblT10SW1.Text = "00 : 00 : 00";
            lblT10SW2.Text = "00 : 00 : 00";
            txtT10TimerNum.Text = "";
            numericUpDownT10TestNum.Value = 0;
            sec10 = 0;
            min10 = 0;
            hrs10 = 0;
        }

        private void connectDB(string p_1, string p_2, string p_3, string p_4, string p_5, string p_6, string p_7, string p_8)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "TimerDataBase.accdb";
            string strProvider = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", path);

            string query = "INSERT INTO tableTimer (TimerAssemblyNumber, TestNumber, SW1Time, SW2Time, ThirtyOuterTerminal,ThirtyInnerTerminal, FiftyOuterTerminal,FiftyInnerTerminal,TestDate) VALUES ('" + p_1 + "','" + p_2 + "','" + p_3 + "','" + p_4 + "','" + p_5 + "','" + p_6 + "','" + p_7 + "','" + p_8 + "','" + DateTime.Now.ToString() + "')";

            OleDbConnection con = new OleDbConnection(strProvider);
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                lblT1ErrMsg.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }
        }

        private void StartControlT1()
        {
            if (txtT1TimerNum.Text != "")
            {
                timerT1.Start();
                lblT1ErrMsg.Text = "";
            }
            else
            {
                lblT1ErrMsg.Text = "Info : Please put Timer Number";
            }
        }

        private void StartControlT2()
        {
            if (txtT2TimerNum.Text != "")
            {
                timerT2.Start();
                lblT2ErrMsg.Text = "";
            }
            else
            {
                lblT2ErrMsg.Text = "Info : Please put Timer Number";
            }
        }

        private void StartControlT3()
        {
            if (txtT3TimerNum.Text != "")
            {
                timerT3.Start();
                lblT3ErrMsg.Text = "";
            }
            else
            {
                lblT3ErrMsg.Text = "Info : Please put Timer Number";
            }
        }

        private void StartControlT4()
        {
            if (txtT4TimerNum.Text != "")
            {
                timerT4.Start();
                lblT4ErrMsg.Text = "";
            }
            else
            {
                lblT4ErrMsg.Text = "Info : Please put Timer Number";
            }

        }

        private void StartControlT5()
        {
            if (txtT5TimerNum.Text != "")
            {
                timerT5.Start();
                lblT5ErrMsg.Text = "";
            }
            else
            {
                lblT5ErrMsg.Text = "Info : Please put Timer Number";
            }
        }

        private void StartControlT6()
        {
            if (txtT6TimerNum.Text != "")
            {
                timerT6.Start();
                lblT6ErrMsg.Text = "";
            }
            else
            {
                lblT6ErrMsg.Text = "Info : Please put Timer Number";
            }
        }

        private void StartControlT7()
        {
            if (txtT7TimerNum.Text != "")
            {
                timerT7.Start();
                lblT7ErrMsg.Text = "";
            }
            else
            {
                lblT7ErrMsg.Text = "Info : Please put Timer Number";
            }
        }

        private void StartControlT8()
        {
            if (txtT8TimerNum.Text != "")
            {
                timerT8.Start();
                lblT8ErrMsg.Text = "";
            }
            else
            {
                lblT8ErrMsg.Text = "Info : Please put Timer Number";
            }
        }

        private void StartControlT9()
        {
            if (txtT9TimerNum.Text != "")
            {
                timerT9.Start();
                lblT9ErrMsg.Text = "";
            }
            else
            {
                lblT9ErrMsg.Text = "Info : Please put Timer Number";
            }
        }

        private void StartControlT10()
        {
            if (txtT10TimerNum.Text != "")
            {
                timerT10.Start();
                lblT10ErrMsg.Text = "";
            }
            else
            {
                lblT10ErrMsg.Text = "Info : Please put Timer Number";
            }
        }

        #endregion //Methods

    }

       
    }
