using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书销售管理系统
{
	public partial class 注册界面 : Form
	{
		public 注册界面()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			var account = tb_account.Text;
			var pwd = tb_password.Text;
			var copypwd = tb_copypwd.Text;
			if (cb_agree.Checked == true)
			{
				if (pwd != copypwd&&account!=null)
				{
					MessageBox.Show("用户名为空或密码输入不一致！");
				}
				else
				{
					string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
					using (SqlConnection conn = new SqlConnection(SqlConStr))
					{
						conn.Open();
						SqlCommand sqlCommand = new SqlCommand();
						sqlCommand.Connection = conn;
						SqlTransaction sqlTransaction = conn.BeginTransaction();
						sqlCommand.Transaction = sqlTransaction;
						try
						{
							sqlCommand.CommandText = "insert into 账户表(用户名,密码) values(@id,@pwd)";
							sqlCommand.CommandTimeout = 60;
							SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
							SqlParameter sqlParameter2 = new SqlParameter("@pwd", SqlDbType.NVarChar, 50);
							sqlParameter1.Value = account;
							sqlParameter2.Value = pwd;
							sqlParameter1.Direction = ParameterDirection.Input;
							sqlParameter2.Direction = ParameterDirection.Input;
							sqlCommand.Parameters.Add(sqlParameter1);
							sqlCommand.Parameters.Add(sqlParameter2);
							var res = sqlCommand.ExecuteNonQuery();
							sqlTransaction.Commit();
							MessageBox.Show(res.ToString());
							this.Close();
						}
						catch
						{

						}

					}

				}
			}
			else
			{ MessageBox.Show("请同意服务条款！"); }
			
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("F:\\【荒野】工作间\\代号：20 VS\\图书销售管理系统\\服务协议.txt");
		}
	}
}
