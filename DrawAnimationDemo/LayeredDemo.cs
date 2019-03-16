using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawAnimationDemo.CustomControl;
using LayeredSkin.Forms;

namespace DrawAnimationDemo
{
    public partial class LayeredDemo : LayeredForm
    {
        CustomControl1 cs = new CustomControl1();
        private static Timer tmc = new Timer();
        public LayeredDemo()
        {
            InitializeComponent();
        }

        private void LayeredDemo_Load(object sender, EventArgs e)
        {
            
            cs.Size = new Size(150, 150);
            cs.Location = new Point(100, 50);
            cs.Value = 0;
            cs.BackColor = Color.Transparent;
            cs.Visible = true;
            this.Controls.Add(cs);
            tmc.Enabled = true;
            tmc.Interval = 50;
            tmc.Tick += Tmc_Tick;
        }

        private void Tmc_Tick(object sender, EventArgs e)
        {
            if (cs.Value < 100)
            {
                //customControl11.Value++;
                cs.Value++;
            }
            else {
                //customControl11.Value = 0;
                cs.Value = 0;
            }
            this.Refresh();
            cs.Refresh();
        }

    }
}
