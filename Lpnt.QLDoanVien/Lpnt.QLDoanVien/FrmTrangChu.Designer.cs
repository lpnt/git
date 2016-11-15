namespace Lpnt.QLDoanVien
{
    partial class FrmTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangChu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnKetNoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.itemCSDL = new DevExpress.XtraBars.BarStaticItem();
            this.itemNgay = new DevExpress.XtraBars.BarStaticItem();
            this.itemGiaoDien = new DevExpress.XtraBars.BarStaticItem();
            this.itemPhienBan = new DevExpress.XtraBars.BarStaticItem();
            this.btnDongTatCaTab = new DevExpress.XtraBars.BarStaticItem();
            this.btnKhoaUngDung = new DevExpress.XtraBars.BarStaticItem();
            this.itemTaiKhoan = new DevExpress.XtraBars.BarStaticItem();
            this.itemNhomNguoiDung = new DevExpress.XtraBars.BarStaticItem();
            this.btnXoaBoNho = new DevExpress.XtraBars.BarButtonItem();
            this.itemNienKhoa = new DevExpress.XtraBars.BarStaticItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanSu = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonVi = new DevExpress.XtraBars.BarButtonItem();
            this.rpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgGiaoDien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTienIch = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgNguoiDung = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpHoTro = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.RS = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.DM = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            this.IMC = new DevExpress.Utils.ImageCollection();
            this.btnNhapTuExcel = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMC)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.skinRibbonGalleryBarItem1,
            this.btnKetNoi,
            this.btnSaoLuu,
            this.btnPhucHoi,
            this.itemCSDL,
            this.itemNgay,
            this.itemGiaoDien,
            this.itemPhienBan,
            this.btnDongTatCaTab,
            this.btnKhoaUngDung,
            this.itemTaiKhoan,
            this.itemNhomNguoiDung,
            this.btnXoaBoNho,
            this.itemNienKhoa,
            this.btnDoiMatKhau,
            this.btnNhanSu,
            this.btnDonVi,
            this.btnNhapTuExcel});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 19;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.btnDongTatCaTab);
            this.ribbon.PageHeaderItemLinks.Add(this.btnKhoaUngDung);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpHeThong,
            this.rpNghiepVu,
            this.rpHoTro});
            this.ribbon.QuickToolbarItemLinks.Add(this.itemNienKhoa);
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.Size = new System.Drawing.Size(758, 144);
            this.ribbon.StatusBar = this.RS;
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 1;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.Caption = "Kết nối";
            this.btnKetNoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKetNoi.Glyph")));
            this.btnKetNoi.Id = 2;
            this.btnKetNoi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKetNoi.LargeGlyph")));
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKetNoi_ItemClick);
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Caption = "Sao lưu";
            this.btnSaoLuu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.Glyph")));
            this.btnSaoLuu.Id = 3;
            this.btnSaoLuu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSaoLuu.LargeGlyph")));
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.Glyph")));
            this.btnPhucHoi.Id = 4;
            this.btnPhucHoi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPhucHoi.LargeGlyph")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // itemCSDL
            // 
            this.itemCSDL.Caption = "CSDL";
            this.itemCSDL.Glyph = ((System.Drawing.Image)(resources.GetObject("itemCSDL.Glyph")));
            this.itemCSDL.Id = 5;
            this.itemCSDL.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("itemCSDL.LargeGlyph")));
            this.itemCSDL.Name = "itemCSDL";
            this.itemCSDL.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // itemNgay
            // 
            this.itemNgay.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.itemNgay.Caption = "Ngày";
            this.itemNgay.Glyph = ((System.Drawing.Image)(resources.GetObject("itemNgay.Glyph")));
            this.itemNgay.Id = 6;
            this.itemNgay.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("itemNgay.LargeGlyph")));
            this.itemNgay.Name = "itemNgay";
            this.itemNgay.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // itemGiaoDien
            // 
            this.itemGiaoDien.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.itemGiaoDien.Caption = "Giao diện";
            this.itemGiaoDien.Glyph = ((System.Drawing.Image)(resources.GetObject("itemGiaoDien.Glyph")));
            this.itemGiaoDien.Id = 7;
            this.itemGiaoDien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("itemGiaoDien.LargeGlyph")));
            this.itemGiaoDien.Name = "itemGiaoDien";
            this.itemGiaoDien.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // itemPhienBan
            // 
            this.itemPhienBan.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.itemPhienBan.Caption = "Phiên bản";
            this.itemPhienBan.Glyph = ((System.Drawing.Image)(resources.GetObject("itemPhienBan.Glyph")));
            this.itemPhienBan.Id = 8;
            this.itemPhienBan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("itemPhienBan.LargeGlyph")));
            this.itemPhienBan.Name = "itemPhienBan";
            this.itemPhienBan.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnDongTatCaTab
            // 
            this.btnDongTatCaTab.Caption = "Đóng Tab";
            this.btnDongTatCaTab.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDongTatCaTab.Glyph")));
            this.btnDongTatCaTab.Id = 9;
            this.btnDongTatCaTab.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDongTatCaTab.LargeGlyph")));
            this.btnDongTatCaTab.Name = "btnDongTatCaTab";
            this.btnDongTatCaTab.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnDongTatCaTab.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDongTatCaTab_ItemClick);
            // 
            // btnKhoaUngDung
            // 
            this.btnKhoaUngDung.Caption = "Khóa ứng dụng";
            this.btnKhoaUngDung.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKhoaUngDung.Glyph")));
            this.btnKhoaUngDung.Id = 10;
            this.btnKhoaUngDung.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKhoaUngDung.LargeGlyph")));
            this.btnKhoaUngDung.Name = "btnKhoaUngDung";
            this.btnKhoaUngDung.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnKhoaUngDung.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhoaUngDung_ItemClick);
            // 
            // itemTaiKhoan
            // 
            this.itemTaiKhoan.Caption = "Tài khoản";
            this.itemTaiKhoan.Glyph = ((System.Drawing.Image)(resources.GetObject("itemTaiKhoan.Glyph")));
            this.itemTaiKhoan.Id = 11;
            this.itemTaiKhoan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("itemTaiKhoan.LargeGlyph")));
            this.itemTaiKhoan.Name = "itemTaiKhoan";
            this.itemTaiKhoan.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // itemNhomNguoiDung
            // 
            this.itemNhomNguoiDung.Caption = "Nhóm người dùng";
            this.itemNhomNguoiDung.Glyph = ((System.Drawing.Image)(resources.GetObject("itemNhomNguoiDung.Glyph")));
            this.itemNhomNguoiDung.Id = 12;
            this.itemNhomNguoiDung.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("itemNhomNguoiDung.LargeGlyph")));
            this.itemNhomNguoiDung.Name = "itemNhomNguoiDung";
            this.itemNhomNguoiDung.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnXoaBoNho
            // 
            this.btnXoaBoNho.Caption = "Xóa bộ nhớ";
            this.btnXoaBoNho.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoaBoNho.Glyph")));
            this.btnXoaBoNho.Id = 13;
            this.btnXoaBoNho.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXoaBoNho.LargeGlyph")));
            this.btnXoaBoNho.Name = "btnXoaBoNho";
            this.btnXoaBoNho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaBoNho_ItemClick);
            // 
            // itemNienKhoa
            // 
            this.itemNienKhoa.Caption = "Niên khóa";
            this.itemNienKhoa.Glyph = ((System.Drawing.Image)(resources.GetObject("itemNienKhoa.Glyph")));
            this.itemNienKhoa.Id = 14;
            this.itemNienKhoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("itemNienKhoa.LargeGlyph")));
            this.itemNienKhoa.Name = "itemNienKhoa";
            this.itemNienKhoa.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "Đổi mật khẩu";
            this.btnDoiMatKhau.Id = 15;
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            // 
            // btnNhanSu
            // 
            this.btnNhanSu.Caption = "Quản lý nhân sự";
            this.btnNhanSu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhanSu.Glyph")));
            this.btnNhanSu.Id = 16;
            this.btnNhanSu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhanSu.LargeGlyph")));
            this.btnNhanSu.Name = "btnNhanSu";
            this.btnNhanSu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanSu_ItemClick);
            // 
            // btnDonVi
            // 
            this.btnDonVi.Caption = "Quản lý đơn vị";
            this.btnDonVi.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDonVi.Glyph")));
            this.btnDonVi.Id = 17;
            this.btnDonVi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDonVi.LargeGlyph")));
            this.btnDonVi.Name = "btnDonVi";
            this.btnDonVi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonVi_ItemClick);
            // 
            // rpHeThong
            // 
            this.rpHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgGiaoDien,
            this.ribbonPageGroup3,
            this.rpgTienIch,
            this.rpgNguoiDung});
            this.rpHeThong.Name = "rpHeThong";
            this.rpHeThong.Text = "Hệ thống";
            // 
            // rpgGiaoDien
            // 
            this.rpgGiaoDien.AllowTextClipping = false;
            this.rpgGiaoDien.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.rpgGiaoDien.Name = "rpgGiaoDien";
            this.rpgGiaoDien.ShowCaptionButton = false;
            this.rpgGiaoDien.Text = "Giao diện";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKetNoi);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSaoLuu);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPhucHoi);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Cơ sở dữ liệu";
            // 
            // rpgTienIch
            // 
            this.rpgTienIch.AllowTextClipping = false;
            this.rpgTienIch.ItemLinks.Add(this.btnXoaBoNho);
            this.rpgTienIch.ItemLinks.Add(this.btnNhapTuExcel);
            this.rpgTienIch.Name = "rpgTienIch";
            this.rpgTienIch.ShowCaptionButton = false;
            this.rpgTienIch.Text = "Tiện ích";
            // 
            // rpgNguoiDung
            // 
            this.rpgNguoiDung.AllowTextClipping = false;
            this.rpgNguoiDung.ItemLinks.Add(this.btnDoiMatKhau);
            this.rpgNguoiDung.Name = "rpgNguoiDung";
            this.rpgNguoiDung.ShowCaptionButton = false;
            this.rpgNguoiDung.Text = "Người dùng";
            // 
            // rpNghiepVu
            // 
            this.rpNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rpNghiepVu.Name = "rpNghiepVu";
            this.rpNghiepVu.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDonVi);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNhanSu);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Quản lý đối tượng";
            // 
            // rpHoTro
            // 
            this.rpHoTro.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rpHoTro.Name = "rpHoTro";
            this.rpHoTro.Text = "Hỗ trợ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // RS
            // 
            this.RS.ItemLinks.Add(this.itemCSDL);
            this.RS.ItemLinks.Add(this.itemNgay);
            this.RS.ItemLinks.Add(this.itemGiaoDien, true);
            this.RS.ItemLinks.Add(this.itemPhienBan, true);
            this.RS.ItemLinks.Add(this.itemTaiKhoan, true);
            this.RS.ItemLinks.Add(this.itemNhomNguoiDung, true);
            this.RS.Location = new System.Drawing.Point(0, 328);
            this.RS.Name = "RS";
            this.RS.Ribbon = this.ribbon;
            this.RS.Size = new System.Drawing.Size(758, 32);
            // 
            // DM
            // 
            this.DM.MdiParent = this;
            this.DM.MenuManager = this.ribbon;
            this.DM.View = this.tabbedView1;
            this.DM.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // IMC
            // 
            this.IMC.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("IMC.ImageStream")));
            this.IMC.InsertGalleryImage("assigntome_16x16.png", "office2013/people/assigntome_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/people/assigntome_16x16.png"), 0);
            this.IMC.Images.SetKeyName(0, "assigntome_16x16.png");
            this.IMC.InsertGalleryImage("customer_16x16.png", "images/people/customer_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/customer_16x16.png"), 1);
            this.IMC.Images.SetKeyName(1, "customer_16x16.png");
            this.IMC.InsertGalleryImage("usergroup_16x16.png", "office2013/people/usergroup_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/people/usergroup_16x16.png"), 2);
            this.IMC.Images.SetKeyName(2, "usergroup_16x16.png");
            this.IMC.InsertGalleryImage("usergroup_16x16.png", "images/people/usergroup_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/usergroup_16x16.png"), 3);
            this.IMC.Images.SetKeyName(3, "usergroup_16x16.png");
            // 
            // btnNhapTuExcel
            // 
            this.btnNhapTuExcel.Caption = "Nhập từ Excel";
            this.btnNhapTuExcel.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhapTuExcel.Glyph")));
            this.btnNhapTuExcel.Id = 18;
            this.btnNhapTuExcel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhapTuExcel.LargeGlyph")));
            this.btnNhapTuExcel.Name = "btnNhapTuExcel";
            this.btnNhapTuExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapTuExcel_ItemClick);
            // 
            // FrmTrangChu
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.RS);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmTrangChu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.RS;
            this.Text = "Phần mềm quản lý đoàn viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTrangChu_FormClosing);
            this.Load += new System.EventHandler(this.FrmTrangChu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgGiaoDien;
        private DevExpress.XtraBars.Docking2010.DocumentManager DM;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar RS;
        private DevExpress.XtraBars.BarButtonItem btnKetNoi;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpHoTro;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarStaticItem itemCSDL;
        private DevExpress.XtraBars.BarStaticItem itemNgay;
        private DevExpress.XtraBars.BarStaticItem itemGiaoDien;
        private DevExpress.XtraBars.BarStaticItem itemPhienBan;
        private DevExpress.XtraBars.BarStaticItem btnDongTatCaTab;
        private DevExpress.XtraBars.BarStaticItem btnKhoaUngDung;
        private DevExpress.XtraBars.BarStaticItem itemTaiKhoan;
        private DevExpress.XtraBars.BarStaticItem itemNhomNguoiDung;
        private DevExpress.XtraBars.BarButtonItem btnXoaBoNho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTienIch;
        private DevExpress.XtraBars.BarStaticItem itemNienKhoa;
        private DevExpress.Utils.ImageCollection IMC;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgNguoiDung;
        private DevExpress.XtraBars.BarButtonItem btnNhanSu;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDonVi;
        private DevExpress.XtraBars.BarButtonItem btnNhapTuExcel;
    }
}

