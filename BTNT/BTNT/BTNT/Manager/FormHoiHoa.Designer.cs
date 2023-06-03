
namespace BTNT.Manager
{
    partial class FormHoiHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoiHoa));
            this.lbTP = new System.Windows.Forms.Label();
            this.cbbVL = new System.Windows.Forms.ComboBox();
            this.cbbCL = new System.Windows.Forms.ComboBox();
            this.cbbTP = new System.Windows.Forms.ComboBox();
            this.lbVL = new System.Windows.Forms.Label();
            this.lbCL = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.gbTT = new System.Windows.Forms.GroupBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.dgDSTPNT = new System.Windows.Forms.DataGridView();
            this.gbTPNT = new System.Windows.Forms.GroupBox();
            this.dgDSPTHH = new System.Windows.Forms.DataGridView();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
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
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gbDSTPHH = new System.Windows.Forms.GroupBox();
            this.cbbTruongPhai = new System.Windows.Forms.ComboBox();
            this.gbTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTPNT)).BeginInit();
            this.gbTPNT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSPTHH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.gbDSTPHH.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTP
            // 
            this.lbTP.AutoSize = true;
            this.lbTP.Location = new System.Drawing.Point(369, 100);
            this.lbTP.Name = "lbTP";
            this.lbTP.Size = new System.Drawing.Size(69, 13);
            this.lbTP.TabIndex = 10;
            this.lbTP.Text = "Trường phái:";
            // 
            // cbbVL
            // 
            this.cbbVL.FormattingEnabled = true;
            this.cbbVL.Location = new System.Drawing.Point(444, 35);
            this.cbbVL.Name = "cbbVL";
            this.cbbVL.Size = new System.Drawing.Size(261, 21);
            this.cbbVL.TabIndex = 8;
            // 
            // cbbCL
            // 
            this.cbbCL.FormattingEnabled = true;
            this.cbbCL.Location = new System.Drawing.Point(96, 92);
            this.cbbCL.Name = "cbbCL";
            this.cbbCL.Size = new System.Drawing.Size(261, 21);
            this.cbbCL.TabIndex = 6;
            // 
            // cbbTP
            // 
            this.cbbTP.FormattingEnabled = true;
            this.cbbTP.Location = new System.Drawing.Point(96, 35);
            this.cbbTP.Name = "cbbTP";
            this.cbbTP.Size = new System.Drawing.Size(261, 21);
            this.cbbTP.TabIndex = 5;
            // 
            // lbVL
            // 
            this.lbVL.AutoSize = true;
            this.lbVL.Location = new System.Drawing.Point(369, 43);
            this.lbVL.Name = "lbVL";
            this.lbVL.Size = new System.Drawing.Size(46, 13);
            this.lbVL.TabIndex = 3;
            this.lbVL.Text = "Vật liệu:";
            // 
            // lbCL
            // 
            this.lbCL.AutoSize = true;
            this.lbCL.Location = new System.Drawing.Point(24, 100);
            this.lbCL.Name = "lbCL";
            this.lbCL.Size = new System.Drawing.Size(53, 13);
            this.lbCL.TabIndex = 2;
            this.lbCL.Text = "Chất liệu:";
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
            // gbTT
            // 
            this.gbTT.Controls.Add(this.cbbTruongPhai);
            this.gbTT.Controls.Add(this.lbTP);
            this.gbTT.Controls.Add(this.cbbVL);
            this.gbTT.Controls.Add(this.cbbCL);
            this.gbTT.Controls.Add(this.cbbTP);
            this.gbTT.Controls.Add(this.lbVL);
            this.gbTT.Controls.Add(this.lbCL);
            this.gbTT.Controls.Add(this.lbMa);
            this.gbTT.Controls.Add(this.btnChon);
            this.gbTT.Location = new System.Drawing.Point(0, 283);
            this.gbTT.Name = "gbTT";
            this.gbTT.Size = new System.Drawing.Size(870, 204);
            this.gbTT.TabIndex = 9;
            this.gbTT.TabStop = false;
            this.gbTT.Text = "Thông tin";
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
            // dgDSTPNT
            // 
            this.dgDSTPNT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSTPNT.Location = new System.Drawing.Point(0, 20);
            this.dgDSTPNT.Name = "dgDSTPNT";
            this.dgDSTPNT.Size = new System.Drawing.Size(268, 224);
            this.dgDSTPNT.TabIndex = 1;
            this.dgDSTPNT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSTPNT_CellContentClick);
            // 
            // gbTPNT
            // 
            this.gbTPNT.Controls.Add(this.dgDSTPNT);
            this.gbTPNT.Location = new System.Drawing.Point(603, 28);
            this.gbTPNT.Name = "gbTPNT";
            this.gbTPNT.Size = new System.Drawing.Size(268, 244);
            this.gbTPNT.TabIndex = 8;
            this.gbTPNT.TabStop = false;
            this.gbTPNT.Text = "Danh sách tác phẩm nghệ thuật";
            // 
            // dgDSPTHH
            // 
            this.dgDSPTHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSPTHH.Location = new System.Drawing.Point(-6, 23);
            this.dgDSPTHH.Name = "dgDSPTHH";
            this.dgDSPTHH.Size = new System.Drawing.Size(584, 224);
            this.dgDSPTHH.TabIndex = 0;
            this.dgDSPTHH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSPTHH_CellContentClick);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 422);
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
            this.barDockControlTop.Size = new System.Drawing.Size(871, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 467);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(871, 20);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(871, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 422);
            // 
            // gbDSTPHH
            // 
            this.gbDSTPHH.Controls.Add(this.dgDSPTHH);
            this.gbDSTPHH.Location = new System.Drawing.Point(0, 25);
            this.gbDSTPHH.Name = "gbDSTPHH";
            this.gbDSTPHH.Size = new System.Drawing.Size(584, 244);
            this.gbDSTPHH.TabIndex = 7;
            this.gbDSTPHH.TabStop = false;
            this.gbDSTPHH.Text = "Danh sách tác phẩm hội hoạ";
            // 
            // cbbTruongPhai
            // 
            this.cbbTruongPhai.FormattingEnabled = true;
            this.cbbTruongPhai.Location = new System.Drawing.Point(444, 92);
            this.cbbTruongPhai.Name = "cbbTruongPhai";
            this.cbbTruongPhai.Size = new System.Drawing.Size(261, 21);
            this.cbbTruongPhai.TabIndex = 11;
            // 
            // FormHoiHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 487);
            this.Controls.Add(this.gbTT);
            this.Controls.Add(this.gbTPNT);
            this.Controls.Add(this.gbDSTPHH);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormHoiHoa";
            this.Text = "FormHoiHoa";
            this.Load += new System.EventHandler(this.FormHoiHoa_Load);
            this.gbTT.ResumeLayout(false);
            this.gbTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTPNT)).EndInit();
            this.gbTPNT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSPTHH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.gbDSTPHH.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTP;
        private System.Windows.Forms.ComboBox cbbVL;
        private System.Windows.Forms.ComboBox cbbCL;
        private System.Windows.Forms.ComboBox cbbTP;
        private System.Windows.Forms.Label lbVL;
        private System.Windows.Forms.Label lbCL;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.GroupBox gbTT;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.DataGridView dgDSTPNT;
        private System.Windows.Forms.GroupBox gbTPNT;
        private System.Windows.Forms.DataGridView dgDSPTHH;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
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
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.GroupBox gbDSTPHH;
        private System.Windows.Forms.ComboBox cbbTruongPhai;
    }
}