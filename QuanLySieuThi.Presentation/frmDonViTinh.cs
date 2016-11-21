using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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

namespace QuanLySieuThi.Presentation
{
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void grcDonViTinh_Load(object sender, EventArgs e)
        {
            var dt = DonViTinhService.LoadDataTable();
            grcDonViTinh.DataSource = dt;
            string id = DonViTinhService.AutoGenerateId();
            
        }

        //Button Thêm
        private void buttonLuu_Click(object sender, EventArgs e)
        {
            var dt = grcDonViTinh.DataSource as DataTable;

            if (dt == null || dt.GetChanges() == null)
                return;
            if (DonViTinhService.SaveChanges(dt))
            {
                XtraMessageBox.Show("Lưu Thành Công", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grcDonViTinh.DataSource = DonViTinhService.LoadDataTable();
            }
            else
            {
                XtraMessageBox.Show("Lưu Thất Bại", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Button Xóa
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có chắc xóa (những) dòng này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            grvDonViTinh.DeleteSelectedRows();
        }

        //Button Đóng
        private void buttonDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Hàm Xác nhận Lưu khi thoát Form
        private void frmDonViTinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dt = grcDonViTinh.DataSource as DataTable;
            if (dt == null || dt.GetChanges() == null) return;
            if (XtraMessageBox.Show("Bạn có muốn lưu những thay đổi không?", "Thoát", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!DonViTinhService.SaveChanges(dt.GetChanges()))
                {
                    XtraMessageBox.Show("Lưu thất bại", "Lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        //Hàm Thêm tự động cột STT
        private void grvDonViTinh_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        //Hàm Xác định ngoại lệ giá trị của hàng
        private void grvDonViTinh_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
    }
}