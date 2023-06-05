using BTNT.DoiTuong;
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
        int cheDo = 0;
        private void FormCTCTL_Load(object sender, EventArgs e)
        {
            layDanhSachCTL();
            gbDSCTL.Enabled = false;
            gbTPNT.Enabled = false;
            gbTT.Enabled = false;
            tbCTL.Enabled =   false;
            tbTP.Enabled = false;
            btnChon.Text = "Chọn";
            cheDo = 0;
            tbTP.Text = "";
        }
        private void layDanhSachCTL()
        {
            string cmd = "SELECT cl.MACTL, cl.TENCTL FROM CUOC_TRIEN_LAM cl WHERE cl.NGAYBATDAU > GETDATE()";

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
            tbCTL.Text = selectedValue;
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

        private void dgDSTPNT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSTPNT.Rows[e.RowIndex];
                tbTP.Text = row.Cells["MATPNT"].Value.ToString();
                
            }
        }

        private void dgDSCTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSCTL.Rows[e.RowIndex];
                tbTP.Text = row.Cells["MATPNT"].Value.ToString();

            }
        }
        List<DtCTCTL> danhSachBackup = new List<DtCTCTL>();
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbDSCTL.Enabled = true;
            gbTPNT.Enabled = false;
            gbTT.Enabled = true;
            tbCTL.Enabled = false;
            tbTP.Enabled = false;
            btnChon.Text = "Ghi";
            cheDo = 2;
            tbTP.Text = "";
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbDSCTL.Enabled = false;
            gbTPNT.Enabled = true;
            gbTT.Enabled = true;
            tbCTL.Enabled = false;
            tbTP.Enabled = false;
            btnChon.Text = "Thêm";
            cheDo = 1;
            tbTP.Text = "";
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbDSCTL.Enabled = true;
            gbTPNT.Enabled = false;
            gbTT.Enabled = true;
            tbCTL.Enabled = false;
            tbTP.Enabled = false;
            btnChon.Text = "Xoá";
            cheDo = 3;
            tbTP.Text = "";
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string ctl = tbCTL.Text;
            string tp = tbTP.Text;
            if (cheDo == 1)
            {
                String cauTruyVan =
                  "DECLARE @result int " +
                  "EXEC @result = sp_themCTL '" +
                  ctl + "','"+tp+"'" +
                  "SELECT 'Value' = @result";

                SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);

                try
                {
                    Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                    // Không có kết quả trả về, kết thúc luôn
                    if (Program.myReader == null)
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thực thi Stored Procedure thất bại!\n\n" + ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    return;
                }


                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();

                if (result == 0)
                {
                    string cauTruyVanInsert = "INSERT INTO CT_CTL(MACTL, MATPNT) VALUES (@MACTL, @MATPNT)";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MACTL", ctl);
                        command.Parameters.AddWithValue("@MATPNT", tp);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    // Cập nhật lại dữ liệu trong DataGridView
                    dgDSCTL.DataSource = ds.Tables["CT_CTL"];

                    // Thiết lập lại AutoSizeMode của các cột
                    foreach (DataGridViewColumn column in dgDSCTL.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    FormCTCTL_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("CTL đã dừng.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (cheDo == 3)
            {
                String cauTruyVan =
                 "DECLARE @result int " +
                 "EXEC @result = sp_kiemtraxoaCTCTL '" +
                 ctl + "'" +
                 "SELECT 'Value' = @result";

                SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);

                try
                {
                    Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                    // Không có kết quả trả về, kết thúc luôn
                    if (Program.myReader == null)
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thực thi Stored Procedure thất bại!\n\n" + ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                    return;
                }


                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();

                if (result == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá MÃ KHÁC này?", "Xác nhận xoá",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {

                        DtCTCTL backup = new DtCTCTL(ctl,tp);

                        danhSachBackup.Add(backup);

                        string query = "DELETE FROM CT_CTL WHERE MACTL = '" + ctl + "' AND MATPNT = '"+tp+"'";

                        // Kết nối đến cơ sở dữ liệu và thực thi câu truy vấn
                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                        }

                        // Cập nhật lại dữ liệu trong DataGridView
                        dgDSCTL.DataSource = ds.Tables["CT_CTL"];

                        // Thiết lập lại AutoSizeMode của các cột
                        foreach (DataGridViewColumn column in dgDSCTL.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    FormCTCTL_Load(sender, e);
                    }
                }
                else
                    {
                        MessageBox.Show("Quá ngày không thể xoá.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        private void PhucHoiDuLieuCTCTL()
        {
            if (danhSachBackup.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để phục hồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DtCTCTL duLieuCanPhucHoi = danhSachBackup[danhSachBackup.Count - 1];


            // Thực hiện việc phục hồi dữ liệu
            string cauTruyVanInsert = "INSERT INTO CT_CTL(MACTL, MATPNT) VALUES (@MACTL, @MATPNT)";

            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                // Thêm các tham số
                command.Parameters.AddWithValue("@MACTL", duLieuCanPhucHoi.MaCTL);
                command.Parameters.AddWithValue("@MATPNT", duLieuCanPhucHoi.MaTPNT);
                command.ExecuteNonQuery();
                connection.Close();
            }


            // Xóa dữ liệu khỏi danh sách phục hồi
            danhSachBackup.RemoveAt(danhSachBackup.Count - 1);

            // Cập nhật lại dữ liệu trong DataGridView
            dgDSCTL.DataSource = ds.Tables["CT_CTL"];

            // Thiết lập lại AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSCTL.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhucHoiDuLieuCTCTL();
            FormCTCTL_Load(sender, e);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCTCTL_Load(sender, e);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}