using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图书销售管理系统
{
	public partial class 登陆界面 : Form
	{
		public 登陆界面()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(SqlConStr))
			{
				conn.Open();
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = conn;
				sqlCommand.CommandText = "Select 书名 from 图书表";
				sqlCommand.CommandTimeout = 60;
				SqlParameter sqlParameter = new SqlParameter("@id", SqlDbType.NVarChar, 50);
				sqlParameter.Value = 1;
				sqlParameter.Direction = ParameterDirection.Input;
				var res = sqlCommand.ExecuteScalar();
				MessageBox.Show(res.ToString());

			}
			//SqlConnection sqlConnection = new SqlConnection(SqlConStr);
			//string SqlComStr = "select 书名 from 图书表";
			//SqlCommand sqlCommand = new SqlCommand(SqlComStr,sqlConnection);
			//sqlCommand.CommandText = "select 书名 from 图书表";
			//sqlConnection.Open();
			//var res = sqlCommand.ExecuteScalar();
			//MessageBox.Show(res.ToString());
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			var account = tb_account.Text;
			var password = tb_password.Text;
			string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(SqlConStr))
			{
				conn.Open();
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = conn;
				sqlCommand.CommandText = "Select * from 账户表 where 用户名=@id and 密码=@pwd";
				sqlCommand.CommandTimeout = 60;
				SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
				SqlParameter sqlParameter2 = new SqlParameter("@pwd", SqlDbType.NVarChar, 50);
				sqlParameter1.Value = account;
				sqlParameter2.Value = password;
				sqlParameter1.Direction = ParameterDirection.Input;
				sqlParameter2.Direction = ParameterDirection.Input;
				sqlCommand.Parameters.Add(sqlParameter1);
				sqlCommand.Parameters.Add(sqlParameter2);
				var res = sqlCommand.ExecuteScalar();
	
				if (res == null || res == DBNull.Value)
					{
					MessageBox.Show("用户不存在或密码错误！");
				}
				else
					 {
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
					StringBuilder stringBuilder = new StringBuilder();
					while (sqlDataReader.Read())
					{
						stringBuilder.AppendLine(sqlDataReader[2].ToString());
					}
		
					共享数据.ACC = tb_account.Text;
					共享数据.PWD = tb_password.Text;
					if (共享数据.ACC=="1001001")
					{
						共享数据.POWER = true;
					}

					MessageBox.Show("欢迎您！  " + stringBuilder.ToString());
					sqlCommand.Parameters.Clear();
					sqlDataReader.Close();
					this.DialogResult = DialogResult.OK;
					this.Close();
					 }

			}

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void btn_zhuce_Click(object sender, EventArgs e)
		{
			注册界面 form = new 注册界面();
			form.ShowDialog();
		
		}

		private void 登陆界面_Load(object sender, EventArgs e)
		{
		}
	}
}
