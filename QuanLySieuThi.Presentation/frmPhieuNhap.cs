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
    public partial class frmPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmChiTietKiemKe_Load(object sender, EventArgs e)
        {
            var dt = PhieuNhapService.LoadDataTable();
            //dt.Columns.Add("Status");
            grcPhieuNhap.DataSource = dt;
        }
    }
}
