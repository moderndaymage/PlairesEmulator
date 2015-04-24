using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace PlairesEmulator
{
    public partial class PLV_Inquiry : Form
    {
        PlanLocVerification p;
        public PLV_Inquiry()
        {
            InitializeComponent();
        }

        public PLV_Inquiry(PlanLocVerification p):this()
        {
            this.p = p;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            string query = "SELECT Location,Roll_No,Remarks,Type FROM Plan,Roll WHERE Plan.Plan_No=Roll.Plan_No AND '"+ cbxPlanType.SelectedText+"-"+txtPlanNo.Text+"'=Roll.Plan_No";
            //create the connection string
            string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Plaires.accdb";

            //create an OleDbDataAdapter to execute the query
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(query, connString);

            //create a command builder
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);

            //create a DataTable to hold the query results
            DataSet dTable = new DataSet();

            //fill the DataTable
            dAdapter.Fill(dTable);

            //BindingSource to sync DataTable and DataGridView
            BindingSource bSource = new BindingSource();

            //set the BindingSource DataSource
            bSource.DataSource = dTable;

            //set the DataGridView DataSource
            this.dgvResult.DataSource = bSource;

            conn.Close();
        }

        private void PLV_Inquiry_FormClosing(object sender, FormClosingEventArgs e)
        {
            p.Show();
        }
    }
}
