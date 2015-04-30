using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Data.OleDb;
using System.IO;

namespace PlairesEmulator
{
    public partial class PLV_AddData : Form
    {
        PLV_Maintenance p;
        public PLV_AddData()
        {
            InitializeComponent();
        }

        public PLV_AddData(PLV_Maintenance p)
            : this()
        {
            this.p = p;
        }

        private void PLV_AddData_FormClosing(object sender, FormClosingEventArgs e)
        {
            p.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //Validators:
                //Once an Input is wrong Exceptions will be thrown
                if (this.GetCheckedRadio(this) == null)
                    throw new Exception();
                int.Parse(txtPlanNo.Text);
                if (txtPlanNo.Text.Length > 6)
                    throw new Exception();

                string parameter = cbxPlanType.SelectedItem.ToString() + "-" + int.Parse(txtPlanNo.Text);//Result of the Plan Type+6 digit No.
                string sql = "INSERT INTO Roll(Plan_No,Location,Roll_No,Type) VALUES('" + parameter + "','" + txtLocation.Text + "','" + txtRollNo.Text + "','Original')";
                OleDbConnection connection = Database.Connect();
                OleDbCommand command = new OleDbCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                if (txtRemarks.Text.Length > 0)
                {
                    sql = "UPDATE Roll SET Remarks='" + txtRemarks.Text + "' WHERE Plan_No='" + parameter + "'";
                    command = new OleDbCommand(sql, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }

                sql = "UPDATE Roll SET Type='" + GetCheckedRadio(this).Text + "' WHERE Plan_No='" + parameter + "'";
                command = new OleDbCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                txtPlanNo.Clear();
                txtLocation.Clear();
                txtRemarks.Clear();
                txtRollNo.Clear();
                SpeechSynthesizer s = new SpeechSynthesizer();//Speech Output
                s.SpeakAsync("Data Sucessfully Entered");
                MessageBox.Show("Data Successfully Entered");
                PLV_AddData_Load(sender, e);

            }
            catch
            {
                SpeechSynthesizer s = new SpeechSynthesizer();//Speech Output
                s.SpeakAsync("Invalid Input");
                MessageBox.Show("Invalid Input");
            }
        }
        RadioButton GetCheckedRadio(Control container)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;
                if (radio != null && radio.Checked)
                    return radio;
            }
            return null;
        }

        private void PLV_AddData_Load(object sender, EventArgs e)
        {
            lvAddData.Items.Clear();
            string sql = "SELECT Plan_No,Location,IIF(Remarks IS NULL,' ',Remarks),Type,Roll_No from Roll ORDER BY Plan_No;";//SQL Query
            OleDbConnection connection = Database.Connect();
            OleDbCommand command = new OleDbCommand(sql, connection);
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            //Outputs the result in the ListView Oriented in Detail Format
            if (reader.HasRows)//If query has result
            {
                while (reader.Read())//Show all possible results
                {
                    string[] data = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                    ListViewItem l = new ListViewItem(data);
                    lvAddData.Items.Add(l);
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
            lvAddData.Items.Clear();
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
                        lvAddData.Items.Add(l);
                }
            }
            else
                MessageBox.Show("No Content");
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            PLV_AddData_Load(sender, e);
        }
    }
}
