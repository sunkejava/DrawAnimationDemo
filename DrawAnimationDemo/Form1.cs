using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawAnimationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Color mainColor = Color.FromArgb(255, 92, 138);//背景色
        private static Timer tmc = new Timer();
        Graphics pc = null;
        private int cheight = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            tmc.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getValue();
            tmc.Interval = 50;
            tmc.Tick += Tmc_Tick;
            cheight = ellipseControl2.Height - 10;
        }

        private void Tmc_Tick(object sender, EventArgs e)
        {
            if (customHxjdtControl1.Value < 100)
            {
                customHxjdtControl1.Value++;
                customHxjdtControl2.Value++;
                customHxjdtControl3.Value++;
                customHxjdtControl4.Value++;
                customHxjdtControl5.Value++;
                customHxjdtControl6.Value++;
                customHxjdtControl7.Value++;
                customHxjdtControl8.Value++;
                customHxjdtControl9.Value++;
                customHxjdtControl10.Value++;
                customHxjdtControl11.Value++;
            }
            else
            {
                tmc.Enabled = false;
                customHxjdtControl1.Value = 0;
                customHxjdtControl2.Value = 0;
                customHxjdtControl3.Value = 0;
                customHxjdtControl4.Value = 0;
                customHxjdtControl5.Value = 0;
                customHxjdtControl6.Value = 0;
                customHxjdtControl7.Value = 0;
                customHxjdtControl8.Value = 0;
                customHxjdtControl9.Value = 0;
                customHxjdtControl10.Value = 0;
                customHxjdtControl11.Value = 0;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            //e.Graphics.FillEllipse(new SolidBrush(this.mainColor), new Rectangle(new Point(e.ClipRectangle.X + circularWidth / 2, e.ClipRectangle.Y + circularWidth / 2), new Size(e.ClipRectangle.Width - 1 - circularWidth, e.ClipRectangle.Height - 1 - circularWidth)));
            using (Pen p = new Pen(Brushes.LightGray, 293))
            {
                //设置连续两段的联接样式  
                p.LineJoin = LineJoin.Round;
                //e.Graphics.DrawEllipse(p, new Rectangle(new Point(e.ClipRectangle.X + circularWidth / 2, e.ClipRectangle.Y + circularWidth / 2), new Size(e.ClipRectangle.Width - 1 - circularWidth, e.ClipRectangle.Height - 1 - circularWidth)));
                e.Graphics.DrawEllipse(p, 0, 258, 293, 293);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Timer tm = new Timer();
            tm.Interval = 60;
            tm.Tick += Tm_Tick;
            tm.Enabled = true;
            cheight = ellipseControl2.Height - 10;
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            if (cheight > 10)
            {
                ellipseControl2.Visible = true;
                ellipseControl2.CenterPotion = new Point(ellipseControl2.CenterPotion.X, cheight);
                cheight = cheight - 5;
                ellipseControl2.Refresh();
            }
            else
            {
                Timer tm = sender as Timer;
                tm.Enabled = false;
                cheight = ellipseControl2.Height-10;
                ellipseControl2.Visible = false;
                ellipseControl2.Refresh();
            }
        }

        private void trackBarx_ValueChanged(object sender, EventArgs e)
        {
            tyControl1.Tyx = trackBarx.Value;
            getValue();
            tyControl1.Refresh();
        }

        private void trackBary_ValueChanged(object sender, EventArgs e)
        {
            tyControl1.Tyy = trackBary.Value;
            getValue();
            tyControl1.Refresh();
        }

        private void trackBarw_ValueChanged(object sender, EventArgs e)
        {
            tyControl1.Tyw = trackBarw.Value;
            getValue();
            tyControl1.Refresh();
        }

        private void trackBarh_ValueChanged(object sender, EventArgs e)
        {
            tyControl1.Tyh = trackBarh.Value;
            getValue();
            tyControl1.Refresh();
        }

        private void getValue()
        {
            label5.Text = "X:" + tyControl1.Size.Width.ToString() + "  Y:" + tyControl1.Size.Height.ToString();
            label1.Text = "x:" + tyControl1.Tyx.ToString();
            label2.Text = "y:" + tyControl1.Tyy.ToString();
            label3.Text = "w:" + tyControl1.Tyw.ToString();
            label4.Text = "h:" + tyControl1.Tyh.ToString();
            trackBarx.Value = tyControl1.Tyx;
            trackBary.Value = tyControl1.Tyy;
            trackBarw.Value = tyControl1.Tyw;
            trackBarh.Value = tyControl1.Tyh;
        }


        private void DrawArcFromThreePoint(Graphics mImgGraph, int x1, int y1, int x2, int y2, int x3, int y3)
        {

            double a = x1 - x2;

            double b = y1 - y2;

            double c = x1 - x3;

            double d = y1 - y3;

            double e = ((x1 * x1 - x2 * x2) + (y1 * y1 - y2 * y2)) / 2.0;

            double f = ((x1 * x1 - x3 * x3) + (y1 * y1 - y3 * y3)) / 2.0;
            mImgGraph.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            mImgGraph.SmoothingMode = SmoothingMode.HighQuality;
            mImgGraph.DrawEllipse(new Pen(Color.Red, 4), x1, y1, 4, 4);
            mImgGraph.DrawEllipse(new Pen(Color.Red, 4), x2, y2, 4, 4);
            mImgGraph.DrawEllipse(new Pen(Color.Red, 4), x3, y3, 4, 4);
            double det = b * c - a * d;
            if (Math.Abs(det) > 0.001)

            {

                //x0,y0为计算得到的原点

                double x0 = -(d * e - b * f) / det;

                double y0 = -(a * f - c * e) / det;



                SolidBrush OriginBrush = new SolidBrush(Color.Blue);

                mImgGraph.FillEllipse(OriginBrush, (int)(x0 - 3), (int)(y0 - 3), 6, 6);

                double radius = Math.Sqrt((x1 - x0) * (x1 - x0) + (y1 - y0) * (y1 - y0));



                double angle1;

                double angle2;

                double angle3;



                double sinValue1;

                double cosValue1;

                double sinValue2;

                double cosValue2;

                double sinValue3;

                double cosValue3;



                sinValue1 = (y1 - y0) / radius;

                cosValue1 = (x1 - x0) / radius;

                if (cosValue1 >= 0.99999) cosValue1 = 0.99999;

                if (cosValue1 <= -0.99999) cosValue1 = -0.99999;

                angle1 = Math.Acos(cosValue1);

                angle1 = angle1 / 3.14 * 180;

                if (sinValue1 < -0.05) angle1 = 360 - angle1;



                sinValue2 = (y2 - y0) / radius;

                cosValue2 = (x2 - x0) / radius;

                if (cosValue2 >= 0.99999) cosValue2 = 0.99999;

                if (cosValue2 <= -0.99999) cosValue2 = -0.99999;

                angle2 = Math.Acos(cosValue2);

                angle2 = angle2 / 3.14 * 180;

                if (sinValue2 < -0.05) angle2 = 360 - angle2;



                sinValue3 = (y3 - y0) / radius;

                cosValue3 = (x3 - x0) / radius;

                if (cosValue3 >= 0.99999) cosValue3 = 0.99999;

                if (cosValue3 <= -0.99999) cosValue3 = -0.99999;

                angle3 = Math.Acos(cosValue3);

                angle3 = angle3 / 3.14 * 180;

                if (sinValue3 < -0.05) angle3 = 360 - angle3;

                Pen CurvePen = new Pen(Color.FromArgb(125, 255, 92, 138), (int)radius/2);

                double Delta13;

                if (angle1 < angle3)

                {

                    Delta13 = angle3 - angle1;

                }

                else Delta13 = angle3 - angle1 + 360;

                double Delta12;

                if (angle1 < angle2)

                {

                    Delta12 = angle2 - angle1;
                }
                else Delta12 = angle2 - angle1 + 360;
                mImgGraph.FillEllipse(new SolidBrush(Color.FromArgb(125, 255, 92, 138)), (int)(x0 - radius), (int)(y0 - radius), (int)(2 * radius), (int)(2 * radius));
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ///581  296
            pc = e.Graphics;
            //cheight = 180;
            //DrawArcFromThreePoint(e.Graphics,2,295,290,180,578,295);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = panel2.PointToClient(MousePosition);
            label6.Text = "X:"+ p.X.ToString() + "   Y:" + p.Y.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Timer tmca = new Timer();
            tmca.Interval = 40;
            tmca.Enabled = true;
            tmca.Tick += Tmca_Tick;
        }

        private void Tmca_Tick(object sender, EventArgs e)
        {
            if (cheight >= 10)
            {
                ellipseControl1.Visible = true;
                ellipseControl1.CenterPotion = new Point(ellipseControl1.CenterPotion.X, cheight);
                cheight = cheight - 5;
                ellipseControl1.Refresh();
            }
            else
            {
                Timer tm = sender as Timer;
                tm.Enabled = false;
                cheight = ellipseControl2.Height-10;
                ellipseControl1.Visible = false;
                ellipseControl1.Refresh();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LayeredDemo ld = new LayeredDemo();
            ld.Show();
        }
    }
}
