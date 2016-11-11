using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace QuanLySieuThi.Presentation
{
    public partial class frmTrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World 123243434!");
            DevExpress.UserSkins.BonusSkins.Register();
            //DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);
        }

        private void OpenForm<T>()
        {
            var f = MdiChildren.FirstOrDefault(i => i is T);

            if (f == null)
            {
                f = Activator.CreateInstance<T>() as Form;
                if (f == null) return;
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                f.Activate();
            }
        }

        private void buttonClick_ThongTinHanghoa(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmHangHoa>();

        }

        private void buttonClick_ChungLoaiHang(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var form in Application.OpenForms.OfType<frmChungLoaiHang>())
            {
                form.Activate();
                return;
            }
            var f = new frmChungLoaiHang();
            f.Show();
        }

        private void buttonClick_LoaiHang(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var form in Application.OpenForms.OfType<frmLoaiHang>())
            {
                form.Activate();
                return;
            }
            var f = new frmLoaiHang();
            f.Show();
        }

        private void buttonClick_DonViTinh(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (var form in Application.OpenForms.OfType<frmDonViTinh>())
            {
                form.Activate();
                return;
            }
            var f = new frmDonViTinh();
            f.Show();
        }

        private void buttonClick_NhaCungCap(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmNhaCungCap>();
        }
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmNhanVien>();
        }

        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmPhieuNhap>();
        }
    }
}
