
namespace BTNT.Manager
{
    partial class FormCTCTL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCTCTL));
            this.dgDSCTL = new System.Windows.Forms.DataGridView();
            this.gbTT = new System.Windows.Forms.GroupBox();
            this.tbTP = new System.Windows.Forms.TextBox();
            this.tbCTL = new System.Windows.Forms.TextBox();
            this.lbTP = new System.Windows.Forms.Label();
            this.lbBST = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.gbTPNT = new System.Windows.Forms.GroupBox();
            this.dgDSTPNT = new System.Windows.Forms.DataGridView();
            this.gbDSCTL = new System.Windows.Forms.GroupBox();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
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
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cbbCTL = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSCTL)).BeginInit();
            this.gbTT.SuspendLayout();
            this.gbTPNT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTPNT)).BeginInit();
            this.gbDSCTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDSCTL
            // 
            this.dgDSCTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSCTL.Location = new System.Drawing.Point(-6, 23);
            this.dgDSCTL.Name = "dgDSCTL";
            this.dgDSCTL.Size = new System.Drawing.Size(590, 331);
            this.dgDSCTL.TabIndex = 0;
            this.dgDSCTL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSCTL_CellContentClick);
            // 
            // gbTT
            // 
            this.gbTT.Controls.Add(this.tbTP);
            this.gbTT.Controls.Add(this.tbCTL);
            this.gbTT.Controls.Add(this.lbTP);
            this.gbTT.Controls.Add(this.lbBST);
            this.gbTT.Controls.Add(this.btnChon);
            this.gbTT.Location = new System.Drawing.Point(0, 411);
            this.gbTT.Name = "gbTT";
            this.gbTT.Size = new System.Drawing.Size(870, 112);
            this.gbTT.TabIndex = 19;
            this.gbTT.TabStop = false;
            this.gbTT.Text = "Thông tin";
            // 
            // tbTP
            // 
            this.tbTP.Location = new System.Drawing.Point(448, 35);
            this.tbTP.Name = "tbTP";
            this.tbTP.Size = new System.Drawing.Size(228, 21);
            this.tbTP.TabIndex = 5;
            // 
            // tbCTL
            // 
            this.tbCTL.Location = new System.Drawing.Point(109, 35);
            this.tbCTL.Name = "tbCTL";
            this.tbCTL.Size = new System.Drawing.Size(222, 21);
            this.tbCTL.TabIndex = 4;
            // 
            // lbTP
            // 
            this.lbTP.AutoSize = true;
            this.lbTP.Location = new System.Drawing.Point(366, 43);
            this.lbTP.Name = "lbTP";
            this.lbTP.Size = new System.Drawing.Size(57, 13);
            this.lbTP.TabIndex = 3;
            this.lbTP.Text = "Tác phẩm:";
            // 
            // lbBST
            // 
            this.lbBST.AutoSize = true;
            this.lbBST.Location = new System.Drawing.Point(24, 43);
            this.lbBST.Name = "lbBST";
            this.lbBST.Size = new System.Drawing.Size(79, 13);
            this.lbBST.TabIndex = 1;
            this.lbBST.Text = "Cuộc triển lãm:";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(748, 20);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(112, 69);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // gbTPNT
            // 
            this.gbTPNT.Controls.Add(this.dgDSTPNT);
            this.gbTPNT.Location = new System.Drawing.Point(603, 51);
            this.gbTPNT.Name = "gbTPNT";
            this.gbTPNT.Size = new System.Drawing.Size(268, 354);
            this.gbTPNT.TabIndex = 18;
            this.gbTPNT.TabStop = false;
            this.gbTPNT.Text = "Danh sách tác phẩm nghệ thuật";
            // 
            // dgDSTPNT
            // 
            this.dgDSTPNT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSTPNT.Location = new System.Drawing.Point(0, 20);
            this.dgDSTPNT.Name = "dgDSTPNT";
            this.dgDSTPNT.Size = new System.Drawing.Size(268, 334);
            this.dgDSTPNT.TabIndex = 1;
            this.dgDSTPNT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSTPNT_CellContentClick);
            // 
            // gbDSCTL
            // 
            this.gbDSCTL.Controls.Add(this.dgDSCTL);
            this.gbDSCTL.Location = new System.Drawing.Point(0, 51);
            this.gbDSCTL.Name = "gbDSCTL";
            this.gbDSCTL.Size = new System.Drawing.Size(584, 354);
            this.gbDSCTL.TabIndex = 17;
            this.gbDSCTL.TabStop = false;
            this.gbDSCTL.Text = "Danh sách cuộc triển lãm";
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 503);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(872, 20);
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
            this.barDockControlTop.Size = new System.Drawing.Size(872, 45);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 458);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(872, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 458);
            // 
            // cbbCTL
            // 
            this.cbbCTL.FormattingEnabled = true;
            this.cbbCTL.Location = new System.Drawing.Point(197, 35);
            this.cbbCTL.Name = "cbbCTL";
            this.cbbCTL.Size = new System.Drawing.Size(121, 21);
            this.cbbCTL.TabIndex = 1;
            this.cbbCTL.SelectedIndexChanged += new System.EventHandler(this.cbbCTL_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuộc triển lãm";
            // 
            // FormCTCTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 523);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbCTL);
            this.Controls.Add(this.gbTT);
            this.Controls.Add(this.gbTPNT);
            this.Controls.Add(this.gbDSCTL);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormCTCTL";
            this.Text = "FormCTCTL";
            this.Load += new System.EventHandler(this.FormCTCTL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSCTL)).EndInit();
            this.gbTT.ResumeLayout(false);
            this.gbTT.PerformLayout();
            this.gbTPNT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTPNT)).EndInit();
            this.gbDSCTL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDSCTL;
        private System.Windows.Forms.GroupBox gbTT;
        private System.Windows.Forms.Label lbTP;
        private System.Windows.Forms.Label lbBST;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.GroupBox gbTPNT;
        private System.Windows.Forms.DataGridView dgDSTPNT;
        private System.Windows.Forms.GroupBox gbDSCTL;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
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
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbCTL;
        private System.Windows.Forms.TextBox tbTP;
        private System.Windows.Forms.TextBox tbCTL;
    }
}