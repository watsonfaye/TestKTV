namespace WindowsFormsApp5
{
    partial class UISingerChoose
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 107);
            this.button1.TabIndex = 0;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1167, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 107);
            this.button2.TabIndex = 0;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(107, 169);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1054, 337);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // UISingerChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.timg__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UISingerChoose";
            this.Size = new System.Drawing.Size(1242, 659);
            this.Load += new System.EventHandler(this.UISingerChoose_Load);
            this.DockChanged += new System.EventHandler(this.UISingerChoose_DockChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
