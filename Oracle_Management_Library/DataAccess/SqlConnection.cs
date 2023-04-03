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
                OracleCommand command = new OracleCommand(queryString);
                command.Connection = oracleConnection;
                command.CommandType = CommandType.Text;
                oracleConnection.Open();
                command.ExecuteNonQueryAsync();
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
