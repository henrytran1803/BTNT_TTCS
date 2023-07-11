using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTNT.Manager
{
    public partial class FormRestore : Form
    {
        public FormRestore()
        {
            InitializeComponent();
            rbtBK.Checked = true;
            btnChon.Enabled = false;
        }

        private void btnDiachi_Click(object sender, EventArgs e)
        {
            if (cheDo == 1)
            {


                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tbLink.Text = dlg.SelectedPath;

                    btnChon.Enabled = true;
                }
            }
            if (cheDo == 2)
            {


                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "SQL SERVER database backup file (*.bak)|*.bak";
                dlg.Title = "Database restore";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    tbLink.Text = dlg.FileName;

                    btnChon.Enabled = true;
                }
            }
        }

        private int cheDo = 1; // Giá trị mặc định là 1

        private void rbtBK_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtBK.Checked)
            {
                cheDo = 1;
                gbRS.Text = "Back up";
                btnChon.Text = "Back up";
                btnChon.Enabled = false;
            }
        }

        private void rbtRS_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtRS.Checked)
            {
                cheDo = 2; 
                gbRS.Text = "Restore";
                btnChon.Text = "Restore";
                btnChon.Enabled = false;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (tbLink.Text == string.Empty)
            {
                MessageBox.Show("Please enter file location");
            }
            else
            {
                if (cheDo == 1)
                {
                    string q = "BACKUP DATABASE [" + Program.database + "] TO DISK='" + tbLink.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    SqlCommand scmd = new SqlCommand(q, Program.conn);
                    scmd.ExecuteNonQuery();
                    // s.Speak("Backup taken successfully");
                    MessageBox.Show("Backup taken successfully", "Backup successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbLink.Text = "";
                    btnChon.Enabled = false;
                }
                else if (cheDo == 2)
                {
                    string sql1 = string.Format("ALTER DATABASE [" + Program.database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand cmd1 = new SqlCommand(sql1, Program.conn);
                    cmd1.ExecuteNonQuery();

                    string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + Program.database + "] FROM DISK='" + tbLink.Text + "' WITH REPLACE;");
                    SqlCommand cmd2 = new SqlCommand(sql2, Program.conn);
                    cmd2.ExecuteNonQuery();

                    string sql3 = string.Format("ALTER DATABASE [" + Program.database + "] SET MULTI_USER");
                    SqlCommand cmd3 = new SqlCommand(sql3, Program.conn);
                    cmd3.ExecuteNonQuery();
                    // s.Speak("Database Restored successfully");
                    MessageBox.Show("Database Restored successfully", "Restore Database successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbLink.Text = "";
                    btnChon.Enabled = false;
                }
            }
        }


        private string GetFormattedCurrentDate()
        {
            DateTime currentDate = DateTime.Now;
            return currentDate.ToString("yyyyMMdd");
        }

        private void FormRestore_Load(object sender, EventArgs e)
        {

        }
    }
}
