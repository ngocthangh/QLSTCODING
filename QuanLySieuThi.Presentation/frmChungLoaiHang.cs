using DevExpress.XtraEditors;
using QuanLySieuThi.DataBussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;

namespace QuanLySieuThi.Presentation
{
    public partial class frmChungLoaiHang : DevExpress.XtraEditors.XtraForm
    {
        public frmChungLoaiHang()
        {
            InitializeComponent();
        }

        private void grcChungLoai_Load(object sender, EventArgs e)
        {
            var dt = ChungLoaiService.LoadDataTable();
            grcChungLoai.DataSource = dt;
            
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            var dt = grcChungLoai.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if (ChungLoaiService.SaveChanges(dt))
            {
                XtraMessageBox.Show("Lưu Thành Công", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Lưu Thất Bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc xóa (những) dòng này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            ChungLoaiHang.DeleteSelectedRows();
        }

        private void buttonDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Hàm tự tạo cột STT trong Grid Control
        private void ChungLoaiHang_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        //Hàm xác nhận giá trị của 1 ô (tức kiểm tra not null)
        private void ChungLoaiHang_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var ChungLoaiHangGroup = ChungLoaiHang.GetFocusedDataRow();

            if (ChungLoaiHangGroup.IsNull("TenChungLoai") || string.IsNullOrWhiteSpace(ChungLoaiHangGroup["TenChungLoai"].ToString()))
            {
                e.ErrorText = "Tên Chủng Loại Hàng Không Được Trống";
                ChungLoaiHang.SetColumnError(ChungLoaiHang.Columns[2], e.ErrorText);
                e.Valid = false;
            }
        }

        private void ChungLoaiHang_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        //Hàm xác nhận Lưu khi Thoát Form mà không Lưu
        private void frmChungLoaiHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dt = grcChungLoai.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if (XtraMessageBox.Show("Bạn có muốn lưu những thay đổi không?", "Thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!ChungLoaiService.SaveChanges(dt.GetChanges()))
                {
                    XtraMessageBox.Show("Lưu thất bại", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        



    }
}