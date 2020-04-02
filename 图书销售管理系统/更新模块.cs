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
	public partial class 更新模块 : Form
	{
		public 更新模块()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void 更新模块_Load(object sender, EventArgs e)
		{
			if (共享数据.POWER != true) { MessageBox.Show("您无权访问！"); this.Close(); }
			//// TODO: 这行代码将数据加载到表“booksDBDataSet.图书表”中。您可以根据需要移动或删除它。
			//this.图书表TableAdapter.Fill(this.booksDBDataSet.图书表);

		}

		private void bt_add_Click(object sender, EventArgs e)
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
					sqlCommand.CommandText = "insert into 图书表 values(@id,@name,@author,@publish,@num,@type,@money)";
					sqlCommand.CommandTimeout = 60;
					SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter2 = new SqlParameter("@name", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter3 = new SqlParameter("@author", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter4 = new SqlParameter("@publish", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter5 = new SqlParameter("@type", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter6 = new SqlParameter("@money", SqlDbType.Int, 10);
					SqlParameter sqlParameter7 = new SqlParameter("@num", SqlDbType.Int, 10);
					sqlParameter1.Value = tb_id.Text;
					sqlParameter2.Value = tb_name.Text;
					sqlParameter3.Value = tb_author.Text;
					sqlParameter4.Value = tb_publish.Text;
					sqlParameter5.Value = tb_type.Text;
					sqlParameter6.Value = tb_money.Value;
					sqlParameter7.Value = tb_num.Value;
					sqlParameter1.Direction = ParameterDirection.Input;
					sqlParameter2.Direction = ParameterDirection.Input;
					sqlParameter3.Direction = ParameterDirection.Input;
					sqlParameter4.Direction = ParameterDirection.Input;
					sqlParameter5.Direction = ParameterDirection.Input;
					sqlParameter6.Direction = ParameterDirection.Input;
					sqlParameter7.Direction = ParameterDirection.Input;
					sqlCommand.Parameters.Add(sqlParameter1);
					sqlCommand.Parameters.Add(sqlParameter2);
					sqlCommand.Parameters.Add(sqlParameter3);
					sqlCommand.Parameters.Add(sqlParameter4);
					sqlCommand.Parameters.Add(sqlParameter5);
					sqlCommand.Parameters.Add(sqlParameter6);
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

		private void bt_delete_Click(object sender, EventArgs e)
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
					sqlCommand.CommandText = "delete from 图书表 where 书号=@id";
					sqlCommand.CommandTimeout = 60;
					SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.VarChar, 50);
					sqlParameter1.Value = tb_id.Text;
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
		}

		private void bt_updata_Click(object sender, EventArgs e)
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
					sqlCommand.CommandText = "update 图书表 set 书名=@name,作者=@author,出版社=@publish,图书类型=@type,单价=@money,数量=@num where 书号=@id";
					sqlCommand.CommandTimeout = 60;
					SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter2 = new SqlParameter("@name", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter3 = new SqlParameter("@author", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter4 = new SqlParameter("@publish", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter5 = new SqlParameter("@type", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter6 = new SqlParameter("@money", SqlDbType.Int, 10);
					SqlParameter sqlParameter7 = new SqlParameter("@num", SqlDbType.Int, 10);
					sqlParameter1.Value = tb_id.Text;
					sqlParameter2.Value = tb_name.Text;
					sqlParameter3.Value = tb_author.Text;
					sqlParameter4.Value = tb_publish.Text;
					sqlParameter5.Value = tb_type.Text;
					sqlParameter6.Value = tb_money.Value;
					sqlParameter7.Value = tb_num.Value;
					sqlParameter1.Direction = ParameterDirection.Input;
					sqlParameter2.Direction = ParameterDirection.Input;
					sqlParameter3.Direction = ParameterDirection.Input;
					sqlParameter4.Direction = ParameterDirection.Input;
					sqlParameter5.Direction = ParameterDirection.Input;
					sqlParameter6.Direction = ParameterDirection.Input;
					sqlParameter7.Direction = ParameterDirection.Input;
					sqlCommand.Parameters.Add(sqlParameter1);
					sqlCommand.Parameters.Add(sqlParameter2);
					sqlCommand.Parameters.Add(sqlParameter3);
					sqlCommand.Parameters.Add(sqlParameter4);
					sqlCommand.Parameters.Add(sqlParameter5);
					sqlCommand.Parameters.Add(sqlParameter6);
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

		private void bt_search_Click(object sender, EventArgs e)
		{
			string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(SqlConStr))
			{
				conn.Open();
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = conn;
				sqlCommand.CommandText = "Select * from 图书表 where 书号=@id";
				sqlCommand.CommandTimeout = 60;
				SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
				sqlParameter1.Value = tb_id.Text;
				sqlParameter1.Direction = ParameterDirection.Input;
				sqlCommand.Parameters.Add(sqlParameter1);
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
				StringBuilder stringBuilder = new StringBuilder();
				while (sqlDataReader.Read())
				{
					stringBuilder.AppendLine(sqlDataReader[0] + " " + sqlDataReader[1] + " " + sqlDataReader[2] + " " + sqlDataReader[3] + " " + sqlDataReader[4] + " " + sqlDataReader[5] + " " + sqlDataReader[6]);
				}
				sqlCommand.Parameters.Clear();
				sqlDataReader.Close();
				MessageBox.Show(stringBuilder.ToString());

			}
		}

		private void tb_name_Click(object sender, EventArgs e)
		{
			string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(SqlConStr))
			{
				conn.Open();
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = conn;
				sqlCommand.CommandText = "Select 书名 from 图书表 where 书号=@id";
				sqlCommand.CommandTimeout = 60;
				SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
				sqlParameter1.Value = tb_id.Text;
				sqlParameter1.Direction = ParameterDirection.Input;
				sqlCommand.Parameters.Add(sqlParameter1);
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
				StringBuilder stringBuilder = new StringBuilder();
				while (sqlDataReader.Read())
				{
					stringBuilder.AppendLine(sqlDataReader[0].ToString());
				}
				sqlCommand.Parameters.Clear();
				sqlDataReader.Close();
				if (stringBuilder.ToString() != null)
				{ tb_name.Text = stringBuilder.ToString(); }


			}
		}

		private void tb_author_TextChanged(object sender, EventArgs e)
		{

		}

		private void tb_publish_TextChanged(object sender, EventArgs e)
		{

		}

		private void tb_type_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void tb_money_ValueChanged(object sender, EventArgs e)
		{

		}

		private void tb_num_ValueChanged(object sender, EventArgs e)
		{

		}

		private void tb_num_Click(object sender, EventArgs e)
		{
			string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(SqlConStr))
			{
				conn.Open();
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = conn;
				sqlCommand.CommandText = "Select 数量 from 图书表 where 书号=@id";
				sqlCommand.CommandTimeout = 60;
				SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
				sqlParameter1.Value = tb_id.Text;
				sqlParameter1.Direction = ParameterDirection.Input;
				sqlCommand.Parameters.Add(sqlParameter1);
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
				StringBuilder stringBuilder = new StringBuilder();
				while (sqlDataReader.Read())
				{
					stringBuilder.AppendLine(sqlDataReader[0].ToString());
				}
				sqlCommand.Parameters.Clear();
				sqlDataReader.Close();
				if (stringBuilder.ToString() != null)
				{ tb_num.Text = stringBuilder.ToString(); }
			}
		}

		private void tb_money_Click(object sender, EventArgs e)
		{
			string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(SqlConStr))
			{
				conn.Open();
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = conn;
				sqlCommand.CommandText = "Select 单价 from 图书表 where 书号=@id";
				sqlCommand.CommandTimeout = 60;
				SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
				sqlParameter1.Value = tb_id.Text;
				sqlParameter1.Direction = ParameterDirection.Input;
				sqlCommand.Parameters.Add(sqlParameter1);
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
				StringBuilder stringBuilder = new StringBuilder();
				while (sqlDataReader.Read())
				{
					stringBuilder.AppendLine(sqlDataReader[0].ToString());
				}
				sqlCommand.Parameters.Clear();
				sqlDataReader.Close();
				if (stringBuilder.ToString() != null)
				{ tb_money.Text = stringBuilder.ToString(); }
			}
		}

		private void tb_type_Click(object sender, EventArgs e)
		{
			string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(SqlConStr))
			{
				conn.Open();
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = conn;
				sqlCommand.CommandText = "Select 图书类型 from 图书表 where 书号=@id";
				sqlCommand.CommandTimeout = 60;
				SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
				sqlParameter1.Value = tb_id.Text;
				sqlParameter1.Direction = ParameterDirection.Input;
				sqlCommand.Parameters.Add(sqlParameter1);
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
				StringBuilder stringBuilder = new StringBuilder();
				while (sqlDataReader.Read())
				{
					stringBuilder.AppendLine(sqlDataReader[0].ToString());
				}
				sqlCommand.Parameters.Clear();
				sqlDataReader.Close();
				if (stringBuilder.ToString() != null)
				{ tb_type.Text = stringBuilder.ToString(); }
			}
		}

		private void tb_publish_Click(object sender, EventArgs e)
		{
			string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(SqlConStr))
			{
				conn.Open();
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = conn;
				sqlCommand.CommandText = "Select 出版社 from 图书表 where 书号=@id";
				sqlCommand.CommandTimeout = 60;
				SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
				sqlParameter1.Value = tb_id.Text;
				sqlParameter1.Direction = ParameterDirection.Input;
				sqlCommand.Parameters.Add(sqlParameter1);
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
				StringBuilder stringBuilder = new StringBuilder();
				while (sqlDataReader.Read())
				{
					stringBuilder.AppendLine(sqlDataReader[0].ToString());
				}
				sqlCommand.Parameters.Clear();
				sqlDataReader.Close();
				if (stringBuilder.ToString() != null)
				{ tb_publish.Text = stringBuilder.ToString(); }
			}
		}

		private void tb_author_Click(object sender, EventArgs e)
		{
			string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(SqlConStr))
			{
				conn.Open();
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = conn;
				sqlCommand.CommandText = "Select 作者 from 图书表 where 书号=@id";
				sqlCommand.CommandTimeout = 60;
				SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
				sqlParameter1.Value = tb_id.Text;
				sqlParameter1.Direction = ParameterDirection.Input;
				sqlCommand.Parameters.Add(sqlParameter1);
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
				StringBuilder stringBuilder = new StringBuilder();
				while (sqlDataReader.Read())
				{
					stringBuilder.AppendLine(sqlDataReader[0].ToString());
				}
				sqlCommand.Parameters.Clear();
				sqlDataReader.Close();
				if (stringBuilder.ToString() != null)
				{ tb_author.Text = stringBuilder.ToString(); }


			}
		}
	}
}