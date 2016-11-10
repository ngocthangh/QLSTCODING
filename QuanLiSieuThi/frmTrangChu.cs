using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace QuanLiSieuThi
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

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm<frmNhanVien>();
        }
    }
}
