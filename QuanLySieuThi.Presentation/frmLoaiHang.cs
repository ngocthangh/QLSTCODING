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

namespace QuanLySieuThi.Presentation
{
    public partial class frmLoaiHang : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiHang()
        {
            InitializeComponent();
        }

        private void grcLoaiHang_Load(object sender, EventArgs e)
        {
            var dt = LoaiHangService.LoadDataTable();
            grcLoaiHang.DataSource = dt;
        }
    }
}