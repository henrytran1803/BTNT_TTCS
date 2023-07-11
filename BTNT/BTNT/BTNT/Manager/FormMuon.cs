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
    public partial class FormMuon : DevExpress.XtraEditors.XtraForm
    {
        public FormMuon()
        {
            InitializeComponent();
        }

        private void FormMuon_Load(object sender, EventArgs e)
        {
            dgDSMuon.ReadOnly = true;
            dgDSTPNT.ReadOnly = true;
            loadDataTPNT();
            loadDataMuon();
            layDanhSachBST();
            gbTT.Enabled = false;
            gbDSMuon.Enabled = false;
            gbTPNT.Enabled = false;
            cbbBST.Enabled = true;
            cbbTP.Enabled = true;
            dpNgayMuon.Enabled = true;
            dpNgayTra.Enabled = true;
            btnChon.Text = "Chọn";
            cheDo = 0;
            tbNDD.Text = "";
        }
        DataSet ds = null;
        int cheDo = 0;
        List<DtMuon> danhSachBackup = new List<DtMuon>();

        private void loadDataTPNT()
        {
            if (ds == null)
            {
                ds = new DataSet();
            }

            string sqlCommand = "SELECT TP.MATPNT, TP.TENTP, CONCAT(TG.HO, ' ', TG.TEN) AS HOVATEN FROM TPNT TP JOIN TAC_GIA TG ON TP.MATG = TG.MATACGIA WHERE TP.MATPNT NOT IN ( SELECT MATPNT FROM SO_HUU UNION SELECT MATPNT FROM MUON )";
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
        private void loadDataMuon()
        {
            if (ds == null)
            {
                ds = new DataSet();
            }

            string sqlCommand = "SELECT M.MATPNT, TP.TENTP, CONCAT(TG.HO, ' ', TG.TEN) AS HOVATEN, BS.TENBST, M.NGAYMUON,M.NGAYTRA, M.NGUOIDAIDIEN  FROM MUON M JOIN TPNT TP ON TP.MATPNT = M.MATPNT JOIN TAC_GIA TG ON TP.MATG = TG.MATACGIA JOIN BO_SUU_TAP BS ON BS.MABST = M.MABST  WHERE TP.MATPNT IN (SELECT MATPNT FROM MUON)";
            DataTable dataTable = Program.ExecSqlDataTable(sqlCommand);

            // Xóa bảng "TPNT" nếu đã tồn tại trong DataSet
            if (ds.Tables.Contains("MUON"))
                ds.Tables.Remove("MUON");

            // Đặt tên cho bảng và thêm dữ liệu vào DataSet
            dataTable.TableName = "MUON";
            ds.Tables.Add(dataTable);

            // Gán nguồn dữ liệu cho DataGridView
            dgDSMuon.DataSource = ds.Tables["MUON"];
            dgDSMuon.Columns["MATPNT"].HeaderText = "Mã";
            dgDSMuon.Columns["TENTP"].HeaderText = "Tên tác phẩm";
            dgDSMuon.Columns["HOVATEN"].HeaderText = "Tên tác giả";
            dgDSMuon.Columns["TENBST"].HeaderText = "Bộ sưu tập";
            dgDSMuon.Columns["NGAYMUON"].HeaderText = "Ngày mượn";
            dgDSMuon.Columns["NGAYTRA"].HeaderText = "Ngày trả";
            dgDSMuon.Columns["NGUOIDAIDIEN"].HeaderText = "Người đại diện";
            // Thiết lập AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSMuon.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void layDanhSachBST()
        {
            string cmd = "SELECT MABST, TENBST FROM BO_SUU_TAP ORDER BY TENBST";
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

                    cbbBST.DataSource = dt;
                    cbbBST.DisplayMember = "TENBST";
                    cbbBST.ValueMember = "MABST";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void layDanhSachTPNT()
        {
            string cmd = "SELECT MATPNT, TENTP FROM TPNT WHERE MATPNT NOT IN ( SELECT MATPNT FROM MUON UNION SELECT MATPNT FROM SO_HUU )";
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

        private void layDanhSachTPMUON()
        {
            string cmd = "SELECT TP.MATPNT, TP.TENTP FROM TPNT TP WHERE TP.MATPNT IN (SELECT MATPNT FROM MUON)";
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

        private void dgDSTPNT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSTPNT.Rows[e.RowIndex];
                cbbTP.SelectedValue = row.Cells["MATPNT"].Value.ToString();
            }
        }

        private void dgDSMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSMuon.Rows[e.RowIndex];
                cbbTP.SelectedValue = row.Cells["MATPNT"].Value.ToString();
                cbbBST.SelectedItem = row.Cells["TENBST"].Value.ToString();
                if (DateTime.TryParse(row.Cells["NGAYMUON"].Value.ToString(), out DateTime ngayMuon))
                {
                    dpNgayMuon.Value = ngayMuon;
                }

                if (DateTime.TryParse(row.Cells["NGAYTRA"].Value.ToString(), out DateTime ngayTra))
                {
                    dpNgayTra.Value = ngayTra;
                }
                
                    tbNDD.Text = row.Cells["NGUOIDAIDIEN"].Value.ToString();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbTT.Enabled = true;
            gbDSMuon.Enabled = false;
            gbTPNT.Enabled = true;
            cbbBST.Enabled = true;
            cbbTP.Enabled = true;
            dpNgayMuon.Enabled = true;
            dpNgayTra.Enabled = true;
            btnChon.Text = "Thêm";
            cheDo = 1;
            layDanhSachTPNT();
            tbNDD.Text = "";
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbTT.Enabled = true;
            gbDSMuon.Enabled = true;
            gbTPNT.Enabled = false;
            cbbBST.Enabled = true;
            cbbTP.Enabled = false;
            dpNgayMuon.Enabled = true;
            dpNgayTra.Enabled = true;
            btnChon.Text = "Ghi";
            cheDo = 2;
            layDanhSachTPMUON();
            tbNDD.Text = "";
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbTT.Enabled = true;
            gbDSMuon.Enabled = true;
            gbTPNT.Enabled = false;
            cbbBST.Enabled = false;
            cbbTP.Enabled = false;
            dpNgayMuon.Enabled = false;
            dpNgayTra.Enabled = false;
            btnChon.Text = "Xoá";
            cheDo = 3;
            layDanhSachTPMUON();
            tbNDD.Text = "";
        }
        private bool kiemTraDauVao()
        {
            if (tbNDD.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống Tên", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (Regex.IsMatch(tbNDD.Text.Trim(), @"^[a-zA-Z]+$") == false)
            {
                MessageBox.Show("Tên chỉ nhận chữ hoa và chữ thường", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (tbNDD.Text.Trim().Length > 50)
            {
                MessageBox.Show("Tên không thể lớn hơn 50 kí tự", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
           

            return true;
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            bool kiemTra = kiemTraDauVao();
            if (kiemTra == false)
                return;
            string ma = cbbTP.SelectedValue.ToString();
            string bst = cbbBST.SelectedValue.ToString();
            DateTime ngaymuon = dpNgayMuon.Value;
            DateTime ngaytra = dpNgayTra.Value;
            string ndd = tbNDD.Text;
            if (cheDo == 1)
            {
                bool kiemtra = KiemTraDauVao();
                if (kiemtra == false)
                    return;
                String cauTruyVan =
                   "DECLARE @result int " +
                   "EXEC @result = KiemTraMaTPNT_MUON '" +
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
                    string cauTruyVanInsert = "INSERT INTO MUON(MATPNT, MABST, NGAYMUON, NGAYTRA, NGUOIDAIDIEN) VALUES (@MATPNT, @MABST, @NGAYMUON, @NGAYTRA, @NGUOIDAIDIEN)";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MATPNT", ma);
                        command.Parameters.AddWithValue("@MABST", bst);
                        command.Parameters.AddWithValue("@NGAYMUON", ngaymuon);
                        command.Parameters.AddWithValue("@NGAYTRA", ngaytra);
                        command.Parameters.AddWithValue("@NGUOIDAIDIEN", ndd);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    // Cập nhật lại dữ liệu trong DataGridView
                    dgDSMuon.DataSource = ds.Tables["MUON"];

                    // Thiết lập lại AutoSizeMode của các cột
                    foreach (DataGridViewColumn column in dgDSTPNT.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    FormMuon_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Mã đã tồn tại. Vui lòng chọn mã khác.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else if (cheDo == 2)
            {
                String cauTruyVan =
                  "DECLARE @result int " +
                  "EXEC @result = KiemTraXoaSua_MUON '" +
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
                int result2 = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();

                if (result2 == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa dữ liệu tác phẩm này?", "Xác nhận sửa",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            string query = "UPDATE MUON SET MABST = @MABST, NGAYMUON = @NGAYMUON, NGAYTRA = @NGAYTRA, NGUOIDAIDIEN = @NGUOIDAIDIEN WHERE MATPNT = @MATPNT";
                            // Thực hiện câu truy vấn UPDATE
                            using (SqlConnection connection = new SqlConnection(Program.connstr))
                            {
                                connection.Open();
                                SqlCommand command = new SqlCommand(query, connection);

                                // Thêm các tham số
                                command.Parameters.AddWithValue("@MATPNT", ma);
                                command.Parameters.AddWithValue("@MABST", bst);
                                command.Parameters.AddWithValue("@NGAYMUON", ngaymuon);
                                command.Parameters.AddWithValue("@NGAYTRA", ngaytra);
                                command.Parameters.AddWithValue("@NGUOIDAIDIEN", ndd);
                                command.ExecuteNonQuery();
                                connection.Close();
                            }

                            // Hiển thị thông báo thành công
                            MessageBox.Show("Dữ liệu đã được sửa đổi thành công.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Load lại dữ liệu
                            FormMuon_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            // Hiển thị thông báo lỗi
                            MessageBox.Show("Sửa dữ liệu không thành công!\n\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    FormMuon_Load(sender, e);
                    return;
                }
                else if(result2 ==1)
                {
                    MessageBox.Show("Không sửa được vì quá ngày. Vui lòng chọn mã khác.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (cheDo == 3)
            {
                String cauTruyVan =
                     "DECLARE @result int " +
                     "EXEC @result = KiemTraXoaSua_MUON '" +
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
                int result3 = int.Parse(Program.myReader.GetValue(0).ToString());
                Program.myReader.Close();

                if (result3 == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá mã khoa này?", "Xác nhận xoá",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DtMuon backup = new DtMuon(ma, bst, ngaymuon, ngaytra,ndd);
                    danhSachBackup.Add(backup);

                    string query = "DELETE FROM MUON WHERE MATPNT = @MATPNT";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@MATPNT", ma);
                        command.ExecuteNonQuery();
                    }

                    // Không cần thiết lập lại nguồn dữ liệu và AutoSizeMode

                    FormMuon_Load(sender, e);
                    }

                }
                else if (result3 == 1)
                {
                    MessageBox.Show("Không xoá được vì quá ngày. Vui lòng chọn mã khác.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
        }
        private bool KiemTraDauVao()
        {
            DateTime ngayMuon = dpNgayMuon.Value;
            DateTime ngayTra = dpNgayTra.Value;
            DateTime ngayHienTai = DateTime.Today;

            if (ngayTra > ngayMuon && ngayTra > ngayHienTai)
            {
                return true; // Đầu vào hợp lệ
            }
            else
            {
                return false; // Đầu vào không hợp lệ
            }
        }

        private void PhucHoiDuLieuMuon()
        {
            if (danhSachBackup.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để phục hồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy dữ liệu cuối cùng trong danh sách
            DtMuon duLieuCanPhucHoi = danhSachBackup[danhSachBackup.Count - 1];

            // Thực hiện việc phục hồi dữ liệu
            string cauTruyVanInsert = "INSERT INTO MUON(MATPNT, MABST, NGAYMUON, NGAYTRA,NGUOIDAIDIEN) VALUES (@MATPNT, @MABST, @NGAYMUON, @NGAYTRA,@NGUOIDAIDIEN)";

            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                // Thêm các tham số
                command.Parameters.AddWithValue("@MATPNT", duLieuCanPhucHoi.MaTPNT);
                command.Parameters.AddWithValue("@MABST", duLieuCanPhucHoi.MaBST);
                command.Parameters.AddWithValue("@NGAYMUON", duLieuCanPhucHoi.NgayMuon);
                command.Parameters.AddWithValue("@NGAYTRA", duLieuCanPhucHoi.NgayTra);
                command.Parameters.AddWithValue("@NGUOIDAIDIEN", duLieuCanPhucHoi.NguoiDaiDien);
                command.ExecuteNonQuery();
                connection.Close();
            }
            // Xóa dữ liệu khỏi danh sách phục hồi
            danhSachBackup.RemoveAt(danhSachBackup.Count - 1);

            // Cập nhật lại dữ liệu trong DataGridView
            dgDSMuon.DataSource = ds.Tables["MUON"];

            // Thiết lập lại AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSMuon.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhucHoiDuLieuMuon();
            FormMuon_Load(sender, e);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormMuon_Load(sender, e);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gbTPNT_Enter(object sender, EventArgs e)
        {

        }

        private void tbNDD_TextChanged(object sender, EventArgs e)
        {

        }

        /**End**/
    }
}