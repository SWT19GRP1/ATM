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
                string general = "Tag: " + plane.Tag + "Coordinates: " + plane.X + "," + plane.Y + "," + plane.Z+ "Direction:" + plane.Direction;
                string date = " Date: " + plane.Timestamp.Day + "/" + plane.Timestamp.Month + "-" +
                              plane.Timestamp.Year + "  " + plane.Timestamp.Hour + ":" + plane.Timestamp.Minute + ":" +
                              plane.Timestamp.Second + ":" + plane.Timestamp.Millisecond;
                System.IO.File.AppendAllText(path,general+date);
            }
        }
    }
}
