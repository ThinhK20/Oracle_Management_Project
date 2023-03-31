using System.Data;

namespace Oracle_Management_Library.DataAccess
{
    public interface IDataConnection
    {
        public DataTable GetSQLQuery(string queryString);

    }
}
