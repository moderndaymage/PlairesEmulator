﻿using System;
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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnPLV_Click(object sender, EventArgs e)
        {
            new PlanLocVerification(this).Show();
            this.Hide();
        }
    }
}
