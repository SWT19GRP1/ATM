using System;
using TransponderReceiver;

namespace ATM
{
    public class TransponderReciever
    {
        private ITransponderReceiver _receiver;

        public event EventHandler<RawTransponderDataEventArgs> RaiseTrackInboundEvent; 

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
        private void RecieverOnTransportDataReady(object sender, RawTransponderDataEventArgs e)
        {
           OnTrackInboundEvent(e);          
        }

        protected virtual void OnTrackInboundEvent(RawTransponderDataEventArgs e)
        {
            EventHandler<RawTransponderDataEventArgs> handler = RaiseTrackInboundEvent;

            handler?.Invoke(this, e);
        }
    }
}
