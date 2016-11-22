namespace QuanLySieuThi.Presentation
{
    partial class frmChungLoaiHang
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
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.grcChungLoai = new DevExpress.XtraGrid.GridControl();
            this.ChungLoaiHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcChungLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChungLoaiHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(600, 35);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.simpleButton3);
            this.panelControl4.Location = new System.Drawing.Point(170, 5);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(76, 24);
            this.panelControl4.TabIndex = 3;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonClose_Image;
            this.simpleButton3.Location = new System.Drawing.Point(0, 0);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Đóng";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.simpleButton2);
            this.panelControl3.Location = new System.Drawing.Point(89, 5);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(75, 24);
            this.panelControl3.TabIndex = 3;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonDelete_Image;
            this.simpleButton2.Location = new System.Drawing.Point(0, 0);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 24);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Xóa";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Location = new System.Drawing.Point(6, 6);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(77, 24);
            this.panelControl2.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::QuanLySieuThi.Presentation.Properties.Resources.buttonSave_Image;
            this.simpleButton1.Location = new System.Drawing.Point(0, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(77, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Lưu";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.grcChungLoai);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 35);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(600, 361);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Danh sách Chủng Loại Hàng";
            // 
            // grcChungLoai
            // 
            this.grcChungLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcChungLoai.Location = new System.Drawing.Point(2, 20);
            this.grcChungLoai.MainView = this.ChungLoaiHang;
            this.grcChungLoai.Name = "grcChungLoai";
            this.grcChungLoai.Size = new System.Drawing.Size(596, 339);
            this.grcChungLoai.TabIndex = 0;
            this.grcChungLoai.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ChungLoaiHang});
            this.grcChungLoai.Load += new System.EventHandler(this.grcChungLoai_Load);
            // 
            // ChungLoaiHang
            // 
            this.ChungLoaiHang.GridControl = this.grcChungLoai;
            this.ChungLoaiHang.IndicatorWidth = 40;
            this.ChungLoaiHang.Name = "ChungLoaiHang";
            this.ChungLoaiHang.NewItemRowText = "Thêm mới";
            this.ChungLoaiHang.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.ChungLoaiHang.OptionsCustomization.AllowQuickHideColumns = false;
            this.ChungLoaiHang.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.ChungLoaiHang.OptionsSelection.MultiSelect = true;
            this.ChungLoaiHang.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.ChungLoaiHang.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // frmChungLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 396);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmChungLoaiHang";
            this.Text = "Quản Lý Chủng Loại Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcChungLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChungLoaiHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl grcChungLoai;
        private DevExpress.XtraGrid.Views.Grid.GridView ChungLoaiHang;
    }
}