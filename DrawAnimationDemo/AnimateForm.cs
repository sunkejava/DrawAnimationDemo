using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawAnimationDemo
{
    public partial class AnimateForm : Form
    {
        public AnimateForm()
        {
            InitializeComponent();
        }
        Utils.AnimationHelp animationHelp = new Utils.AnimationHelp();
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_AnimateType.Text))
            {
                MessageBox.Show("请选择动画类型");
                return;
            }
            Utils.AninationType atype = Utils.AninationType.Default;
            switch (cmb_AnimateType.Text)
            {
                case "Bounce":
                    atype = Utils.AninationType.Bounce;
                    break;
                default:
                    atype = Utils.AninationType.Default;
                    break;
            }
            doAnimation(atype);
        }

        private void AnimateForm_Load(object sender, EventArgs e)
        {
            cmb_AnimateType.Items.Add("Default");
            cmb_AnimateType.Items.Add("Bounce");
        }

        private void doAnimation(Utils.AninationType at)
        {
            foreach (Control item in panel_Main.Controls)
            {
                if (item.Name.Contains("_Test"))
                {
                    Thread thread = new Thread(() => animationHelp.startAction(item, at));
                    thread.Start();
                }
            }
        }
    }
}
