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
	public partial class 销售分析 : Form
	{
		public 销售分析()
		{
			InitializeComponent();
		}

		private void btn_search_Click(object sender, EventArgs e)
		{

			{
				string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
				using (SqlConnection conn = new SqlConnection(SqlConStr))
				{
					conn.Open();
					SqlCommand sqlCommand = new SqlCommand();
					sqlCommand.Connection = conn;
					sqlCommand.CommandText = "Select * from 订单表 where 订单编号=@id and 用户名=@name";
					sqlCommand.CommandTimeout = 60;
					SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter2 = new SqlParameter("@name", SqlDbType.NVarChar, 50);
					sqlParameter1.Value = tb_sid.Text;
					sqlParameter2.Value = tb_account.Text;
					sqlParameter1.Direction = ParameterDirection.Input;
					sqlParameter2.Direction = ParameterDirection.Input;
					sqlCommand.Parameters.Add(sqlParameter1);
					sqlCommand.Parameters.Add(sqlParameter2);
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
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void tb_data_TextChanged(object sender, EventArgs e)
		{
			try
			{
				DateTime dateTime = DateTime.ParseExact(tb_data.Text.ToString(), "yyyyMMddHHmm", null);
				label8.Text = dateTime.ToString();
			}
			catch
			{
				label8.Text = "格式错误";
			}
		}

		private void tb_type_Click(object sender, EventArgs e)
		{
			var account = tb_account.Text;
			string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(SqlConStr))
			{
				conn.Open();
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = conn;
				sqlCommand.CommandText = "Select * from 账户表 where 用户名=@id";
				sqlCommand.CommandTimeout = 60;
				SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
				sqlParameter1.Value = account;
				sqlParameter1.Direction = ParameterDirection.Input;
				sqlCommand.Parameters.Add(sqlParameter1);
				var res = sqlCommand.ExecuteScalar();
				if (res == null || res == DBNull.Value)
				{
					MessageBox.Show("用户不是会员！");
					tb_type.Text =null;
				}
				else
				{
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
					StringBuilder stringBuilder = new StringBuilder();
					while (sqlDataReader.Read())
					{
						stringBuilder.AppendLine(sqlDataReader[3].ToString());
					}

					tb_type.Text = stringBuilder.ToString();
					sqlCommand.Parameters.Clear();
					sqlDataReader.Close();
				}

			}

		}

		private void tb_type_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_update_Click(object sender, EventArgs e)
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
					sqlCommand.CommandText = "update 订单表 set 书号=@bid,销售时间=@data,账户类型=@type,单价=@money,数量=@num where 订单编号=@id and 用户名=@name";
					sqlCommand.CommandTimeout = 60;
					SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter2 = new SqlParameter("@name", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter3 = new SqlParameter("@bid", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter4 = new SqlParameter("@data", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter5 = new SqlParameter("@type", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter6 = new SqlParameter("@money", SqlDbType.Int, 10);
					SqlParameter sqlParameter7 = new SqlParameter("@num", SqlDbType.Int, 10);
					sqlParameter1.Value = tb_sid.Text;
					sqlParameter2.Value = tb_account.Text;
					sqlParameter3.Value = tb_bid.Text;
					sqlParameter4.Value = tb_data.Text;
					sqlParameter5.Value = tb_type.Text;
					sqlParameter6.Value = int.Parse(lb_realmoney.Text);
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

				int nnum = 0;
				string SSqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
				using (SqlConnection cconn = new SqlConnection(SSqlConStr))
				{
					cconn.Open();
					SqlCommand ssqlCommand = new SqlCommand();
					ssqlCommand.Connection = cconn;
					ssqlCommand.CommandText = "Select * from 图书表 where 书号=@id";
					ssqlCommand.CommandTimeout = 60;
					SqlParameter ssqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
					ssqlParameter1.Value = tb_bid.Text;
					ssqlParameter1.Direction = ParameterDirection.Input;
					ssqlCommand.Parameters.Add(ssqlParameter1);
					SqlDataReader ssqlDataReader = ssqlCommand.ExecuteReader(CommandBehavior.CloseConnection);


					while (ssqlDataReader.Read())
					{
						nnum = (int)ssqlDataReader[4];
					}
					ssqlCommand.Parameters.Clear();
					ssqlDataReader.Close();

				}

				string SssqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
				using (SqlConnection ccconn = new SqlConnection(SssqlConStr))
				{
					ccconn.Open();
					SqlCommand sssqlCommand = new SqlCommand();
					sssqlCommand.Connection = ccconn;
					SqlTransaction sssqlTransaction = ccconn.BeginTransaction();
					sssqlCommand.Transaction = sssqlTransaction;
					try
					{
						sssqlCommand.CommandText = "update 图书表 set 数量=@num where 书号=@id";
						sssqlCommand.CommandTimeout = 60;
						SqlParameter sssqlParameter1 = new SqlParameter("@id", SqlDbType.VarChar, 50);
						SqlParameter sssqlParameter7 = new SqlParameter("@num", SqlDbType.Int, 10);
						sssqlParameter1.Value = tb_bid.Text;
						sssqlParameter7.Value = nnum - tb_num.Value;
						sssqlParameter1.Direction = ParameterDirection.Input;
						sssqlParameter7.Direction = ParameterDirection.Input;
						sssqlCommand.Parameters.Add(sssqlParameter1);
						sssqlCommand.Parameters.Add(sssqlParameter7);
						var res = sssqlCommand.ExecuteNonQuery();
						sssqlTransaction.Commit();
						MessageBox.Show(res.ToString());
						sssqlCommand.Parameters.Clear();
						sssqlTransaction.Commit();
					}
					catch
					{
					}

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
					sqlCommand.CommandText = "delete from 订单表 where 订单编号=@id and 用户名=@name";
					sqlCommand.CommandTimeout = 60;
					SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter2 = new SqlParameter("@name", SqlDbType.NVarChar, 50);
					sqlParameter1.Value = tb_sid.Text;
					sqlParameter2.Value = tb_account.Text;
					sqlParameter1.Direction = ParameterDirection.Input;
					sqlParameter2.Direction = ParameterDirection.Input;
					sqlCommand.Parameters.Add(sqlParameter1);
					sqlCommand.Parameters.Add(sqlParameter2);
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

		private void btn_add_Click(object sender, EventArgs e)
		{

			if (tb_sid.Text == "点击自动创建编号")
			{ MessageBox.Show("未生成编号"); }
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
						sqlCommand.CommandText = "insert into 订单表 values(@id,@bid,@num,@data,@money,@name,@type)";
						sqlCommand.CommandTimeout = 60;
						SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
						SqlParameter sqlParameter2 = new SqlParameter("@name", SqlDbType.NVarChar, 50);
						SqlParameter sqlParameter3 = new SqlParameter("@bid", SqlDbType.NVarChar, 50);
						SqlParameter sqlParameter4 = new SqlParameter("@data", SqlDbType.NVarChar, 50);
						SqlParameter sqlParameter5 = new SqlParameter("@type", SqlDbType.NVarChar, 50);
						SqlParameter sqlParameter6 = new SqlParameter("@money", SqlDbType.Int, 10);
						SqlParameter sqlParameter7 = new SqlParameter("@num", SqlDbType.Int, 10);
						sqlParameter1.Value = tb_data.Text + tb_bid.Text + tb_account.Text;
						sqlParameter2.Value = tb_account.Text;
						sqlParameter3.Value = tb_bid.Text;
						sqlParameter4.Value = tb_data.Text;
						sqlParameter5.Value = tb_type.Text;
						//int flag ;
						//int realmoney;
						//if (int.TryParse(lb_realmoney.Text.ToString(), out flag))
						///*MessageBox.Show(lb_realmoney.Text)*/
						//{ }
						//else
						//{
						//	MessageBox.Show("类型转换错误！");
						//}
						sqlParameter6.Value = num_realmoney.Value;//记得学会用decimal！！！！
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
						//sqlTransaction.Commit();
						//MessageBox.Show(res.ToString());
						sqlCommand.Parameters.Clear();
						sqlTransaction.Commit();




					}
					catch
					{
					}
					int nnum = 0;
					string SSqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
					using (SqlConnection cconn = new SqlConnection(SSqlConStr))
					{
						cconn.Open();
						SqlCommand ssqlCommand = new SqlCommand();
						ssqlCommand.Connection = cconn;
						ssqlCommand.CommandText = "Select * from 图书表 where 书号=@id";
						ssqlCommand.CommandTimeout = 60;
						SqlParameter ssqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
						ssqlParameter1.Value = tb_bid.Text;
						ssqlParameter1.Direction = ParameterDirection.Input;
						ssqlCommand.Parameters.Add(ssqlParameter1);
						SqlDataReader ssqlDataReader = ssqlCommand.ExecuteReader(CommandBehavior.CloseConnection);


						while (ssqlDataReader.Read())
						{
							nnum = (int)ssqlDataReader[4];
						}
						ssqlCommand.Parameters.Clear();
						ssqlDataReader.Close();

					}

					string SssqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
					using (SqlConnection ccconn = new SqlConnection(SssqlConStr))
					{
						ccconn.Open();
						SqlCommand sssqlCommand = new SqlCommand();
						sssqlCommand.Connection = ccconn;
						SqlTransaction sssqlTransaction = ccconn.BeginTransaction();
						sssqlCommand.Transaction = sssqlTransaction;
						try
						{
							sssqlCommand.CommandText = "update 图书表 set 数量=@num where 书号=@id";
							sssqlCommand.CommandTimeout = 60;
							SqlParameter sssqlParameter1 = new SqlParameter("@id", SqlDbType.VarChar, 50);
							SqlParameter sssqlParameter7 = new SqlParameter("@num", SqlDbType.Int, 10);
							sssqlParameter1.Value = tb_bid.Text;
							sssqlParameter7.Value = nnum - tb_num.Value;
							sssqlParameter1.Direction = ParameterDirection.Input;
							sssqlParameter7.Direction = ParameterDirection.Input;
							sssqlCommand.Parameters.Add(sssqlParameter1);
							sssqlCommand.Parameters.Add(sssqlParameter7);
							var res = sssqlCommand.ExecuteNonQuery();
							sssqlTransaction.Commit();
							//MessageBox.Show(res.ToString());
							sssqlCommand.Parameters.Clear();
							sssqlTransaction.Commit();
						}
						catch
						{
						}

					}




				}















			}
		}

		private void tb_sid_Click(object sender, EventArgs e)
		{
			tb_sid.Text = tb_data.Text + tb_bid.Text + tb_account.Text;
		}

		private void button1_Click(object sender, EventArgs e)
		{

			string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(SqlConStr))
			{
				conn.Open();
				DataSet dataSet = new DataSet();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from 销售表", conn);
				sqlDataAdapter.Fill(dataSet, "SALES");
				DataTable dataTable = dataSet.Tables[0];
				DataSet dataSet1 = new DataSet();
				SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("select * from 订单表", conn);
				sqlDataAdapter1.Fill(dataSet1, "sales");
				DataTable dataTable1 = dataSet1.Tables[0];

				//生成暂时表
				for (int i = 0; i < dataTable1.Rows.Count; i++)
				{
					DataRow dr = dataTable1.Rows[i];
					DataRow newdr = dataTable.NewRow();
					newdr["订单编号"] = dr["订单编号"];

					string str = dr["销售时间"].ToString();
					string newstr = str.Substring(0, 4) + "-" + str.Substring(4, 2) + "-" + str.Substring(6, 2) + " " + str.Substring(8, 2) + ":" + str.Substring(10, 2);
					DateTime time;
					if (!DateTime.TryParse(newstr, out time))
						MessageBox.Show("字符串不正确。");



					newdr["时间"] = time;
					newdr["毛利"] = (int)dr["单价"] * (int)dr["销售数量"];
					dataTable.Rows.Add(newdr);

				}
				//this.dataGridView1.DataSource = dataTable;





				//替换销售表
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{

					SqlCommand sqlCommand = new SqlCommand();
					sqlCommand.Connection = conn;
					//SqlTransaction sqlTransaction = conn.BeginTransaction();
					//sqlCommand.Transaction = sqlTransaction;
					try
					{
						sqlCommand.CommandText = "insert into 销售表 values(@id,@time,@money)";
						sqlCommand.CommandTimeout = 60;
						SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
						SqlParameter sqlParameter6 = new SqlParameter("@money", SqlDbType.Int, 10);
						SqlParameter sqlParameter7 = new SqlParameter("@time", SqlDbType.DateTime);
						sqlParameter1.Value = dataTable.Rows[i]["订单编号"];
						sqlParameter6.Value = dataTable.Rows[i]["毛利"];
						sqlParameter7.Value = dataTable.Rows[i]["时间"];
						sqlParameter1.Direction = ParameterDirection.Input;
						sqlParameter6.Direction = ParameterDirection.Input;
						sqlParameter7.Direction = ParameterDirection.Input;
						sqlCommand.Parameters.Add(sqlParameter1);
						sqlCommand.Parameters.Add(sqlParameter6);
						sqlCommand.Parameters.Add(sqlParameter7);

						var res = sqlCommand.ExecuteNonQuery();
						//sqlTransaction.Commit();
						sqlCommand.Parameters.Clear();

					}
					catch
					{
					}

				}































































			}
		}

		private void btn_ssea_Click(object sender, EventArgs e)
		{
			string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(SqlConStr))
			{
				conn.Open();
				DataSet dataSet = new DataSet();
				string sql = "select * from 销售表" + " where 时间<"+"'" + dtp_end.Value.ToString() +"'"+ " and 时间 >" + "'"+dtp_start.Value.ToString()+"'";
				//MessageBox.Show(sql);
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, conn);
				sqlDataAdapter.Fill(dataSet, "销售");
				DataTable dataTable = dataSet.Tables[0];
				this.dataGridView1.DataSource = dataTable;

			}
		}

		public decimal vippower(string str)
		{
			decimal res = 0.0M;
			
			switch (int.Parse(str))
			{
				case 100: res = 0.99M; break;
				case 200: res = 0.95M; break;
				case 300: res = 0.90M; break;
				case 400: res = 0.85M; break;
				case 500: res = 0.80M; break;
				case 600: res = 0.75M; break;
				case 700: res = 0.70M; break;
				case 800: res = 0.65M; break;
				case 900: res = 0.60M; break;
				default: res = 1; break;
			}
			return res;
		}
		private void tb_money_ValueChanged(object sender, EventArgs e)
		{
			decimal res = vippower(tb_type.Text) * tb_money.Value;
			MessageBox.Show(vippower(tb_type.Text).ToString());
			lb_realmoney.Text = res.ToString();
			num_realmoney.Value = res;
		}

		private void lb_realmoney_Click(object sender, EventArgs e)
		{

		}
	}
}
