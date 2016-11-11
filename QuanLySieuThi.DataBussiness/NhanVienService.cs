using QuanLySieuThi.DataModel;
using QuanLySieuThi.DataAccess;
using System.Data;


namespace QuanLySieuThi.DataBussiness
{
    public class NhanVienService
    {
        private static readonly NhanVienController Controller = new NhanVienController();

        public static DataTable LoadDataTable()
        {
            return Controller.GetByAll();
        }

        public static bool SaveChanges(DataTable dt)
        {
            if (dt == null) return false;
            return Controller.SaveChanges(dt);
        }

        //public static bool SaveBooks(BookInfo row)
        //{
        //    var dataBook = Controller.GetByPublisherPublishYear(row["Publisher"].ToString(), (short)row["PublishYear"]);
        //    DataRow rowBook;
        //    if (dataBook.Rows.Count == 0)
        //    {
        //        if (!Controller.Insert(new BookInfo
        //        {
        //            BookTitleId = (int)row["BookTitleId"],
        //            Publisher = row["Publisher"].ToString(),
        //            PublishYear = short.Parse(row["PublishYear"].ToString()),
        //            Count = (int)row["Count"],
        //            Price = (decimal)row["Price"]
        //        })) return null;

        //        rowBook = Controller.GetByLast();
        //    }
        //    else
        //    {
        //        rowBook = dataBook.Rows[0];
        //    }

        //    var n = (int)row["Count"];
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (!TomeService.Insert(new TomeInfo()
        //        {
        //            BookId = (int)rowBook["Id"],
        //            Status = 1
        //        })) return null;
        //    }

        //    return rowBook;
        //}
        public static bool Insert(NhanVien nhanVien)
        {
            return Controller.Insert(nhanVien);
        }
        public static bool Update(NhanVien nhanVien)
        {
            return Controller.Update(nhanVien);
        }
        //public static DataTable FindBook(string bookId)
        //{
        //    return Controller.FindBook(string.Format("where Book.Id ={0}", bookId));
        //}

        //public static DataTable FindBook(string bookName, string category)
        //{
        //    string where = "";
        //    if (bookName != "")
        //    {
        //        where += string.Format("BookTitle.Name ='{0}'", bookName);
        //    }
        //    if (category != "")
        //    {
        //        if (where != "")
        //        {
        //            where += " and ";
        //        }
        //        where += string.Format("Category.ID = {0}", category);
        //    }
        //    if (where != "")
        //        where = where.Insert(0, "Where ");
        //    return Controller.FindBook(where);
        //}
        //public static bool GetByBookId(string bookId)

        //{
        //    DataTable dt = Controller.GetByBookId(bookId);
        //    int number;
        //    int.TryParse(dt.Rows[0]["Count"].ToString(), out number);
        //    if (number > 0)
        //        return true;
        //    return false;
        //}

        //public static DataRow GetBookId(BookInfo info)
        //{
        //    var dt = Controller.GetByPublisherPublishYear(info.Publisher, info.PublishYear);
        //    //var dt = Controller.GetByTop("",
        //    //    string.Format("Publisher = N'{0}' and PublishYear = {1}", info.Publisher, info.PublishYear), "");
        //    if (dt.Rows.Count == 0)
        //    {
        //        return !Controller.Insert(info) ? null : Controller.GetByLast();
        //    }

        //    return dt.Rows[0];
        //}

        public static DataTable GetById(string id)
        {
            return Controller.GetById(id);
        }
    }
}
