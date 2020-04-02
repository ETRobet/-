namespace 图书销售管理系统
{
	partial class 注册界面
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_account = new System.Windows.Forms.TextBox();
			this.tb_password = new System.Windows.Forms.TextBox();
			this.tb_copypwd = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.cb_agree = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 15F);
			this.label1.Location = new System.Drawing.Point(12, 94);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "用户名：";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 15F);
			this.label2.Location = new System.Drawing.Point(12, 192);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "密码：";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 15F);
			this.label3.Location = new System.Drawing.Point(12, 267);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "确认密码：";
			// 
			// tb_account
			// 
			this.tb_account.Location = new System.Drawing.Point(153, 99);
			this.tb_account.Name = "tb_account";
			this.tb_account.Size = new System.Drawing.Size(146, 25);
			this.tb_account.TabIndex = 3;
			// 
			// tb_password
			// 
			this.tb_password.Location = new System.Drawing.Point(153, 197);
			this.tb_password.Name = "tb_password";
			this.tb_password.PasswordChar = '*';
			this.tb_password.Size = new System.Drawing.Size(146, 25);
			this.tb_password.TabIndex = 4;
			// 
			// tb_copypwd
			// 
			this.tb_copypwd.Location = new System.Drawing.Point(153, 272);
			this.tb_copypwd.Name = "tb_copypwd";
			this.tb_copypwd.PasswordChar = '*';
			this.tb_copypwd.Size = new System.Drawing.Size(146, 25);
			this.tb_copypwd.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button1.Font = new System.Drawing.Font("宋体", 20F);
			this.button1.Location = new System.Drawing.Point(0, 390);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(360, 146);
			this.button1.TabIndex = 6;
			this.button1.Text = "注册";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(236, 358);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(112, 15);
			this.linkLabel1.TabIndex = 7;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "我同意服务条款";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// cb_agree
			// 
			this.cb_agree.AutoSize = true;
			this.cb_agree.Location = new System.Drawing.Point(212, 356);
			this.cb_agree.Name = "cb_agree";
			this.cb_agree.Size = new System.Drawing.Size(18, 17);
			this.cb_agree.TabIndex = 8;
			this.cb_agree.UseVisualStyleBackColor = true;
			// 
			// 注册界面
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 536);
			this.Controls.Add(this.cb_agree);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tb_copypwd);
			this.Controls.Add(this.tb_password);
			this.Controls.Add(this.tb_account);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "注册界面";
			this.Text = "注册界面";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_account;
		private System.Windows.Forms.TextBox tb_password;
		private System.Windows.Forms.TextBox tb_copypwd;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.CheckBox cb_agree;
	}
}