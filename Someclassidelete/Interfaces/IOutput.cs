using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Interfaces;

namespace ATM
{
    public interface IOutput
    {
        IVehicleFormatter Formatter { get; set; }
        void LogVehicleData(List<IVehicle> v);
    }
}
