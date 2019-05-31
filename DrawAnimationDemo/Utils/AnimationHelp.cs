/****************************************************************************
*Copyright (c) 2019  All Rights Reserved.
*CLR版本： 4.0.30319.42000
*机器名称：KDT-8
*命名空间：DrawAnimationDemo.Utils
*文件名：  AnimationHelp
*版本号：  V1.0.0.0
*唯一标识：c540b44e-7e2f-4076-b1a7-fc441a0a32e9
*当前的用户域：KDT-8
*创建人：  sunkejava
*电子邮箱：declineaberdeen@foxmail.com
*创建时间：2019/5/31 14:05:29
*描述：动画帮助类
*
*=====================================================================
*修改标记
*修改时间：2019/5/31 14:05:29
*修改人： Administrator
*版本号： V1.0.0.0
*描述：
*
*****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawAnimationDemo.Utils
{
    public enum AninationType
    {
        Default,//默认
        Bounce,//弹跳


    }

    public class AnimationHelp
    {
        private Control animationControl = null;
        private AninationType animationType = AninationType.Bounce;
        private System.Drawing.Point oldPoint = new System.Drawing.Point(0, 0);
        System.Windows.Forms.Timer animationTimer = new System.Windows.Forms.Timer();
        public void startAction(Control needControl, AninationType needAnimationType)
        {
            animationControl = needControl;
            animationType = needAnimationType;
            animationTimer.Interval = 1000;
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();
        }
        /// <summary>
        /// 定时触发动画操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            switch (animationType)
            {
                case AninationType.Bounce:
                    doBounce();
                    break;
                case AninationType.Default:
                    break;
            }
        }
        /// <summary>
        /// 弹跳操作
        /// </summary>
        private void doBounce()
        {
            if (animationControl != null)
            {
                oldPoint = oldPoint != new System.Drawing.Point(0, 0) ? oldPoint : animationControl.Location;
                animationControl.Location = new System.Drawing.Point(oldPoint.X, oldPoint.Y + 40);
                animationControl.Location = new System.Drawing.Point(oldPoint.X, oldPoint.Y + 20);
                animationControl.Location = new System.Drawing.Point(oldPoint.X, oldPoint.Y + 0);
                animationControl.Refresh();
                Thread.Sleep(50);
                animationControl.Location = new System.Drawing.Point(oldPoint.X, oldPoint.Y + 30);
                animationControl.Location = new System.Drawing.Point(oldPoint.X, oldPoint.Y + 15);
                animationControl.Location = new System.Drawing.Point(oldPoint.X, oldPoint.Y + 0);
                animationControl.Refresh();
                Thread.Sleep(50);
                animationControl.Location = new System.Drawing.Point(oldPoint.X, oldPoint.Y + 12);
                animationControl.Location = new System.Drawing.Point(oldPoint.X, oldPoint.Y + 0);
                animationControl.Refresh();
                Thread.Sleep(50);
                animationTimer.Stop();
            }
        }
    }
}
