using System;
using TransponderReceiver;

namespace ATM
{
    public class ProcessedTransponderEventArgs : EventArgs
    {

    }
    public interface ITrackFilter
    {
        event EventHandler<RawTransponderDataEventArgs> RawDataEvent;
    }
}