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

namespace BTNT.Manager
{
    public partial class FormCTCTL : DevExpress.XtraEditors.XtraForm
    {
        public FormCTCTL()
        {
            InitializeComponent();
        }

        private void FormCTCTL_Load(object sender, EventArgs e)
        {
            layDanhSachCTL();
        }
        private void layDanhSachCTL()
        {
            string cmd = "SELECT cl.MACTL, cl.TENCTL FROM CUOC_TRIEN_LAM cl";

            try
            {
                using (SqlConnection connection = new SqlConnection(Program.connstr))
                {
                    connection.Open();

                    DataTable dt = new DataTable();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd, connection))
                    {
                        da.Fill(dt);
                    }

                    cbbCTL.DataSource = dt;
                    cbbCTL.DisplayMember = "TENCTL";
                    cbbCTL.ValueMember = "MACTL";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void layDanhSachTPNT()
        {
            string cmd = "SELECT MACTL, TENCTL FROM CUOC_TRIEN_LAM";
            try
            {
                using (SqlConnection connection = new SqlConnection(Program.connstr))
                {
                    connection.Open();

                    DataTable dt = new DataTable();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd, connection))
                    {
                        da.Fill(dt);
                    }

                    cbbCTL.DataSource = dt;
                    cbbCTL.DisplayMember = "TENCTL";
                    cbbCTL.ValueMember = "MACTL";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbbCTL_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cbbCTL.SelectedValue.ToString();
            loadDataCTL(selectedValue);
            loadDataTPNT(selectedValue);
        }

        DataSet ds = null;
        private void loadDataCTL(string MA)
        {
            if (ds == null)
            {
                ds = new DataSet();
            }

            string sqlCommand = "SELECT C.MATPNT, TP.TENTP, TL.TENCTL, TL.NGAYBATDAU, TL.NGAYKETTHUC FROM CT_CTL C JOIN TPNT TP ON C.MATPNT = TP.MATPNT JOIN CUOC_TRIEN_LAM TL ON TL.MACTL = C.MACTL WHERE C.MACTL = '"+MA+"'";
            DataTable dataTable = Program.ExecSqlDataTable(sqlCommand);

            // Xóa bảng "TPNT" nếu đã tồn tại trong DataSet
            if (ds.Tables.Contains("CT_CTL"))
                ds.Tables.Remove("CT_CTL");

            // Đặt tên cho bảng và thêm dữ liệu vào DataSet
            dataTable.TableName = "CT_CTL";
            ds.Tables.Add(dataTable);

            // Gán nguồn dữ liệu cho DataGridView
            dgDSCTL.DataSource = ds.Tables["CT_CTL"];
            dgDSCTL.Columns["MATPNT"].HeaderText = "Mã tác phẩm";
            dgDSCTL.Columns["TENTP"].HeaderText = "Tên tác phẩm";
            dgDSCTL.Columns["TENCTL"].HeaderText = "Tên cuộc triển lãm";
            dgDSCTL.Columns["NGAYBATDAU"].HeaderText = "Ngày bắt đầu";
            dgDSCTL.Columns["NGAYKETTHUC"].HeaderText = "Ngày kết thúc";
            // Thiết lập AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSCTL.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void loadDataTPNT(string MA)
        {
            if (ds == null)
            {
                ds = new DataSet();
            }

            string sqlCommand = "EXEC LayDanhSach_tpnt_CTL @MACTL = '" + MA + "';" +
                 "SELECT MATPNT, TENTP FROM TPNT;"; 
            DataTable dataTable = Program.ExecSqlDataTable(sqlCommand);

            // Xóa bảng "TPNT" nếu đã tồn tại trong DataSet
            if (ds.Tables.Contains("TPNT"))
                ds.Tables.Remove("TPNT");

            // Đặt tên cho bảng và thêm dữ liệu vào DataSet
            dataTable.TableName = "TPNT";
            ds.Tables.Add(dataTable);

            // Gán nguồn dữ liệu cho DataGridView
            dgDSTPNT.DataSource = ds.Tables["TPNT"];
            dgDSTPNT.Columns["MATPNT"].HeaderText = "Mã tác phẩm";
            dgDSTPNT.Columns["TENTP"].HeaderText = "Tên tác phẩm";
        
            // Thiết lập AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSTPNT.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }


    }
}