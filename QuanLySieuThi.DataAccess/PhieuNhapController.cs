using QuanLySieuThi.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DataAccess
{
    public class PhieuNhapController
    {
        private readonly Connector _connect;

        public PhieuNhapController()
        {
            _connect = new Connector("PHIEUNHAP");
        }

        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }
        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_PHIEUNHAP_GETALL");
        }

        public bool SaveChanges(DataTable dt)
        {
            return _connect.SaveChanges(dt);
        }

        //public DataTable GetByTop(string top, string where, string order)
        //{
        //    return _connect.LoadData("sp_Book_GetByTop", new[] { "@top", "@where", "@oder" },
        //        new object[] { top, where, order }, 3);
        //}

        //public DataTable GetById(int id)
        //{
        //    return _connect.LoadData("SP_NHANVIEN_GETBYID", new[] { "@Id" }, new object[] { id }, 1);

        //}

        public DataTable GetById(string maNhanVien)
        {

            return _connect.LoadData("SP_PHIEUNHAP_GETBYID", new[] { "@MaPhieuNhap" }, new object[] { maNhanVien }, 1);
        }

        //public DataTable FindBook(string where)
        //{
        //    return _connect.LoadData("sp_Book_FindBook", new[] { "@where" }, new object[] { where }, 1);
        //}

        public bool Insert(PhieuNhap phieuNhap)
        {
            return _connect.Update(phieuNhap);
        }

        //public DataRow GetByLast()
        //{
        //    var dt = _connect.LoadData("sp_Book_GetByLast");
        //    return dt != null ? dt.Rows[0] : null;
        //}

        //public int GetLastId()
        //{
        //    var dt = _connect.LoadData("sp_Book_GetLastId");
        //    return dt.Rows.Count == 0 ? -1 : (int)dt.Rows[0]["Id"];
        //}

        public bool Update(PhieuNhap phieuNhap)
        {
            return _connect.Update("SP_PHIEUNHAP_UPD", phieuNhap) == 1;
        }
    }
}
