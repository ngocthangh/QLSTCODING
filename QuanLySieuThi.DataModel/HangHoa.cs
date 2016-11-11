using System;


namespace QuanLySieuThi.DataModel
{
    public partial class HangHoa
    {
        public string MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public Nullable<decimal> GiaMua { get; set; }
        public Nullable<decimal> GiaBan { get; set; }
        public Nullable<System.DateTime> NgaySanXuat { get; set; }
        public Nullable<System.DateTime> HanSuDung { get; set; }
        public Nullable<int> SoLuongNhap { get; set; }
        public Nullable<int> SoLuongBan { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public Nullable<int> VAT { get; set; }
        public string MaLoaiHang { get; set; }
        public string MaDVT { get; set; }
    }
}
