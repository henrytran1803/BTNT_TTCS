using BTNT.Manager;
using BTNT.User;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTNT.View
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void ribbon_Click(object sender, EventArgs e)
        {
           
        }

        private void btnKhamPha_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormKhamPha));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormKhamPha form = new FormKhamPha();
               form.MdiParent = this;

                form.Show();

            }
        }

        private void btnTrienLam_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormTrienLamSapDienRa));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormTrienLamSapDienRa form = new FormTrienLamSapDienRa();
                form.MdiParent = this;

                form.Show();

            }
        }

        private void btnTPNT_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormTPNT));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormTPNT form = new FormTPNT();
                form.MdiParent = this;

                form.Show();

            }
        }

        private void btnDieuKhac_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDieuKhac));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDieuKhac form = new FormDieuKhac();
                form.MdiParent = this;

                form.Show();

            }
        }

        private void btnHoiHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormHoiHoa));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormHoiHoa form = new FormHoiHoa();
                form.MdiParent = this;

                form.Show();

            }
        }

        private void btnKhac_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormKhac));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormKhac form = new FormKhac();
                form.MdiParent = this;

                form.Show();

            }
        }

        private void btnTacGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormTacGia));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormTacGia form = new FormTacGia();
                form.MdiParent = this;

                form.Show();

            }
        }

        private void btnBST_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormBST));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormBST form = new FormBST();
                form.MdiParent = this;

                form.Show();

            }
        }

        private void btnMuon_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormMuon));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormMuon form = new FormMuon();
                form.MdiParent = this;

                form.Show();

            }
        }

        private void btnSoHuu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormSoHuu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormSoHuu form = new FormSoHuu();
                form.MdiParent = this;

                form.Show();

            }
        }

        private void btnTrienLamNgheThuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormTrienLam));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormTrienLam form = new FormTrienLam();
                form.MdiParent = this;

                form.Show();

            }
        }
        public void nguoiDung()
        {
            rbpTrangChu.Visible = true;
            rbpTPNT.Visible = false;
            rbpTrienLam.Visible = false;
            rbpHeThong.Visible = true;
            btnQuyen.Caption = "Người dùng";
            btnTaoTk.Enabled = false;
            btnDangXuat.Enabled = false;
        }
        public void nhanVien()
        {
            rbpTrangChu.Visible = false;
            rbpTPNT.Visible = true;
            rbpTrienLam.Visible = true;
            rbpHeThong.Visible = true;
            btnQuyen.Caption = "Nhân viên";
            btnTaoTk.Enabled = false;
        }
        public void ennable()
        {
            rbpTrangChu.Visible = false;
            rbpTPNT.Visible = true;
            rbpTrienLam.Visible = true;
            rbpHeThong.Visible = true;
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnTaoTk.Enabled = false;
        }
        public void unennable()
        {
            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Program.role == "NGUOIDUNG")
            {
                this.nguoiDung();
            }
            else if (Program.role == "NHANVIEN")
            {
                this.nhanVien();
            }
            Program.KetNoi();
        }

        private void btnCTCTL_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormCTCTL));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormCTCTL form = new FormCTCTL();
                form.MdiParent = this;

                form.Show();

            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            unennable();
            Program.loginName = "nd";
            Program.loginPassword = "123456";
            Program.role = "NGUOIDUNG";
            FormMain_Load(sender, e);
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormLogin));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormLogin form = new FormLogin();
                form.Show();

            }
        }
    }
}