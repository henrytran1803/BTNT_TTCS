﻿
namespace BTNT.View
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhamPha = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrienLam = new DevExpress.XtraBars.BarButtonItem();
            this.btnTPNT = new DevExpress.XtraBars.BarButtonItem();
            this.btnDieuKhac = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoiHoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhac = new DevExpress.XtraBars.BarButtonItem();
            this.btnBST = new DevExpress.XtraBars.BarButtonItem();
            this.btnMuon = new DevExpress.XtraBars.BarButtonItem();
            this.btnSoHuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnTacGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrienLamNgheThuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnCTCTL = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.rbpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpTrangChu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgTrangChu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpTPNT = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgTPNT = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgQLTP = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpTrienLam = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgTrienLam = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(60, 58, 60, 58);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnDangNhap,
            this.btnDangXuat,
            this.btnRestore,
            this.btnThoat,
            this.btnKhamPha,
            this.btnTrienLam,
            this.btnTPNT,
            this.btnDieuKhac,
            this.btnHoiHoa,
            this.btnKhac,
            this.btnBST,
            this.btnMuon,
            this.btnSoHuu,
            this.btnTacGia,
            this.btnTrienLamNgheThuat,
            this.btnCTCTL,
            this.btnQuyen});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 660;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpHeThong,
            this.rbpTrangChu,
            this.rbpTPNT,
            this.rbpTrienLam});
            this.ribbon.Size = new System.Drawing.Size(1664, 308);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.Image")));
            this.btnDangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.ImageOptions.LargeImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 2;
            this.btnDangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.Image")));
            this.btnDangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.ImageOptions.LargeImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Backup/ Restore";
            this.btnRestore.Id = 3;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTaoTk.ImageOptions.Image")));
            this.btnRestore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTaoTk.ImageOptions.LargeImage")));
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 4;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // btnKhamPha
            // 
            this.btnKhamPha.Caption = "Khám phá";
            this.btnKhamPha.Id = 5;
            this.btnKhamPha.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhamPha.ImageOptions.Image")));
            this.btnKhamPha.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhamPha.ImageOptions.LargeImage")));
            this.btnKhamPha.Name = "btnKhamPha";
            this.btnKhamPha.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhamPha_ItemClick);
            // 
            // btnTrienLam
            // 
            this.btnTrienLam.Caption = "Triển lãm";
            this.btnTrienLam.Id = 6;
            this.btnTrienLam.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTrienLam.ImageOptions.Image")));
            this.btnTrienLam.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTrienLam.ImageOptions.LargeImage")));
            this.btnTrienLam.Name = "btnTrienLam";
            this.btnTrienLam.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrienLam_ItemClick);
            // 
            // btnTPNT
            // 
            this.btnTPNT.Caption = "Tác phẩm";
            this.btnTPNT.Id = 7;
            this.btnTPNT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTPNT.ImageOptions.Image")));
            this.btnTPNT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTPNT.ImageOptions.LargeImage")));
            this.btnTPNT.Name = "btnTPNT";
            this.btnTPNT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTPNT_ItemClick);
            // 
            // btnDieuKhac
            // 
            this.btnDieuKhac.Caption = "Điêu khắc";
            this.btnDieuKhac.Id = 8;
            this.btnDieuKhac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDieuKhac.ImageOptions.Image")));
            this.btnDieuKhac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDieuKhac.ImageOptions.LargeImage")));
            this.btnDieuKhac.Name = "btnDieuKhac";
            this.btnDieuKhac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDieuKhac_ItemClick);
            // 
            // btnHoiHoa
            // 
            this.btnHoiHoa.Caption = "Hội hoạ";
            this.btnHoiHoa.Id = 9;
            this.btnHoiHoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoiHoa.ImageOptions.Image")));
            this.btnHoiHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHoiHoa.ImageOptions.LargeImage")));
            this.btnHoiHoa.Name = "btnHoiHoa";
            this.btnHoiHoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoiHoa_ItemClick);
            // 
            // btnKhac
            // 
            this.btnKhac.Caption = "Khác";
            this.btnKhac.Id = 10;
            this.btnKhac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhac.ImageOptions.Image")));
            this.btnKhac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhac.ImageOptions.LargeImage")));
            this.btnKhac.Name = "btnKhac";
            this.btnKhac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhac_ItemClick);
            // 
            // btnBST
            // 
            this.btnBST.Caption = "Bộ sưu tập";
            this.btnBST.Id = 11;
            this.btnBST.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBST.ImageOptions.Image")));
            this.btnBST.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBST.ImageOptions.LargeImage")));
            this.btnBST.Name = "btnBST";
            this.btnBST.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBST_ItemClick);
            // 
            // btnMuon
            // 
            this.btnMuon.Caption = "Mượn";
            this.btnMuon.Id = 12;
            this.btnMuon.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMuon.ImageOptions.Image")));
            this.btnMuon.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMuon.ImageOptions.LargeImage")));
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMuon_ItemClick);
            // 
            // btnSoHuu
            // 
            this.btnSoHuu.Caption = "Sở hữu";
            this.btnSoHuu.Id = 13;
            this.btnSoHuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSoHuu.ImageOptions.Image")));
            this.btnSoHuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSoHuu.ImageOptions.LargeImage")));
            this.btnSoHuu.Name = "btnSoHuu";
            this.btnSoHuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSoHuu_ItemClick);
            // 
            // btnTacGia
            // 
            this.btnTacGia.Caption = "Tác giả";
            this.btnTacGia.Id = 14;
            this.btnTacGia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTacGia.ImageOptions.Image")));
            this.btnTacGia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTacGia.ImageOptions.LargeImage")));
            this.btnTacGia.Name = "btnTacGia";
            this.btnTacGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTacGia_ItemClick);
            // 
            // btnTrienLamNgheThuat
            // 
            this.btnTrienLamNgheThuat.Caption = "Triển lãm";
            this.btnTrienLamNgheThuat.Id = 15;
            this.btnTrienLamNgheThuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTrienLamNgheThuat.ImageOptions.Image")));
            this.btnTrienLamNgheThuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTrienLamNgheThuat.ImageOptions.LargeImage")));
            this.btnTrienLamNgheThuat.Name = "btnTrienLamNgheThuat";
            this.btnTrienLamNgheThuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTrienLamNgheThuat_ItemClick);
            // 
            // btnCTCTL
            // 
            this.btnCTCTL.Caption = "Chi tiết cuộc triển lãm";
            this.btnCTCTL.Id = 16;
            this.btnCTCTL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCTCTL.ImageOptions.Image")));
            this.btnCTCTL.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCTCTL.ImageOptions.LargeImage")));
            this.btnCTCTL.Name = "btnCTCTL";
            this.btnCTCTL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCTCTL_ItemClick);
            // 
            // btnQuyen
            // 
            this.btnQuyen.Caption = "Người dùng";
            this.btnQuyen.Id = 17;
            this.btnQuyen.Name = "btnQuyen";
            // 
            // rbpHeThong
            // 
            this.rbpHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbpHeThong.Name = "rbpHeThong";
            this.rbpHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRestore);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // rbpTrangChu
            // 
            this.rbpTrangChu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgTrangChu});
            this.rbpTrangChu.Name = "rbpTrangChu";
            this.rbpTrangChu.Text = "Trang chủ";
            // 
            // rbpgTrangChu
            // 
            this.rbpgTrangChu.ItemLinks.Add(this.btnKhamPha);
            this.rbpgTrangChu.ItemLinks.Add(this.btnTrienLam);
            this.rbpgTrangChu.Name = "rbpgTrangChu";
            this.rbpgTrangChu.Text = "Trang chủ";
            // 
            // rbpTPNT
            // 
            this.rbpTPNT.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgTPNT,
            this.rbpgQLTP});
            this.rbpTPNT.Name = "rbpTPNT";
            this.rbpTPNT.Text = "Tác phẩm nghệ thuật";
            // 
            // rbpgTPNT
            // 
            this.rbpgTPNT.ItemLinks.Add(this.btnTPNT);
            this.rbpgTPNT.ItemLinks.Add(this.btnDieuKhac);
            this.rbpgTPNT.ItemLinks.Add(this.btnHoiHoa);
            this.rbpgTPNT.ItemLinks.Add(this.btnKhac);
            this.rbpgTPNT.ItemLinks.Add(this.btnTacGia);
            this.rbpgTPNT.Name = "rbpgTPNT";
            this.rbpgTPNT.Text = "Tác phẩm nghệ thuật";
            // 
            // rbpgQLTP
            // 
            this.rbpgQLTP.ItemLinks.Add(this.btnBST);
            this.rbpgQLTP.ItemLinks.Add(this.btnMuon);
            this.rbpgQLTP.ItemLinks.Add(this.btnSoHuu);
            this.rbpgQLTP.Name = "rbpgQLTP";
            this.rbpgQLTP.Text = "Quản lý tác phẩm";
            // 
            // rbpTrienLam
            // 
            this.rbpTrienLam.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgTrienLam});
            this.rbpTrienLam.Name = "rbpTrienLam";
            this.rbpTrienLam.Text = "Triển lãm";
            // 
            // rbpgTrienLam
            // 
            this.rbpgTrienLam.ItemLinks.Add(this.btnTrienLamNgheThuat);
            this.rbpgTrienLam.ItemLinks.Add(this.btnCTCTL);
            this.rbpgTrienLam.Name = "rbpgTrienLam";
            this.rbpgTrienLam.Text = "Triển lãm";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.btnQuyen);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 1331);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1664, 48);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 1379);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpTrangChu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgTrangChu;
        private DevExpress.XtraBars.BarButtonItem btnKhamPha;
        private DevExpress.XtraBars.BarButtonItem btnTrienLam;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpTPNT;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgTPNT;
        private DevExpress.XtraBars.BarButtonItem btnTPNT;
        private DevExpress.XtraBars.BarButtonItem btnDieuKhac;
        private DevExpress.XtraBars.BarButtonItem btnHoiHoa;
        private DevExpress.XtraBars.BarButtonItem btnKhac;
        private DevExpress.XtraBars.BarButtonItem btnBST;
        private DevExpress.XtraBars.BarButtonItem btnMuon;
        private DevExpress.XtraBars.BarButtonItem btnSoHuu;
        private DevExpress.XtraBars.BarButtonItem btnTacGia;
        private DevExpress.XtraBars.BarButtonItem btnTrienLamNgheThuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgQLTP;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpTrienLam;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgTrienLam;
        private DevExpress.XtraBars.BarButtonItem btnCTCTL;
        public DevExpress.XtraBars.BarButtonItem btnQuyen;
    }
}