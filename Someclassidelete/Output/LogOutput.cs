using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class LogOutput:IOutput
    {
        public void logVehicleData(List<IVehicle> vehicles)
        {
            foreach (var plane in vehicles)
            {
               // string s = "Tag: "+plane.tag+"Coordinates"
                 //          System.IO.File.AppendAllText(,s);
            }
        }
    }
}
