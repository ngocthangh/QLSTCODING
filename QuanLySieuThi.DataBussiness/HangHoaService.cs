using System;
using QuanLySieuThi.DataAccess;
using QuanLySieuThi.DataModel;
using System.Data;

namespace QuanLySieuThi.DataBussiness
{
    public class HangHoaService
    {
        private static readonly HangHoaController Controller = new HangHoaController();

        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }

        public static bool SaveChanges(DataTable dt)
        {
            return Controller.SaveChange(dt);
        }

        public static bool Insert(HangHoa hanghoa)
        {
            return Controller.Insert(hanghoa);
        }

        public static bool Update(HangHoa hanghoa)
        {
            return Controller.Update(hanghoa);
        }

        public static DataTable GetById(string id)
        {
            return Controller.GetById(id);
        }
    }
}
