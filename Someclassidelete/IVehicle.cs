using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public interface IVehicle
    {
        int Y { get; }
        int X { get; }
        int Z { get; }
        DateTime Timestamp { get; }
        string Tag { get; }
        double Speed { get; }
        int Direction { get; }
        void Update(string tag, int x, int y, int z, DateTime time);
    }
}
