using DevExpress.XtraEditors;
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

namespace BTNT.View
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbLoginName.Text = "";
            tbMatKhau.PasswordChar = '❅';
            tbMatKhau.MaxLength = 14;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbLoginName.Text.Trim() == "" || tbMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản & mật khẩu không thể bỏ trống", "Thông Báo", MessageBoxButtons.OK);
                return;
            }

            Program.loginName = tbLoginName.Text.Trim();
            Program.loginPassword = tbMatKhau.Text.Trim();

            if (Program.KetNoi() == 0)
                return;

            String statement = "EXEC sp_DangNhap '" + Program.loginName + "'";

            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(statement, connection))
                {
                    // Thực thi stored procedure và lấy giá trị trả về
                    string role = command.ExecuteScalar()?.ToString();

                    if (role == "NGUOIDUNG")
                    {
                        Program.formMain.nguoiDung();
                    }
                    else if (role == "NHANVIEN")
                    {
                        Program.formMain.nhanVien();
                    }

                    Program.formMain.ennable();
                    this.Visible = false;
                }
            }
        }

    }
}