namespace 图书销售管理系统
{
	partial class 销售报表
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(200, 34);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 53);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(200, 93);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 57);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(609, 211);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(200, 156);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 55);
			this.button4.TabIndex = 3;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// 销售报表
			// 
			this.ClientSize = new System.Drawing.Size(696, 579);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "销售报表";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_create;
		private BooksDBDataSet booksDBDataSet;
		private System.Windows.Forms.BindingSource 订单表BindingSource;
		private BooksDBDataSetTableAdapters.订单表TableAdapter 订单表TableAdapter;
		private System.Windows.Forms.TextBox tb_bid;
		private System.Windows.Forms.TextBox tb_account;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown tb_num;
		private System.Windows.Forms.TextBox tb_type;
		private System.Windows.Forms.NumericUpDown tb_money;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.TextBox tb_sid;
		private System.Windows.Forms.TextBox tb_data;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox tb_end;
		private System.Windows.Forms.TextBox tb_start;
		private System.Windows.Forms.RadioButton rb_day;
		private System.Windows.Forms.RadioButton rb_month;
		private System.Windows.Forms.RadioButton rb_year;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}