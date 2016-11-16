using QuanLySieuThi.DataModel;
using System.Data;

namespace QuanLySieuThi.DataAccess
{
    public class DonViTinhController
    {
        private readonly Connector _connect;

        public DonViTinhController()
        {
            _connect = new Connector("DONVITINH");
        }

        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }

        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_DONVITINH_GETALL");
        }

        public bool SaveChange(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }

        public bool Insert(DonViTinh donvitinh)
        {
            return _connect.Update(donvitinh);
        }

        public DataTable GetById(string donvitinh)
        {
            return _connect.LoadData("SP_DONVITINH_GETBYID", new[] { "@MaDVT" }, new object[] { donvitinh }, 1);
        }

        public bool Update(DonViTinh donvitinh)
        {
            return _connect.Update("SP_DONVITINH_UPD", donvitinh) == 1;
        }
    }
}
