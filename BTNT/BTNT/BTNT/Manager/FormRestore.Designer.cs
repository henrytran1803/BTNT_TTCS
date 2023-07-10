
namespace BTNT.Manager
{
    partial class FormRestore
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
            this.gbRS = new System.Windows.Forms.GroupBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnDiachi = new System.Windows.Forms.Button();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.rbtBK = new System.Windows.Forms.RadioButton();
            this.rbtRS = new System.Windows.Forms.RadioButton();
            this.gbRS.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRS
            // 
            this.gbRS.Controls.Add(this.rbtRS);
            this.gbRS.Controls.Add(this.rbtBK);
            this.gbRS.Controls.Add(this.tbLink);
            this.gbRS.Controls.Add(this.btnDiachi);
            this.gbRS.Controls.Add(this.btnChon);
            this.gbRS.Location = new System.Drawing.Point(189, 47);
            this.gbRS.Name = "gbRS";
            this.gbRS.Size = new System.Drawing.Size(1302, 753);
            this.gbRS.TabIndex = 0;
            this.gbRS.TabStop = false;
            this.gbRS.Text = "Back up";
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(514, 440);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(295, 44);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "Back up";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnDiachi
            // 
            this.btnDiachi.Location = new System.Drawing.Point(986, 307);
            this.btnDiachi.Name = "btnDiachi";
            this.btnDiachi.Size = new System.Drawing.Size(179, 44);
            this.btnDiachi.TabIndex = 1;
            this.btnDiachi.Text = "Location";
            this.btnDiachi.UseVisualStyleBackColor = true;
            this.btnDiachi.Click += new System.EventHandler(this.btnDiachi_Click);
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(392, 320);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(545, 31);
            this.tbLink.TabIndex = 2;
            // 
            // rbtBK
            // 
            this.rbtBK.AutoSize = true;
            this.rbtBK.Location = new System.Drawing.Point(464, 118);
            this.rbtBK.Name = "rbtBK";
            this.rbtBK.Size = new System.Drawing.Size(121, 29);
            this.rbtBK.TabIndex = 1;
            this.rbtBK.TabStop = true;
            this.rbtBK.Text = "Back up";
            this.rbtBK.UseVisualStyleBackColor = true;
            this.rbtBK.CheckedChanged += new System.EventHandler(this.rbtBK_CheckedChanged);
            // 
            // rbtRS
            // 
            this.rbtRS.AutoSize = true;
            this.rbtRS.Location = new System.Drawing.Point(721, 118);
            this.rbtRS.Name = "rbtRS";
            this.rbtRS.Size = new System.Drawing.Size(118, 29);
            this.rbtRS.TabIndex = 3;
            this.rbtRS.TabStop = true;
            this.rbtRS.Text = "Restore";
            this.rbtRS.UseVisualStyleBackColor = true;
            this.rbtRS.CheckedChanged += new System.EventHandler(this.rbtRS_CheckedChanged);
            // 
            // FormRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 915);
            this.Controls.Add(this.gbRS);
            this.Name = "FormRestore";
            this.Text = "Back up/ Restore";
            this.gbRS.ResumeLayout(false);
            this.gbRS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRS;
        private System.Windows.Forms.RadioButton rbtRS;
        private System.Windows.Forms.RadioButton rbtBK;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Button btnDiachi;
        private System.Windows.Forms.Button btnChon;
    }
}