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
            var trackfilter = new TrackFilter(reciever);
            while (true)
            {
                
            }
        }
    }
}
