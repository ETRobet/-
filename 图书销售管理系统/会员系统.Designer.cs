namespace 图书销售管理系统
{
	partial class 会员系统
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
			this.components = new System.ComponentModel.Container();
			this.lb_nowacc = new System.Windows.Forms.Label();
			this.lb_noteacc = new System.Windows.Forms.Label();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.账户表BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.booksDBDataSet = new 图书销售管理系统.BooksDBDataSet();
			this.账户表TableAdapter = new 图书销售管理系统.BooksDBDataSetTableAdapters.账户表TableAdapter();
			this.btn_search = new System.Windows.Forms.Button();
			this.btn_updatepwd = new System.Windows.Forms.Button();
			this.tb_password = new System.Windows.Forms.TextBox();
			this.tb_copypwd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.tb_ID = new System.Windows.Forms.TextBox();
			this.tb_NUM = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btn_show = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.账户表BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb_NUM)).BeginInit();
			this.SuspendLayout();
			// 
			// lb_nowacc
			// 
			this.lb_nowacc.AutoSize = true;
			this.lb_nowacc.Font = new System.Drawing.Font("宋体", 20F);
			this.lb_nowacc.Location = new System.Drawing.Point(178, 79);
			this.lb_nowacc.Name = "lb_nowacc";
			this.lb_nowacc.Size = new System.Drawing.Size(134, 34);
			this.lb_nowacc.TabIndex = 0;
			this.lb_nowacc.Text = "account";
			this.lb_nowacc.Click += new System.EventHandler(this.label1_Click);
			// 
			// lb_noteacc
			// 
			this.lb_noteacc.AutoSize = true;
			this.lb_noteacc.Font = new System.Drawing.Font("宋体", 10F);
			this.lb_noteacc.Location = new System.Drawing.Point(19, 92);
			this.lb_noteacc.Name = "lb_noteacc";
			this.lb_noteacc.Size = new System.Drawing.Size(110, 17);
			this.lb_noteacc.TabIndex = 1;
			this.lb_noteacc.Text = "当前用户名：";
			// 
			// btn_update
			// 
			this.btn_update.Location = new System.Drawing.Point(659, 550);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(387, 265);
			this.btn_update.TabIndex = 3;
			this.btn_update.Text = "修改用户信息";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(358, 319);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(112, 78);
			this.btn_delete.TabIndex = 4;
			this.btn_delete.Text = "销毁当前账户并退出";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// 账户表BindingSource
			// 
			this.账户表BindingSource.DataMember = "账户表";
			this.账户表BindingSource.DataSource = this.booksDBDataSet;
			// 
			// booksDBDataSet
			// 
			this.booksDBDataSet.DataSetName = "BooksDBDataSet";
			this.booksDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// 账户表TableAdapter
			// 
			this.账户表TableAdapter.ClearBeforeFill = true;
			// 
			// btn_search
			// 
			this.btn_search.Location = new System.Drawing.Point(335, 79);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(123, 34);
			this.btn_search.TabIndex = 5;
			this.btn_search.Text = "查询当前账户";
			this.btn_search.UseVisualStyleBackColor = true;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
			// 
			// btn_updatepwd
			// 
			this.btn_updatepwd.Location = new System.Drawing.Point(358, 246);
			this.btn_updatepwd.Name = "btn_updatepwd";
			this.btn_updatepwd.Size = new System.Drawing.Size(112, 50);
			this.btn_updatepwd.TabIndex = 6;
			this.btn_updatepwd.Text = "修改密码";
			this.btn_updatepwd.UseVisualStyleBackColor = true;
			this.btn_updatepwd.Click += new System.EventHandler(this.btn_updatepwd_Click);
			// 
			// tb_password
			// 
			this.tb_password.Location = new System.Drawing.Point(256, 151);
			this.tb_password.Name = "tb_password";
			this.tb_password.PasswordChar = '*';
			this.tb_password.Size = new System.Drawing.Size(202, 25);
			this.tb_password.TabIndex = 7;
			// 
			// tb_copypwd
			// 
			this.tb_copypwd.Location = new System.Drawing.Point(256, 199);
			this.tb_copypwd.Name = "tb_copypwd";
			this.tb_copypwd.PasswordChar = '*';
			this.tb_copypwd.Size = new System.Drawing.Size(202, 25);
			this.tb_copypwd.TabIndex = 8;
			this.tb_copypwd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(164, 154);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 9;
			this.label1.Text = "新密码";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(164, 202);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 10;
			this.label2.Text = "重复密码";
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter1.Location = new System.Drawing.Point(659, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(387, 815);
			this.splitter1.TabIndex = 11;
			this.splitter1.TabStop = false;
			// 
			// tb_ID
			// 
			this.tb_ID.Location = new System.Drawing.Point(826, 86);
			this.tb_ID.Name = "tb_ID";
			this.tb_ID.Size = new System.Drawing.Size(166, 25);
			this.tb_ID.TabIndex = 12;
			// 
			// tb_NUM
			// 
			this.tb_NUM.Location = new System.Drawing.Point(826, 200);
			this.tb_NUM.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.tb_NUM.Name = "tb_NUM";
			this.tb_NUM.Size = new System.Drawing.Size(175, 25);
			this.tb_NUM.TabIndex = 13;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(724, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 15;
			this.label3.Text = "用户名：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(724, 202);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 15);
			this.label5.TabIndex = 17;
			this.label5.Text = "会员积分：";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// btn_show
			// 
			this.btn_show.Location = new System.Drawing.Point(826, 231);
			this.btn_show.Name = "btn_show";
			this.btn_show.Size = new System.Drawing.Size(95, 23);
			this.btn_show.TabIndex = 18;
			this.btn_show.Text = "显示当前积分";
			this.btn_show.UseVisualStyleBackColor = true;
			this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
			// 
			// 会员系统
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1046, 815);
			this.Controls.Add(this.btn_show);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_NUM);
			this.Controls.Add(this.tb_ID);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_copypwd);
			this.Controls.Add(this.tb_password);
			this.Controls.Add(this.btn_updatepwd);
			this.Controls.Add(this.btn_search);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.lb_noteacc);
			this.Controls.Add(this.lb_nowacc);
			this.Name = "会员系统";
			this.Text = "会员系统";
			this.Load += new System.EventHandler(this.会员系统_Load);
			((System.ComponentModel.ISupportInitialize)(this.账户表BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb_NUM)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_nowacc;
		private System.Windows.Forms.Label lb_noteacc;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_delete;
		private BooksDBDataSet booksDBDataSet;
		private System.Windows.Forms.BindingSource 账户表BindingSource;
		private BooksDBDataSetTableAdapters.账户表TableAdapter 账户表TableAdapter;
		private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.Button btn_updatepwd;
		private System.Windows.Forms.TextBox tb_password;
		private System.Windows.Forms.TextBox tb_copypwd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.TextBox tb_ID;
		private System.Windows.Forms.NumericUpDown tb_NUM;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btn_show;
	}
}