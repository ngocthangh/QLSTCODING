using QuanLySieuThi.DataModel;
using System.Data;
using System;

namespace QuanLySieuThi.DataAccess
{
    public class ChungLoaiController
    {
        private readonly Connector _connect;

        public ChungLoaiController()
        {
            _connect = new Connector("CHUNGLOAI");
        }

        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }

        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_CHUNGLOAI_GETALL");
        }

        public bool SaveChange(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }

        public bool Insert(ChungLoai chungloai)
        {
            return _connect.Update(chungloai);
        }

        public DataTable GetById(string maChungLoai)
        {
            return _connect.LoadData("SP_CHUNGLOAI_GETBYID", new[] { "@MaChungLoai" }, new object[] { maChungLoai }, 1);
        }

        public bool Update(ChungLoai chungloai)
        {
            return _connect.Update("SP_CHUNGLOAI_UPD", chungloai) == 1;
        }
    }
}
