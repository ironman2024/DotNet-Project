namespace Timer_v1
{
    partial class frmReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableTimerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TimerDataBaseDataSet = new Timer_v1.TimerDataBaseDataSet();
            this.tableTimerTableAdapter = new Timer_v1.TimerDataBaseDataSetTableAdapters.tableTimerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tableTimerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerDataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableTimerBindingSource
            // 
            this.tableTimerBindingSource.DataMember = "tableTimer";
            this.tableTimerBindingSource.DataSource = this.TimerDataBaseDataSet;
            // 
            // TimerDataBaseDataSet
            // 
            this.TimerDataBaseDataSet.DataSetName = "TimerDataBaseDataSet";
            this.TimerDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTimerTableAdapter
            // 
            this.tableTimerTableAdapter.ClearBeforeFill = true;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 470);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReport_FormClosing);
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableTimerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerDataBaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tableTimerBindingSource;
        private TimerDataBaseDataSet TimerDataBaseDataSet;
        private Timer_v1.TimerDataBaseDataSetTableAdapters.tableTimerTableAdapter tableTimerTableAdapter;
    }
}