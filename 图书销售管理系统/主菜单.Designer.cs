namespace 图书销售管理系统
{
	partial class bt_about
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bt_about));
			this.bt_search = new System.Windows.Forms.Button();
			this.bt_update = new System.Windows.Forms.Button();
			this.bt_vip = new System.Windows.Forms.Button();
			this.bt_sale = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.管理员模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bt_search
			// 
			this.bt_search.Font = new System.Drawing.Font("迷你简稚艺", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.bt_search.Location = new System.Drawing.Point(12, 82);
			this.bt_search.Name = "bt_search";
			this.bt_search.Size = new System.Drawing.Size(459, 453);
			this.bt_search.TabIndex = 0;
			this.bt_search.Text = "查询模块";
			this.bt_search.UseVisualStyleBackColor = true;
			this.bt_search.Click += new System.EventHandler(this.button1_Click);
			// 
			// bt_update
			// 
			this.bt_update.Font = new System.Drawing.Font("迷你简稚艺", 24F);
			this.bt_update.Location = new System.Drawing.Point(477, 82);
			this.bt_update.Name = "bt_update";
			this.bt_update.Size = new System.Drawing.Size(399, 247);
			this.bt_update.TabIndex = 1;
			this.bt_update.Text = "更新模块";
			this.bt_update.UseVisualStyleBackColor = true;
			this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
			// 
			// bt_vip
			// 
			this.bt_vip.Font = new System.Drawing.Font("迷你简稚艺", 24F);
			this.bt_vip.Location = new System.Drawing.Point(12, 541);
			this.bt_vip.Name = "bt_vip";
			this.bt_vip.Size = new System.Drawing.Size(459, 207);
			this.bt_vip.TabIndex = 2;
			this.bt_vip.Text = "会员系统";
			this.bt_vip.UseVisualStyleBackColor = true;
			this.bt_vip.Click += new System.EventHandler(this.button3_Click);
			// 
			// bt_sale
			// 
			this.bt_sale.Font = new System.Drawing.Font("迷你简稚艺", 24F);
			this.bt_sale.Location = new System.Drawing.Point(477, 335);
			this.bt_sale.Name = "bt_sale";
			this.bt_sale.Size = new System.Drawing.Size(399, 413);
			this.bt_sale.TabIndex = 3;
			this.bt_sale.Text = "销售报表";
			this.bt_sale.UseVisualStyleBackColor = true;
			this.bt_sale.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("迷你简稚艺", 16F);
			this.button5.Location = new System.Drawing.Point(1152, 676);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(163, 79);
			this.button5.TabIndex = 4;
			this.button5.Text = "关于软件";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理员模式ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1327, 28);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 管理员模式ToolStripMenuItem
			// 
			this.管理员模式ToolStripMenuItem.Name = "管理员模式ToolStripMenuItem";
			this.管理员模式ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
			this.管理员模式ToolStripMenuItem.Text = "管理员模式";
			this.管理员模式ToolStripMenuItem.Click += new System.EventHandler(this.管理员模式ToolStripMenuItem_Click);
			// 
			// bt_about
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1327, 767);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.bt_sale);
			this.Controls.Add(this.bt_vip);
			this.Controls.Add(this.bt_update);
			this.Controls.Add(this.bt_search);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "bt_about";
			this.Text = "主菜单";
			this.Load += new System.EventHandler(this.主菜单_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bt_search;
		private System.Windows.Forms.Button bt_update;
		private System.Windows.Forms.Button bt_vip;
		private System.Windows.Forms.Button bt_sale;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 管理员模式ToolStripMenuItem;
	}
}