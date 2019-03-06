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
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            foreach (var plane in vehicles)
            {
                string general = "Tag: " + plane.tag + "Coordinates: " + plane.x + "," + plane.y + "," + plane.z+ "Direction:" + plane.dir;
                string date = " Date: " + plane.timestamp.Day + "/" + plane.timestamp.Month + "-" +
                              plane.timestamp.Year + "  " + plane.timestamp.Hour + ":" + plane.timestamp.Minute + ":" +
                              plane.timestamp.Second + ":" + plane.timestamp.Millisecond;
                System.IO.File.AppendAllText(path,general+date);
            }
        }
    }
}
