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
    }
}