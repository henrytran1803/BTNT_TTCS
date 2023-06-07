
namespace BTNT.Manager
{
    partial class FormKhac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhac));
            this.gbDSTPK = new System.Windows.Forms.GroupBox();
            this.dgDSPTK = new System.Windows.Forms.DataGridView();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.gbTT = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.lbAnh = new System.Windows.Forms.Label();
            this.cbbPC = new System.Windows.Forms.ComboBox();
            this.cbbTP = new System.Windows.Forms.ComboBox();
            this.lbPC = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.gbTPNT = new System.Windows.Forms.GroupBox();
            this.dgDSTPNT = new System.Windows.Forms.DataGridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTL = new System.Windows.Forms.ComboBox();
            this.gbDSTPK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSPTK)).BeginInit();
            this.gbTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.gbTPNT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTPNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDSTPK
            // 
            this.gbDSTPK.Controls.Add(this.dgDSPTK);
            this.gbDSTPK.Location = new System.Drawing.Point(0, 27);
            this.gbDSTPK.Name = "gbDSTPK";
            this.gbDSTPK.Size = new System.Drawing.Size(584, 244);
            this.gbDSTPK.TabIndex = 10;
            this.gbDSTPK.TabStop = false;
            this.gbDSTPK.Text = "Danh sách tác phẩm khác";
            // 
            // dgDSPTK
            // 
            this.dgDSPTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSPTK.Location = new System.Drawing.Point(-6, 23);
            this.dgDSPTK.Name = "dgDSPTK";
            this.dgDSPTK.Size = new System.Drawing.Size(584, 224);
            this.dgDSPTK.TabIndex = 0;
            this.dgDSPTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSPTK_CellContentClick);
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
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
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
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
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
            // gbTT
            // 
            this.gbTT.Controls.Add(this.cbbTL);
            this.gbTT.Controls.Add(this.label1);
            this.gbTT.Controls.Add(this.pictureBox);
            this.gbTT.Controls.Add(this.tbUrl);
            this.gbTT.Controls.Add(this.btnChonHinh);
            this.gbTT.Controls.Add(this.lbAnh);
            this.gbTT.Controls.Add(this.cbbPC);
            this.gbTT.Controls.Add(this.cbbTP);
            this.gbTT.Controls.Add(this.lbPC);
            this.gbTT.Controls.Add(this.lbMa);
            this.gbTT.Controls.Add(this.btnChon);
            this.gbTT.Location = new System.Drawing.Point(0, 280);
            this.gbTT.Name = "gbTT";
            this.gbTT.Size = new System.Drawing.Size(870, 204);
            this.gbTT.TabIndex = 12;
            this.gbTT.TabStop = false;
            this.gbTT.Text = "Thông tin";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(444, 78);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(140, 114);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 18;
            this.pictureBox.TabStop = false;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(96, 99);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(180, 21);
            this.tbUrl.TabIndex = 14;
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(282, 97);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(75, 23);
            this.btnChonHinh.TabIndex = 13;
            this.btnChonHinh.Text = "Chọn hình";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // lbAnh
            // 
            this.lbAnh.AutoSize = true;
            this.lbAnh.Location = new System.Drawing.Point(24, 107);
            this.lbAnh.Name = "lbAnh";
            this.lbAnh.Size = new System.Drawing.Size(30, 13);
            this.lbAnh.TabIndex = 12;
            this.lbAnh.Text = "Ảnh:";
            // 
            // cbbPC
            // 
            this.cbbPC.FormattingEnabled = true;
            this.cbbPC.Location = new System.Drawing.Point(444, 35);
            this.cbbPC.Name = "cbbPC";
            this.cbbPC.Size = new System.Drawing.Size(261, 21);
            this.cbbPC.TabIndex = 8;
            this.cbbPC.SelectedIndexChanged += new System.EventHandler(this.cbbPC_SelectedIndexChanged);
            // 
            // cbbTP
            // 
            this.cbbTP.FormattingEnabled = true;
            this.cbbTP.Location = new System.Drawing.Point(96, 35);
            this.cbbTP.Name = "cbbTP";
            this.cbbTP.Size = new System.Drawing.Size(261, 21);
            this.cbbTP.TabIndex = 5;
            // 
            // lbPC
            // 
            this.lbPC.AutoSize = true;
            this.lbPC.Location = new System.Drawing.Point(372, 43);
            this.lbPC.Name = "lbPC";
            this.lbPC.Size = new System.Drawing.Size(66, 13);
            this.lbPC.TabIndex = 3;
            this.lbPC.Text = "Phong cách:";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(24, 43);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(72, 13);
            this.lbMa.TabIndex = 1;
            this.lbMa.Text = "Mã tác phẩm:";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(746, 35);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(112, 157);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
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
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // gbTPNT
            // 
            this.gbTPNT.Controls.Add(this.dgDSTPNT);
            this.gbTPNT.Location = new System.Drawing.Point(602, 30);
            this.gbTPNT.Name = "gbTPNT";
            this.gbTPNT.Size = new System.Drawing.Size(268, 244);
            this.gbTPNT.TabIndex = 11;
            this.gbTPNT.TabStop = false;
            this.gbTPNT.Text = "Danh sách tác phẩm nghệ thuật";
            // 
            // dgDSTPNT
            // 
            this.dgDSTPNT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSTPNT.Location = new System.Drawing.Point(0, 20);
            this.dgDSTPNT.Name = "dgDSTPNT";
            this.dgDSTPNT.Size = new System.Drawing.Size(268, 224);
            this.dgDSTPNT.TabIndex = 1;
            this.dgDSTPNT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSTPNT_CellContentClick);
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(870, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 466);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(870, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 421);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(870, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 421);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Thể loại:";
            // 
            // cbbTL
            // 
            this.cbbTL.FormattingEnabled = true;
            this.cbbTL.Location = new System.Drawing.Point(96, 70);
            this.cbbTL.Name = "cbbTL";
            this.cbbTL.Size = new System.Drawing.Size(261, 21);
            this.cbbTL.TabIndex = 20;
            // 
            // FormKhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 486);
            this.Controls.Add(this.gbDSTPK);
            this.Controls.Add(this.gbTT);
            this.Controls.Add(this.gbTPNT);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormKhac";
            this.Text = "Tác phẩm khác";
            this.Load += new System.EventHandler(this.FormKhac_Load);
            this.gbDSTPK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSPTK)).EndInit();
            this.gbTT.ResumeLayout(false);
            this.gbTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.gbTPNT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTPNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDSTPK;
        private System.Windows.Forms.DataGridView dgDSPTK;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private System.Windows.Forms.GroupBox gbTT;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.Label lbAnh;
        private System.Windows.Forms.ComboBox cbbPC;
        private System.Windows.Forms.ComboBox cbbTP;
        private System.Windows.Forms.Label lbPC;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Button btnChon;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.GroupBox gbTPNT;
        private System.Windows.Forms.DataGridView dgDSTPNT;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox cbbTL;
        private System.Windows.Forms.Label label1;
    }
}