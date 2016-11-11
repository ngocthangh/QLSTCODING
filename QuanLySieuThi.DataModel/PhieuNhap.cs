using System;


namespace QuanLySieuThi.DataModel
{
    public partial class PhieuNhap
    {
        public string MaPhieuNhap { get; set; }
        public string MaNhanVien { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public Nullable<decimal> TongTien { get; set; }
    }
}
