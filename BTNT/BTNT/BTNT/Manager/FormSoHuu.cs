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
    public partial class FormSoHuu : DevExpress.XtraEditors.XtraForm
    {
        public FormSoHuu()
        {
            InitializeComponent();
        }

        private void dgDSTPNT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSTPNT.Rows[e.RowIndex];
                cbbTP.SelectedValue = row.Cells["MATPNT"].Value.ToString();
            }
        }
        DataSet ds = null;
        int cheDo = 0;
        List<DtSoHuu> danhSachBackup = new List<DtSoHuu>();
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
        private void loadDataSoHuu()
        {
            if (ds == null)
            {
                ds = new DataSet();
            }

            string sqlCommand = "SELECT S.MATPNT, TP.TENTP, CONCAT(TG.HO, ' ', TG.TEN) AS HOVATEN, S.NGAYSOHUU ,S.GIATRI, S.TINHTRANG  FROM SO_HUU S JOIN TPNT TP ON TP.MATPNT = S.MATPNT JOIN TAC_GIA TG ON TP.MATG = TG.MATACGIA WHERE TP.MATPNT IN (SELECT MATPNT FROM SO_HUU)";
            DataTable dataTable = Program.ExecSqlDataTable(sqlCommand);

            // Xóa bảng "TPNT" nếu đã tồn tại trong DataSet
            if (ds.Tables.Contains("SO_HUU"))
                ds.Tables.Remove("SO_HUU");

            // Đặt tên cho bảng và thêm dữ liệu vào DataSet
            dataTable.TableName = "SO_HUU";
            ds.Tables.Add(dataTable);

            // Gán nguồn dữ liệu cho DataGridView
            dgDSSH.DataSource = ds.Tables["SO_HUU"];
            dgDSSH.Columns["MATPNT"].HeaderText = "Mã";
            dgDSSH.Columns["TENTP"].HeaderText = "Tên tác phẩm";
            dgDSSH.Columns["HOVATEN"].HeaderText = "Tên tác giả";
            dgDSSH.Columns["NGAYSOHUU"].HeaderText = "Ngở sở hữu";
            dgDSSH.Columns["GIATRI"].HeaderText = "Giá trị";
            dgDSSH.Columns["TINHTRANG"].HeaderText = "Tình trạng";
            // Thiết lập AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSSH.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
        private void layDanhSachTPSH()
        {
            string cmd = "SELECT TP.MATPNT, TP.TENTP FROM TPNT TP WHERE TP.MATPNT IN (SELECT MATPNT FROM SO_HUU)";
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

        private void dgDSMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSSH.Rows[e.RowIndex];
                cbbTP.SelectedValue = row.Cells["MATPNT"].Value.ToString();
                tbGiaTri.Text = row.Cells["GIATRI"].Value.ToString();
                if (DateTime.TryParse(row.Cells["NGAYSOHUU"].Value.ToString(), out DateTime ngayMuon))
                {
                    dpNgaySoHuu.Value = ngayMuon;
                }
                string value = row.Cells["TINHTRANG"].Value.ToString();
                if (value == "0")
                {
                    rbt2.Checked = true;
                }
                if (value == "1")
                {
                    rbt1.Checked = true;
                }


            }
        }

        private void FormSoHuu_Load(object sender, EventArgs e)
        {
            loadDataSoHuu();
            loadDataTPNT();
            dgDSSH.ReadOnly = true;
            dgDSTPNT.ReadOnly = true;
            gbTT.Enabled = false;
            gbDSSh.Enabled = false;
            gbTPNT.Enabled = false;
            cbbTP.Enabled = true;
            tbGiaTri.Enabled = true;
            rbt1.Enabled = true;
            rbt2.Enabled =  true;
            btnChon.Text = "Chọn";
            tbGiaTri.Text = "";
            cheDo = 0;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbTT.Enabled = true;
            gbDSSh.Enabled = false;
            gbTPNT.Enabled = true;
            cbbTP.Enabled = true;
            tbGiaTri.Enabled = true;
            rbt1.Enabled = true;
            rbt2.Enabled = true;
            btnChon.Text = "Thêm";
            tbGiaTri.Text = "";
            cheDo = 1;
            layDanhSachTPNT();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbTT.Enabled = true;
            gbDSSh.Enabled = true;
            gbTPNT.Enabled = false;
            cbbTP.Enabled = false;
            tbGiaTri.Enabled = true;
            rbt1.Enabled = true;
            rbt2.Enabled = true;
            btnChon.Text = "Ghi";
            tbGiaTri.Text = "";
            cheDo = 2;
            layDanhSachTPSH();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbTT.Enabled = true;
            gbDSSh.Enabled = true;
            gbTPNT.Enabled = false;
            cbbTP.Enabled = false;
            tbGiaTri.Enabled = false;
            rbt1.Enabled = false;
            rbt2.Enabled = false;
            btnChon.Text = "Xoá";
            tbGiaTri.Text = "";
            cheDo = 3;
            layDanhSachTPSH();
        }
        private bool kiemTraDauVao()
        {
           
            if (tbGiaTri.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống mã", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (Regex.IsMatch(tbGiaTri.Text.Trim(), @"^[.0-9]+$") == false)
            {
                MessageBox.Show("Mã chỉ chấp nhận chữ hoa, chữ thường và số", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (tbGiaTri.Text.Trim().Length > 20)
            {
                MessageBox.Show("Mã không thể lớn hơn 20 kí tự", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            bool kiemtra = kiemTraDauVao();
            if (kiemtra = false)
                return;

            string ma = cbbTP.SelectedValue.ToString();
            string giatri = tbGiaTri.Text.Trim();
            string tinhtrang = "";
            if (rbt1.Checked == true)
            {
                tinhtrang = "1";
            }
            else if (rbt2.Checked == true)
            {
                tinhtrang = "0";
            }
            DateTime ngaysohuu = dpNgaySoHuu.Value;
            if (cheDo == 1)
            {
                String cauTruyVan =
                   "DECLARE @result int " +
                   "EXEC @result = KiemTraMaTPNT_SOHUU '" +
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
                    string cauTruyVanInsert = "INSERT INTO SO_HUU(MATPNT, NGAYSOHUU, GIATRI, TINHTRANG) VALUES (@MATPNT, @NGAYSOHUU, @GIATRI, @TINHTRANG)";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MATPNT", ma);
                        command.Parameters.AddWithValue("@NGAYSOHUU", ngaysohuu);
                        command.Parameters.AddWithValue("@GIATRI", giatri);
                        command.Parameters.AddWithValue("@TINHTRANG", tinhtrang);

                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    // Cập nhật lại dữ liệu trong DataGridView
                    dgDSSH.DataSource = ds.Tables["SO_HUU"];

                    // Thiết lập lại AutoSizeMode của các cột
                    foreach (DataGridViewColumn column in dgDSTPNT.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    FormSoHuu_Load(sender, e);
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
                        try
                        {
                            string query = "UPDATE SO_HUU SET NGAYSOHUU = @NGAYSOHUU, GIATRI = @GIATRI, TINHTRANG = @TINHTRANG WHERE MATPNT = @MATPNT";
                            // Thực hiện câu truy vấn UPDATE
                            using (SqlConnection connection = new SqlConnection(Program.connstr))
                            {
                                connection.Open();
                                SqlCommand command = new SqlCommand(query, connection);

                                // Thêm các tham số
                                command.Parameters.AddWithValue("@MATPNT", ma);
                                command.Parameters.AddWithValue("@NGAYSOHUU", ngaysohuu);
                                command.Parameters.AddWithValue("@GIATRI", giatri);
                                command.Parameters.AddWithValue("@TINHTRANG", tinhtrang);

                                command.ExecuteNonQuery();
                                connection.Close();
                            }

                            // Hiển thị thông báo thành công
                            MessageBox.Show("Dữ liệu đã được sửa đổi thành công.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Load lại dữ liệu
                            FormSoHuu_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            // Hiển thị thông báo lỗi
                            MessageBox.Show("Sửa dữ liệu không thành công!\n\n" + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    FormSoHuu_Load(sender, e);
                    return;
                }
            else if (cheDo == 3)
            {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá mã khoa này?", "Xác nhận xoá",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DtSoHuu backup = new DtSoHuu(ma, ngaysohuu, tinhtrang, giatri);
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

                    FormSoHuu_Load(sender, e);
                    }

                }
            }
        private void PhucHoiDuLieuSoHuu()
        {
            if (danhSachBackup.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để phục hồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy dữ liệu cuối cùng trong danh sách
            DtSoHuu duLieuCanPhucHoi = danhSachBackup[danhSachBackup.Count - 1];

            // Thực hiện việc phục hồi dữ liệu
            string cauTruyVanInsert = "INSERT INTO SO_HUU(MATPNT, NGAYSOHUU, GIATRI, TINHTRANG) VALUES (@MATPNT, @NGAYSOHUU, @GIATRI, @TINHTRANG)";

            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                // Thêm các tham số
                command.Parameters.AddWithValue("@MATPNT", duLieuCanPhucHoi.MaTPNT);
                command.Parameters.AddWithValue("@NGAYSOHUU", duLieuCanPhucHoi.NgaySoHuu);
                command.Parameters.AddWithValue("@GIATRI", duLieuCanPhucHoi.GiaTri);
                command.Parameters.AddWithValue("@TINHTRANG", duLieuCanPhucHoi.TinhTrang);

                command.ExecuteNonQuery();
                connection.Close();
            }
            danhSachBackup.RemoveAt(danhSachBackup.Count - 1);

            // Cập nhật lại dữ liệu trong DataGridView
            dgDSSH.DataSource = ds.Tables["SO_HUU"];

            // Thiết lập lại AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSSH.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhucHoiDuLieuSoHuu();
            FormSoHuu_Load(sender, e);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSoHuu_Load(sender, e);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}