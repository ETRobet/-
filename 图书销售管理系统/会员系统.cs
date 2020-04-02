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
	public partial class 会员系统 : Form
	{
		public 会员系统()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void 会员系统_Load(object sender, EventArgs e)
		{
			// TODO: 这行代码将数据加载到表“booksDBDataSet.账户表”中。您可以根据需要移动或删除它。
			this.账户表TableAdapter.Fill(this.booksDBDataSet.账户表);
			lb_nowacc.Text = 共享数据.ACC;
		}



		private void btn_update_Click(object sender, EventArgs e)
		{
			if (共享数据.POWER == true)

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
						sqlCommand.CommandText = "update 账户表 set 会员积分=@num where 用户名=@id";
						sqlCommand.CommandTimeout = 60;
						SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.VarChar, 50);
						SqlParameter sqlParameter7 = new SqlParameter("@num", SqlDbType.Int, 10);
						sqlParameter1.Value = tb_ID.Text;
						sqlParameter7.Value = tb_NUM.Value;
						sqlParameter1.Direction = ParameterDirection.Input;
						sqlParameter7.Direction = ParameterDirection.Input;
						sqlCommand.Parameters.Add(sqlParameter1);
						sqlCommand.Parameters.Add(sqlParameter7);
						var res = sqlCommand.ExecuteNonQuery();
						sqlTransaction.Commit();
						MessageBox.Show(res.ToString());
						sqlCommand.Parameters.Clear();
						sqlTransaction.Commit();
					}
					catch
					{
					}

				}
			}
			else
			{ MessageBox.Show("您无权修改！"); }
		}

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
			//try
			//{
			//	this.账户表TableAdapter.FillBy(this.booksDBDataSet.账户表, idtool_search.Text);
			//}
			//catch (System.Exception ex)
			//{
			//	System.Windows.Forms.MessageBox.Show(ex.Message);
			//}

		}

		private void idToolStripTextBox_Click(object sender, EventArgs e)
		{
			
		}

		private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
		{

		}

		private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btn_search_Click_1(object sender, EventArgs e)
		{

			{
				string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
				using (SqlConnection conn = new SqlConnection(SqlConStr))
				{
					conn.Open();
					SqlCommand sqlCommand = new SqlCommand();
					sqlCommand.Connection = conn;
					sqlCommand.CommandText = "Select * from 账户表 where 用户名=@id";
					sqlCommand.CommandTimeout = 60;
					SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
					sqlParameter1.Value = 共享数据.ACC;
					sqlParameter1.Direction = ParameterDirection.Input;
					sqlCommand.Parameters.Add(sqlParameter1);
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
					StringBuilder stringBuilder = new StringBuilder();
					while (sqlDataReader.Read())
					{
						stringBuilder.AppendLine("用户名："+sqlDataReader[0] + "密码：" + sqlDataReader[1] + "账户类型：" + sqlDataReader[2] + "会员积分：" + sqlDataReader[3]);
					}
					sqlCommand.Parameters.Clear();
					sqlDataReader.Close();
					MessageBox.Show(stringBuilder.ToString());

				}
			}
		}

		private void btn_delete_Click(object sender, EventArgs e)
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
					sqlCommand.CommandText = "delete from 账户表 where 用户名=@id";
					sqlCommand.CommandTimeout = 60;
					SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.VarChar, 50);
					sqlParameter1.Value = 共享数据.ACC;
					sqlParameter1.Direction = ParameterDirection.Input;
					sqlCommand.Parameters.Add(sqlParameter1);
					var res = sqlCommand.ExecuteNonQuery();
					sqlTransaction.Commit();
					MessageBox.Show(res.ToString());
					sqlCommand.Parameters.Clear();
					sqlTransaction.Commit();
				}
				catch
				{

				}

			}
			Application.Exit();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_updatepwd_Click(object sender, EventArgs e)
		{
			var pwd = tb_password.Text;
			var copypwd = tb_copypwd.Text;
			if (pwd != copypwd)
			{
				MessageBox.Show("密码输入不一致！");
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
						sqlCommand.CommandText = "update 账户表 set 密码=@pwd where 用户名=@id";
						sqlCommand.CommandTimeout = 60;
						SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
						SqlParameter sqlParameter2 = new SqlParameter("@pwd", SqlDbType.NVarChar, 50);
						sqlParameter1.Value = 共享数据.ACC;
						sqlParameter2.Value = tb_password.Text;
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

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void btn_show_Click(object sender, EventArgs e)
		{
			string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(SqlConStr))
			{
				conn.Open();
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = conn;
				sqlCommand.CommandText = "Select 会员积分 from 账户表 where 用户名=@id";
				sqlCommand.CommandTimeout = 60;
				SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
				sqlParameter1.Value = tb_ID.Text;
				sqlParameter1.Direction = ParameterDirection.Input;
				sqlCommand.Parameters.Add(sqlParameter1);
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
				int x=0;
				while (sqlDataReader.Read())
				{
					x=(int)sqlDataReader[0];
				}
				sqlCommand.Parameters.Clear();
				sqlDataReader.Close();
				tb_NUM.Value = x;

			}
		}
	}
}
