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

        class PointXYZ 
        {
            public double x;
            public double y;
            public double z;

            public PointXYZ(double vx, double vy, double vz)
            {
                this.x = vx;
                this.y = vy;
                this.z = vz;
            }
        };

        PointXYZ[] pCube;

        double DistanceCamera = 300;
        double DistanceScreen = 100;
        //PointRPY[] pCube;

        double roll;
        double pitch;
        double yaw;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            double DiceSize = 50;

            double pitch_wdeg = 180 * Math.Acos(1.0 / Math.Sqrt(3)) / Math.PI;

            //pCube = new PointRPY[8] {
            //    new PointRPY(0, pitch_wdeg,  45),
            //    new PointRPY(0,180-pitch_wdeg,  45),
            //    new PointRPY(0, pitch_wdeg, -45),
            //    new PointRPY(0, pitch_wdeg, 135),
            //    new PointRPY(0,180-pitch_wdeg, -45),
            //    new PointRPY(0,180-pitch_wdeg, 135),
            //    new PointRPY(0, pitch_wdeg, 225),
            //    new PointRPY(0,180-pitch_wdeg, 225),
            //};

            pCube = new PointXYZ[8] {
                new PointXYZ( DiceSize, DiceSize, DiceSize),
                new PointXYZ(-DiceSize, DiceSize, DiceSize),
                new PointXYZ(-DiceSize,-DiceSize, DiceSize),
                new PointXYZ( DiceSize,-DiceSize, DiceSize),
                new PointXYZ( DiceSize, DiceSize,-DiceSize),
                new PointXYZ(-DiceSize, DiceSize,-DiceSize),
                new PointXYZ(-DiceSize,-DiceSize,-DiceSize),
                new PointXYZ( DiceSize,-DiceSize,-DiceSize)
            };


            roll = 0;
            pitch = 0;
            yaw = 0;

            tmrMain.Start();
            
        }

        private void ShowCube(double DistanceCamera, double DistanceScreen)
        {
            Bitmap bmp = new Bitmap(pbMain.Width, pbMain.Height);
            Graphics g = Graphics.FromImage(bmp);

            g.FillRectangle(Brushes.Red, 0, 0, pbMain.Width, pbMain.Height);


            foreach (var p in pCube)
            {
                double work_px = (Math.Cos(yaw) * Math.Cos(pitch) ) * p.x
                               + (Math.Cos(yaw) * Math.Sin(pitch) * Math.Sin(roll) - Math.Sin(yaw) * Math.Cos(roll) ) * p.y
                               + (Math.Cos(yaw) * Math.Sin(pitch) * Math.Cos(roll) + Math.Sin(yaw) * Math.Sin(roll) ) * p.z;
                double work_py = (Math.Sin(yaw) * Math.Cos(pitch)) * p.x
                               + (Math.Sin(yaw) * Math.Sin(pitch) * Math.Sin(roll) + Math.Cos(yaw) * Math.Cos(roll)) * p.y
                               + (Math.Sin(yaw) * Math.Sin(pitch) * Math.Cos(roll) - Math.Cos(yaw) * Math.Sin(roll)) * p.z;
                double work_pz = (-Math.Sin(pitch)) * p.x
                               + (Math.Cos(pitch) * Math.Sin(roll) ) * p.y
                               + (Math.Cos(pitch) * Math.Cos(roll) ) * p.z;

                //txtDebug.AppendText(p.x.ToString() + "," + p.y.ToString() + "," + p.z.ToString() + Environment.NewLine);

                double workx = (work_px * DistanceCamera) / (work_pz + DistanceCamera + DistanceScreen);
                double worky = (work_py * DistanceCamera) / (work_pz + DistanceCamera + DistanceScreen);

                //txtDebug.AppendText(workx.ToString() + "," + worky.ToString() + Environment.NewLine);
                g.DrawRectangle(Pens.Black, (float)workx + 100, (float)worky + 100, 2, 2);
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

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            ShowCube(DistanceCamera, DistanceScreen);
        }

        private void btnRollPlus_Click(object sender, EventArgs e)
        {
            roll += 5.0/180.0*Math.PI;
        }

        private void btnRollMinus_Click(object sender, EventArgs e)
        {
            roll -= 5.0 / 180.0 * Math.PI;
        }

        private void btnPitchPlus_Click(object sender, EventArgs e)
        {
            pitch += 5.0 / 180.0 * Math.PI;
        }

        private void btnPitchMinus_Click(object sender, EventArgs e)
        {
            pitch -= 5.0 / 180.0 * Math.PI;
        }

        private void btnYawPlus_Click(object sender, EventArgs e)
        {
            yaw += 5.0 / 180.0 * Math.PI;
        }

        private void btnYawMinus_Click(object sender, EventArgs e)
        {
            yaw -= 5.0 / 180.0 * Math.PI;
        }
    }
}
