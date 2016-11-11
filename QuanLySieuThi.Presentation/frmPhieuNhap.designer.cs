namespace QuanLySieuThi.Presentation
{
    partial class frmPhieuNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grcPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaPhieuNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grcPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grcPhieuNhap
            // 
            this.grcPhieuNhap.Location = new System.Drawing.Point(12, 12);
            this.grcPhieuNhap.MainView = this.gridView1;
            this.grcPhieuNhap.Name = "grcPhieuNhap";
            this.grcPhieuNhap.Size = new System.Drawing.Size(688, 297);
            this.grcPhieuNhap.TabIndex = 0;
            this.grcPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaPhieuNhap,
            this.NhanVien,
            this.NgayLap,
            this.TongTien});
            this.gridView1.GridControl = this.grcPhieuNhap;
            this.gridView1.Name = "gridView1";
            // 
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.Caption = "Mã Phiếu Nhập";
            this.MaPhieuNhap.FieldName = "MaPhieuNhap";
            this.MaPhieuNhap.Name = "MaPhieuNhap";
            this.MaPhieuNhap.Visible = true;
            this.MaPhieuNhap.VisibleIndex = 0;
            // 
            // NhanVien
            // 
            this.NhanVien.Caption = "Nhân Viên";
            this.NhanVien.FieldName = "MaNhanVien";
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Visible = true;
            this.NhanVien.VisibleIndex = 1;
            // 
            // NgayLap
            // 
            this.NgayLap.Caption = "Ngày Lập";
            this.NgayLap.FieldName = "NgayLap";
            this.NgayLap.Name = "NgayLap";
            this.NgayLap.Visible = true;
            this.NgayLap.VisibleIndex = 2;
            // 
            // TongTien
            // 
            this.TongTien.Caption = "Tổng Tiền";
            this.TongTien.FieldName = "TongTien";
            this.TongTien.Name = "TongTien";
            this.TongTien.Visible = true;
            this.TongTien.VisibleIndex = 3;
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 321);
            this.Controls.Add(this.grcPhieuNhap);
            this.Name = "frmPhieuNhap";
            this.Text = "frmChiTietKiemKe";
            this.Load += new System.EventHandler(this.frmChiTietKiemKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grcPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaPhieuNhap;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn TongTien;
    }
}