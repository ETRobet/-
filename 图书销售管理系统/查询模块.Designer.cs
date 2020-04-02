namespace 图书销售管理系统
{
	partial class 查询模块
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
			this.btn_ids = new System.Windows.Forms.Button();
			this.btn_names = new System.Windows.Forms.Button();
			this.btn_types = new System.Windows.Forms.Button();
			this.tb_name = new System.Windows.Forms.TextBox();
			this.tb_publish = new System.Windows.Forms.TextBox();
			this.tb_author = new System.Windows.Forms.TextBox();
			this.tb_id = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_type = new System.Windows.Forms.ComboBox();
			this.图书表BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.booksDBDataSet = new 图书销售管理系统.BooksDBDataSet();
			this.图书表TableAdapter = new 图书销售管理系统.BooksDBDataSetTableAdapters.图书表TableAdapter();
			this.图书表BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.cb_vr = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.图书表BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.图书表BindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_ids
			// 
			this.btn_ids.Font = new System.Drawing.Font("迷你简稚艺", 30F);
			this.btn_ids.Location = new System.Drawing.Point(0, 12);
			this.btn_ids.Name = "btn_ids";
			this.btn_ids.Size = new System.Drawing.Size(583, 266);
			this.btn_ids.TabIndex = 0;
			this.btn_ids.Text = "书号查询";
			this.btn_ids.UseVisualStyleBackColor = true;
			this.btn_ids.Click += new System.EventHandler(this.button1_Click);
			// 
			// btn_names
			// 
			this.btn_names.Font = new System.Drawing.Font("迷你简稚艺", 30F);
			this.btn_names.Location = new System.Drawing.Point(0, 273);
			this.btn_names.Name = "btn_names";
			this.btn_names.Size = new System.Drawing.Size(583, 299);
			this.btn_names.TabIndex = 2;
			this.btn_names.Text = "书名查询";
			this.btn_names.UseVisualStyleBackColor = true;
			this.btn_names.Click += new System.EventHandler(this.button3_Click);
			// 
			// btn_types
			// 
			this.btn_types.Font = new System.Drawing.Font("迷你简稚艺", 20F);
			this.btn_types.Location = new System.Drawing.Point(579, 363);
			this.btn_types.Name = "btn_types";
			this.btn_types.Size = new System.Drawing.Size(337, 209);
			this.btn_types.TabIndex = 6;
			this.btn_types.Text = "类型查询";
			this.btn_types.UseVisualStyleBackColor = true;
			this.btn_types.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// tb_name
			// 
			this.tb_name.Location = new System.Drawing.Point(721, 78);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(150, 25);
			this.tb_name.TabIndex = 7;
			// 
			// tb_publish
			// 
			this.tb_publish.Location = new System.Drawing.Point(721, 208);
			this.tb_publish.Name = "tb_publish";
			this.tb_publish.Size = new System.Drawing.Size(150, 25);
			this.tb_publish.TabIndex = 8;
			this.tb_publish.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// tb_author
			// 
			this.tb_author.Location = new System.Drawing.Point(721, 145);
			this.tb_author.Name = "tb_author";
			this.tb_author.Size = new System.Drawing.Size(150, 25);
			this.tb_author.TabIndex = 9;
			// 
			// tb_id
			// 
			this.tb_id.Location = new System.Drawing.Point(721, 19);
			this.tb_id.Name = "tb_id";
			this.tb_id.Size = new System.Drawing.Size(150, 25);
			this.tb_id.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(659, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 15);
			this.label1.TabIndex = 11;
			this.label1.Text = "书号：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(659, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "书名：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(659, 148);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 15);
			this.label3.TabIndex = 13;
			this.label3.Text = "作者：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.label4.Location = new System.Drawing.Point(659, 208);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 15);
			this.label4.TabIndex = 14;
			this.label4.Text = "出版社:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(660, 276);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 15);
			this.label5.TabIndex = 16;
			this.label5.Text = "类别：";
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
			this.tb_type.Location = new System.Drawing.Point(721, 273);
			this.tb_type.Name = "tb_type";
			this.tb_type.Size = new System.Drawing.Size(150, 23);
			this.tb_type.TabIndex = 23;
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
			// 图书表BindingSource1
			// 
			this.图书表BindingSource1.DataMember = "图书表";
			this.图书表BindingSource1.DataSource = this.booksDBDataSet;
			// 
			// cb_vr
			// 
			this.cb_vr.AutoSize = true;
			this.cb_vr.Font = new System.Drawing.Font("宋体", 20F);
			this.cb_vr.Location = new System.Drawing.Point(332, 522);
			this.cb_vr.Name = "cb_vr";
			this.cb_vr.Size = new System.Drawing.Size(241, 38);
			this.cb_vr.TabIndex = 24;
			this.cb_vr.Text = "启用模糊查询";
			this.cb_vr.UseVisualStyleBackColor = true;
			// 
			// 查询模块
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(919, 572);
			this.Controls.Add(this.cb_vr);
			this.Controls.Add(this.tb_type);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_id);
			this.Controls.Add(this.tb_author);
			this.Controls.Add(this.tb_publish);
			this.Controls.Add(this.tb_name);
			this.Controls.Add(this.btn_types);
			this.Controls.Add(this.btn_names);
			this.Controls.Add(this.btn_ids);
			this.Name = "查询模块";
			this.Text = "查询模块";
			this.Load += new System.EventHandler(this.查询模块_Load);
			((System.ComponentModel.ISupportInitialize)(this.图书表BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.图书表BindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_ids;
		private System.Windows.Forms.Button btn_names;
		private System.Windows.Forms.Button btn_types;
		private System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.TextBox tb_publish;
		private System.Windows.Forms.TextBox tb_author;
		private System.Windows.Forms.TextBox tb_id;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private BooksDBDataSet booksDBDataSet;
		private System.Windows.Forms.BindingSource 图书表BindingSource;
		private BooksDBDataSetTableAdapters.图书表TableAdapter 图书表TableAdapter;
		private System.Windows.Forms.ComboBox tb_type;
		private System.Windows.Forms.BindingSource 图书表BindingSource1;
		private System.Windows.Forms.CheckBox cb_vr;
	}
}