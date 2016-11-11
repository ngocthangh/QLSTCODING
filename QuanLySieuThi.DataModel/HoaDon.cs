using System;

namespace QuanLySieuThi.DataModel
{
    public partial class HoaDon
    {
        public string MaHoaDon { get; set; }
        public string MaNhanVien { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string MaKhachHang { get; set; }
        public Nullable<decimal> TongTien { get; set; }
        public Nullable<int> DiemThuong { get; set; }
        public Nullable<int> MucGiam { get; set; }
    }
}
