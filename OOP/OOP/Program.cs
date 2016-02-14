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
        private static string sTxt;
        private static Sensor[] sObj;


      [STAThread]
        static void Main(string[] args)
        {

            int counter, maxSid = 9;
            sTxt = null;

            sObj = new Sensor[maxSid];
            for (counter = 0; counter < maxSid; counter++)
            {
                sObj[counter] = new Sensor(counter);
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDaq());
            
          }
        public static string value()
        {
            sTxt = null;
            for (int i = 0; i < 9; i++)
            {
                sTxt += sObj[i].GetValue().ToString("F3") + "\r\n";
            }
            return sTxt;
        }

    }
}
