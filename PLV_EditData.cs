using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace PlairesEmulator
{
    public partial class PLV_EditData : Form
    {
        PLV_Maintenance p;
        public PLV_EditData()
        {
            InitializeComponent();
        }

        public PLV_EditData(PLV_Maintenance p)
            : this()
        {
            this.p = p;
        }

        private void PLV_EditData_Load(object sender, EventArgs e)
        {
                string sql = "SELECT Plan_No from Roll ORDER BY Plan_No;";//SQL Query
                string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Documents\\PlairesEmulator\\Plaires.accdb;Persist Security Info=False;";//Tentative Database Location for Prototype Dev't
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbCommand command = new OleDbCommand(sql, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                //Outputs the result in the ListView Oriented in Detail Format
                if (reader.HasRows)//If query has result
                {
                    while (reader.Read())//Show all possible results
                    {
                        cbxPlanNo.Items.Add(reader.GetString(0));
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

        private void PLV_EditData_FormClosing(object sender, FormClosingEventArgs e)
        {
            p.Show();
        }

        private void cbxPlanNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(cbxPlanNo.SelectedItem.ToString());
                string sql = "SELECT Location,Roll_No,IIF(Remarks IS NULL,' ',Remarks),Type FROM Roll WHERE (Plan_No='" +cbxPlanNo.SelectedItem.ToString() + "')";//SQL Query
                //Note IIF is used to make sure that the null values will not cause exceptions
                string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Documents\\PlairesEmulator\\Plaires.accdb;Persist Security Info=False;";//Tentative Database Location for Prototype Dev't
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbCommand command = new OleDbCommand(sql, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                //Outputs the result in the All the forms Oriented in Detail Format
                if (reader.HasRows)//If query has result
                {
                    while (reader.Read())//Show all possible results
                    {
                        string[] values = new string[4];
                        values[0] = reader.GetString(0);//Location
                        values[1] = reader.GetString(1);//Roll No.
                        values[2] = reader.GetString(2);//Remarks
                        values[3] = reader.GetString(3);//Type of plan
                        
                        txtLocation.Text=values[0];
                        txtRollNo.Text=values[1];
                        txtRemarks.Text=values[2];
                        this.SetCheckedRadio(this, values[3]);
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
            catch
            {
                SpeechSynthesizer s = new SpeechSynthesizer();//Speech Output
                s.SpeakAsync("Invalid Plan No");
                MessageBox.Show("Invalid Plan No");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Validators:
                //Once an Input is wrong Exceptions will be thrown
                if (this.GetCheckedRadio(this) == null)
                    throw new Exception();

                string sql = "UPDATE Roll SET Location='" + txtLocation.Text + "',Roll_No='" + txtRollNo.Text + "' WHERE Plan_No='"+cbxPlanNo.SelectedItem.ToString()+"'";
                string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Documents\\PlairesEmulator\\Plaires.accdb;Persist Security Info=False;";//Tentative Database Location for Prototype Dev't
                OleDbConnection connection = new OleDbConnection(connetionString);
                OleDbCommand command = new OleDbCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                    sql = "UPDATE Roll SET Remarks='" + txtRemarks.Text + "' WHERE Plan_No='" + cbxPlanNo.SelectedItem.ToString() + "'";
                    command = new OleDbCommand(sql, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                sql = "UPDATE Roll SET Type='" + GetCheckedRadio(this).Text + "' WHERE Plan_No='" + cbxPlanNo.SelectedItem.ToString() + "'";
                command = new OleDbCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                txtLocation.Clear();
                txtRemarks.Clear();
                txtRollNo.Clear();
                SpeechSynthesizer s = new SpeechSynthesizer();//Speech Output
                s.SpeakAsync("Data Sucessfully Updated");
                MessageBox.Show("Data Successfully Updated");

            }
            catch(Exception ex)
            {
                SpeechSynthesizer s = new SpeechSynthesizer();//Speech Output
                s.SpeakAsync("Invalid Update");
                MessageBox.Show("Invalid Update");
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

        public void SetCheckedRadio(Control container,string input)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;
                if (radio != null && radio.Text == input)
                    radio.Select();
            }
        }
    }
}
