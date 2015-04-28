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
                        string[] data={reader.GetString(0),reader.GetString(1),reader.GetString(2),reader.GetString(3),reader.GetString(4)};
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

        private void PLV_EditData_FormClosing(object sender, FormClosingEventArgs e)
        {
            p.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Validators:
                //Once an Input is wrong Exceptions will be thrown
                if (this.GetCheckedRadio(this) == null)
                    throw new Exception("No Checked Radio Button");

                string sql = "UPDATE Roll SET Location='" + txtLocation.Text + "',Roll_No='" + txtRollNo.Text + "' WHERE Plan_No='"+txtPlanNo.Text+"'";
                OleDbConnection connection = Database.Connect();
                OleDbCommand command = new OleDbCommand(sql, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                if (txtRemarks.Text.Length != 0)
                {
                    sql = "UPDATE Roll SET Remarks='" + txtRemarks.Text + "' WHERE Plan_No='" + txtPlanNo.Text + "'";
                    command = new OleDbCommand(sql, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                sql = "UPDATE Roll SET Type='" + GetCheckedRadio(this).Text + "' WHERE Plan_No='" + txtPlanNo.Text+ "'";
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
                PLV_EditData_Load(sender, e);
            }
            catch(Exception ex)
            {
                SpeechSynthesizer s = new SpeechSynthesizer();//Speech Output
                s.SpeakAsync("Invalid Update");
                MessageBox.Show("Invalid Update"+ex.Message);
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

        void SetCheckedRadio(Control container,string input)
        {
            foreach (var control in container.Controls)
            {
                RadioButton radio = control as RadioButton;
                if (radio != null && radio.Text == input)
                {
                    radio.Select();
                    return;
                }
            }
        }

        private void lvInquiry_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
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
                        txtPlanNo.Text = reader.GetString(4);
                        txtLocation.Text = reader.GetString(0);
                        txtRollNo.Text = reader.GetString(1);
                        txtRemarks.Text = reader.GetString(2);
                        this.SetCheckedRadio(this, reader.GetString(3));
                        //MessageBox.Show(reader.GetString(3));
                    }
                }
            //}
            //catch { }
        }
    }
}
