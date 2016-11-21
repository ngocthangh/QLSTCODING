using QuanLySieuThi.DataModel;
using System.Data;


namespace QuanLySieuThi.DataAccess
{
    public class NhanVienController
    {
        private readonly Connector _connect;

        public NhanVienController()
        {
            _connect = new Connector("NHANVIEN");
        }

        public DataTable GetDataTable()
        {
            return _connect.getDataTable();
        }

        public string AutoGenerateId()
        {
            return _connect.AutoGenerateId("SP_NHANVIEN_AUTOGENERATEID");
        }

        public DataTable GetByAll()
        {
            return _connect.LoadData("SP_NHANVIEN_GETALL");
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

            return _connect.LoadData("SP_NHANVIEN_GETBYID", new[] { "@MaNhanVien" }, new object[] { maNhanVien }, 1);
        }

        //public DataTable FindBook(string where)
        //{
        //    return _connect.LoadData("sp_Book_FindBook", new[] { "@where" }, new object[] { where }, 1);
        //}

        public bool Insert(NhanVien nhanVien)
        {
            return _connect.Update(nhanVien);
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

        public bool Update(NhanVien nhanVien)
        {
            return _connect.Update("SP_NHANVIEN_UPD", nhanVien) == 1;
        }
    }
}
