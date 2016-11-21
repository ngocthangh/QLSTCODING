using QuanLySieuThi.DataAccess;
using QuanLySieuThi.DataModel;
using System.Data;

namespace QuanLySieuThi.DataBussiness
{
    public class ChungLoaiService
    {
        private static readonly ChungLoaiController Controller = new ChungLoaiController();

        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }

        public static bool SaveChanges(DataTable dt)
        {
            if (dt == null) return false;
            return Controller.SaveChange(dt);
        }

       public static bool Insert(ChungLoai chungloai)
        {
            return Controller.Insert(chungloai);
        }

        public static bool Update(ChungLoai chungloai)
        {
            return Controller.Update(chungloai);
        }

        public static DataTable GetById(string id)
        {
            return Controller.GetById(id);
        }

        public static string AutoGenerateId()
        {
            return Controller.AutoGenerateId();
        }
    }
}
