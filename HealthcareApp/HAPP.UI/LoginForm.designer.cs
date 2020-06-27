namespace HApp.UI
{
    partial class LoginForm
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
            this.denglu1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // denglu1
            // 
            this.denglu1.Location = new System.Drawing.Point(104, 53);
            this.denglu1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.denglu1.Name = "denglu1";
            this.denglu1.Size = new System.Drawing.Size(100, 29);
            this.denglu1.TabIndex = 0;
            this.denglu1.Text = "患者登录";
            this.denglu1.UseVisualStyleBackColor = true;
            this.denglu1.Click += new System.EventHandler(this.denglu1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "医生登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "CA注册";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 276);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.denglu1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "登录窗口";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button denglu1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

