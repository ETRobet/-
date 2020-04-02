namespace 图书销售管理系统
{
	partial class 登陆界面
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(登陆界面));
			this.btn_testcon = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_denglu = new System.Windows.Forms.Button();
			this.btn_zhuce = new System.Windows.Forms.Button();
			this.tb_account = new System.Windows.Forms.TextBox();
			this.tb_password = new System.Windows.Forms.TextBox();
			this.lb_account = new System.Windows.Forms.Label();
			this.lb_password = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_testcon
			// 
			this.btn_testcon.BackColor = System.Drawing.SystemColors.Control;
			this.btn_testcon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_testcon.Font = new System.Drawing.Font("迷你简丫丫", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_testcon.Location = new System.Drawing.Point(-2, 465);
			this.btn_testcon.Name = "btn_testcon";
			this.btn_testcon.Size = new System.Drawing.Size(133, 38);
			this.btn_testcon.TabIndex = 0;
			this.btn_testcon.Text = "测试连接";
			this.btn_testcon.UseVisualStyleBackColor = false;
			this.btn_testcon.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("迷你简稚艺", 10F);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(543, 465);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "图书销售管理系统V1.0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.DarkGray;
			this.label2.Location = new System.Drawing.Point(545, 484);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(175, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "copyright by Aerolite";
			// 
			// btn_denglu
			// 
			this.btn_denglu.BackColor = System.Drawing.Color.Transparent;
			this.btn_denglu.Location = new System.Drawing.Point(299, 210);
			this.btn_denglu.Name = "btn_denglu";
			this.btn_denglu.Size = new System.Drawing.Size(63, 36);
			this.btn_denglu.TabIndex = 3;
			this.btn_denglu.Text = "登陆";
			this.btn_denglu.UseVisualStyleBackColor = false;
			this.btn_denglu.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// btn_zhuce
			// 
			this.btn_zhuce.BackColor = System.Drawing.Color.Transparent;
			this.btn_zhuce.Location = new System.Drawing.Point(380, 210);
			this.btn_zhuce.Name = "btn_zhuce";
			this.btn_zhuce.Size = new System.Drawing.Size(59, 36);
			this.btn_zhuce.TabIndex = 4;
			this.btn_zhuce.Text = "注册";
			this.btn_zhuce.UseVisualStyleBackColor = false;
			this.btn_zhuce.Click += new System.EventHandler(this.btn_zhuce_Click);
			// 
			// tb_account
			// 
			this.tb_account.BackColor = System.Drawing.Color.LavenderBlush;
			this.tb_account.Location = new System.Drawing.Point(318, 103);
			this.tb_account.Name = "tb_account";
			this.tb_account.Size = new System.Drawing.Size(100, 25);
			this.tb_account.TabIndex = 5;
			// 
			// tb_password
			// 
			this.tb_password.BackColor = System.Drawing.Color.LavenderBlush;
			this.tb_password.Location = new System.Drawing.Point(318, 153);
			this.tb_password.Name = "tb_password";
			this.tb_password.PasswordChar = '*';
			this.tb_password.Size = new System.Drawing.Size(100, 25);
			this.tb_password.TabIndex = 6;
			// 
			// lb_account
			// 
			this.lb_account.AutoSize = true;
			this.lb_account.BackColor = System.Drawing.Color.Transparent;
			this.lb_account.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_account.Location = new System.Drawing.Point(316, 79);
			this.lb_account.Name = "lb_account";
			this.lb_account.Size = new System.Drawing.Size(65, 20);
			this.lb_account.TabIndex = 7;
			this.lb_account.Text = "登录名：";
			// 
			// lb_password
			// 
			this.lb_password.AutoSize = true;
			this.lb_password.BackColor = System.Drawing.Color.Transparent;
			this.lb_password.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_password.Location = new System.Drawing.Point(316, 131);
			this.lb_password.Name = "lb_password";
			this.lb_password.Size = new System.Drawing.Size(51, 20);
			this.lb_password.TabIndex = 8;
			this.lb_password.Text = "密码：";
			this.lb_password.Click += new System.EventHandler(this.label4_Click);
			// 
			// 登陆界面
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(724, 502);
			this.Controls.Add(this.lb_password);
			this.Controls.Add(this.lb_account);
			this.Controls.Add(this.tb_password);
			this.Controls.Add(this.tb_account);
			this.Controls.Add(this.btn_zhuce);
			this.Controls.Add(this.btn_denglu);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_testcon);
			this.Name = "登陆界面";
			this.Text = "登陆界面";
			this.Load += new System.EventHandler(this.登陆界面_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_testcon;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_denglu;
		private System.Windows.Forms.Button btn_zhuce;
		private System.Windows.Forms.TextBox tb_account;
		private System.Windows.Forms.TextBox tb_password;
		private System.Windows.Forms.Label lb_account;
		private System.Windows.Forms.Label lb_password;
	}
}

