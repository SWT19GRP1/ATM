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
                Console.Write("Tag: {0} ",plane.Tag);
                Console.Write("Speed: {0} ",plane.Speed);
                Console.Write("Direction: {0} ",plane.Direction);
                Console.Write("Coordinates: {0},{1},{2} ", plane.X, plane.Y, plane.Z);
                Console.Write("Date: {0}/{1}-{2} {3}:{4}:{5}:{6}\n\r", plane.Timestamp.Day, plane.Timestamp.Month, plane.Timestamp.Year, plane.Timestamp.Hour, plane.Timestamp.Minute, plane.Timestamp.Second, plane.Timestamp.Millisecond);
            }
            
        }
    }
}
