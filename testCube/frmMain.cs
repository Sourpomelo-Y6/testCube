using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testCube
{
    public partial class frmMain : Form
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


        PointRPY[] pCube;




        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            double DistanceCamera = 30;
            double DistanceScreen = 10;
            double DiceSize = 100;

            double pitch_wdeg = 180 * Math.Acos(1.0 / Math.Sqrt(3)) / Math.PI;

            pCube = new PointRPY[8] {
                new PointRPY(0, pitch_wdeg,  45),
                new PointRPY(0,180-pitch_wdeg,  45),
                new PointRPY(0, pitch_wdeg, -45),
                new PointRPY(0, pitch_wdeg, 135),
                new PointRPY(0,180-pitch_wdeg, -45),
                new PointRPY(0,180-pitch_wdeg, 135),
                new PointRPY(0, pitch_wdeg, 225),
                new PointRPY(0,180-pitch_wdeg, 225),
            };

            Bitmap bmp = new Bitmap(pbMain.Width, pbMain.Height);
            Graphics g = Graphics.FromImage(bmp);

            g.FillRectangle(Brushes.Red, 0, 0, pbMain.Width, pbMain.Height);


            foreach (var p in pCube) 
            {
                //txtDebug.AppendText(p.x.ToString() + "," + p.y.ToString() + "," + p.z.ToString() + Environment.NewLine);

                double workx = (p.x * DistanceCamera) / (p.z + DistanceCamera + DistanceScreen);
                double worky = (p.y * DistanceCamera) / (p.z + DistanceCamera + DistanceScreen);

                txtDebug.AppendText(workx.ToString()+","+worky.ToString()+Environment.NewLine);
                g.DrawRectangle(Pens.Black, (float)workx+100, (float)worky+100, 2, 2);
            }


            if (pbMain.Image != null) 
            {
                pbMain.Image.Dispose();
                pbMain.Image = null;
            }
            pbMain.Image = (Image)bmp.Clone();

            g.Dispose();
            bmp.Dispose();
        }
    }
}
