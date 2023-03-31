using Oracle_Management_Library.DataAccess;

namespace Oracle_Management_Library
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; set; }
        public static void InitializeConnections()
        {
            Connection = new SqlConnection(new ModelContext());
        }
    }
}
