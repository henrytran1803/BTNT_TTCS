
namespace BTNT.User
{
    partial class FormTrienLamSapDienRa
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
            this.gbDSTrienLam = new System.Windows.Forms.GroupBox();
            this.dgDSTrienLam = new System.Windows.Forms.DataGridView();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.gbDSTacPham = new System.Windows.Forms.GroupBox();
            this.dgDSTacPham = new System.Windows.Forms.DataGridView();
            this.lbMaCTL = new System.Windows.Forms.Label();
            this.lbNMaCTL = new System.Windows.Forms.Label();
            this.lbTenCTL = new System.Windows.Forms.Label();
            this.lbNTenCTL = new System.Windows.Forms.Label();
            this.lbNgayBatDau = new System.Windows.Forms.Label();
            this.lbNhapNgayBatDau = new System.Windows.Forms.Label();
            this.labellbNgayKetThuc7 = new System.Windows.Forms.Label();
            this.lbNNgayKetThuc = new System.Windows.Forms.Label();
            this.lbMaTP = new System.Windows.Forms.Label();
            this.lbNMaTP = new System.Windows.Forms.Label();
            this.lbTenTP = new System.Windows.Forms.Label();
            this.lbNTenTP = new System.Windows.Forms.Label();
            this.lbTenTacGia = new System.Windows.Forms.Label();
            this.lbNTenTacGia = new System.Windows.Forms.Label();
            this.lbNam = new System.Windows.Forms.Label();
            this.lbNNam = new System.Windows.Forms.Label();
            this.gbDSTrienLam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTrienLam)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.gbDSTacPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTacPham)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDSTrienLam
            // 
            this.gbDSTrienLam.Controls.Add(this.dgDSTrienLam);
            this.gbDSTrienLam.Location = new System.Drawing.Point(1, 12);
            this.gbDSTrienLam.Name = "gbDSTrienLam";
            this.gbDSTrienLam.Size = new System.Drawing.Size(382, 234);
            this.gbDSTrienLam.TabIndex = 0;
            this.gbDSTrienLam.TabStop = false;
            this.gbDSTrienLam.Text = "Danh sách triển lãm";
            // 
            // dgDSTrienLam
            // 
            this.dgDSTrienLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSTrienLam.Location = new System.Drawing.Point(0, 20);
            this.dgDSTrienLam.Name = "dgDSTrienLam";
            this.dgDSTrienLam.Size = new System.Drawing.Size(382, 214);
            this.dgDSTrienLam.TabIndex = 0;
            this.dgDSTrienLam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSTrienLam_CellContentClick);
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.lbNNam);
            this.gbThongTin.Controls.Add(this.lbNam);
            this.gbThongTin.Controls.Add(this.lbNTenTacGia);
            this.gbThongTin.Controls.Add(this.lbTenTacGia);
            this.gbThongTin.Controls.Add(this.lbNTenTP);
            this.gbThongTin.Controls.Add(this.lbTenTP);
            this.gbThongTin.Controls.Add(this.lbNMaTP);
            this.gbThongTin.Controls.Add(this.lbMaTP);
            this.gbThongTin.Controls.Add(this.lbNNgayKetThuc);
            this.gbThongTin.Controls.Add(this.labellbNgayKetThuc7);
            this.gbThongTin.Controls.Add(this.lbNhapNgayBatDau);
            this.gbThongTin.Controls.Add(this.lbNgayBatDau);
            this.gbThongTin.Controls.Add(this.lbNTenCTL);
            this.gbThongTin.Controls.Add(this.lbTenCTL);
            this.gbThongTin.Controls.Add(this.lbNMaCTL);
            this.gbThongTin.Controls.Add(this.lbMaCTL);
            this.gbThongTin.Location = new System.Drawing.Point(389, 12);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(401, 463);
            this.gbThongTin.TabIndex = 1;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin";
            // 
            // gbDSTacPham
            // 
            this.gbDSTacPham.Controls.Add(this.dgDSTacPham);
            this.gbDSTacPham.Location = new System.Drawing.Point(1, 252);
            this.gbDSTacPham.Name = "gbDSTacPham";
            this.gbDSTacPham.Size = new System.Drawing.Size(382, 223);
            this.gbDSTacPham.TabIndex = 2;
            this.gbDSTacPham.TabStop = false;
            this.gbDSTacPham.Text = "Dánh sách tác phẩm";
            // 
            // dgDSTacPham
            // 
            this.dgDSTacPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSTacPham.Location = new System.Drawing.Point(0, 14);
            this.dgDSTacPham.Name = "dgDSTacPham";
            this.dgDSTacPham.Size = new System.Drawing.Size(382, 209);
            this.dgDSTacPham.TabIndex = 1;
            this.dgDSTacPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSTacPham_CellContentClick);
            // 
            // lbMaCTL
            // 
            this.lbMaCTL.AutoSize = true;
            this.lbMaCTL.Location = new System.Drawing.Point(42, 34);
            this.lbMaCTL.Name = "lbMaCTL";
            this.lbMaCTL.Size = new System.Drawing.Size(90, 13);
            this.lbMaCTL.TabIndex = 0;
            this.lbMaCTL.Text = "Mã cuộc triển lãm";
            // 
            // lbNMaCTL
            // 
            this.lbNMaCTL.AutoSize = true;
            this.lbNMaCTL.Location = new System.Drawing.Point(160, 34);
            this.lbNMaCTL.Name = "lbNMaCTL";
            this.lbNMaCTL.Size = new System.Drawing.Size(35, 13);
            this.lbNMaCTL.TabIndex = 1;
            this.lbNMaCTL.Text = "label2";
            // 
            // lbTenCTL
            // 
            this.lbTenCTL.AutoSize = true;
            this.lbTenCTL.Location = new System.Drawing.Point(42, 79);
            this.lbTenCTL.Name = "lbTenCTL";
            this.lbTenCTL.Size = new System.Drawing.Size(94, 13);
            this.lbTenCTL.TabIndex = 2;
            this.lbTenCTL.Text = "Tên cuộc triển lãm";
            // 
            // lbNTenCTL
            // 
            this.lbNTenCTL.AutoSize = true;
            this.lbNTenCTL.Location = new System.Drawing.Point(160, 79);
            this.lbNTenCTL.Name = "lbNTenCTL";
            this.lbNTenCTL.Size = new System.Drawing.Size(35, 13);
            this.lbNTenCTL.TabIndex = 3;
            this.lbNTenCTL.Text = "label4";
            // 
            // lbNgayBatDau
            // 
            this.lbNgayBatDau.AutoSize = true;
            this.lbNgayBatDau.Location = new System.Drawing.Point(42, 125);
            this.lbNgayBatDau.Name = "lbNgayBatDau";
            this.lbNgayBatDau.Size = new System.Drawing.Size(72, 13);
            this.lbNgayBatDau.TabIndex = 4;
            this.lbNgayBatDau.Text = "Ngày bắt đầu";
            // 
            // lbNhapNgayBatDau
            // 
            this.lbNhapNgayBatDau.AutoSize = true;
            this.lbNhapNgayBatDau.Location = new System.Drawing.Point(160, 125);
            this.lbNhapNgayBatDau.Name = "lbNhapNgayBatDau";
            this.lbNhapNgayBatDau.Size = new System.Drawing.Size(35, 13);
            this.lbNhapNgayBatDau.TabIndex = 5;
            this.lbNhapNgayBatDau.Text = "label6";
            // 
            // labellbNgayKetThuc7
            // 
            this.labellbNgayKetThuc7.AutoSize = true;
            this.labellbNgayKetThuc7.Location = new System.Drawing.Point(42, 177);
            this.labellbNgayKetThuc7.Name = "labellbNgayKetThuc7";
            this.labellbNgayKetThuc7.Size = new System.Drawing.Size(74, 13);
            this.labellbNgayKetThuc7.TabIndex = 6;
            this.labellbNgayKetThuc7.Text = "Ngày kết thúc";
            // 
            // lbNNgayKetThuc
            // 
            this.lbNNgayKetThuc.AutoSize = true;
            this.lbNNgayKetThuc.Location = new System.Drawing.Point(160, 177);
            this.lbNNgayKetThuc.Name = "lbNNgayKetThuc";
            this.lbNNgayKetThuc.Size = new System.Drawing.Size(35, 13);
            this.lbNNgayKetThuc.TabIndex = 7;
            this.lbNNgayKetThuc.Text = "label8";
            // 
            // lbMaTP
            // 
            this.lbMaTP.AutoSize = true;
            this.lbMaTP.Location = new System.Drawing.Point(42, 221);
            this.lbMaTP.Name = "lbMaTP";
            this.lbMaTP.Size = new System.Drawing.Size(68, 13);
            this.lbMaTP.TabIndex = 8;
            this.lbMaTP.Text = "Mã tác phẩm";
            // 
            // lbNMaTP
            // 
            this.lbNMaTP.AutoSize = true;
            this.lbNMaTP.Location = new System.Drawing.Point(160, 221);
            this.lbNMaTP.Name = "lbNMaTP";
            this.lbNMaTP.Size = new System.Drawing.Size(41, 13);
            this.lbNMaTP.TabIndex = 9;
            this.lbNMaTP.Text = "label10";
            // 
            // lbTenTP
            // 
            this.lbTenTP.AutoSize = true;
            this.lbTenTP.Location = new System.Drawing.Point(42, 269);
            this.lbTenTP.Name = "lbTenTP";
            this.lbTenTP.Size = new System.Drawing.Size(72, 13);
            this.lbTenTP.TabIndex = 10;
            this.lbTenTP.Text = "Tên tác phẩm";
            // 
            // lbNTenTP
            // 
            this.lbNTenTP.AutoSize = true;
            this.lbNTenTP.Location = new System.Drawing.Point(160, 269);
            this.lbNTenTP.Name = "lbNTenTP";
            this.lbNTenTP.Size = new System.Drawing.Size(41, 13);
            this.lbNTenTP.TabIndex = 11;
            this.lbNTenTP.Text = "label12";
            // 
            // lbTenTacGia
            // 
            this.lbTenTacGia.AutoSize = true;
            this.lbTenTacGia.Location = new System.Drawing.Point(42, 315);
            this.lbTenTacGia.Name = "lbTenTacGia";
            this.lbTenTacGia.Size = new System.Drawing.Size(60, 13);
            this.lbTenTacGia.TabIndex = 12;
            this.lbTenTacGia.Text = "Tên tác giả";
            // 
            // lbNTenTacGia
            // 
            this.lbNTenTacGia.AutoSize = true;
            this.lbNTenTacGia.Location = new System.Drawing.Point(160, 315);
            this.lbNTenTacGia.Name = "lbNTenTacGia";
            this.lbNTenTacGia.Size = new System.Drawing.Size(41, 13);
            this.lbNTenTacGia.TabIndex = 13;
            this.lbNTenTacGia.Text = "label14";
            // 
            // lbNam
            // 
            this.lbNam.AutoSize = true;
            this.lbNam.Location = new System.Drawing.Point(42, 348);
            this.lbNam.Name = "lbNam";
            this.lbNam.Size = new System.Drawing.Size(28, 13);
            this.lbNam.TabIndex = 14;
            this.lbNam.Text = "Năm";
            // 
            // lbNNam
            // 
            this.lbNNam.AutoSize = true;
            this.lbNNam.Location = new System.Drawing.Point(160, 348);
            this.lbNNam.Name = "lbNNam";
            this.lbNNam.Size = new System.Drawing.Size(41, 13);
            this.lbNNam.TabIndex = 15;
            this.lbNNam.Text = "label14";
            // 
            // FormTrienLamSapDienRa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 475);
            this.Controls.Add(this.gbDSTacPham);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.gbDSTrienLam);
            this.Name = "FormTrienLamSapDienRa";
            this.Text = "Triển lãm";
            this.Load += new System.EventHandler(this.FormTrienLamSapDienRa_Load);
            this.gbDSTrienLam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTrienLam)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbDSTacPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTacPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDSTrienLam;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.GroupBox gbDSTacPham;
        private System.Windows.Forms.DataGridView dgDSTrienLam;
        private System.Windows.Forms.DataGridView dgDSTacPham;
        private System.Windows.Forms.Label lbNNam;
        private System.Windows.Forms.Label lbNam;
        private System.Windows.Forms.Label lbNTenTacGia;
        private System.Windows.Forms.Label lbTenTacGia;
        private System.Windows.Forms.Label lbNTenTP;
        private System.Windows.Forms.Label lbTenTP;
        private System.Windows.Forms.Label lbNMaTP;
        private System.Windows.Forms.Label lbMaTP;
        private System.Windows.Forms.Label lbNNgayKetThuc;
        private System.Windows.Forms.Label labellbNgayKetThuc7;
        private System.Windows.Forms.Label lbNhapNgayBatDau;
        private System.Windows.Forms.Label lbNgayBatDau;
        private System.Windows.Forms.Label lbNTenCTL;
        private System.Windows.Forms.Label lbTenCTL;
        private System.Windows.Forms.Label lbNMaCTL;
        private System.Windows.Forms.Label lbMaCTL;
    }
}