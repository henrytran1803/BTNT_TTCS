
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
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.gbDSTacPham = new System.Windows.Forms.GroupBox();
            this.dgDSTrienLam = new System.Windows.Forms.DataGridView();
            this.dgDSTacPham = new System.Windows.Forms.DataGridView();
            this.gbDSTrienLam.SuspendLayout();
            this.gbDSTacPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTrienLam)).BeginInit();
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
            // gbThongTin
            // 
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
            // dgDSTrienLam
            // 
            this.dgDSTrienLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSTrienLam.Location = new System.Drawing.Point(0, 20);
            this.dgDSTrienLam.Name = "dgDSTrienLam";
            this.dgDSTrienLam.Size = new System.Drawing.Size(382, 214);
            this.dgDSTrienLam.TabIndex = 0;
            // 
            // dgDSTacPham
            // 
            this.dgDSTacPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSTacPham.Location = new System.Drawing.Point(0, 14);
            this.dgDSTacPham.Name = "dgDSTacPham";
            this.dgDSTacPham.Size = new System.Drawing.Size(382, 209);
            this.dgDSTacPham.TabIndex = 1;
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
            this.gbDSTrienLam.ResumeLayout(false);
            this.gbDSTacPham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTrienLam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSTacPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDSTrienLam;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.GroupBox gbDSTacPham;
        private System.Windows.Forms.DataGridView dgDSTrienLam;
        private System.Windows.Forms.DataGridView dgDSTacPham;
    }
}