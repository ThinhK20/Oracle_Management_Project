using Oracle_Management_Library.Models;

namespace Oracle_Management_Library.DataAccess
{
    public interface IDataConnection
    {
        public List<Nhanvien> GetNhanVien();
    }
}
