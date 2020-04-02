namespace 图书销售管理系统
{
	partial class 更新模块
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
			this.tb_id = new System.Windows.Forms.TextBox();
			this.tb_name = new System.Windows.Forms.TextBox();
			this.tb_author = new System.Windows.Forms.TextBox();
			this.tb_publish = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.bt_add = new System.Windows.Forms.Button();
			this.bt_updata = new System.Windows.Forms.Button();
			this.bt_delete = new System.Windows.Forms.Button();
			this.bt_search = new System.Windows.Forms.Button();
			this.图书表BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.booksDBDataSet = new 图书销售管理系统.BooksDBDataSet();
			this.图书表TableAdapter = new 图书销售管理系统.BooksDBDataSetTableAdapters.图书表TableAdapter();
			this.tb_num = new System.Windows.Forms.NumericUpDown();
			this.tb_money = new System.Windows.Forms.NumericUpDown();
			this.tb_type = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.图书表BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb_num)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tb_money)).BeginInit();
			this.SuspendLayout();
			// 
			// tb_id
			// 
			this.tb_id.Location = new System.Drawing.Point(89, 21);
			this.tb_id.Name = "tb_id";
			this.tb_id.Size = new System.Drawing.Size(181, 25);
			this.tb_id.TabIndex = 0;
			// 
			// tb_name
			// 
			this.tb_name.Location = new System.Drawing.Point(89, 52);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(181, 25);
			this.tb_name.TabIndex = 1;
			this.tb_name.Click += new System.EventHandler(this.tb_name_Click);
			// 
			// tb_author
			// 
			this.tb_author.Location = new System.Drawing.Point(89, 83);
			this.tb_author.Name = "tb_author";
			this.tb_author.Size = new System.Drawing.Size(181, 25);
			this.tb_author.TabIndex = 2;
			this.tb_author.Click += new System.EventHandler(this.tb_author_Click);
			this.tb_author.TextChanged += new System.EventHandler(this.tb_author_TextChanged);
			// 
			// tb_publish
			// 
			this.tb_publish.Location = new System.Drawing.Point(89, 114);
			this.tb_publish.Name = "tb_publish";
			this.tb_publish.Size = new System.Drawing.Size(181, 25);
			this.tb_publish.TabIndex = 3;
			this.tb_publish.Click += new System.EventHandler(this.tb_publish_Click);
			this.tb_publish.TextChanged += new System.EventHandler(this.tb_publish_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "书号：";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "书名：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "作者：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "出版社：";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 148);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "类型：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(16, 179);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 15);
			this.label6.TabIndex = 12;
			this.label6.Text = "单价：";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(16, 215);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(52, 15);
			this.label7.TabIndex = 13;
			this.label7.Text = "数量：";
			// 
			// bt_add
			// 
			this.bt_add.Font = new System.Drawing.Font("迷你简稚艺", 20F);
			this.bt_add.Location = new System.Drawing.Point(289, 23);
			this.bt_add.Name = "bt_add";
			this.bt_add.Size = new System.Drawing.Size(207, 94);
			this.bt_add.TabIndex = 14;
			this.bt_add.Text = "添加";
			this.bt_add.UseVisualStyleBackColor = true;
			this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
			// 
			// bt_updata
			// 
			this.bt_updata.Font = new System.Drawing.Font("迷你简稚艺", 20F);
			this.bt_updata.Location = new System.Drawing.Point(502, 23);
			this.bt_updata.Name = "bt_updata";
			this.bt_updata.Size = new System.Drawing.Size(212, 94);
			this.bt_updata.TabIndex = 15;
			this.bt_updata.Text = "更新";
			this.bt_updata.UseVisualStyleBackColor = true;
			this.bt_updata.Click += new System.EventHandler(this.bt_updata_Click);
			// 
			// bt_delete
			// 
			this.bt_delete.Font = new System.Drawing.Font("迷你简稚艺", 20F);
			this.bt_delete.Location = new System.Drawing.Point(289, 117);
			this.bt_delete.Name = "bt_delete";
			this.bt_delete.Size = new System.Drawing.Size(207, 114);
			this.bt_delete.TabIndex = 16;
			this.bt_delete.Text = "删除";
			this.bt_delete.UseVisualStyleBackColor = true;
			this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
			// 
			// bt_search
			// 
			this.bt_search.Font = new System.Drawing.Font("迷你简稚艺", 20F);
			this.bt_search.Location = new System.Drawing.Point(502, 117);
			this.bt_search.Name = "bt_search";
			this.bt_search.Size = new System.Drawing.Size(212, 114);
			this.bt_search.TabIndex = 17;
			this.bt_search.Text = "查询书号";
			this.bt_search.UseVisualStyleBackColor = true;
			this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
			// 
			// 图书表BindingSource
			// 
			this.图书表BindingSource.DataMember = "图书表";
			this.图书表BindingSource.DataSource = this.booksDBDataSet;
			// 
			// booksDBDataSet
			// 
			this.booksDBDataSet.DataSetName = "BooksDBDataSet";
			this.booksDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// 图书表TableAdapter
			// 
			this.图书表TableAdapter.ClearBeforeFill = true;
			// 
			// tb_num
			// 
			this.tb_num.Location = new System.Drawing.Point(90, 213);
			this.tb_num.Name = "tb_num";
			this.tb_num.Size = new System.Drawing.Size(83, 25);
			this.tb_num.TabIndex = 20;
			this.tb_num.ValueChanged += new System.EventHandler(this.tb_num_ValueChanged);
			this.tb_num.Click += new System.EventHandler(this.tb_num_Click);
			// 
			// tb_money
			// 
			this.tb_money.Location = new System.Drawing.Point(89, 177);
			this.tb_money.Name = "tb_money";
			this.tb_money.Size = new System.Drawing.Size(84, 25);
			this.tb_money.TabIndex = 21;
			this.tb_money.ValueChanged += new System.EventHandler(this.tb_money_ValueChanged);
			this.tb_money.Click += new System.EventHandler(this.tb_money_Click);
			// 
			// tb_type
			// 
			this.tb_type.FormattingEnabled = true;
			this.tb_type.Items.AddRange(new object[] {
            "社会人文",
            "计算机科学",
            "艺术",
            "军事历史",
            "其他"});
			this.tb_type.Location = new System.Drawing.Point(89, 145);
			this.tb_type.Name = "tb_type";
			this.tb_type.Size = new System.Drawing.Size(181, 23);
			this.tb_type.TabIndex = 22;
			this.tb_type.SelectedIndexChanged += new System.EventHandler(this.tb_type_SelectedIndexChanged);
			this.tb_type.Click += new System.EventHandler(this.tb_type_Click);
			// 
			// 更新模块
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 253);
			this.Controls.Add(this.tb_type);
			this.Controls.Add(this.tb_money);
			this.Controls.Add(this.tb_num);
			this.Controls.Add(this.bt_search);
			this.Controls.Add(this.bt_delete);
			this.Controls.Add(this.bt_updata);
			this.Controls.Add(this.bt_add);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_publish);
			this.Controls.Add(this.tb_author);
			this.Controls.Add(this.tb_name);
			this.Controls.Add(this.tb_id);
			this.Name = "更新模块";
			this.Text = "录入模块";
			this.Load += new System.EventHandler(this.更新模块_Load);
			((System.ComponentModel.ISupportInitialize)(this.图书表BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb_num)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tb_money)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb_id;
		private System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.TextBox tb_author;
		private System.Windows.Forms.TextBox tb_publish;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button bt_add;
		private System.Windows.Forms.Button bt_updata;
		private System.Windows.Forms.Button bt_delete;
		private System.Windows.Forms.Button bt_search;
		private BooksDBDataSet booksDBDataSet;
		private System.Windows.Forms.BindingSource 图书表BindingSource;
		private BooksDBDataSetTableAdapters.图书表TableAdapter 图书表TableAdapter;
		private System.Windows.Forms.NumericUpDown tb_num;
		private System.Windows.Forms.NumericUpDown tb_money;
		private System.Windows.Forms.ComboBox tb_type;
	}
}