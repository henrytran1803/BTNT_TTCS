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
    public partial class FormBST : DevExpress.XtraEditors.XtraForm
    {
        public FormBST()
        {
            InitializeComponent();
        }

        private void cbbPC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void layDanhSachHT()
        {
            string cmd = "SELECT MAHT, TENHINHTHUC FROM HINH_THUC";
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

                    cbbHT.DataSource = dt;
                    cbbHT.DisplayMember = "TENHINHTHUC";
                    cbbHT.ValueMember = "MAHT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        DataSet ds = null;
        private void loadDataBST()
        {
            if (ds == null)
            {
                ds = new DataSet();
            }

            string sqlCommand = "SELECT B.MABST, B.TENBST, H.TENHINHTHUC, B.SDT, B.DIACHI, B.MOTA FROM BO_SUU_TAP B JOIN HINH_THUC H ON H.MAHT = B.MAHT";
            DataTable dataTable = Program.ExecSqlDataTable(sqlCommand);

            // Xóa bảng "TPNT" nếu đã tồn tại trong DataSet
            if (ds.Tables.Contains("BO_SUU_TAP"))
                ds.Tables.Remove("BO_SUU_TAP");

            // Đặt tên cho bảng và thêm dữ liệu vào DataSet
            dataTable.TableName = "BO_SUU_TAP";
            ds.Tables.Add(dataTable);

            // Gán nguồn dữ liệu cho DataGridView
            dgDSBST.DataSource = ds.Tables["BO_SUU_TAP"];
            dgDSBST.Columns["MABST"].HeaderText = "Mã";
            dgDSBST.Columns["TENBST"].HeaderText = "Tên bộ sưu tập";
            dgDSBST.Columns["TENHINHTHUC"].HeaderText = "Hình thức";
            dgDSBST.Columns["SDT"].HeaderText = "Số điện thoại";
            dgDSBST.Columns["DIACHI"].HeaderText = "Địa chỉ";
            dgDSBST.Columns["MOTA"].HeaderText = "Mô tả";
            // Thiết lập AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSBST.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        int cheDo = 0;
        private void FormBST_Load(object sender, EventArgs e)
        {
            layDanhSachHT();
            loadDataBST();

            dgDSBST.ReadOnly = true;
            gbTT.Enabled = false;
            gbDSBST.Enabled = false;
            tbMa.Enabled = true;
            tbTen.Enabled = true;
            tbMT.Enabled = true;
            tbDC.Enabled = true;
            tbSDT.Enabled = true;
            cbbHT.Enabled = true;
            tbSDT.Text = "";
            tbMa.Text = "";
            tbTen.Text = "";
            tbMT.Text = "";
            tbDC.Text = "";
            btnChon.Text = "Chọn";
            cheDo = 0;
        }

        private void dgDSBST_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSBST.Rows[e.RowIndex];
                tbMa.Text = row.Cells["MABST"].Value.ToString();
                tbTen.Text = row.Cells["TENBST"].Value.ToString();
                tbMT.Text = row.Cells["MOTA"].Value.ToString();
                tbDC.Text = row.Cells["DIACHI"].Value.ToString();
                tbSDT.Text = row.Cells["SDT"].Value.ToString();
                cbbHT.SelectedItem = row.Cells["TENHINHTHUC"].Value.ToString();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbTT.Enabled = true;
            gbDSBST.Enabled = true;
            tbMa.Enabled = true;
            tbTen.Enabled = true;
            tbMT.Enabled = true;
            tbDC.Enabled = true;
            tbSDT.Enabled = true;
            cbbHT.Enabled = true;
            tbSDT.Text = "";
            tbMa.Text = "";
            tbTen.Text = "";
            tbMT.Text = "";
            tbDC.Text = "";
            btnChon.Text = "Thêm";
            cheDo = 1;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbTT.Enabled = true;
            gbDSBST.Enabled = true;
            tbMa.Enabled = false;
            tbTen.Enabled = true;
            tbMT.Enabled = true;
            tbDC.Enabled = true;
            tbSDT.Enabled = true;
            cbbHT.Enabled = true;
            tbSDT.Text = "";
            tbMa.Text = "";
            tbTen.Text = "";
            tbMT.Text = "";
            tbDC.Text = "";
            btnChon.Text = "Ghi";
            cheDo = 2;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbTT.Enabled = true;
            gbDSBST.Enabled = true;
            tbMa.Enabled = false;
            tbTen.Enabled = false;
            tbMT.Enabled = false;
            tbDC.Enabled = false;
            tbSDT.Enabled = false;
            cbbHT.Enabled = false;
            tbSDT.Text = "";
            tbMa.Text = "";
            tbTen.Text = "";
            tbMT.Text = "";
            tbDC.Text = "";
            btnChon.Text = "Xoá";
            cheDo = 3;
        }
        private bool kiemTraDauVao()
        {
            if (tbMa.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống mã", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (Regex.IsMatch(tbMa.Text.Trim(), @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã chỉ chấp nhận chữ hoa, chữ thường và số", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (tbMa.Text.Trim().Length > 8)
            {
                MessageBox.Show("Mã không thể lớn hơn 8 kí tự", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (tbTen.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống tên", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (tbSDT.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống SĐT", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (tbMT.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống Mô tả", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (tbDC.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (Regex.IsMatch(tbSDT.Text.Trim(), @"^[0-9]+$") == false)
            {
                MessageBox.Show("SĐT chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (tbSDT.Text.Trim().Length > 10)
            {
                MessageBox.Show("Mã không thể lớn hơn 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        List<DtBST> danhSachBackup = new List<DtBST>();

        private void btnChon_Click(object sender, EventArgs e)
        {
            bool kiemTra = kiemTraDauVao();
            if (kiemTra == false)
                return;
            string ma = tbMa.Text.Trim();
            string ten = tbTen.Text;
            string sDT = tbSDT.Text;
            string diaChi = tbDC.Text;
            string moTa = tbMT.Text;
            string hinhThuc = cbbHT.SelectedValue.ToString();
            if (cheDo ==1)
            {
                String cauTruyVan =
                  "DECLARE @result int " +
                  "EXEC @result = sp_KiemTraThemBST '" +
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
                    string cauTruyVanInsert = "INSERT INTO BO_SUU_TAP(MABST, TENBST, MOTA, MAHT, SDT, DIACHI) VALUES (@MABST, @TENBST, @MOTA, @MAHT, @SDT, @DIACHI)";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MABST", ma);
                        command.Parameters.AddWithValue("@TENBST", ten);
                        command.Parameters.AddWithValue("@MOTA", moTa);
                        command.Parameters.AddWithValue("@MAHT", hinhThuc);
                        command.Parameters.AddWithValue("@SDT", sDT);
                        command.Parameters.AddWithValue("@DIACHI", diaChi);

                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    // Cập nhật lại dữ liệu trong DataGridView
                    dgDSBST.DataSource = ds.Tables["BO_SUU_TAP"];

                    // Thiết lập lại AutoSizeMode của các cột
                    foreach (DataGridViewColumn column in dgDSBST.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    FormBST_Load(sender, e);
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
                    string query = "UPDATE BO_SUU_TAP SET MAHT = @MAHT, DIACHI = @DIACHI, SDT = @SDT, MOTA = @MOTA, TENBST = @TENBST WHERE MABST = @MABST";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MABST", ma);
                        command.Parameters.AddWithValue("@TENBST", ten);
                        command.Parameters.AddWithValue("@MOTA", moTa);
                        command.Parameters.AddWithValue("@MAHT", hinhThuc);
                        command.Parameters.AddWithValue("@SDT", sDT);
                        command.Parameters.AddWithValue("@DIACHI", diaChi);

                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                }
                FormBST_Load(sender, e);
                return;

            }
            else if (cheDo == 3)
            {

                String cauTruyVan =  "DECLARE @result int " +
                                    "EXEC @result = sp_XoaBST '" +
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
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá MÃ KHÁC này?", "Xác nhận xoá",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {

                        DtBST backup = new DtBST(ma,ten, hinhThuc, sDT, diaChi, moTa);

                        danhSachBackup.Add(backup);

                        string query = "DELETE FROM BO_SUU_TAP WHERE MABST = '" + ma + "'";

                        // Kết nối đến cơ sở dữ liệu và thực thi câu truy vấn
                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                        }

                        // Cập nhật lại dữ liệu trong DataGridView
                        dgDSBST.DataSource = ds.Tables["BO_SUU_TAP"];

                        // Thiết lập lại AutoSizeMode của các cột
                        foreach (DataGridViewColumn column in dgDSBST.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                        FormBST_Load(sender, e);
                    }

                }
                else
                {
                    MessageBox.Show("Bộ sưu tập này có tác phẩm nghệ thuật, không thể xoá.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                }
        }
        private void PhucHoiDuLieuBST()
        {
            if (danhSachBackup.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để phục hồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DtBST duLieuCanPhucHoi = danhSachBackup[danhSachBackup.Count - 1];


            // Thực hiện việc phục hồi dữ liệu
            string cauTruyVanInsert = "INSERT INTO BO_SUU_TAP(MABST, TENBST, MOTA, MAHT, SDT, DIACHI) VALUES (@MABST, @TENBST, @MOTA, @MAHT, @SDT, @DIACHI)";

            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                // Thêm các tham số
                command.Parameters.AddWithValue("@MABST", duLieuCanPhucHoi.MaBST);
                command.Parameters.AddWithValue("@TENBST", duLieuCanPhucHoi.TenBST);
                command.Parameters.AddWithValue("@MOTA", duLieuCanPhucHoi.MoTa);
                command.Parameters.AddWithValue("@MAHT", duLieuCanPhucHoi.MaHT);
                command.Parameters.AddWithValue("@SDT", duLieuCanPhucHoi.SDT);
                command.Parameters.AddWithValue("@DIACHI", duLieuCanPhucHoi.DiaChi);

                command.ExecuteNonQuery();
                connection.Close();
            }

            // Xóa dữ liệu khỏi danh sách phục hồi
            danhSachBackup.RemoveAt(danhSachBackup.Count - 1);

            // Cập nhật lại dữ liệu trong DataGridView
            dgDSBST.DataSource = ds.Tables["BO_SUU_TAP"];

            // Thiết lập lại AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSBST.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhucHoiDuLieuBST();
            FormBST_Load(sender, e);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormBST_Load(sender, e);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        /**end**/
    }
}