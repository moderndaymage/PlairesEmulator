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
            lvInquiry.Items.Clear();
            //MessageBox.Show("btnOk Start");
            string parameter = cbxPlanType.SelectedItem.ToString() + "-" + txtPlanNo.Text;
            string sql = "SELECT Location,Roll_No,IIF(Remarks IS NULL,' ',Remarks),Type FROM Roll WHERE Plan_No='" + parameter + "';";
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Documents\\PlairesEmulator\\Plaires.accdb;Persist Security Info=False;";
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbCommand command=new OleDbCommand(sql,connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] values=new string[4];
                    values[0]=reader.GetString(0);
                    values[1]=reader.GetString(1);
                    values[2]=reader.GetString(2);
                    values[3]=reader.GetString(3);
                    ListViewItem l = new ListViewItem(values);
                    lvInquiry.Items.Add(l);
                }
            }
            else
            {
                MessageBox.Show("Plan Roll cannot be found");
            }
            connection.Close();
        }

        private void PLV_Inquiry_FormClosing(object sender, FormClosingEventArgs e)
        {
            p.Show();
        }
    }
}
