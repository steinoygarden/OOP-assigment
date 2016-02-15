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
            string TimeStamp = DateTime.Now.ToString("HH:mm:ss",new System.Globalization.CultureInfo("en-GB"));

            for (int i = 0; i < 3; i++)
            {
                sTxt += "A: "+sObj[i].GetSenId().ToString() + "\t"+ sObj[i].GetValue(false).ToString("F3") +"\t"+TimeStamp+ "\r\n";
            }
            for (int j = 3; j<4;j++)
            {
                sTxt +="D: "+sObj[j].GetSenId().ToString()+"\t"+ sObj[j].GetValue(true).ToString("F3") + "\t" + TimeStamp + "\r\n";
            }
            return sTxt;
        }

    }
}
