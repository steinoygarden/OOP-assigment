using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP
{
    public partial class frmDaq : Form
    {
        double i;
        double j;
        Timer tmrSampling;
        Timer tmrLogging;
        string Filename;
        int LogCount;
        public frmDaq()
        {
            InitializeComponent();
            Filename = "log.txt";
            lblFileName.Text = Filename;
            LogCount = 0;
            lblNumbLog.Text = LogCount.ToString();

        }

        private void btnSampling_Click(object sender, EventArgs e)
        {
            i = 3.1;          // Samplingtime
            string s = Program.value();
            txtSensors.Text = s;

            tmrSampling = new Timer();
            tmrSampling.Tick += new EventHandler(timer_Tick); // Everytime timer ticks, timer_Tick will be called
            tmrSampling.Interval = (100);                     // Timer will tick at 5 seconds
            tmrSampling.Start();                              // Start the timer

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            // The code that is runed throug when the timer tick.

            if (i != 0)
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
                tmrSampling.Stop();
            }

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // messagebox shown when pressing Help
            MessageBox.Show("Push the sample button to collect a sample of the sensors.\n\r Ther is only possieble to collect a sample every 5. second.");
        }

        private void btnLogging_Click(object sender, EventArgs e)
        {
            j = 9;      // Logging Time
            tmrLogging = new Timer();
            tmrLogging.Tick += new EventHandler(timer_Tick2); // Everytime timer ticks, timer_Tick will be called
            tmrLogging.Interval = (100);                     // Timer will tick at 5 seconds
            tmrLogging.Start();
            LogCount++;
            lblNumbLog.Text = LogCount.ToString();
            using (StreamWriter writer = File.AppendText(Filename))
            {
                writer.Write(txtSensors.Text);
            }
        }

        private void timer_Tick2(object sender, EventArgs e)
        {
            // The code that is runed throug when the timer tick.

            if (j != 0)
            {
                btnLogging.Enabled = false;
                txtLogging.Text = "time to next logging: " + j.ToString() + " s";
                j -= 0.1;
                j = Math.Round(j, 1);
            }
            else
            {
                btnLogging.Enabled = true;
                txtLogging.Text = "time to next logging: " + i.ToString() + " s";
                tmrLogging.Stop();
            }

        }

    }
}