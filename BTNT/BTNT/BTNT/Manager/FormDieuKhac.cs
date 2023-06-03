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
    public partial class FormDieuKhac : DevExpress.XtraEditors.XtraForm
    {
        public FormDieuKhac()
        {
            InitializeComponent();
        }
        int cheDo = 0;
        private void FormDieuKhac_Load(object sender, EventArgs e)
        {
            loadDataTPNT();
            loadDataTPDK();
            loadCBB();
            cheDo = 0;
            gbTT.Enabled = false;
            tbCC.Enabled = true;
            tbKL.Enabled = true;
            cbbVL.Enabled = true;
            cbbTP.Enabled = true;
            cbbPC.Enabled = true;
            btnChon.Enabled = true;
            btnChonMa.Enabled = true;
            btnChon.Text = "Chọn";
            tbCC.Text = "";
            tbKL.Text = "";
        }
        private void loadCBB()
        {
            layDanhSachTPNT();
            layDanhSachVL();
            layDanhSachPC();
        }
        private void layDanhSachTPNT()
        {
            string cmd = "SELECT MATPNT, TENTP FROM TPNT WHERE MATPNT NOT IN ( SELECT MATPNT FROM HOI_HOA UNION SELECT MATPNT FROM KHAC UNION SELECT MATPNT FROM DIEU_KHAC )";
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

                    cbbTP.DataSource = dt;
                    cbbTP.DisplayMember = "TENTP";
                    cbbTP.ValueMember = "MATPNT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbVL_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void layDanhSachVL()
        {
            string cmd = "SELECT MAVL, TENVL FROM VAT_LIEU_DK";

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

                    cbbVL.DataSource = dt;
                    cbbVL.DisplayMember = "TENVL";
                    cbbVL.ValueMember = "MAVL";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void layDanhSachPC()
        {
            string cmd = "SELECT MAPC, TENPC FROM PHONG_CACH_DK";
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

                    cbbTP.DataSource = dt;
                    cbbTP.DisplayMember = "TENPC";
                    cbbTP.ValueMember = "MAPC";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        DataSet ds = null;
        private void loadDataTPNT()
        {
            if (ds == null)
            {
                ds = new DataSet();
            }

            string sqlCommand = "SELECT TP.MATPNT, TP.TENTP, CONCAT(TG.HO, ' ', TG.TEN) AS HOVATEN FROM TPNT TP JOIN TAC_GIA TG ON TP.MATG = TG.MATACGIA WHERE TP.MATPNT NOT IN ( SELECT MATPNT FROM HOI_HOA UNION SELECT MATPNT FROM KHAC UNION  SELECT MATPNT FROM DIEU_KHAC)";

            DataTable dataTable = Program.ExecSqlDataTable(sqlCommand);

            // Xóa bảng "TPNT" nếu đã tồn tại trong DataSet
            if (ds.Tables.Contains("TPNT"))
                ds.Tables.Remove("TPNT");

            // Đặt tên cho bảng và thêm dữ liệu vào DataSet
            dataTable.TableName = "TPNT";
            ds.Tables.Add(dataTable);

            // Gán nguồn dữ liệu cho DataGridView
            dgDSTPNT.DataSource = ds.Tables["TPNT"];
            dgDSTPNT.Columns["MATPNT"].HeaderText = "Mã";
            dgDSTPNT.Columns["TENTP"].HeaderText = "Tên tac phẩm";
            dgDSTPNT.Columns["HOVATEN"].HeaderText = "Tên tác giả"; 

            // Thiết lập AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSTPNT.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void loadDataTPDK()
        {
            if (ds == null)
            {
                ds = new DataSet();
            }

            string sqlCommand = "SELECT TP.MATPNT, TP.TENTP, CONCAT(TG.HO, ' ', TG.TEN) AS HOVATEN FROM TPNT TP JOIN TAC_GIA TG ON TP.MATG = TG.MATACGIA WHERE TP.MATPNT IN (SELECT MATPNT FROM DIEU_KHAC)";
            DataTable dataTable = Program.ExecSqlDataTable(sqlCommand);

            // Xóa bảng "TPNT" nếu đã tồn tại trong DataSet
            if (ds.Tables.Contains("TPNT_DK"))
                ds.Tables.Remove("TPNT_DK");

            // Đặt tên cho bảng và thêm dữ liệu vào DataSet
            dataTable.TableName = "TPNT_DK";
            ds.Tables.Add(dataTable);

            // Gán nguồn dữ liệu cho DataGridView
            dgDSPTDK.DataSource = ds.Tables["TPNT_DK"];
            dgDSPTDK.Columns["MATPNT"].HeaderText = "Mã";
            dgDSPTDK.Columns["TENTP"].HeaderText = "Tên tac phẩm";
            dgDSPTDK.Columns["HOVATEN"].HeaderText = "Tên tác giả";

            // Thiết lập AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSPTDK.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cheDo = 1;
            gbTT.Enabled = true;
            tbCC.Enabled = true;
            tbKL.Enabled = true;
            cbbVL.Enabled = true;
            cbbTP.Enabled = true;
            cbbPC.Enabled = true;
            btnChon.Enabled = true;
            btnChonMa.Enabled = true;
            btnChon.Text = "Thêm";
            tbCC.Text = "";
            tbKL.Text = "";
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cheDo = 2;
            gbTT.Enabled = true;
            tbCC.Enabled = true;
            tbKL.Enabled = true;
            cbbVL.Enabled = true;
            cbbTP.Enabled = true;
            cbbPC.Enabled = true;
            btnChon.Enabled = true;
            btnChonMa.Enabled = true;
            btnChon.Text = "Thêm";
            tbCC.Text = "";
            tbKL.Text = "";
        }
    }
}