
namespace BTNT.Manager
{
    partial class FormDieuKhac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDieuKhac));
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
            this.gbDSTPDK = new System.Windows.Forms.GroupBox();
            this.gbTPNT = new System.Windows.Forms.GroupBox();
            this.gbTT = new System.Windows.Forms.GroupBox();
            this.btnChonMa = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.lbMa = new System.Windows.Forms.Label();
            this.lbPC = new System.Windows.Forms.Label();
            this.lbVL = new System.Windows.Forms.Label();
            this.cbbTP = new System.Windows.Forms.ComboBox();
            this.cbbPC = new System.Windows.Forms.ComboBox();
            this.cbbVL = new System.Windows.Forms.ComboBox();
            this.lbCC = new System.Windows.Forms.Label();
            this.lbKL = new System.Windows.Forms.Label();
            this.tbCC = new System.Windows.Forms.TextBox();
            this.tbKL = new System.Windows.Forms.TextBox();
            this.dgDSPTDK = new System.Windows.Forms.DataGridView();
            this.dgDSTPNT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.gbDSTPDK.SuspendLayout();
            this.gbTPNT.SuspendLayout();
            this.gbTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSPTDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTPNT)).BeginInit();
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
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "Hoàn tác";
            this.btnHoanTac.Id = 3;
            this.btnHoanTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.Image")));
            this.btnHoanTac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.LargeImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 4;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
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
            this.barDockControlTop.Size = new System.Drawing.Size(870, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 464);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(870, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 419);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(870, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 419);
            // 
            // gbDSTPDK
            // 
            this.gbDSTPDK.Controls.Add(this.dgDSPTDK);
            this.gbDSTPDK.Location = new System.Drawing.Point(0, 27);
            this.gbDSTPDK.Name = "gbDSTPDK";
            this.gbDSTPDK.Size = new System.Drawing.Size(378, 244);
            this.gbDSTPDK.TabIndex = 4;
            this.gbDSTPDK.TabStop = false;
            this.gbDSTPDK.Text = "Danh sách tác phẩm điêu khắc";
            // 
            // gbTPNT
            // 
            this.gbTPNT.Controls.Add(this.btnChonMa);
            this.gbTPNT.Controls.Add(this.dgDSTPNT);
            this.gbTPNT.Location = new System.Drawing.Point(400, 27);
            this.gbTPNT.Name = "gbTPNT";
            this.gbTPNT.Size = new System.Drawing.Size(470, 244);
            this.gbTPNT.TabIndex = 5;
            this.gbTPNT.TabStop = false;
            this.gbTPNT.Text = "Danh sách tác phẩm nghệ thuật";
            // 
            // gbTT
            // 
            this.gbTT.Controls.Add(this.tbKL);
            this.gbTT.Controls.Add(this.tbCC);
            this.gbTT.Controls.Add(this.lbKL);
            this.gbTT.Controls.Add(this.lbCC);
            this.gbTT.Controls.Add(this.cbbVL);
            this.gbTT.Controls.Add(this.cbbPC);
            this.gbTT.Controls.Add(this.cbbTP);
            this.gbTT.Controls.Add(this.lbVL);
            this.gbTT.Controls.Add(this.lbPC);
            this.gbTT.Controls.Add(this.lbMa);
            this.gbTT.Controls.Add(this.btnChon);
            this.gbTT.Location = new System.Drawing.Point(0, 280);
            this.gbTT.Name = "gbTT";
            this.gbTT.Size = new System.Drawing.Size(870, 204);
            this.gbTT.TabIndex = 6;
            this.gbTT.TabStop = false;
            this.gbTT.Text = "Thông tin";
            // 
            // btnChonMa
            // 
            this.btnChonMa.Location = new System.Drawing.Point(389, 12);
            this.btnChonMa.Name = "btnChonMa";
            this.btnChonMa.Size = new System.Drawing.Size(75, 232);
            this.btnChonMa.TabIndex = 7;
            this.btnChonMa.Text = "chọn";
            this.btnChonMa.UseVisualStyleBackColor = true;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(783, 175);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(75, 23);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
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
            // lbPC
            // 
            this.lbPC.AutoSize = true;
            this.lbPC.Location = new System.Drawing.Point(24, 100);
            this.lbPC.Name = "lbPC";
            this.lbPC.Size = new System.Drawing.Size(66, 13);
            this.lbPC.TabIndex = 2;
            this.lbPC.Text = "Phong cách:";
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
            // cbbTP
            // 
            this.cbbTP.FormattingEnabled = true;
            this.cbbTP.Location = new System.Drawing.Point(96, 35);
            this.cbbTP.Name = "cbbTP";
            this.cbbTP.Size = new System.Drawing.Size(261, 21);
            this.cbbTP.TabIndex = 5;
            // 
            // cbbPC
            // 
            this.cbbPC.FormattingEnabled = true;
            this.cbbPC.Location = new System.Drawing.Point(96, 92);
            this.cbbPC.Name = "cbbPC";
            this.cbbPC.Size = new System.Drawing.Size(261, 21);
            this.cbbPC.TabIndex = 6;
            // 
            // cbbVL
            // 
            this.cbbVL.FormattingEnabled = true;
            this.cbbVL.Location = new System.Drawing.Point(428, 35);
            this.cbbVL.Name = "cbbVL";
            this.cbbVL.Size = new System.Drawing.Size(261, 21);
            this.cbbVL.TabIndex = 8;
            this.cbbVL.SelectedIndexChanged += new System.EventHandler(this.cbbVL_SelectedIndexChanged);
            // 
            // lbCC
            // 
            this.lbCC.AutoSize = true;
            this.lbCC.Location = new System.Drawing.Point(24, 147);
            this.lbCC.Name = "lbCC";
            this.lbCC.Size = new System.Drawing.Size(58, 13);
            this.lbCC.TabIndex = 9;
            this.lbCC.Text = "Chiều cao:";
            // 
            // lbKL
            // 
            this.lbKL.AutoSize = true;
            this.lbKL.Location = new System.Drawing.Point(369, 100);
            this.lbKL.Name = "lbKL";
            this.lbKL.Size = new System.Drawing.Size(61, 13);
            this.lbKL.TabIndex = 10;
            this.lbKL.Text = "Khối lượng:";
            // 
            // tbCC
            // 
            this.tbCC.Location = new System.Drawing.Point(96, 139);
            this.tbCC.Name = "tbCC";
            this.tbCC.Size = new System.Drawing.Size(261, 21);
            this.tbCC.TabIndex = 11;
            // 
            // tbKL
            // 
            this.tbKL.Location = new System.Drawing.Point(428, 92);
            this.tbKL.Name = "tbKL";
            this.tbKL.Size = new System.Drawing.Size(261, 21);
            this.tbKL.TabIndex = 12;
            // 
            // dgDSPTDK
            // 
            this.dgDSPTDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSPTDK.Location = new System.Drawing.Point(0, 20);
            this.dgDSPTDK.Name = "dgDSPTDK";
            this.dgDSPTDK.Size = new System.Drawing.Size(378, 224);
            this.dgDSPTDK.TabIndex = 0;
            // 
            // dgDSTPNT
            // 
            this.dgDSTPNT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSTPNT.Location = new System.Drawing.Point(0, 20);
            this.dgDSTPNT.Name = "dgDSTPNT";
            this.dgDSTPNT.Size = new System.Drawing.Size(382, 224);
            this.dgDSTPNT.TabIndex = 1;
            // 
            // FormDieuKhac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 484);
            this.Controls.Add(this.gbTT);
            this.Controls.Add(this.gbTPNT);
            this.Controls.Add(this.gbDSTPDK);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormDieuKhac";
            this.Text = "FormDieuKhac";
            this.Load += new System.EventHandler(this.FormDieuKhac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.gbDSTPDK.ResumeLayout(false);
            this.gbTPNT.ResumeLayout(false);
            this.gbTT.ResumeLayout(false);
            this.gbTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSPTDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTPNT)).EndInit();
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
        private System.Windows.Forms.GroupBox gbTT;
        private System.Windows.Forms.TextBox tbKL;
        private System.Windows.Forms.TextBox tbCC;
        private System.Windows.Forms.Label lbKL;
        private System.Windows.Forms.Label lbCC;
        private System.Windows.Forms.ComboBox cbbVL;
        private System.Windows.Forms.ComboBox cbbPC;
        private System.Windows.Forms.ComboBox cbbTP;
        private System.Windows.Forms.Label lbVL;
        private System.Windows.Forms.Label lbPC;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.GroupBox gbTPNT;
        private System.Windows.Forms.Button btnChonMa;
        private System.Windows.Forms.DataGridView dgDSTPNT;
        private System.Windows.Forms.GroupBox gbDSTPDK;
        private System.Windows.Forms.DataGridView dgDSPTDK;
    }
}