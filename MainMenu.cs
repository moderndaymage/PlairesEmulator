using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlairesEmulator
{
    public partial class MainMenu : Form
    {
        //Constructors
        public MainMenu()
        {
            InitializeComponent();//GUI Components Here
        }
        //End Constructors

        //Event Handlers
        private void btnPLV_Click(object sender, EventArgs e)
        {
            //PlanLocVerification Form Transition(Changes form)
            new PlanLocVerification(this).Show();
            this.Hide();
            //Hides the form to be ready for use later
        }
    }
}
