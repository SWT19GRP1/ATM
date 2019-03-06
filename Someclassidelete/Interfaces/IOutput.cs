using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    interface IOutput
    {
        void logVehicleData(List<IVehicle> V);
    }
}
