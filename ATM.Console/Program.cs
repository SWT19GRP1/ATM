using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TransponderReceiver;

namespace ATM.Console
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var reciever = TransponderReceiverFactory.CreateTransponderDataReceiver();
            var transponderReciever = new TransponderReciever(reciever);
            var trackfilter = new TrackFilter(transponderReciever,0,0,500,80000,80000,);
            while (true)
            {
                
            }
        }
    }
}
