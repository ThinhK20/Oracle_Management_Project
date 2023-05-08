using System.Data;

namespace Oracle_Management_Library.DataAccess
{
	public interface IDataConnection
	{
		public DataTable GetSQLQuery(string queryString);
		public void ExecuteSQLTextQuery(string queryString);
		public void ExecuteStoredProcedure(string queryString, string paramsStr);
		public void ExecuteStoredProcedureLuong(string queryString, string paramsStr1, string paramsStr2);
		public void ExecuteStoredProcedurePhuCap(string queryString, string paramsStr1, string paramsStr2);

	}
}
