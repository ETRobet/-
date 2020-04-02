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
	public partial class 销售报表 : Form
	{
		public 销售报表()
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
				SqlTransaction sqlTransaction = conn.BeginTransaction();
				sqlCommand.Transaction = sqlTransaction;
				try
				{
					sqlCommand.CommandText = "update 订单表 set 书号=@bid,销售时间=@data,账户类型=@type,单价=@money,数量=@num where 订单编号=@id and 用户名=@name";
					sqlCommand.CommandTimeout = 60;
					SqlParameter sqlParameter1 = new SqlParameter("@id", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter2 = new SqlParameter("@name", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter3 = new SqlParameter("@bid", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter4 = new SqlParameter("@data", SqlDbType.Int, 10);
					SqlParameter sqlParameter5 = new SqlParameter("@type", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter6 = new SqlParameter("@money", SqlDbType.Int, 10);
					SqlParameter sqlParameter7 = new SqlParameter("@num", SqlDbType.Int, 10);
					sqlParameter1.Value = tb_sid.Text;
					sqlParameter2.Value = tb_account.Text;
					sqlParameter3.Value = tb_bid.Text;
					sqlParameter4.Value = tb_data.Text;
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

		private void 销售报表_Load(object sender, EventArgs e)
		{
			//// TODO: 这行代码将数据加载到表“booksDBDataSet.订单表”中。您可以根据需要移动或删除它。
			//this.订单表TableAdapter.Fill(this.booksDBDataSet.订单表);

		}

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.订单表TableAdapter.FillBy(this.booksDBDataSet.订单表);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void tb_id_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{


		}

		private void button1_Click_1(object sender, EventArgs e)
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
					SqlParameter sqlParameter4 = new SqlParameter("@data", SqlDbType.Int, 10);
					SqlParameter sqlParameter5 = new SqlParameter("@type", SqlDbType.NVarChar, 50);
					SqlParameter sqlParameter6 = new SqlParameter("@money", SqlDbType.Int, 10);
					SqlParameter sqlParameter7 = new SqlParameter("@num", SqlDbType.Int, 10);
					sqlParameter1.Value = tb_data.Text+ tb_bid.Text+tb_account.Text;
					sqlParameter2.Value = tb_account.Text;
					sqlParameter3.Value = tb_bid.Text;
					sqlParameter4.Value = tb_data.Text;
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
								sssqlParameter1.Value =tb_bid.Text;
								sssqlParameter7.Value = nnum-tb_num.Value;
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
					MessageBox.Show("用户不存在！");
				}
				else
				{
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
					StringBuilder stringBuilder = new StringBuilder();
					while (sqlDataReader.Read())
					{
						stringBuilder.AppendLine(sqlDataReader[2].ToString());
					}

					tb_type.Text=stringBuilder.ToString();
					sqlCommand.Parameters.Clear();
					sqlDataReader.Close();
				}

			}

		}

		private void tb_sid_Click(object sender, EventArgs e)
		{
			tb_sid.Text =tb_data.Text+tb_bid.Text+tb_account.Text;
		}

		private void btn_create_Click(object sender, EventArgs e)
		{
			if ((tb_start.Text.Length == tb_end.Text.Length)||(tb_start.Text.CompareTo(tb_end.Text)<=0))
			{
				if (rb_day.Checked == true) { }


				if (rb_month.Checked == true) { }



				if (rb_year.Checked == true)
				{

					string st = tb_start.Text + "01010000";
                    DateTime StartTime = DateTime.ParseExact(st, "yyyyMMddHHmm", null);
					string en = tb_end.Text + "01010000";
					DateTime EndTime = DateTime.ParseExact(en, "yyyyMMddHHmm", null);









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
			else
			{
				MessageBox.Show("日期初始化错误！");
			}
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			//if (rb_day.Checked == true)
			//{
			//	日销售表 day = new 日销售表();
			//	day.Show();
			//}
			//if (rb_month.Checked == true)
			//{
			//	月销售表 month = new 月销售表();
			//	month.Show();
			//}
			//if (rb_year.Checked == true)
			//{
			//	年销售表 year = new 年销售表();
			//	year.Show();
			//}
			//if(cb_day.Checked != true&&cb_month.Checked != true&&cb_year.Checked != true)
			//{ MessageBox.Show("请选择报表类型！"); }

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

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void btn_fresh_Click(object sender, EventArgs e)
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

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void label13_Click(object sender, EventArgs e)
		{

		}
	}

		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
