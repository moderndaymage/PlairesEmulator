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
    public partial class PLV_Maintenance : Form
    {
        PlanLocVerification p;
        public PLV_Maintenance()
        {
            InitializeComponent();
        }
        
        public PLV_Maintenance(PlanLocVerification p):this()
        {
            this.p = p;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new PLV_AddData(this).Show();
            this.Hide();
        }

        private void PLV_Maintenance_FormClosing(object sender, FormClosingEventArgs e)
        {
            p.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new PLV_EditData(this).Show();
            this.Hide();
        }

        private void btnReindex_Click(object sender, EventArgs e)
        {
            new PLV_Reindex(this).Show();
            this.Hide();
        }
    }
}
