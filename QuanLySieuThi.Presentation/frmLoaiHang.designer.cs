namespace QuanLySieuThi.Presentation
{
    partial class frmLoaiHang
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.grcLoaiHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaLoaiHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoaiHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenChungLoaiHang = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcLoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBoxEdit1);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.textEdit2);
            this.groupControl1.Controls.Add(this.textEdit1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(717, 88);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Loại Hàng";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(374, 32);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(126, 20);
            this.comboBoxEdit1.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(261, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(106, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tên Chủng Loại Hàng:";
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(95, 60);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(135, 20);
            this.textEdit2.TabIndex = 3;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(95, 29);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(135, 20);
            this.textEdit1.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên Loại Hàng:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Loại Hàng:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDong);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 88);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(717, 34);
            this.panelControl1.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonClose_Image;
            this.btnDong.Location = new System.Drawing.Point(165, 6);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonDelete_Image;
            this.btnXoa.Location = new System.Drawing.Point(84, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonSave_Image;
            this.btnLuu.Location = new System.Drawing.Point(3, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.grcLoaiHang);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 122);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(717, 286);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Danh Sách Loại Hàng";
            // 
            // grcLoaiHang
            // 
            this.grcLoaiHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcLoaiHang.Location = new System.Drawing.Point(2, 20);
            this.grcLoaiHang.MainView = this.gridView1;
            this.grcLoaiHang.Name = "grcLoaiHang";
            this.grcLoaiHang.Size = new System.Drawing.Size(713, 264);
            this.grcLoaiHang.TabIndex = 0;
            this.grcLoaiHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grcLoaiHang.Load += new System.EventHandler(this.grcLoaiHang_Load);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.MaLoaiHang,
            this.TenLoaiHang,
            this.TenChungLoaiHang});
            this.gridView1.GridControl = this.grcLoaiHang;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm Mới";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 64;
            // 
            // MaLoaiHang
            // 
            this.MaLoaiHang.Caption = "Mã Loại Hàng";
            this.MaLoaiHang.FieldName = "MaLoaiHang";
            this.MaLoaiHang.Name = "MaLoaiHang";
            this.MaLoaiHang.Visible = true;
            this.MaLoaiHang.VisibleIndex = 1;
            this.MaLoaiHang.Width = 202;
            // 
            // TenLoaiHang
            // 
            this.TenLoaiHang.Caption = "Tên Loại Hàng";
            this.TenLoaiHang.FieldName = "TenLoaiHang";
            this.TenLoaiHang.Name = "TenLoaiHang";
            this.TenLoaiHang.Visible = true;
            this.TenLoaiHang.VisibleIndex = 2;
            this.TenLoaiHang.Width = 202;
            // 
            // TenChungLoaiHang
            // 
            this.TenChungLoaiHang.Caption = "Tên Chủng Loại Hàng";
            this.TenChungLoaiHang.FieldName = "TenChungLoai";
            this.TenChungLoaiHang.Name = "TenChungLoaiHang";
            this.TenChungLoaiHang.Visible = true;
            this.TenChungLoaiHang.VisibleIndex = 3;
            this.TenChungLoaiHang.Width = 205;
            // 
            // frmLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 408);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmLoaiHang";
            this.Text = "Quản Lý Loại Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcLoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl grcLoaiHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn MaLoaiHang;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoaiHang;
        private DevExpress.XtraGrid.Columns.GridColumn TenChungLoaiHang;
    }
}