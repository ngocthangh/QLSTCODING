using System.Data;
using QuanLySieuThi.DataModel;

namespace QuanLySieuThi.DataAccess
{
    public class LoaiHangController
    {
        private readonly Connector _connect;

        public LoaiHangController()
        {
            _connect = new Connector("LOAIHANG");
        }

        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }

        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_LOAIHANG_GETALL");
        }

        public bool SaveChange(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }

        public bool Insert(LoaiHang loaihang)
        {
            return _connect.Update(loaihang);
        }

        public DataTable GetById(string maloaihang)
        {
            return _connect.LoadData("SP_LOAIHANG_GETBYID", new[] { "@MaLoaiHang" }, new object[] { maloaihang }, 1);
        }

        public bool Update(LoaiHang loaihang)
        {
            return _connect.Update("SP_CHUNGLOAI_UPD", loaihang) == 1;
        }
    }
}
