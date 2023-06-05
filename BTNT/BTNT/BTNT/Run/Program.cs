using BTNT.View;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTNT
{
    static class Program
    {

        public static SqlConnection conn = new SqlConnection();//conn
        public static String connstr = "";//connstr
        public static String connstrPublisher = "Data Source=HENRYF46A;Initial Catalog=BTNT;Integrated Security=True";
        public static SqlDataReader myReader;//myReader
        public static String database = "BTNT";

        public static String serverName = "HENRYF46A";//servername
        public static String serverNameLeft = "";
        public static String userName = "";//username

        public static String loginName = "nd";//mlogin
        public static String loginPassword = "123456";//password


        public static String currentLogin = "";//mloginDN
        public static String currentPassword = "";//passwordDN





        /**********************************************
         * role: tên nhóm quyền đang đăng nhập: CONGTY - CHINHANH - USER
         * staff: tên nhân viên đang đăng nhập
         * brand: chi nhánh đang đăng nhập
         **********************************************/
        public static String role = "NGUOIDUNG";// mGroup
        public static String staff = "";//mHoten
        public static int brand = 0;//mChiNhanh



        public static BindingSource bindingSource = new BindingSource();//bds_dspm
        public static FormMain formMain;


        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.serverName + ";Initial Catalog=" +
                       Program.database + ";User ID=" +
                       Program.loginName + ";password=" + Program.loginPassword;
                Program.conn.ConnectionString = Program.connstr;

                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nXem lại tài khoản và mật khẩu.\n " + e.Message, "", MessageBoxButtons.OK);
                //Console.WriteLine(e.Message);
                return 0;
            }
        }
        public static void UpdateDatabase(DataTable dataTable, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connstr))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();

                    // Xác định các truy vấn Insert, Update, Delete dựa trên DataTable và tên bảng
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.SelectCommand = new SqlCommand("SELECT * FROM " + tableName, connection);
                    dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
                    dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                    dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();

                    // Cập nhật dữ liệu vào cơ sở dữ liệu
                    dataAdapter.Update(dataTable);

                    // Thông báo thành công
                    MessageBox.Show("Dữ liệu đã được cập nhật vào bảng " + tableName + ".", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi
                    MessageBox.Show("Lỗi khi cập nhật dữ liệu vào cơ sở dữ liệu:\n\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.formMain = new FormMain();
            Application.Run(formMain);
        }
    }
}

