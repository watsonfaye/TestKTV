namespace 点歌后台管理系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.歌手管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.歌曲管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置资源路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.歌手管理ToolStripMenuItem,
            this.歌曲管理ToolStripMenuItem,
            this.设置资源路径ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1267, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 歌手管理ToolStripMenuItem
            // 
            this.歌手管理ToolStripMenuItem.Name = "歌手管理ToolStripMenuItem";
            this.歌手管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.歌手管理ToolStripMenuItem.Text = "歌手管理";
            this.歌手管理ToolStripMenuItem.Click += new System.EventHandler(this.歌手管理ToolStripMenuItem_Click);
            // 
            // 歌曲管理ToolStripMenuItem
            // 
            this.歌曲管理ToolStripMenuItem.Name = "歌曲管理ToolStripMenuItem";
            this.歌曲管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.歌曲管理ToolStripMenuItem.Text = "歌曲管理";
            this.歌曲管理ToolStripMenuItem.Click += new System.EventHandler(this.歌曲管理ToolStripMenuItem_Click);
            // 
            // 设置资源路径ToolStripMenuItem
            // 
            this.设置资源路径ToolStripMenuItem.Name = "设置资源路径ToolStripMenuItem";
            this.设置资源路径ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.设置资源路径ToolStripMenuItem.Text = "设置资源路径";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 686);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 歌手管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 歌曲管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置资源路径ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
    }
}

