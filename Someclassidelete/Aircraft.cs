using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public class Aircraft : IVehicle
    {
        public int x { get; private set; }
        public int y { get; private set; }
        public int z { get; private set; }
        public DateTime timestamp { get; private set; }
        public double speed { get; private set; }
        public int direction { get; private set; }

        public void update(string tag, int x, int y, int z, DateTime time)
        {
            ;
        }
    }
}
