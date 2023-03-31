using Oracle_Management_Library.Models;

namespace Oracle_Management_Library.DataAccess
{
    internal class SqlConnection : IDataConnection
    {
        private readonly ModelContext db;

        public SqlConnection(ModelContext db)
        {
            this.db = db;
        }
        public List<Nhanvien> GetNhanVien()
        {
            return db.Nhanviens.ToList();
        }
    }
}
