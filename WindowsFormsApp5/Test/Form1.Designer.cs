namespace Test
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.myItem4 = new Test.MyItem();
            this.myItem3 = new Test.MyItem();
            this.myItem2 = new Test.MyItem();
            this.myItem1 = new Test.MyItem();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1124, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // myItem4
            // 
            this.myItem4.Location = new System.Drawing.Point(872, 220);
            this.myItem4.Name = "myItem4";
            this.myItem4.Size = new System.Drawing.Size(100, 150);
            this.myItem4.TabIndex = 0;
            this.myItem4.Url = null;
            // 
            // myItem3
            // 
            this.myItem3.Location = new System.Drawing.Point(694, 220);
            this.myItem3.Name = "myItem3";
            this.myItem3.Size = new System.Drawing.Size(100, 150);
            this.myItem3.TabIndex = 0;
            this.myItem3.Url = null;
            // 
            // myItem2
            // 
            this.myItem2.Location = new System.Drawing.Point(516, 220);
            this.myItem2.Name = "myItem2";
            this.myItem2.Size = new System.Drawing.Size(100, 150);
            this.myItem2.TabIndex = 0;
            this.myItem2.Url = null;
            // 
            // myItem1
            // 
            this.myItem1.Location = new System.Drawing.Point(338, 220);
            this.myItem1.Name = "myItem1";
            this.myItem1.Size = new System.Drawing.Size(100, 150);
            this.myItem1.TabIndex = 0;
            this.myItem1.Url = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 606);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.myItem4);
            this.Controls.Add(this.myItem3);
            this.Controls.Add(this.myItem2);
            this.Controls.Add(this.myItem1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyItem myItem1;
        private MyItem myItem2;
        private MyItem myItem3;
        private MyItem myItem4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

