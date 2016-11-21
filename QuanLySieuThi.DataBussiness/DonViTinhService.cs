using System;
using QuanLySieuThi.DataAccess;
using QuanLySieuThi.DataModel;
using System.Data;

namespace QuanLySieuThi.DataBussiness
{
    public class DonViTinhService
    {
        private static readonly DonViTinhController Controller = new DonViTinhController();

        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }

        public static bool SaveChanges(DataTable dt)
        {
            return Controller.SaveChange(dt);
        }

        public static bool Insert(DonViTinh donvitinh)
        {
            return Controller.Insert(donvitinh);
        }

        public static bool Update(DonViTinh donvitinh)
        {
            return Controller.Update(donvitinh);
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
