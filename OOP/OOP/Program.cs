using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDaq());
            int counter, maxSid = 9;
            string sTxt;
            Sensor[] sObj = new Sensor[maxSid];
            for (counter = 0;counter<maxSid;counter++)
            {
                sObj[counter] = new Sensor(counter);
            }
            for (counter = 0; counter<maxSid;counter ++)
            {
                sTxt = sObj[counter].GetValue().ToString("F3");
            }
        }
    }
}
