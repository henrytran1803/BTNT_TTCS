
namespace BTNT.Manager
{
    partial class FormTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTacGia));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bgDSTacGia = new System.Windows.Forms.GroupBox();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.dgDSTacGia = new System.Windows.Forms.DataGridView();
            this.lbMa = new System.Windows.Forms.Label();
            this.lbHo = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.lbNgayMat = new System.Windows.Forms.Label();
            this.lbQuocTich = new System.Windows.Forms.Label();
            this.lbThoiDai = new System.Windows.Forms.Label();
            this.lbPhongCach = new System.Windows.Forms.Label();
            this.lbDienGiai = new System.Windows.Forms.Label();
            this.cbbThoiDai = new System.Windows.Forms.ComboBox();
            this.cbbPhongCach = new System.Windows.Forms.ComboBox();
            this.cbbQuocTich = new System.Windows.Forms.ComboBox();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbHo = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbDienGiai = new System.Windows.Forms.TextBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.tbNgayS = new System.Windows.Forms.TextBox();
            this.tbThangS = new System.Windows.Forms.TextBox();
            this.tbNamS = new System.Windows.Forms.TextBox();
            this.tbNamM = new System.Windows.Forms.TextBox();
            this.tbThangM = new System.Windows.Forms.TextBox();
            this.tbNgayM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.bgDSTacGia.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnHoanTac,
            this.btnReload,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "Hoàn tác";
            this.btnHoanTac.Id = 3;
            this.btnHoanTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.Image")));
            this.btnHoanTac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.LargeImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoanTac_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(802, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 460);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(802, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 415);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(802, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 415);
            // 
            // bgDSTacGia
            // 
            this.bgDSTacGia.Controls.Add(this.dgDSTacGia);
            this.bgDSTacGia.Location = new System.Drawing.Point(0, 30);
            this.bgDSTacGia.Name = "bgDSTacGia";
            this.bgDSTacGia.Size = new System.Drawing.Size(802, 214);
            this.bgDSTacGia.TabIndex = 4;
            this.bgDSTacGia.TabStop = false;
            this.bgDSTacGia.Text = "Danh sách tác giả";
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.label3);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.tbNamM);
            this.gbThongTin.Controls.Add(this.tbThangM);
            this.gbThongTin.Controls.Add(this.tbNgayM);
            this.gbThongTin.Controls.Add(this.tbNamS);
            this.gbThongTin.Controls.Add(this.tbThangS);
            this.gbThongTin.Controls.Add(this.tbNgayS);
            this.gbThongTin.Controls.Add(this.btnChon);
            this.gbThongTin.Controls.Add(this.tbDienGiai);
            this.gbThongTin.Controls.Add(this.tbTen);
            this.gbThongTin.Controls.Add(this.tbHo);
            this.gbThongTin.Controls.Add(this.tbMa);
            this.gbThongTin.Controls.Add(this.cbbQuocTich);
            this.gbThongTin.Controls.Add(this.cbbPhongCach);
            this.gbThongTin.Controls.Add(this.cbbThoiDai);
            this.gbThongTin.Controls.Add(this.lbDienGiai);
            this.gbThongTin.Controls.Add(this.lbPhongCach);
            this.gbThongTin.Controls.Add(this.lbThoiDai);
            this.gbThongTin.Controls.Add(this.lbQuocTich);
            this.gbThongTin.Controls.Add(this.lbNgayMat);
            this.gbThongTin.Controls.Add(this.lbNgaySinh);
            this.gbThongTin.Controls.Add(this.lbTen);
            this.gbThongTin.Controls.Add(this.lbHo);
            this.gbThongTin.Controls.Add(this.lbMa);
            this.gbThongTin.Location = new System.Drawing.Point(0, 250);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(802, 230);
            this.gbThongTin.TabIndex = 5;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin";
            // 
            // dgDSTacGia
            // 
            this.dgDSTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSTacGia.Location = new System.Drawing.Point(0, 20);
            this.dgDSTacGia.Name = "dgDSTacGia";
            this.dgDSTacGia.Size = new System.Drawing.Size(802, 194);
            this.dgDSTacGia.TabIndex = 0;
            this.dgDSTacGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSTacGia_CellContentClick);
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(12, 39);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(63, 13);
            this.lbMa.TabIndex = 0;
            this.lbMa.Text = "Mã tác giả: ";
            // 
            // lbHo
            // 
            this.lbHo.AutoSize = true;
            this.lbHo.Location = new System.Drawing.Point(276, 39);
            this.lbHo.Name = "lbHo";
            this.lbHo.Size = new System.Drawing.Size(24, 13);
            this.lbHo.TabIndex = 1;
            this.lbHo.Text = "Họ:";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(552, 39);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(29, 13);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "Tên:";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(12, 98);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(58, 13);
            this.lbNgaySinh.TabIndex = 3;
            this.lbNgaySinh.Text = "Ngày sinh:";
            // 
            // lbNgayMat
            // 
            this.lbNgayMat.AutoSize = true;
            this.lbNgayMat.Location = new System.Drawing.Point(276, 98);
            this.lbNgayMat.Name = "lbNgayMat";
            this.lbNgayMat.Size = new System.Drawing.Size(57, 13);
            this.lbNgayMat.TabIndex = 4;
            this.lbNgayMat.Text = "Ngày mất:";
            // 
            // lbQuocTich
            // 
            this.lbQuocTich.AutoSize = true;
            this.lbQuocTich.Location = new System.Drawing.Point(552, 98);
            this.lbQuocTich.Name = "lbQuocTich";
            this.lbQuocTich.Size = new System.Drawing.Size(56, 13);
            this.lbQuocTich.TabIndex = 5;
            this.lbQuocTich.Text = "Quốc tịch:";
            // 
            // lbThoiDai
            // 
            this.lbThoiDai.AutoSize = true;
            this.lbThoiDai.Location = new System.Drawing.Point(12, 160);
            this.lbThoiDai.Name = "lbThoiDai";
            this.lbThoiDai.Size = new System.Drawing.Size(48, 13);
            this.lbThoiDai.TabIndex = 6;
            this.lbThoiDai.Text = "Thời đại:";
            // 
            // lbPhongCach
            // 
            this.lbPhongCach.AutoSize = true;
            this.lbPhongCach.Location = new System.Drawing.Point(276, 160);
            this.lbPhongCach.Name = "lbPhongCach";
            this.lbPhongCach.Size = new System.Drawing.Size(66, 13);
            this.lbPhongCach.TabIndex = 7;
            this.lbPhongCach.Text = "Phong cách:";
            // 
            // lbDienGiai
            // 
            this.lbDienGiai.AutoSize = true;
            this.lbDienGiai.Location = new System.Drawing.Point(552, 160);
            this.lbDienGiai.Name = "lbDienGiai";
            this.lbDienGiai.Size = new System.Drawing.Size(51, 13);
            this.lbDienGiai.TabIndex = 8;
            this.lbDienGiai.Text = "Diễn giải:";
            // 
            // cbbThoiDai
            // 
            this.cbbThoiDai.FormattingEnabled = true;
            this.cbbThoiDai.Location = new System.Drawing.Point(74, 152);
            this.cbbThoiDai.Name = "cbbThoiDai";
            this.cbbThoiDai.Size = new System.Drawing.Size(196, 21);
            this.cbbThoiDai.TabIndex = 11;
            // 
            // cbbPhongCach
            // 
            this.cbbPhongCach.FormattingEnabled = true;
            this.cbbPhongCach.Location = new System.Drawing.Point(339, 152);
            this.cbbPhongCach.Name = "cbbPhongCach";
            this.cbbPhongCach.Size = new System.Drawing.Size(196, 21);
            this.cbbPhongCach.TabIndex = 12;
            // 
            // cbbQuocTich
            // 
            this.cbbQuocTich.FormattingEnabled = true;
            this.cbbQuocTich.Location = new System.Drawing.Point(606, 92);
            this.cbbQuocTich.Name = "cbbQuocTich";
            this.cbbQuocTich.Size = new System.Drawing.Size(196, 21);
            this.cbbQuocTich.TabIndex = 13;
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(74, 31);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(196, 21);
            this.tbMa.TabIndex = 14;
            // 
            // tbHo
            // 
            this.tbHo.Location = new System.Drawing.Point(339, 36);
            this.tbHo.Name = "tbHo";
            this.tbHo.Size = new System.Drawing.Size(196, 21);
            this.tbHo.TabIndex = 15;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(606, 36);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(196, 21);
            this.tbTen.TabIndex = 16;
            // 
            // tbDienGiai
            // 
            this.tbDienGiai.Location = new System.Drawing.Point(606, 152);
            this.tbDienGiai.Name = "tbDienGiai";
            this.tbDienGiai.Size = new System.Drawing.Size(196, 21);
            this.tbDienGiai.TabIndex = 17;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(333, 197);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(202, 27);
            this.btnChon.TabIndex = 18;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // tbNgayS
            // 
            this.tbNgayS.Location = new System.Drawing.Point(74, 90);
            this.tbNgayS.Name = "tbNgayS";
            this.tbNgayS.Size = new System.Drawing.Size(42, 21);
            this.tbNgayS.TabIndex = 19;
            // 
            // tbThangS
            // 
            this.tbThangS.Location = new System.Drawing.Point(140, 90);
            this.tbThangS.Name = "tbThangS";
            this.tbThangS.Size = new System.Drawing.Size(42, 21);
            this.tbThangS.TabIndex = 20;
            // 
            // tbNamS
            // 
            this.tbNamS.Location = new System.Drawing.Point(206, 90);
            this.tbNamS.Name = "tbNamS";
            this.tbNamS.Size = new System.Drawing.Size(64, 21);
            this.tbNamS.TabIndex = 21;
            // 
            // tbNamM
            // 
            this.tbNamM.Location = new System.Drawing.Point(474, 92);
            this.tbNamM.Name = "tbNamM";
            this.tbNamM.Size = new System.Drawing.Size(64, 21);
            this.tbNamM.TabIndex = 24;
            // 
            // tbThangM
            // 
            this.tbThangM.Location = new System.Drawing.Point(408, 92);
            this.tbThangM.Name = "tbThangM";
            this.tbThangM.Size = new System.Drawing.Size(42, 21);
            this.tbThangM.TabIndex = 23;
            // 
            // tbNgayM
            // 
            this.tbNgayM.Location = new System.Drawing.Point(342, 92);
            this.tbNgayM.Name = "tbNgayM";
            this.tbNgayM.Size = new System.Drawing.Size(42, 21);
            this.tbNgayM.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "/";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(390, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "/";
            // 
            // FormTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 480);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.bgDSTacGia);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormTacGia";
            this.Text = "FormTacGia";
            this.Load += new System.EventHandler(this.FormTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.bgDSTacGia.ResumeLayout(false);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox tbDienGiai;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbHo;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.ComboBox cbbQuocTich;
        private System.Windows.Forms.ComboBox cbbPhongCach;
        private System.Windows.Forms.ComboBox cbbThoiDai;
        private System.Windows.Forms.Label lbDienGiai;
        private System.Windows.Forms.Label lbPhongCach;
        private System.Windows.Forms.Label lbThoiDai;
        private System.Windows.Forms.Label lbQuocTich;
        private System.Windows.Forms.Label lbNgayMat;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbHo;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.GroupBox bgDSTacGia;
        private System.Windows.Forms.DataGridView dgDSTacGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNamM;
        private System.Windows.Forms.TextBox tbThangM;
        private System.Windows.Forms.TextBox tbNgayM;
        private System.Windows.Forms.TextBox tbNamS;
        private System.Windows.Forms.TextBox tbThangS;
        private System.Windows.Forms.TextBox tbNgayS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}