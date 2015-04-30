using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Speech.Synthesis;

namespace PlairesEmulator
{
    public partial class PLV_Reindex : Form
    {
        PLV_Maintenance p;
        public PLV_Reindex()
        {
            InitializeComponent();
        }
        public PLV_Reindex(PLV_Maintenance p)
            : this()
        {
            this.p = p;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtPlanNo.Text);
                if (txtPlanNo.Text.Length > 6)
                    throw new Exception();
                string parameter = cbxPlanType.SelectedItem.ToString() + "-" + int.Parse(txtPlanNo.Text);//Result of the Plan Type+6 digit No.
                string sql = "UPDATE Roll SET Plan_No='" + parameter + "' WHERE Plan_No='" + txtOldPlanNo.Text + "';";//SQL Query
                OleDbConnection connection = Database.Connect();
                OleDbCommand command = new OleDbCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                SpeechSynthesizer s = new SpeechSynthesizer();//Speech Output
                s.SpeakAsync("Data Successfully Reindexed");
                MessageBox.Show("Data Successfully Reindexed");
                connection.Close();
                PLV_Reindex_Load(sender, e);
            }
            catch
            {
                SpeechSynthesizer s = new SpeechSynthesizer();//Speech Output
                s.SpeakAsync("Error on Plan Reindexing");
                MessageBox.Show("Error on Plan Reindexing");
            }
        }

        private void PLV_Reindex_FormClosed(object sender, FormClosedEventArgs e)
        {
            p.Show();
        }

        private void PLV_Reindex_Load(object sender, EventArgs e)
        {
            lvEditData.Items.Clear();
            string sql = "SELECT Plan_No,Location,IIF(Remarks IS NULL,'',Remarks),Type,Roll_No from Roll ORDER BY Plan_No;";//SQL Query
            string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Documents\\PlairesEmulator\\Plaires.accdb;Persist Security Info=False;";//Tentative Database Location for Prototype Dev't
            OleDbConnection connection = new OleDbConnection(connetionString);
            OleDbCommand command = new OleDbCommand(sql, connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)//If query has result
            {
                while (reader.Read())//Show all possible results
                {
                    string[] data = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                    ListViewItem l = new ListViewItem(data);
                    lvEditData.Items.Add(l);
                }
            }
            else
            {
                SpeechSynthesizer s = new SpeechSynthesizer();//Speech Output
                s.SpeakAsync("No Record found");
                MessageBox.Show("No Record found");
            }
            connection.Close();
        }

        private void cbxSearchByPlanType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvEditData.Items.Clear();
            txtPlanNo.Clear();
            txtLocation.Clear();
            txtRemarks.Clear();
            txtRollNo.Clear();
            string query = "SELECT Plan_No,Location,IIF(Remarks IS NULL,'',Remarks),Type,Roll_No FROM Roll;";
            OleDbConnection connection = Database.Connect();
            OleDbCommand command = new OleDbCommand(query, connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] data = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                    ListViewItem l = new ListViewItem(data);
                    if (reader.GetString(0).StartsWith(cbxSearchByPlanType.SelectedItem.ToString()))
                        lvEditData.Items.Add(l);
                }
            }
            else
                MessageBox.Show("No Content");
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            PLV_Reindex_Load(sender, e);
        }

        private void lvEditData_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lvEditData.SelectedItems.Count < 1)
                    return;
                //MessageBox.Show(lvEditData.SelectedItems[0].Text);
                string sql = "SELECT Location,Roll_No,IIF(Remarks IS NULL,' ',Remarks),Type,Plan_No FROM Roll WHERE (Plan_No='" + lvEditData.SelectedItems[0].Text + "');";//SQL Query
                OleDbConnection connection = Database.Connect();
                OleDbCommand command = new OleDbCommand(sql, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();
                //MessageBox.Show(reader.FieldCount+"");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtOldPlanNo.Text = reader.GetString(4);
                        txtLocation.Text = reader.GetString(0);
                        txtRollNo.Text = reader.GetString(1);
                        txtRemarks.Text = reader.GetString(2);
                        txtType.Text = reader.GetString(3);
                        //MessageBox.Show(reader.GetString(3));
                    }
                }
                connection.Close();
            }
            catch { }
        }
    }
}
