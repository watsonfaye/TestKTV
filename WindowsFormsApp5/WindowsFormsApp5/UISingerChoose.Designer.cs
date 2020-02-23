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
            this.panel1 = new System.Windows.Forms.Panel();
            this.myItem5 = new WindowsFormsApp5.MyItem();
            this.myItem4 = new WindowsFormsApp5.MyItem();
            this.myItem3 = new WindowsFormsApp5.MyItem();
            this.myItem2 = new WindowsFormsApp5.MyItem();
            this.myItem1 = new WindowsFormsApp5.MyItem();
            this.panel1.SuspendLayout();
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
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.myItem5);
            this.panel1.Controls.Add(this.myItem4);
            this.panel1.Controls.Add(this.myItem3);
            this.panel1.Controls.Add(this.myItem2);
            this.panel1.Controls.Add(this.myItem1);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(123, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 513);
            this.panel1.TabIndex = 1;
            // 
            // myItem5
            // 
            this.myItem5.BackColor = System.Drawing.Color.Transparent;
            this.myItem5.Location = new System.Drawing.Point(829, 160);
            this.myItem5.Name = "myItem5";
            this.myItem5.Size = new System.Drawing.Size(150, 230);
            this.myItem5.TabIndex = 0;
            this.myItem5.Url = null;
            // 
            // myItem4
            // 
            this.myItem4.BackColor = System.Drawing.Color.Transparent;
            this.myItem4.Location = new System.Drawing.Point(633, 160);
            this.myItem4.Name = "myItem4";
            this.myItem4.Size = new System.Drawing.Size(150, 230);
            this.myItem4.TabIndex = 0;
            this.myItem4.Url = null;
            // 
            // myItem3
            // 
            this.myItem3.BackColor = System.Drawing.Color.Transparent;
            this.myItem3.Location = new System.Drawing.Point(437, 160);
            this.myItem3.Name = "myItem3";
            this.myItem3.Size = new System.Drawing.Size(150, 230);
            this.myItem3.TabIndex = 0;
            this.myItem3.Url = null;
            // 
            // myItem2
            // 
            this.myItem2.BackColor = System.Drawing.Color.Transparent;
            this.myItem2.Location = new System.Drawing.Point(241, 160);
            this.myItem2.Name = "myItem2";
            this.myItem2.Size = new System.Drawing.Size(150, 230);
            this.myItem2.TabIndex = 0;
            this.myItem2.Url = null;
            // 
            // myItem1
            // 
            this.myItem1.BackColor = System.Drawing.Color.Transparent;
            this.myItem1.Location = new System.Drawing.Point(45, 160);
            this.myItem1.Name = "myItem1";
            this.myItem1.Size = new System.Drawing.Size(150, 230);
            this.myItem1.TabIndex = 0;
            this.myItem1.Url = null;
            // 
            // UISingerChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.timg__4_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UISingerChoose";
            this.Size = new System.Drawing.Size(1242, 659);
            this.Load += new System.EventHandler(this.UISingerChoose_Load);
            this.DockChanged += new System.EventHandler(this.UISingerChoose_DockChanged);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private MyItem myItem5;
        private MyItem myItem4;
        private MyItem myItem3;
        private MyItem myItem2;
        private MyItem myItem1;
    }
}
