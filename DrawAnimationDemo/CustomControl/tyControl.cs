using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DrawAnimationDemo.CustomControl
{
    public partial class tyControl : Control
    {
        public tyControl()
        {
            InitializeComponent();
        }
        private int tyx = 125;
        private int tyy = 258;
        private int tyw = 293;
        private int tyh = 293;
        public int Tyx
        {
            get { return tyx; }
            set { tyx = value; }
        }

        public int Tyy
        {
            get { return tyy; }
            set { tyy = value; }
        }
        public int Tyw
        {
            get { return tyw; }
            set { tyw = value; }
        }
        public int Tyh
        {
            get { return tyh; }
            set { tyh = value; }
        }

        private void tyControl_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            //e.Graphics.FillEllipse(new SolidBrush(this.mainColor), new Rectangle(new Point(e.ClipRectangle.X + circularWidth / 2, e.ClipRectangle.Y + circularWidth / 2), new Size(e.ClipRectangle.Width - 1 - circularWidth, e.ClipRectangle.Height - 1 - circularWidth)));
            using (Pen p = new Pen(Brushes.LightGray, tyw))
            {
                //设置连续两段的联接样式  
                p.LineJoin = LineJoin.Round;
                //e.Graphics.DrawEllipse(p, new Rectangle(new Point(e.ClipRectangle.X + circularWidth / 2, e.ClipRectangle.Y + circularWidth / 2), new Size(e.ClipRectangle.Width - 1 - circularWidth, e.ClipRectangle.Height - 1 - circularWidth)));
                e.Graphics.DrawEllipse(p, tyx, tyy, tyw, tyh);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            //e.Graphics.FillEllipse(new SolidBrush(this.mainColor), new Rectangle(new Point(e.ClipRectangle.X + circularWidth / 2, e.ClipRectangle.Y + circularWidth / 2), new Size(e.ClipRectangle.Width - 1 - circularWidth, e.ClipRectangle.Height - 1 - circularWidth)));
            using (Pen p = new Pen(Color.FromArgb(125, 255, 92, 138), tyw))
            {
                //设置连续两段的联接样式  
                p.LineJoin = LineJoin.Round;
                //e.Graphics.DrawEllipse(p, new Rectangle(new Point(e.ClipRectangle.X + circularWidth / 2, e.ClipRectangle.Y + circularWidth / 2), new Size(e.ClipRectangle.Width - 1 - circularWidth, e.ClipRectangle.Height - 1 - circularWidth)));
                e.Graphics.DrawEllipse(p, tyx, tyy, tyw, tyh);
            }
        }
    }
}
