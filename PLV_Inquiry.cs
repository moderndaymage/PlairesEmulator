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
    public partial class PLV_Inquiry : Form
    {
        //Fields
        PlanLocVerification p;//References the former form PlanLocVerification
        //Fields End

        //Constructors
        public PLV_Inquiry()
        {
            InitializeComponent();
        }

        //Constructor Overload(For Referencing Former Form PlanLocVerification)
        public PLV_Inquiry(PlanLocVerification p):this()
        {
            this.p = p;
        }
        //Constructors End

        //Event Handlers
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                lvInquiry.Items.Clear();//Clears the former query result
                string parameter = cbxPlanType.SelectedItem.ToString() + "-" + txtPlanNo.Text;//Result of the Plan Type+6 digit No.
                string sql = "SELECT Location,Roll_No,IIF(Remarks IS NULL,' ',Remarks),Type FROM Roll WHERE Plan_No='" + parameter + "';";//SQL Query
                //Note IIF is used to make sure that the null values will not cause exceptions
                OleDbConnection connection = Database.Connect();
                OleDbCommand command = new OleDbCommand(sql, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                //Outputs the result in the ListView Oriented in Detail Format
                if (reader.HasRows)//If query has result
                {
                    while (reader.Read())//Show all possible results
                    {
                        string[] values = new string[4];
                        values[0] = reader.GetString(0);//Location
                        values[1] = reader.GetString(1);//Roll No.
                        values[2] = reader.GetString(2);//Remarks
                        values[3] = reader.GetString(3);//Type of plan
                        ListViewItem l = new ListViewItem(values);
                        lvInquiry.Items.Add(l);
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
                s.SpeakAsync("Invalid Query");
                MessageBox.Show("Invalid Query");
            }
        }

        //Closing event Causes to return back
        private void PLV_Inquiry_FormClosing(object sender, FormClosingEventArgs e)
        {
            p.Show();//Returns to the PlanLocVerification form
        }
        //End
    }
}
