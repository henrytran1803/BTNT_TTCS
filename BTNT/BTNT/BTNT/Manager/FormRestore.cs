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
                    string cmd = "BACKUP DATABASE [" + Program.database + "] TO DISK= '" + tbLink.Text + "\\database" + GetFormattedCurrentDate() + ".bak'";

                    try
                    {
                        SqlCommand sqlCommand = new SqlCommand(cmd, Program.conn);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Backup successful!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Backup failed: " + ex.Message);
                    }
                    tbLink.Text = "";
                    btnChon.Enabled = false;
                }
                else if (cheDo == 2)
                {
                    string cmd = "RESTORE DATABASE [" + Program.database + "] FROM DISK '" + tbLink.Text + "' WITH NoRecovery";

                    try
                    {
                        SqlCommand sqlCommand = new SqlCommand(cmd, Program.conn);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Restore successful!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Restore failed: " + ex.Message);
                    }
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
    }
}
