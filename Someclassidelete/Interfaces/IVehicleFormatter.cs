using System;
using System.Collections.Generic;
using System.Text;

namespace ATM.Interfaces
{
    public interface IVehicleFormatter
    {
        string VehicleToString(IVehicle vehicle);
    }
}
