namespace QuanLySieuThi.Presentation
{
    partial class frmDonViTinh
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grcDonViTinh = new DevExpress.XtraGrid.GridControl();
            this.grvDonViTinh = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcDonViTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDonViTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnDong);
            this.panelControl1.Controls.Add(this.btnXoa);
            this.panelControl1.Controls.Add(this.btnLuu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(619, 33);
            this.panelControl1.TabIndex = 0;
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonClose_Image;
            this.btnDong.Location = new System.Drawing.Point(168, 6);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.buttonDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonDelete_Image;
            this.btnXoa.Location = new System.Drawing.Point(87, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonSave_Image;
            this.btnLuu.Location = new System.Drawing.Point(6, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grcDonViTinh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 33);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(619, 373);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Danh Sách Đơn Vị Tính";
            // 
            // grcDonViTinh
            // 
            this.grcDonViTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcDonViTinh.Location = new System.Drawing.Point(2, 20);
            this.grcDonViTinh.MainView = this.grvDonViTinh;
            this.grcDonViTinh.Name = "grcDonViTinh";
            this.grcDonViTinh.Size = new System.Drawing.Size(615, 351);
            this.grcDonViTinh.TabIndex = 0;
            this.grcDonViTinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvDonViTinh});
            this.grcDonViTinh.Load += new System.EventHandler(this.grcDonViTinh_Load);
            // 
            // grvDonViTinh
            // 
            this.grvDonViTinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenDVT});
            this.grvDonViTinh.GridControl = this.grcDonViTinh;
            this.grvDonViTinh.IndicatorWidth = 40;
            this.grvDonViTinh.Name = "grvDonViTinh";
            this.grvDonViTinh.NewItemRowText = "Thêm Mới";
            this.grvDonViTinh.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.grvDonViTinh.OptionsCustomization.AllowQuickHideColumns = false;
            this.grvDonViTinh.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.grvDonViTinh.OptionsSelection.MultiSelect = true;
            this.grvDonViTinh.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grvDonViTinh.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.grvDonViTinh.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.grvDonViTinh_CustomDrawRowIndicator);
            this.grvDonViTinh.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.grvDonViTinh_InvalidRowException);
            // 
            // TenDVT
            // 
            this.TenDVT.Caption = "Tên Đơn Vị Tính";
            this.TenDVT.FieldName = "TenDVT";
            this.TenDVT.Name = "TenDVT";
            this.TenDVT.Visible = true;
            this.TenDVT.VisibleIndex = 1;
            // 
            // frmDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 406);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDonViTinh";
            this.Text = "Quản Lí Đơn Vị Tính";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDonViTinh_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcDonViTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDonViTinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grcDonViTinh;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn TenDVT;
    }
}