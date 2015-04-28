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
                string connetionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Documents\\PlairesEmulator\\Plaires.accdb;Persist Security Info=False;";//Tentative Database Location for Prototype Dev't
                OleDbConnection connection = new OleDbConnection(connetionString);
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

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Title = "Open .xlsx file to Import";
            if (o.ShowDialog() == DialogResult.OK)
            {
                //try
                //{
                    MessageBox.Show(o.FileName);
                    OleDbConnection connection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;DataSource='" + o.FileName + "';Extended Properties=Excel 12.0;");
                    OleDbCommand command = new OleDbCommand("SELECT * FROM [Roll$] ORDER BY Plan_No", connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    connection.Close();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string[] values = new string[5];
                            try
                            {
                                OleDbConnection accessDBConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Documents\\PlairesEmulator\\Plaires.accdb;Persist Security Info=False;");
                                OleDbCommand accessDBCommand=new OleDbCommand("INSERT INTO Roll Values('"+reader.GetString(0)+"','"+reader.GetString(1)+"','"+reader.GetString(2)+"','"+reader.GetString(3)+"','"+reader.GetString(4)+"');",accessDBConnection);
                                accessDBConnection.Open();
                                accessDBCommand.ExecuteNonQuery();
                                accessDBConnection.Close();
                                MessageBox.Show(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) +
                                    " " + reader.GetString(4) + " is successfully Imported to the Plaires.accdb");

                            }
                            catch
                            {
                                MessageBox.Show(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) +
                                    " " + reader.GetString(4) + " Cannot be imported due to conflict with the Database Rules of Plaires.accdb");
                            }
                        }
                    }
                    else MessageBox.Show("No Data to Import");
                //}
                //catch
                //{
                //    MessageBox.Show("Data to Import not compatible with the Database");
                //}
            }
        }
    }
}
