using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    interface IVehicle
    {
        int y { get; }
        int x { get; }
        int z { get; }
        DateTime timestamp { get; }
        string tag { get; }
        double speed { get; }
        int direction { get; }
        void update(string tag, int x, int y, int z, DateTime time);
    }
}
