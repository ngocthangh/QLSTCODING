using System;

namespace QuanLySieuThi.DataModel
{
    public partial class KhachHangThanThiet
    {
        public string MaKhachHang { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public Nullable<System.DateTime> NgayCapThe { get; set; }
        public Nullable<int> DiemThuong { get; set; }
    }
}
