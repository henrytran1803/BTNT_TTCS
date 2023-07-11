
namespace BTNT.Manager
{
    partial class FormTPNT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTPNT));
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
            this.gbDSTPNT = new System.Windows.Forms.GroupBox();
            this.dgDSTPNT = new System.Windows.Forms.DataGridView();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.tbDienGiai = new System.Windows.Forms.TextBox();
            this.lbDienGiai = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.tbNam = new System.Windows.Forms.TextBox();
            this.cbbCD = new System.Windows.Forms.ComboBox();
            this.cbbQT = new System.Windows.Forms.ComboBox();
            this.cbbTD = new System.Windows.Forms.ComboBox();
            this.cbbTacGia = new System.Windows.Forms.ComboBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.lbQT = new System.Windows.Forms.Label();
            this.lbTD = new System.Windows.Forms.Label();
            this.lbTacGia = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbCD = new System.Windows.Forms.Label();
            this.lbNam = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.gbDSTPNT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTPNT)).BeginInit();
            this.gbThongTin.SuspendLayout();
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.barDockControlTop.Size = new System.Drawing.Size(1550, 68);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 830);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.barDockControlBottom.Size = new System.Drawing.Size(1550, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 68);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 762);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1550, 68);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 762);
            // 
            // gbDSTPNT
            // 
            this.gbDSTPNT.Controls.Add(this.dgDSTPNT);
            this.gbDSTPNT.Location = new System.Drawing.Point(0, 52);
            this.gbDSTPNT.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDSTPNT.Name = "gbDSTPNT";
            this.gbDSTPNT.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbDSTPNT.Size = new System.Drawing.Size(1550, 423);
            this.gbDSTPNT.TabIndex = 4;
            this.gbDSTPNT.TabStop = false;
            this.gbDSTPNT.Text = "Tẩm phẩm nghệ thuật";
            // 
            // dgDSTPNT
            // 
            this.dgDSTPNT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSTPNT.Location = new System.Drawing.Point(0, 38);
            this.dgDSTPNT.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgDSTPNT.Name = "dgDSTPNT";
            this.dgDSTPNT.RowHeadersWidth = 82;
            this.dgDSTPNT.Size = new System.Drawing.Size(1550, 385);
            this.dgDSTPNT.TabIndex = 0;
            this.dgDSTPNT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSTPNT_CellContentClick);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.tbDienGiai);
            this.gbThongTin.Controls.Add(this.lbDienGiai);
            this.gbThongTin.Controls.Add(this.btnChon);
            this.gbThongTin.Controls.Add(this.tbNam);
            this.gbThongTin.Controls.Add(this.cbbCD);
            this.gbThongTin.Controls.Add(this.cbbQT);
            this.gbThongTin.Controls.Add(this.cbbTD);
            this.gbThongTin.Controls.Add(this.cbbTacGia);
            this.gbThongTin.Controls.Add(this.tbTen);
            this.gbThongTin.Controls.Add(this.tbMa);
            this.gbThongTin.Controls.Add(this.lbQT);
            this.gbThongTin.Controls.Add(this.lbTD);
            this.gbThongTin.Controls.Add(this.lbTacGia);
            this.gbThongTin.Controls.Add(this.lbTen);
            this.gbThongTin.Controls.Add(this.lbCD);
            this.gbThongTin.Controls.Add(this.lbNam);
            this.gbThongTin.Controls.Add(this.lbMa);
            this.gbThongTin.Location = new System.Drawing.Point(0, 487);
            this.gbThongTin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbThongTin.Size = new System.Drawing.Size(1550, 365);
            this.gbThongTin.TabIndex = 5;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin";
            this.gbThongTin.Enter += new System.EventHandler(this.gbThongTin_Enter);
            // 
            // tbDienGiai
            // 
            this.tbDienGiai.Location = new System.Drawing.Point(654, 208);
            this.tbDienGiai.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbDienGiai.Name = "tbDienGiai";
            this.tbDienGiai.Size = new System.Drawing.Size(298, 33);
            this.tbDienGiai.TabIndex = 16;
            // 
            // lbDienGiai
            // 
            this.lbDienGiai.AutoSize = true;
            this.lbDienGiai.Location = new System.Drawing.Point(528, 223);
            this.lbDienGiai.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDienGiai.Name = "lbDienGiai";
            this.lbDienGiai.Size = new System.Drawing.Size(101, 25);
            this.lbDienGiai.TabIndex = 15;
            this.lbDienGiai.Text = "Diễn giải:";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(1136, 231);
            this.btnChon.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(212, 85);
            this.btnChon.TabIndex = 14;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // tbNam
            // 
            this.tbNam.Location = new System.Drawing.Point(164, 127);
            this.tbNam.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbNam.Name = "tbNam";
            this.tbNam.Size = new System.Drawing.Size(348, 33);
            this.tbNam.TabIndex = 13;
            // 
            // cbbCD
            // 
            this.cbbCD.FormattingEnabled = true;
            this.cbbCD.Location = new System.Drawing.Point(164, 208);
            this.cbbCD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbbCD.Name = "cbbCD";
            this.cbbCD.Size = new System.Drawing.Size(348, 33);
            this.cbbCD.TabIndex = 12;
            // 
            // cbbQT
            // 
            this.cbbQT.FormattingEnabled = true;
            this.cbbQT.Location = new System.Drawing.Point(1086, 127);
            this.cbbQT.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbbQT.Name = "cbbQT";
            this.cbbQT.Size = new System.Drawing.Size(298, 33);
            this.cbbQT.TabIndex = 11;
            // 
            // cbbTD
            // 
            this.cbbTD.FormattingEnabled = true;
            this.cbbTD.Location = new System.Drawing.Point(654, 127);
            this.cbbTD.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbbTD.Name = "cbbTD";
            this.cbbTD.Size = new System.Drawing.Size(298, 33);
            this.cbbTD.TabIndex = 10;
            this.cbbTD.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbbTacGia
            // 
            this.cbbTacGia.FormattingEnabled = true;
            this.cbbTacGia.Location = new System.Drawing.Point(1082, 50);
            this.cbbTacGia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbbTacGia.Name = "cbbTacGia";
            this.cbbTacGia.Size = new System.Drawing.Size(298, 33);
            this.cbbTacGia.TabIndex = 9;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(654, 50);
            this.tbTen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(298, 33);
            this.tbTen.TabIndex = 8;
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(164, 50);
            this.tbMa.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(348, 33);
            this.tbMa.TabIndex = 7;
            // 
            // lbQT
            // 
            this.lbQT.AutoSize = true;
            this.lbQT.Location = new System.Drawing.Point(968, 142);
            this.lbQT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbQT.Name = "lbQT";
            this.lbQT.Size = new System.Drawing.Size(102, 25);
            this.lbQT.TabIndex = 6;
            this.lbQT.Text = "Quốc gia:";
            // 
            // lbTD
            // 
            this.lbTD.AutoSize = true;
            this.lbTD.Location = new System.Drawing.Point(528, 142);
            this.lbTD.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTD.Name = "lbTD";
            this.lbTD.Size = new System.Drawing.Size(95, 25);
            this.lbTD.TabIndex = 5;
            this.lbTD.Text = "Thời đại:";
            // 
            // lbTacGia
            // 
            this.lbTacGia.AutoSize = true;
            this.lbTacGia.Location = new System.Drawing.Point(968, 65);
            this.lbTacGia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTacGia.Name = "lbTacGia";
            this.lbTacGia.Size = new System.Drawing.Size(87, 25);
            this.lbTacGia.TabIndex = 4;
            this.lbTacGia.Text = "Tác giả:";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(528, 65);
            this.lbTen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(54, 25);
            this.lbTen.TabIndex = 3;
            this.lbTen.Text = "Tên:";
            // 
            // lbCD
            // 
            this.lbCD.AutoSize = true;
            this.lbCD.Location = new System.Drawing.Point(44, 223);
            this.lbCD.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCD.Name = "lbCD";
            this.lbCD.Size = new System.Drawing.Size(86, 25);
            this.lbCD.TabIndex = 2;
            this.lbCD.Text = "Chủ đề:";
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Location = new System.Drawing.Point(44, 142);
            this.lbNam.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(62, 25);
            this.lbNam.TabIndex = 1;
            this.lbNam.Text = "Năm:";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(44, 65);
            this.lbMa.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(46, 25);
            this.lbMa.TabIndex = 0;
            this.lbMa.Text = "Mã:";
            // 
            // FormTPNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 852);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.gbDSTPNT);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormTPNT";
            this.Text = "Tác phẩm nghệ thuật";
            this.Load += new System.EventHandler(this.FormTPNT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.gbDSTPNT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTPNT)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
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
        private System.Windows.Forms.ComboBox cbbTD;
        private System.Windows.Forms.ComboBox cbbTacGia;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.Label lbQT;
        private System.Windows.Forms.Label lbTD;
        private System.Windows.Forms.Label lbTacGia;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbCD;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.GroupBox gbDSTPNT;
        private System.Windows.Forms.DataGridView dgDSTPNT;
        private System.Windows.Forms.TextBox tbNam;
        private System.Windows.Forms.ComboBox cbbCD;
        private System.Windows.Forms.ComboBox cbbQT;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox tbDienGiai;
        private System.Windows.Forms.Label lbDienGiai;
    }
}