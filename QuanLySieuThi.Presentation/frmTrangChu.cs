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
            DevExpress.UserSkins.BonusSkins.Register();
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
            OpenForm<frmChungLoaiHang>();
        }

        private void buttonClick_LoaiHang(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmLoaiHang>();
        }

        private void buttonClick_DonViTinh(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmDonViTinh>();
        }

        private void buttonClick_NhaCungCap(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmNhaCungCap>();
        }
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmNhanVien>();
            //OpenForm<Form1>();
        }

        private void btnPhieuNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmPhieuNhap>();
        }
    }
}
