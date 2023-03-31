using Oracle_Management_Library.DataAccess;
using System.Configuration;

namespace Oracle_Management_Library
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections()
        {
            Connection = new SqlConnection(new ModelContext());
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
