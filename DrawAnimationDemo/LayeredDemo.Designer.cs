namespace DrawAnimationDemo
{
    partial class LayeredDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayeredDemo));
            this.lbu = new LayeredSkin.Controls.LayeredBaseControl();
            this.SuspendLayout();
            // 
            // lbu
            // 
            this.lbu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lbu.Borders.BottomColor = System.Drawing.Color.Empty;
            this.lbu.Borders.BottomWidth = 1;
            this.lbu.Borders.LeftColor = System.Drawing.Color.Empty;
            this.lbu.Borders.LeftWidth = 1;
            this.lbu.Borders.RightColor = System.Drawing.Color.Empty;
            this.lbu.Borders.RightWidth = 1;
            this.lbu.Borders.TopColor = System.Drawing.Color.Empty;
            this.lbu.Borders.TopWidth = 1;
            this.lbu.Canvas = ((System.Drawing.Bitmap)(resources.GetObject("lbu.Canvas")));
            this.lbu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbu.Location = new System.Drawing.Point(0, 0);
            this.lbu.Name = "lbu";
            this.lbu.Size = new System.Drawing.Size(800, 450);
            this.lbu.TabIndex = 0;
            this.lbu.Text = "layeredBaseControl1";
            // 
            // LayeredDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbu);
            this.Name = "LayeredDemo";
            this.Radius = 25;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LayeredDemo";
            this.Load += new System.EventHandler(this.LayeredDemo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LayeredSkin.Controls.LayeredBaseControl lbu;
    }
}