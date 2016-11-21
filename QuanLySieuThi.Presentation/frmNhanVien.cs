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
    public partial class frmNhanVien : XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            var dt = NhanVienService.LoadDataTable();
            //dt.Columns.Add("Status");
            grcNhanVien.DataSource = dt;
            string id = NhanVienService.AutoGenerateId();
            txtMaNhanVien.Text = id;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void hideContainerTop_Click(object sender, EventArgs e)
        {

        }
    }
}
