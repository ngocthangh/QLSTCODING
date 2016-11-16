using QuanLySieuThi.DataAccess;
using QuanLySieuThi.DataModel;
using System.Data;

namespace QuanLySieuThi.DataBussiness
{
    public class NhaCungCapService
    {
        private static readonly NhaCungCapController Controller = new NhaCungCapController();

        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }

        public static bool SaveChanges(DataTable dt)
        {
            return Controller.SaveChange(dt);
        }

        public static bool Insert(NhaCungCap nhaCungCap)
        {
            return Controller.Insert(nhaCungCap);
        }

        public static bool Update(NhaCungCap nhaCungCap)
        {
            return Controller.Update(nhaCungCap);
        }

        public static DataTable GetById(string id)
        {
            return Controller.GetById(id);
        }
    }
}
