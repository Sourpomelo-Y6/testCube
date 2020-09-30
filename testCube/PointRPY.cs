using System;

namespace testCube
{
    class PointRPY 
    {
        /// <summary>Rotate Roll Radian </summary>
        public double Roll;

        /// <summary>Rotate Pitch Radian </summary>
        public double Pitch;

        /// <summary>Rotate Yaw Radian </summary>
        public double Yaw;


        public double x;
        public double y;
        public double z;


        public PointRPY(double degRoll, double degPitch , double degYaw)
        {
            this.Roll = Deg2Rad(degRoll);
            this.Pitch = Deg2Rad(degPitch);
            this.Yaw = Deg2Rad(degYaw);

            this.x = 100 * Math.Sqrt(3) * Math.Cos(Math.PI / 2.0 - Pitch) * Math.Cos(Yaw);
            this.y = 100 * Math.Sqrt(3) * Math.Cos(Math.PI / 2.0 - Pitch) * Math.Sin(Yaw);
            this.z = 100 * Math.Sqrt(3) * Math.Sin(Math.PI / 2.0 - Pitch) ;
        }

        private double Deg2Rad(double deg)
        {
            return Math.PI * deg / 180.0;
        }
    };
    
}
