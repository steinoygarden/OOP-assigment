using System;
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
        double i;
        Timer timer;
        public frmDaq()
        {
            InitializeComponent();
            
        }

        private void btnSampling_Click(object sender, EventArgs e)
        {
            
            string s = Program.value();
            txtSensors.Text = s;
            i = 5;
     
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            timer.Interval = (100);                     // Timer will tick at 5 seconds
            timer.Start();                              // Start the timer

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            
            if (i!= 0)
            {
                btnSampling.Enabled = false;
                txtSampling.Text = "time to next sample: " + i.ToString() + " s";
                i -= 0.1;
                i = Math.Round(i, 1);
            }
            else
            {
                btnSampling.Enabled = true;
                txtSampling.Text = "time to next sample: " + i.ToString() + " s";
                timer.Stop();
            }
             
        }
    } 
}



