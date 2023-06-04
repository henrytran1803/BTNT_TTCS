
namespace BTNT.Manager
{
    partial class FormBST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBST));
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
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
            this.tbMT = new System.Windows.Forms.TextBox();
            this.lbMT = new System.Windows.Forms.Label();
            this.cbbHT = new System.Windows.Forms.ComboBox();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbMa = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.gbTT = new System.Windows.Forms.GroupBox();
            this.dgDSBST = new System.Windows.Forms.DataGridView();
            this.gbDSBST = new System.Windows.Forms.GroupBox();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.lbSDT = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbDC = new System.Windows.Forms.TextBox();
            this.lbHT = new System.Windows.Forms.Label();
            this.lbDC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.gbTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSBST)).BeginInit();
            this.gbDSBST.SuspendLayout();
            this.SuspendLayout();
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(871, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 426);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 471);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(871, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 426);
            // 
            // tbMT
            // 
            this.tbMT.Location = new System.Drawing.Point(102, 73);
            this.tbMT.Name = "tbMT";
            this.tbMT.Size = new System.Drawing.Size(180, 21);
            this.tbMT.TabIndex = 14;
            // 
            // lbMT
            // 
            this.lbMT.AutoSize = true;
            this.lbMT.Location = new System.Drawing.Point(24, 81);
            this.lbMT.Name = "lbMT";
            this.lbMT.Size = new System.Drawing.Size(38, 13);
            this.lbMT.TabIndex = 12;
            this.lbMT.Text = "Mô tả:";
            // 
            // cbbHT
            // 
            this.cbbHT.FormattingEnabled = true;
            this.cbbHT.Location = new System.Drawing.Point(462, 116);
            this.cbbHT.Name = "cbbHT";
            this.cbbHT.Size = new System.Drawing.Size(180, 21);
            this.cbbHT.TabIndex = 8;
            this.cbbHT.SelectedIndexChanged += new System.EventHandler(this.cbbPC_SelectedIndexChanged);
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(372, 43);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(84, 13);
            this.lbTen.TabIndex = 3;
            this.lbTen.Text = "Tên bộ sưu tập:";
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(24, 43);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(80, 13);
            this.lbMa.TabIndex = 1;
            this.lbMa.Text = "Mã bộ sưu tập:";
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
            // gbTT
            // 
            this.gbTT.Controls.Add(this.lbDC);
            this.gbTT.Controls.Add(this.lbHT);
            this.gbTT.Controls.Add(this.tbDC);
            this.gbTT.Controls.Add(this.tbSDT);
            this.gbTT.Controls.Add(this.lbSDT);
            this.gbTT.Controls.Add(this.tbTen);
            this.gbTT.Controls.Add(this.tbMa);
            this.gbTT.Controls.Add(this.tbMT);
            this.gbTT.Controls.Add(this.lbMT);
            this.gbTT.Controls.Add(this.cbbHT);
            this.gbTT.Controls.Add(this.lbTen);
            this.gbTT.Controls.Add(this.lbMa);
            this.gbTT.Controls.Add(this.btnChon);
            this.gbTT.Location = new System.Drawing.Point(1, 287);
            this.gbTT.Name = "gbTT";
            this.gbTT.Size = new System.Drawing.Size(870, 204);
            this.gbTT.TabIndex = 15;
            this.gbTT.TabStop = false;
            this.gbTT.Text = "Thông tin";
            // 
            // dgDSBST
            // 
            this.dgDSBST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSBST.Location = new System.Drawing.Point(-6, 23);
            this.dgDSBST.Name = "dgDSBST";
            this.dgDSBST.Size = new System.Drawing.Size(876, 224);
            this.dgDSBST.TabIndex = 0;
            this.dgDSBST.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSBST_CellContentClick);
            // 
            // gbDSBST
            // 
            this.gbDSBST.Controls.Add(this.dgDSBST);
            this.gbDSBST.Location = new System.Drawing.Point(0, 28);
            this.gbDSBST.Name = "gbDSBST";
            this.gbDSBST.Size = new System.Drawing.Size(871, 244);
            this.gbDSBST.TabIndex = 13;
            this.gbDSBST.TabStop = false;
            this.gbDSBST.Text = "Danh sách bộ sưu tập";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(102, 35);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(180, 21);
            this.tbMa.TabIndex = 19;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(462, 35);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(180, 21);
            this.tbTen.TabIndex = 20;
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(372, 81);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(41, 13);
            this.lbSDT.TabIndex = 21;
            this.lbSDT.Text = "Phone:";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(462, 73);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(180, 21);
            this.tbSDT.TabIndex = 22;
            // 
            // tbDC
            // 
            this.tbDC.Location = new System.Drawing.Point(102, 116);
            this.tbDC.Name = "tbDC";
            this.tbDC.Size = new System.Drawing.Size(180, 21);
            this.tbDC.TabIndex = 23;
            // 
            // lbHT
            // 
            this.lbHT.AutoSize = true;
            this.lbHT.Location = new System.Drawing.Point(372, 124);
            this.lbHT.Name = "lbHT";
            this.lbHT.Size = new System.Drawing.Size(53, 13);
            this.lbHT.TabIndex = 24;
            this.lbHT.Text = "Hình thức";
            // 
            // lbDC
            // 
            this.lbDC.AutoSize = true;
            this.lbDC.Location = new System.Drawing.Point(24, 124);
            this.lbDC.Name = "lbDC";
            this.lbDC.Size = new System.Drawing.Size(50, 13);
            this.lbDC.TabIndex = 25;
            this.lbDC.Text = "Address:";
            // 
            // FormBST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 491);
            this.Controls.Add(this.gbTT);
            this.Controls.Add(this.gbDSBST);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormBST";
            this.Text = "Bộ sưu tập";
            this.Load += new System.EventHandler(this.FormBST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.gbTT.ResumeLayout(false);
            this.gbTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSBST)).EndInit();
            this.gbDSBST.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlRight;
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
        private System.Windows.Forms.GroupBox gbTT;
        private System.Windows.Forms.Label lbDC;
        private System.Windows.Forms.Label lbHT;
        private System.Windows.Forms.TextBox tbDC;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox tbMT;
        private System.Windows.Forms.Label lbMT;
        private System.Windows.Forms.ComboBox cbbHT;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.GroupBox gbDSBST;
        private System.Windows.Forms.DataGridView dgDSBST;
    }
}