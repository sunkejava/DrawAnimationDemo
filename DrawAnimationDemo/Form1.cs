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
        private static Timer tmc = new Timer();
        private void button1_Click(object sender, EventArgs e)
        {
            tmc.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmc.Interval = 50;
            tmc.Tick += Tmc_Tick;
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
        private int circularWidth = 16;//默认环形宽度
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            using (Pen p = new Pen(Brushes.LightGray, circularWidth))
            {
                //设置连续两段的联接样式  
                p.LineJoin = LineJoin.Round;
                e.Graphics.DrawEllipse(p, new Rectangle(new Point(e.ClipRectangle.X + circularWidth / 2, e.ClipRectangle.Y + circularWidth / 2), new Size(e.ClipRectangle.Width - 1 - circularWidth, e.ClipRectangle.Height - 1 - circularWidth)));
            }
        }
    }
}
