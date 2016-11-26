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
    }
}