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
	public partial class 查询模块 : Form
	{
		public 查询模块()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
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

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click_1(object sender, EventArgs e)
		{
			string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(SqlConStr))
			{
				conn.Open();
				SqlCommand sqlCommand = new SqlCommand();
				sqlCommand.Connection = conn;
				sqlCommand.CommandText = "Select * from 图书表 where 图书类型=@type";
				sqlCommand.CommandTimeout = 60;
				SqlParameter sqlParameter1 = new SqlParameter("@type", SqlDbType.NVarChar, 50);
				sqlParameter1.Value = tb_type.Text;
				sqlParameter1.Direction = ParameterDirection.Input;
				sqlCommand.Parameters.Add(sqlParameter1);
				SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
				StringBuilder stringBuilder = new StringBuilder();
				while (sqlDataReader.Read())
				{
					stringBuilder.AppendLine(sqlDataReader[0]+" "+sqlDataReader[1]+" "+sqlDataReader[2]+" "+sqlDataReader[3]+" "+sqlDataReader[4]+" "+sqlDataReader[5]+" "+sqlDataReader[6]);
				}
				sqlCommand.Parameters.Clear();
				sqlDataReader.Close();
				MessageBox.Show(stringBuilder.ToString());

			}
		}

		private void 查询模块_Load(object sender, EventArgs e)
		{
			//// TODO: 这行代码将数据加载到表“booksDBDataSet.图书表”中。您可以根据需要移动或删除它。
			//this.图书表TableAdapter.Fill(this.booksDBDataSet.图书表);

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			string SqlConStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BooksDB;Integrated Security=true";
			using (SqlConnection conn = new SqlConnection(SqlConStr))
			{
				if (cb_vr.Checked == true)
				{
					conn.Open();
					SqlCommand sqlCommand = new SqlCommand();
					sqlCommand.Connection = conn;
					sqlCommand.CommandText = "Select * from 图书表 where 书名 like @name";
					sqlCommand.CommandTimeout = 60;
					SqlParameter sqlParameter1 = new SqlParameter("@name", "%" + tb_name.Text + "%");
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
				else
				{
					conn.Open();
					SqlCommand sqlCommand = new SqlCommand();
					sqlCommand.Connection = conn;
					sqlCommand.CommandText = "Select * from 图书表 where 书名=@name";
					sqlCommand.CommandTimeout = 60;
					SqlParameter sqlParameter1 = new SqlParameter("@name",tb_name.Text);
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
		}
	}
}
