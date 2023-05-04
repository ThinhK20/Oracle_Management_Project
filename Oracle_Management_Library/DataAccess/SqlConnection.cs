using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Oracle_Management_Library.DataAccess
{
	internal class SqlConnection : IDataConnection
	{
		private readonly ModelContext db;
		public SqlConnection(ModelContext db)
		{
			this.db = db;
		}
		public DataTable GetSQLQuery(string queryString)
		{
			string connectionString = GlobalConfig.CnnString("OracleConnection");

			using (OracleConnection oracleConnection = new OracleConnection(connectionString))
			{
				try
				{
					OracleCommand command = new OracleCommand(queryString);
					OracleDataAdapter adapter = new OracleDataAdapter();
					command.Connection = oracleConnection;
					command.CommandType = CommandType.Text;
					oracleConnection.Open();

					adapter.SelectCommand = command;
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					return dt;
				}
				catch
				{
					DataTable dt = new DataTable();

					return dt;
				}

			}
		}

		public void ExecuteSQLTextQuery(string queryString)
		{
			string connectionString = GlobalConfig.CnnString("OracleConnection");
			using (OracleConnection oracleConnection = new OracleConnection(connectionString))
			{
				try
				{
					OracleCommand command = new OracleCommand(queryString);
					command.Connection = oracleConnection;
					command.CommandType = CommandType.Text;
					oracleConnection.Open();
					command.ExecuteNonQuery();
				}
				catch
				{

				}
			}
		}

		public void ExecuteStoredProcedure(string queryString, string paramsStr)
		{
			string connectionString = GlobalConfig.CnnString("OracleConnection");
			using (OracleConnection oracleConnection = new OracleConnection(connectionString))
			{
				try
				{
					oracleConnection.Open();
					OracleCommand command = new OracleCommand(queryString);
					command.Connection = oracleConnection;
					command.CommandType = CommandType.StoredProcedure;
					if (paramsStr != null && paramsStr != "")
					{
						command.Parameters.Add("Key", OracleDbType.Varchar2).Value = paramsStr;

					}
					command.ExecuteNonQuery();
					OracleDataAdapter da = new OracleDataAdapter();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}



		/// <summary>
		/// TODO: Implement Login feature.
		/// </summary>
		public void Login(string username, string password, string databaseName)
		{
			setConnection();
		}


		private void closeConnect()
		{
			OracleConnection.ClearAllPools();
		}

		private void setConnection()
		{

		}
	}
}
