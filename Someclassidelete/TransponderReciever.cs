using System;
using TransponderReceiver;

namespace ATM
{
    public class TransponderReciever
    {
        private ITransponderReceiver _receiver;

        public TransponderReciever(ITransponderReceiver receiver)
        {
            _receiver = receiver;
            Attach();
        }

        public void Attach()
        {            
            _receiver.TransponderDataReady += RecieverOnTransportDataReady;
        }

        public void Detach()
        {
            _receiver.TransponderDataReady -= RecieverOnTransportDataReady;
        }
        private static void RecieverOnTransportDataReady(object sender, RawTransponderDataEventArgs e)
        {
            foreach (var data in e.TransponderData)
            {
                Console.WriteLine($"Transponderdata {data}");
            }
        }
    }
}
