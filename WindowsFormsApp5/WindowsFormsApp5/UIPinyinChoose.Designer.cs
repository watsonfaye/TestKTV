namespace WindowsFormsApp5
{
    partial class UIPinyinChoose
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIPinyinChoose));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.songItem6 = new WindowsFormsApp5.SongItem();
            this.songItem1 = new WindowsFormsApp5.SongItem();
            this.songItem2 = new WindowsFormsApp5.SongItem();
            this.songItem3 = new WindowsFormsApp5.SongItem();
            this.songItem4 = new WindowsFormsApp5.SongItem();
            this.songItem5 = new WindowsFormsApp5.SongItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "timg (4).jpg");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.songItem6);
            this.flowLayoutPanel1.Controls.Add(this.songItem1);
            this.flowLayoutPanel1.Controls.Add(this.songItem2);
            this.flowLayoutPanel1.Controls.Add(this.songItem3);
            this.flowLayoutPanel1.Controls.Add(this.songItem4);
            this.flowLayoutPanel1.Controls.Add(this.songItem5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(440, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(689, 750);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.DockChanged += new System.EventHandler(this.flowLayoutPanel1_DockChanged);
            // 
            // songItem6
            // 
            this.songItem6.BackColor = System.Drawing.Color.Transparent;
            this.songItem6.Location = new System.Drawing.Point(3, 3);
            this.songItem6.Name = "songItem6";
            this.songItem6.Size = new System.Drawing.Size(649, 118);
            this.songItem6.SongIndex = 0;
            this.songItem6.SongName = null;
            this.songItem6.TabIndex = 0;
            // 
            // songItem1
            // 
            this.songItem1.BackColor = System.Drawing.Color.Transparent;
            this.songItem1.Location = new System.Drawing.Point(3, 127);
            this.songItem1.Name = "songItem1";
            this.songItem1.Size = new System.Drawing.Size(649, 118);
            this.songItem1.SongIndex = 0;
            this.songItem1.SongName = null;
            this.songItem1.TabIndex = 0;
            // 
            // songItem2
            // 
            this.songItem2.BackColor = System.Drawing.Color.Transparent;
            this.songItem2.Location = new System.Drawing.Point(3, 251);
            this.songItem2.Name = "songItem2";
            this.songItem2.Size = new System.Drawing.Size(649, 118);
            this.songItem2.SongIndex = 0;
            this.songItem2.SongName = null;
            this.songItem2.TabIndex = 0;
            // 
            // songItem3
            // 
            this.songItem3.BackColor = System.Drawing.Color.Transparent;
            this.songItem3.Location = new System.Drawing.Point(3, 375);
            this.songItem3.Name = "songItem3";
            this.songItem3.Size = new System.Drawing.Size(649, 118);
            this.songItem3.SongIndex = 0;
            this.songItem3.SongName = null;
            this.songItem3.TabIndex = 0;
            // 
            // songItem4
            // 
            this.songItem4.BackColor = System.Drawing.Color.Transparent;
            this.songItem4.Location = new System.Drawing.Point(3, 499);
            this.songItem4.Name = "songItem4";
            this.songItem4.Size = new System.Drawing.Size(649, 118);
            this.songItem4.SongIndex = 0;
            this.songItem4.SongName = null;
            this.songItem4.TabIndex = 0;
            // 
            // songItem5
            // 
            this.songItem5.BackColor = System.Drawing.Color.Transparent;
            this.songItem5.Location = new System.Drawing.Point(3, 623);
            this.songItem5.Name = "songItem5";
            this.songItem5.Size = new System.Drawing.Size(649, 118);
            this.songItem5.SongIndex = 0;
            this.songItem5.SongName = null;
            this.songItem5.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(335, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 146);
            this.button1.TabIndex = 1;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Location = new System.Drawing.Point(1175, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 146);
            this.button2.TabIndex = 1;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(1175, 175);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 53);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UIPinyinChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::WindowsFormsApp5.Properties.Resources.timg__4_;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UIPinyinChoose";
            this.Size = new System.Drawing.Size(1498, 756);
            this.Load += new System.EventHandler(this.PinyinRequestSong_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private SongItem songItem6;
        private SongItem songItem1;
        private SongItem songItem2;
        private SongItem songItem3;
        private SongItem songItem4;
        private SongItem songItem5;
    }
}
