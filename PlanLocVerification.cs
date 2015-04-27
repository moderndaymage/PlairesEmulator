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
    public partial class PlanLocVerification : Form
    {
        MainMenu m;
        public PlanLocVerification()
        {
            InitializeComponent();
        }

        public PlanLocVerification(MainMenu m):this()
        {
            this.m = m;
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            new PLV_Inquiry(this).Show();
            this.Hide();
        }

        private void PlanLocVerification_FormClosed(object sender, FormClosedEventArgs e)
        {
            m.Show();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            new PLV_Maintenance(this).Show();
            this.Hide();
        }
    }
}
