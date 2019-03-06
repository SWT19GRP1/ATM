﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ATM
{
    public class Aircraft : IVehicle
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }
        public DateTime Timestamp { get; private set; }
        public string Tag { get; private set; }
        public double Speed { get; private set; }
        public int Direction { get; private set; }

        public Aircraft(int x, int y, int z, DateTime timestamp, string tag, double speed, int direction)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Timestamp = timestamp;
            this.Tag = tag;
            this.Speed = speed;
            this.Direction = direction;
        }

        public void Update(IVehicle old)
        {
            var deltaX = this.X - old.X;
            var deltaY = this.Y - old.Y;
            var deltaZ = this.Z - old.Z;

            var distance = (float) Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

            var timeDiff = this.Timestamp - this.Timestamp;

            var timeDiffInSec = timeDiff.TotalSeconds;

            this.Speed = distance / timeDiffInSec;

        }
    }
}
