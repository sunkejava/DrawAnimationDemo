namespace DrawAnimationDemo
{
    partial class AnimateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.cmb_AnimateType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.Label_Test = new System.Windows.Forms.Label();
            this.Button_Test = new System.Windows.Forms.Button();
            this.Panel_Test = new System.Windows.Forms.Panel();
            this.PictureBox_Test = new System.Windows.Forms.PictureBox();
            this.ListBox_Test = new System.Windows.Forms.ListBox();
            this.ListView_Test = new System.Windows.Forms.ListView();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Test)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_AnimateType
            // 
            this.cmb_AnimateType.FormattingEnabled = true;
            this.cmb_AnimateType.Location = new System.Drawing.Point(64, 355);
            this.cmb_AnimateType.Name = "cmb_AnimateType";
            this.cmb_AnimateType.Size = new System.Drawing.Size(121, 20);
            this.cmb_AnimateType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "动画类型：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.ListView_Test);
            this.panel_Main.Controls.Add(this.ListBox_Test);
            this.panel_Main.Controls.Add(this.PictureBox_Test);
            this.panel_Main.Controls.Add(this.Panel_Test);
            this.panel_Main.Controls.Add(this.Button_Test);
            this.panel_Main.Controls.Add(this.Label_Test);
            this.panel_Main.Location = new System.Drawing.Point(3, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(685, 349);
            this.panel_Main.TabIndex = 3;
            // 
            // Label_Test
            // 
            this.Label_Test.AutoSize = true;
            this.Label_Test.Location = new System.Drawing.Point(9, 9);
            this.Label_Test.Name = "Label_Test";
            this.Label_Test.Size = new System.Drawing.Size(83, 12);
            this.Label_Test.TabIndex = 0;
            this.Label_Test.Text = "Label控件测试";
            // 
            // Button_Test
            // 
            this.Button_Test.Location = new System.Drawing.Point(98, 4);
            this.Button_Test.Name = "Button_Test";
            this.Button_Test.Size = new System.Drawing.Size(75, 23);
            this.Button_Test.TabIndex = 1;
            this.Button_Test.Text = "按钮控件测试";
            this.Button_Test.UseVisualStyleBackColor = true;
            // 
            // Panel_Test
            // 
            this.Panel_Test.BackColor = System.Drawing.Color.LightCoral;
            this.Panel_Test.Location = new System.Drawing.Point(188, 4);
            this.Panel_Test.Name = "Panel_Test";
            this.Panel_Test.Size = new System.Drawing.Size(94, 56);
            this.Panel_Test.TabIndex = 2;
            // 
            // PictureBox_Test
            // 
            this.PictureBox_Test.BackgroundImage = global::DrawAnimationDemo.Properties.Resources.logo;
            this.PictureBox_Test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox_Test.Location = new System.Drawing.Point(287, 4);
            this.PictureBox_Test.Name = "PictureBox_Test";
            this.PictureBox_Test.Size = new System.Drawing.Size(56, 56);
            this.PictureBox_Test.TabIndex = 3;
            this.PictureBox_Test.TabStop = false;
            // 
            // ListBox_Test
            // 
            this.ListBox_Test.FormattingEnabled = true;
            this.ListBox_Test.ItemHeight = 12;
            this.ListBox_Test.Location = new System.Drawing.Point(348, 4);
            this.ListBox_Test.Name = "ListBox_Test";
            this.ListBox_Test.Size = new System.Drawing.Size(120, 148);
            this.ListBox_Test.TabIndex = 4;
            // 
            // ListView_Test
            // 
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.ListView_Test.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.ListView_Test.Location = new System.Drawing.Point(474, 3);
            this.ListView_Test.Name = "ListView_Test";
            this.ListView_Test.Size = new System.Drawing.Size(99, 149);
            this.ListView_Test.TabIndex = 5;
            this.ListView_Test.UseCompatibleStateImageBehavior = false;
            // 
            // AnimateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 379);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_AnimateType);
            this.Controls.Add(this.label1);
            this.Name = "AnimateForm";
            this.Text = "AnimateForm";
            this.Load += new System.EventHandler(this.AnimateForm_Load);
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_AnimateType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Label Label_Test;
        private System.Windows.Forms.Button Button_Test;
        private System.Windows.Forms.PictureBox PictureBox_Test;
        private System.Windows.Forms.Panel Panel_Test;
        private System.Windows.Forms.ListBox ListBox_Test;
        private System.Windows.Forms.ListView ListView_Test;
    }
}