using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书销售管理系统
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			登陆界面 login = new 登陆界面();
			if (login.ShowDialog()==DialogResult.OK)
			{Application.Run(new bt_about());}
			else
			{ return; }
		}
	}
}
