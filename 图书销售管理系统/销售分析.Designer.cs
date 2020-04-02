namespace 图书销售管理系统
{
	partial class 销售分析
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
			this.btn_search = new System.Windows.Forms.Button();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_create = new System.Windows.Forms.Button();
			this.tb_sid = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_account = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_type = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_bid = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tb_data = new System.Windows.Forms.TextBox();
			this.btn_add = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.tb_money = new System.Windows.Forms.NumericUpDown();
			this.tb_num = new System.Windows.Forms.NumericUpDown();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_ssea = new System.Windows.Forms.Button();
			this.lb_realmoney = new System.Windows.Forms.Label();
			this.dtp_start = new System.Windows.Forms.DateTimePicker();
			this.dtp_end = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.num_realmoney = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.tb_money)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb_num)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_realmoney)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_search
			// 
			this.btn_search.Location = new System.Drawing.Point(339, 12);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(84, 74);
			this.btn_search.TabIndex = 0;
			this.btn_search.Text = "查询";
			this.btn_search.UseVisualStyleBackColor = true;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// btn_update
			// 
			this.btn_update.Location = new System.Drawing.Point(339, 92);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(84, 78);
			this.btn_update.TabIndex = 1;
			this.btn_update.Text = "更新";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(339, 176);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(84, 85);
			this.btn_delete.TabIndex = 2;
			this.btn_delete.Text = "删除";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_create
			// 
			this.btn_create.Location = new System.Drawing.Point(429, 92);
			this.btn_create.Name = "btn_create";
			this.btn_create.Size = new System.Drawing.Size(290, 240);
			this.btn_create.TabIndex = 3;
			this.btn_create.Text = "报表生成";
			this.btn_create.UseVisualStyleBackColor = true;
			this.btn_create.Click += new System.EventHandler(this.button1_Click);
			// 
			// tb_sid
			// 
			this.tb_sid.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.tb_sid.Location = new System.Drawing.Point(142, 39);
			this.tb_sid.Name = "tb_sid";
			this.tb_sid.Size = new System.Drawing.Size(182, 25);
			this.tb_sid.TabIndex = 4;
			this.tb_sid.Text = "点击自动创建编号";
			this.tb_sid.Click += new System.EventHandler(this.tb_sid_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(59, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "订单编号";
			// 
			// tb_account
			// 
			this.tb_account.Location = new System.Drawing.Point(142, 92);
			this.tb_account.Name = "tb_account";
			this.tb_account.Size = new System.Drawing.Size(182, 25);
			this.tb_account.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(59, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "用户名";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(59, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "用户权益";
			// 
			// tb_type
			// 
			this.tb_type.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.tb_type.Location = new System.Drawing.Point(142, 145);
			this.tb_type.Name = "tb_type";
			this.tb_type.Size = new System.Drawing.Size(182, 25);
			this.tb_type.TabIndex = 9;
			this.tb_type.Text = "点击自动获取";
			this.tb_type.Click += new System.EventHandler(this.tb_type_Click);
			this.tb_type.TextChanged += new System.EventHandler(this.tb_type_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(59, 195);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 15);
			this.label4.TabIndex = 10;
			this.label4.Text = "书号";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// tb_bid
			// 
			this.tb_bid.Location = new System.Drawing.Point(142, 192);
			this.tb_bid.Name = "tb_bid";
			this.tb_bid.Size = new System.Drawing.Size(182, 25);
			this.tb_bid.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(59, 249);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 15);
			this.label5.TabIndex = 12;
			this.label5.Text = "数量";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(59, 298);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(37, 15);
			this.label6.TabIndex = 15;
			this.label6.Text = "售价";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(59, 344);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 15);
			this.label7.TabIndex = 16;
			this.label7.Text = "日期";
			// 
			// tb_data
			// 
			this.tb_data.Location = new System.Drawing.Point(142, 344);
			this.tb_data.Name = "tb_data";
			this.tb_data.Size = new System.Drawing.Size(182, 25);
			this.tb_data.TabIndex = 17;
			this.tb_data.TextChanged += new System.EventHandler(this.tb_data_TextChanged);
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(339, 267);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(84, 130);
			this.btn_add.TabIndex = 18;
			this.btn_add.Text = "添加";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(139, 382);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 15);
			this.label8.TabIndex = 19;
			this.label8.Text = "等价格式";
			// 
			// tb_money
			// 
			this.tb_money.Location = new System.Drawing.Point(142, 296);
			this.tb_money.Name = "tb_money";
			this.tb_money.Size = new System.Drawing.Size(120, 25);
			this.tb_money.TabIndex = 22;
			this.tb_money.ValueChanged += new System.EventHandler(this.tb_money_ValueChanged);
			// 
			// tb_num
			// 
			this.tb_num.Location = new System.Drawing.Point(142, 249);
			this.tb_num.Name = "tb_num";
			this.tb_num.Size = new System.Drawing.Size(120, 25);
			this.tb_num.TabIndex = 23;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(0, 413);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(731, 343);
			this.dataGridView1.TabIndex = 24;
			// 
			// btn_ssea
			// 
			this.btn_ssea.Location = new System.Drawing.Point(429, 338);
			this.btn_ssea.Name = "btn_ssea";
			this.btn_ssea.Size = new System.Drawing.Size(290, 59);
			this.btn_ssea.TabIndex = 25;
			this.btn_ssea.Text = "销售表查询";
			this.btn_ssea.UseVisualStyleBackColor = true;
			this.btn_ssea.Click += new System.EventHandler(this.btn_ssea_Click);
			// 
			// lb_realmoney
			// 
			this.lb_realmoney.AutoSize = true;
			this.lb_realmoney.ForeColor = System.Drawing.SystemColors.ScrollBar;
			this.lb_realmoney.Location = new System.Drawing.Point(272, 280);
			this.lb_realmoney.Name = "lb_realmoney";
			this.lb_realmoney.Size = new System.Drawing.Size(52, 15);
			this.lb_realmoney.TabIndex = 26;
			this.lb_realmoney.Text = "优惠后";
			this.lb_realmoney.Click += new System.EventHandler(this.lb_realmoney_Click);
			// 
			// dtp_start
			// 
			this.dtp_start.Location = new System.Drawing.Point(528, 12);
			this.dtp_start.Name = "dtp_start";
			this.dtp_start.Size = new System.Drawing.Size(191, 25);
			this.dtp_start.TabIndex = 27;
			this.dtp_start.Value = new System.DateTime(1990, 1, 1, 0, 1, 0, 0);
			// 
			// dtp_end
			// 
			this.dtp_end.Location = new System.Drawing.Point(528, 61);
			this.dtp_end.Name = "dtp_end";
			this.dtp_end.Size = new System.Drawing.Size(191, 25);
			this.dtp_end.TabIndex = 28;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(455, 19);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 15);
			this.label9.TabIndex = 29;
			this.label9.Text = "起始时间";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(455, 68);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 15);
			this.label10.TabIndex = 30;
			this.label10.Text = "终止时间";
			// 
			// num_realmoney
			// 
			this.num_realmoney.Location = new System.Drawing.Point(268, 298);
			this.num_realmoney.Name = "num_realmoney";
			this.num_realmoney.Size = new System.Drawing.Size(56, 25);
			this.num_realmoney.TabIndex = 31;
			// 
			// 销售分析
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(731, 756);
			this.Controls.Add(this.num_realmoney);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dtp_end);
			this.Controls.Add(this.dtp_start);
			this.Controls.Add(this.lb_realmoney);
			this.Controls.Add(this.btn_ssea);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tb_num);
			this.Controls.Add(this.tb_money);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.tb_data);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tb_bid);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tb_type);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tb_account);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_sid);
			this.Controls.Add(this.btn_create);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.btn_search);
			this.Name = "销售分析";
			this.Text = "销售分析";
			((System.ComponentModel.ISupportInitialize)(this.tb_money)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb_num)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_realmoney)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_create;
		private System.Windows.Forms.TextBox tb_sid;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_account;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_type;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_bid;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tb_data;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown tb_money;
		private System.Windows.Forms.NumericUpDown tb_num;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_ssea;
		public System.Windows.Forms.Label lb_realmoney;
		private System.Windows.Forms.DateTimePicker dtp_start;
		private System.Windows.Forms.DateTimePicker dtp_end;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown num_realmoney;
	}
}