using System;
using System.Collections.Generic;
using System.Text;
using TransponderReceiver;

namespace ATM
{
    public class TrackFilter
    {
        private ITransponderReceiver _receiver;
        public int XOffset { get; set; }
        public int YOffset { get; set; }
        public int ZOffset { get; set; }
        public int XLength { get; set; }
        public int YWidth { get; set; }
        public int ZHeight { get; set; }
        public TrackFilter(ITransponderReceiver reciever, int xOffset = 0, int yOffset = 0,
            int zOffset = 500, int xLength = 80000, int yWidth = 80000, int zHeight = 19500)
        {
            _receiver = reciever;
            _receiver.TransponderDataReady += HandlerOnRaiseTrackInsideMonitoringAreaEvent;
            XOffset = xOffset;
            YOffset = yOffset;
            ZOffset = zOffset;
            XLength = xLength;
            YWidth = yWidth;
            ZHeight = zHeight;
        }

        private void HandlerOnRaiseTrackInsideMonitoringAreaEvent(object sender, RawTransponderDataEventArgs e)
        {
            char[] separators = { ';' };

            foreach (var data in e.TransponderData)
            {

                var tokens = data.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                var tag = tokens[0];
                var xCoordinate = int.Parse(tokens[1]);
                var yCoordinate = int.Parse(tokens[2]);
                var zCoordinate = int.Parse(tokens[3]);
                var time = long.Parse(tokens[4]);
                var year = int.Parse(tokens[4].Substring(0, 5));
                Console.WriteLine("Observed:  " + tag + "\t" + xCoordinate + "\t" + yCoordinate + "\t" + zCoordinate + "\t");
                var s = GetDate(tokens[4]);
                Console.WriteLine(s.Year +" "+ s.Month +" "+ s.Day +" "+ s.Hour +" "+ s.Minute +" "+ s.Second +" "+ s.Millisecond);
                if ((xCoordinate >= XOffset) && (xCoordinate <= (XOffset + XLength)))
                {
                    if (yCoordinate >= YOffset && yCoordinate <= YOffset + YWidth)
                    {
                        if ((zCoordinate >= ZOffset) && (zCoordinate <= (zCoordinate + ZHeight)))
                        {
                            Console.WriteLine("Inbound:  " + tag + "\t" + xCoordinate + "\t" + yCoordinate + "\t" + zCoordinate + "\t" + time);
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        private DateTime GetDate(string date)
        {
            int year   = int.Parse(date.Substring(0,4));
            var month  = int.Parse(date.Substring(4,2));
            var day    = int.Parse(date.Substring(6, 2));
            var hour   = int.Parse(date.Substring(8, 2));
            var minute = int.Parse(date.Substring(10, 2));
            var second = int.Parse(date.Substring(12, 2));
            var milli  = int.Parse(date.Substring(14, 3));
            var returnDateTime= new DateTime(year,month,day,hour,minute,second,milli);

            return returnDateTime;
        }
    }
}
