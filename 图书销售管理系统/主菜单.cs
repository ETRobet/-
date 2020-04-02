using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书销售管理系统
{
	
	public partial class bt_about : Form
	{
		public bt_about()
		{
			InitializeComponent();
		}
		private void 主菜单_Load(object sender, EventArgs e)
		{

		}

		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			销售分析 sale = new 销售分析();
			sale.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			查询模块 se = new 查询模块();
			se.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			会员系统 vip = new 会员系统();
			vip.Show();
		}

		private void bt_update_Click(object sender, EventArgs e)
		{
			更新模块 update = new 更新模块();
			update.Show();
		}

		private void 管理员模式ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (共享数据.POWER != true)
			{ MessageBox.Show("请登录管理员账户！"); 登陆界面 login = new 登陆界面(); login.ShowDialog(); }
			else
			{ MessageBox.Show("当前登陆账户已拥有管理员权限！"); }
		
		}
	}
}
