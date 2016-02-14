﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class frmDaq : Form
    {

        public frmDaq()
        {
            InitializeComponent();

        }

        private void btnSampling_Click(object sender, EventArgs e)
        {
            string s = Program.value();
            txtSensors.Text = s;
            tmrSampling.Start();
            btnSampling.Enabled = tmrSampling < 5000;
        }
    }
}



