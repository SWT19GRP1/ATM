using System;
using System.Collections.Generic;
using System.Text;

namespace ATM
{
    interface IVehicle
    {
        int y { get; set; }
        int x { get; set; }
        int z { get; set; }
        DateTime timestamp { get; set; }
        double speed { get; set; }
    }
}
