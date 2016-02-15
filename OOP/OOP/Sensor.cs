using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Sensor
    {
        double dVal;
        int sId;
        Random rSenVal;
        int sRange = 5;

        public Sensor(int id)
        {
            sId = id;
            rSenVal = new Random(id);
            dVal = 0.0F;
        }
        
        public double GetValue(bool digital)
        {if (digital == true)
            {
                dVal = rSenVal.Next(0, 2);
            }
        else
            {
                dVal = (rSenVal.Next(0, 4096) / 4096.0) * sRange;
            }
            
            return dVal;
        }
        public int GetSenId()
        {
            return sId;
        }
    }
}
