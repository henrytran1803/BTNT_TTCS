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
using System.Text.RegularExpressions;
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
            dgDSTPNT.ReadOnly = true;
            dgDSPTDK.ReadOnly = true;
            gbDSTPDK.Enabled = false;
            gbTPNT.Enabled = false;
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
            btnChon.Text = "Chọn";
            tbCC.Text = "";
            tbKL.Text = "";
        }
        private void loadCBB()
        {
         
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
        private void layDanhSachTPDK()
        {
            string cmd = "SELECT TP.MATPNT, TP.TENTP FROM TPNT TP WHERE TP.MATPNT IN (SELECT MATPNT FROM DIEU_KHAC)";
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

                    cbbPC.DataSource = dt;
                    cbbPC.DisplayMember = "TENPC";
                    cbbPC.ValueMember = "MAPC";
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

            string sqlCommand = "SELECT DK.MATPNT, TP.TENTP, CONCAT(TG.HO, ' ', TG.TEN) AS HOVATEN, DK.KHOILUONG, DK.CHIEUCAO, PC.TENPC, VL.TENVL FROM TPNT TP JOIN TAC_GIA TG ON TP.MATG = TG.MATACGIA JOIN DIEU_KHAC DK ON DK.MATPNT = TP.MATPNT JOIN PHONG_CACH_DK PC ON PC.MAPC = DK.MAPC JOIN VAT_LIEU_DK VL ON VL.MAVL = DK.MAVL  WHERE TP.MATPNT IN (SELECT MATPNT FROM DIEU_KHAC)";
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
            dgDSPTDK.Columns["KHOILUONG"].HeaderText = "Khối lượng";
            dgDSPTDK.Columns["CHIEUCAO"].HeaderText = "Chiều cao";
            dgDSPTDK.Columns["TENPC"].HeaderText = "Phong cách";
            dgDSPTDK.Columns["TENVL"].HeaderText = "Vật liệu";
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
            btnChon.Text = "Thêm";
            tbCC.Text = "";
            tbKL.Text = "";
            gbDSTPDK.Enabled = false;
            gbTPNT.Enabled = true;

            layDanhSachTPNT();
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
            btnChon.Text = "Thêm";
            tbCC.Text = "";
            tbKL.Text = "";
            gbDSTPDK.Enabled = true;
            gbTPNT.Enabled = false;
            
            layDanhSachTPDK();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cheDo = 3;
            gbTT.Enabled = true;
            tbCC.Enabled = false;
            tbKL.Enabled = false;
            cbbVL.Enabled = false;
            cbbTP.Enabled = true;
            cbbPC.Enabled = false;
            btnChon.Enabled = true;
            btnChon.Text = "Xoá";
            tbCC.Text = "";
            tbKL.Text = "";
            gbDSTPDK.Enabled = true;
            gbTPNT.Enabled = false;

            layDanhSachTPDK();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDieuKhac_Load(sender, e);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private bool kiemTraDauVao()
        {
            if (tbCC.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống chiều cao", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (Regex.IsMatch(tbCC.Text.Trim(), @"^[0-9]+$") == false)
            {
                MessageBox.Show(" chiều cao chỉ chấp nhận à số", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (tbCC.Text.Trim().Length > 4)
            {
                MessageBox.Show("Chiều cao không thể lớn hơn 8 kí tự", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (tbKL.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống khối lượng", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (Regex.IsMatch(tbKL.Text.Trim(), @"^[0-9]+$") == false)
            {
                MessageBox.Show("khối lượng chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (tbKL.Text.Trim().Length > 5)
            {
                MessageBox.Show("khối lượng không thể lớn hơn 5 kí tự", "Thông báo", MessageBoxButtons.OK);
            }

            return true;
        }
        List<DtDieuKhac> danhSachBackup = new List<DtDieuKhac>();
        private void btnChon_Click(object sender, EventArgs e)
        {
            bool kiemTra = kiemTraDauVao();
            if (kiemTra == false)
                return;
            string ma = cbbTP.SelectedValue.ToString();
            string khoiLuong = tbKL.Text;
            string chieuCao = tbCC.Text;
            string vatLieu = cbbVL.SelectedValue.ToString();
            string phongCach = cbbPC.SelectedValue.ToString();

            // Kiểm tra mã TPNT trong bảng DIEU_KHAC
            if (cheDo == 1)
            {
                String cauTruyVan =
                   "DECLARE @result int " +
                   "EXEC @result = KiemTraMATPNT_Dieu_Khac '" +
                   ma + "' " +
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
                string cauTruyVanInsert = "INSERT INTO DIEU_KHAC(MATPNT, MAVL, CHIEUCAO, KHOILUONG, MAPC) VALUES (@MATPNT, @MAVL, @CHIEUCAO, @KHOILUONG, @MAPC)";

                using (SqlConnection connection = new SqlConnection(Program.connstr))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                    // Thêm các tham số
                    command.Parameters.AddWithValue("@MATPNT", ma);
                    command.Parameters.AddWithValue("@MAVL", vatLieu);
                    command.Parameters.AddWithValue("@CHIEUCAO", chieuCao);
                    command.Parameters.AddWithValue("@KHOILUONG", khoiLuong);
                    command.Parameters.AddWithValue("@MAPC", phongCach);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                // Cập nhật lại dữ liệu trong DataGridView
                dgDSPTDK.DataSource = ds.Tables["TPNT_DK"];

                // Thiết lập lại AutoSizeMode của các cột
                foreach (DataGridViewColumn column in dgDSTPNT.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                FormDieuKhac_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Mã đã tồn tại. Vui lòng chọn mã khác.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
            else if (cheDo == 2)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa dữ liệu tác phẩm này?", "Xác nhận sửa",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "UPDATE DIEU_KHAC SET MAVL = @MAVL, CHIEUCAO = @CHIEUCAO, KHOILUONG = @KHOILUONG, MAPC = @MAPC WHERE MATPNT = @MATPNT";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MATPNT", ma);
                        command.Parameters.AddWithValue("@MAVL", vatLieu);
                        command.Parameters.AddWithValue("@CHIEUCAO", chieuCao);
                        command.Parameters.AddWithValue("@KHOILUONG", khoiLuong);
                        command.Parameters.AddWithValue("@MAPC", phongCach);

                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                }
                FormDieuKhac_Load(sender, e);
                return;

            }
            else if (cheDo == 3)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá mã khoa này?", "Xác nhận xoá",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    DtDieuKhac backup = new DtDieuKhac(ma, vatLieu, khoiLuong, chieuCao, phongCach);

                    danhSachBackup.Add(backup);

                    string query = "DELETE FROM DIEU_KHAC WHERE MATPNT = '" + ma + "'";

                    // Kết nối đến cơ sở dữ liệu và thực thi câu truy vấn
                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                    }

                    // Cập nhật lại dữ liệu trong DataGridView
                    dgDSPTDK.DataSource = ds.Tables["TPNT_DK"];

                    // Thiết lập lại AutoSizeMode của các cột
                    foreach (DataGridViewColumn column in dgDSTPNT.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    FormDieuKhac_Load(sender, e);
                }

            }

        }
        private void PhucHoiDuLieuTPNTDK()
        {
            if (danhSachBackup.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để phục hồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy dữ liệu cuối cùng trong danh sách
            DtDieuKhac duLieuCanPhucHoi = danhSachBackup[danhSachBackup.Count - 1];

            // Thực hiện việc phục hồi dữ liệu
            string cauTruyVanInsert = "INSERT INTO DIEU_KHAC(MATPNT, MAVL, CHIEUCAO, KHOILUONG, MAPC) VALUES (@MATPNT, @MAVL, @CHIEUCAO, @KHOILUONG, @MAPC)";

            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                // Thêm các tham số
                command.Parameters.AddWithValue("@MATPNT", duLieuCanPhucHoi.MaTPNT);
                command.Parameters.AddWithValue("@MAVL", duLieuCanPhucHoi.MaVL);
                command.Parameters.AddWithValue("@CHIEUCAO", duLieuCanPhucHoi.ChieuCao);
                command.Parameters.AddWithValue("@KHOILUONG", duLieuCanPhucHoi.KhoiLuong);
                command.Parameters.AddWithValue("@MAPC", duLieuCanPhucHoi.PhongCach);

                command.ExecuteNonQuery();
                connection.Close();
            }


            // Xóa dữ liệu khỏi danh sách phục hồi
            danhSachBackup.RemoveAt(danhSachBackup.Count - 1);

            // Cập nhật lại dữ liệu trong DataGridView
            dgDSPTDK.DataSource = ds.Tables["TPNT_DK"];

            // Thiết lập lại AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSPTDK.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void dgDSTPNT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSTPNT.Rows[e.RowIndex];
                cbbTP.SelectedItem = row.Cells["MATPNT"].Value.ToString();
            }
        }

        private void dgDSPTDK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSPTDK.Rows[e.RowIndex];
                cbbTP.SelectedItem = row.Cells["MATPNT"].Value.ToString();
                cbbPC.SelectedItem = row.Cells["TENPC"].Value.ToString();
                cbbVL.SelectedItem = row.Cells["TENVL"].Value.ToString();
                tbKL.Text = row.Cells["KHOILUONG"].Value.ToString();
                tbCC.Text = row.Cells["CHIEUCAO"].Value.ToString();
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhucHoiDuLieuTPNTDK();
            FormDieuKhac_Load(sender, e);
        }
    }
}