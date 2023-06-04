
namespace BTNT.Manager
{
    partial class FormSoHuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSoHuu));
            this.gbDSMuon = new System.Windows.Forms.GroupBox();
            this.dgDSMuon = new System.Windows.Forms.DataGridView();
            this.lbGiaTi = new System.Windows.Forms.Label();
            this.dpNgaySoHuu = new System.Windows.Forms.DateTimePicker();
            this.gbTT = new System.Windows.Forms.GroupBox();
            this.lbNgaySoHuu = new System.Windows.Forms.Label();
            this.cbbTP = new System.Windows.Forms.ComboBox();
            this.lbTP = new System.Windows.Forms.Label();
            this.btnChon = new System.Windows.Forms.Button();
            this.gbTPNT = new System.Windows.Forms.GroupBox();
            this.dgDSTPNT = new System.Windows.Forms.DataGridView();
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
            this.lbTT = new System.Windows.Forms.Label();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.tbGiaTri = new System.Windows.Forms.TextBox();
            this.gbDSMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSMuon)).BeginInit();
            this.gbTT.SuspendLayout();
            this.gbTPNT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTPNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDSMuon
            // 
            this.gbDSMuon.Controls.Add(this.dgDSMuon);
            this.gbDSMuon.Location = new System.Drawing.Point(0, 28);
            this.gbDSMuon.Name = "gbDSMuon";
            this.gbDSMuon.Size = new System.Drawing.Size(584, 244);
            this.gbDSMuon.TabIndex = 16;
            this.gbDSMuon.TabStop = false;
            this.gbDSMuon.Text = "Danh sách sở hữu";
            // 
            // dgDSMuon
            // 
            this.dgDSMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSMuon.Location = new System.Drawing.Point(-6, 23);
            this.dgDSMuon.Name = "dgDSMuon";
            this.dgDSMuon.Size = new System.Drawing.Size(584, 224);
            this.dgDSMuon.TabIndex = 0;
            // 
            // lbGiaTi
            // 
            this.lbGiaTi.AutoSize = true;
            this.lbGiaTi.Location = new System.Drawing.Point(372, 107);
            this.lbGiaTi.Name = "lbGiaTi";
            this.lbGiaTi.Size = new System.Drawing.Size(39, 13);
            this.lbGiaTi.TabIndex = 14;
            this.lbGiaTi.Text = "Giá trị:";
            // 
            // dpNgaySoHuu
            // 
            this.dpNgaySoHuu.Location = new System.Drawing.Point(96, 101);
            this.dpNgaySoHuu.Name = "dpNgaySoHuu";
            this.dpNgaySoHuu.Size = new System.Drawing.Size(261, 21);
            this.dpNgaySoHuu.TabIndex = 13;
            // 
            // gbTT
            // 
            this.gbTT.Controls.Add(this.tbGiaTri);
            this.gbTT.Controls.Add(this.rbt2);
            this.gbTT.Controls.Add(this.rbt1);
            this.gbTT.Controls.Add(this.lbTT);
            this.gbTT.Controls.Add(this.lbGiaTi);
            this.gbTT.Controls.Add(this.dpNgaySoHuu);
            this.gbTT.Controls.Add(this.lbNgaySoHuu);
            this.gbTT.Controls.Add(this.cbbTP);
            this.gbTT.Controls.Add(this.lbTP);
            this.gbTT.Controls.Add(this.btnChon);
            this.gbTT.Location = new System.Drawing.Point(0, 290);
            this.gbTT.Name = "gbTT";
            this.gbTT.Size = new System.Drawing.Size(870, 204);
            this.gbTT.TabIndex = 18;
            this.gbTT.TabStop = false;
            this.gbTT.Text = "Thông tin";
            // 
            // lbNgaySoHuu
            // 
            this.lbNgaySoHuu.AutoSize = true;
            this.lbNgaySoHuu.Location = new System.Drawing.Point(24, 107);
            this.lbNgaySoHuu.Name = "lbNgaySoHuu";
            this.lbNgaySoHuu.Size = new System.Drawing.Size(72, 13);
            this.lbNgaySoHuu.TabIndex = 12;
            this.lbNgaySoHuu.Text = "Ngày sở hữu:";
            // 
            // cbbTP
            // 
            this.cbbTP.FormattingEnabled = true;
            this.cbbTP.Location = new System.Drawing.Point(96, 30);
            this.cbbTP.Name = "cbbTP";
            this.cbbTP.Size = new System.Drawing.Size(261, 21);
            this.cbbTP.TabIndex = 8;
            // 
            // lbTP
            // 
            this.lbTP.AutoSize = true;
            this.lbTP.Location = new System.Drawing.Point(24, 38);
            this.lbTP.Name = "lbTP";
            this.lbTP.Size = new System.Drawing.Size(57, 13);
            this.lbTP.TabIndex = 3;
            this.lbTP.Text = "Tác phẩm:";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(746, 35);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(112, 157);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            // 
            // gbTPNT
            // 
            this.gbTPNT.Controls.Add(this.dgDSTPNT);
            this.gbTPNT.Location = new System.Drawing.Point(602, 31);
            this.gbTPNT.Name = "gbTPNT";
            this.gbTPNT.Size = new System.Drawing.Size(268, 244);
            this.gbTPNT.TabIndex = 17;
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
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 429);
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
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
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
            this.barDockControlTop.Size = new System.Drawing.Size(871, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 474);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(871, 20);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(871, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 429);
            // 
            // lbTT
            // 
            this.lbTT.AutoSize = true;
            this.lbTT.Location = new System.Drawing.Point(372, 38);
            this.lbTT.Name = "lbTT";
            this.lbTT.Size = new System.Drawing.Size(60, 13);
            this.lbTT.TabIndex = 16;
            this.lbTT.Text = "Tình trạng:";
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Location = new System.Drawing.Point(444, 34);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(41, 17);
            this.rbt1.TabIndex = 17;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "Tốt";
            this.rbt1.UseVisualStyleBackColor = true;
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.Location = new System.Drawing.Point(588, 34);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(56, 17);
            this.rbt2.TabIndex = 18;
            this.rbt2.TabStop = true;
            this.rbt2.Text = "Bảo trì";
            this.rbt2.UseVisualStyleBackColor = true;
            // 
            // tbGiaTri
            // 
            this.tbGiaTri.Location = new System.Drawing.Point(444, 99);
            this.tbGiaTri.Name = "tbGiaTri";
            this.tbGiaTri.Size = new System.Drawing.Size(261, 21);
            this.tbGiaTri.TabIndex = 19;
            // 
            // FormSoHuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 494);
            this.Controls.Add(this.gbDSMuon);
            this.Controls.Add(this.gbTT);
            this.Controls.Add(this.gbTPNT);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormSoHuu";
            this.Text = "Sở hữu";
            this.gbDSMuon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSMuon)).EndInit();
            this.gbTT.ResumeLayout(false);
            this.gbTT.PerformLayout();
            this.gbTPNT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTPNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDSMuon;
        private System.Windows.Forms.DataGridView dgDSMuon;
        private System.Windows.Forms.Label lbGiaTi;
        private System.Windows.Forms.DateTimePicker dpNgaySoHuu;
        private System.Windows.Forms.GroupBox gbTT;
        private System.Windows.Forms.TextBox tbGiaTri;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.Label lbTT;
        private System.Windows.Forms.Label lbNgaySoHuu;
        private System.Windows.Forms.ComboBox cbbTP;
        private System.Windows.Forms.Label lbTP;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.GroupBox gbTPNT;
        private System.Windows.Forms.DataGridView dgDSTPNT;
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
    }
}