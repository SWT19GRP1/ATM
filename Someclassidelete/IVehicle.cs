using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    public interface IVehicle
    {
        int y { get; set; }
        int x { get; set; }
        int z { get; set; }
        DateTime timestamp { get; set; }
        double speed { get; set; }
        string tag { get; set; }
    }
}
