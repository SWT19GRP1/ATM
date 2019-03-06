using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class TerminalOutput:IOutput
    {
        public void logVehicleData(List<IVehicle> vehicles)
        {
            Console.Clear();
            Console.WriteLine("Current Airplanes in Airspace:");
            foreach (var plane in vehicles)
            {
                Console.WriteLine("Tag:{0}, Speed:{1}, Coordinates:{2},{3},{4} - Date: {5}/{6}-{7} {8}:{9}",plane.Tag,plane.Speed,plane.X,plane.Y,plane.Z,plane.Timestamp.Day,plane.Timestamp.Month,plane.Timestamp.Year,plane.Timestamp.Hour,plane.Timestamp.Minute);
            }
            
        }
    }
}
