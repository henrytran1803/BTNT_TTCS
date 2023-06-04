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
    public partial class FormTrienLam : DevExpress.XtraEditors.XtraForm
    {
        public FormTrienLam()
        {
            InitializeComponent();
        }

        private void FormTrienLam_Load(object sender, EventArgs e)
        {
            loadDataTL();
            dgDSTL.ReadOnly = true;
            gbDSTL.Enabled = false;
            gbTT.Enabled = false;
            tbTen.Enabled = true;
            dpDT.Enabled = true;
            dpDE.Enabled = true;
            tbMa.Enabled = true;
            tbTen.Text = "";
            tbMa.Text = "";
            btnChon.Text = "Chọn";
            cheDo = 0;
        }
        DataSet ds = null;
        List<DtCTL> danhSachBackup = new List<DtCTL>();

        private void loadDataTL()
        {
            if (ds == null)
            {
                ds = new DataSet();
            }

            string sqlCommand = "SELECT MACTL, TENCTL, NGAYBATDAU, NGAYKETTHUC FROM CUOC_TRIEN_LAM";
            DataTable dataTable = Program.ExecSqlDataTable(sqlCommand);

            // Xóa bảng "TPNT" nếu đã tồn tại trong DataSet
            if (ds.Tables.Contains("CUOC_TRIEN_LAM"))
                ds.Tables.Remove("CUOC_TRIEN_LAM");

            // Đặt tên cho bảng và thêm dữ liệu vào DataSet
            dataTable.TableName = "CUOC_TRIEN_LAM";
            ds.Tables.Add(dataTable);

            // Gán nguồn dữ liệu cho DataGridView
            dgDSTL.DataSource = ds.Tables["CUOC_TRIEN_LAM"];
            dgDSTL.Columns["MACTL"].HeaderText = "Mã";
            dgDSTL.Columns["TENCTL"].HeaderText = "Tên cuộc triển lãm";
            dgDSTL.Columns["NGAYBATDAU"].HeaderText = "Ngày bắt đầu";
            dgDSTL.Columns["NGAYKETTHUC"].HeaderText = "Ngày kết thúc";
            // Thiết lập AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSTL.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        int cheDo = 0;

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbDSTL.Enabled = true;
            gbTT.Enabled = true;
            tbTen.Enabled = true;
            dpDT.Enabled = true;
            dpDE.Enabled = true;
            tbMa.Enabled = true;
            tbTen.Text = "";
            tbMa.Text = "";
            btnChon.Text = "Thêm";
            cheDo = 1;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbDSTL.Enabled = true;
            gbTT.Enabled = true;
            tbTen.Enabled = true;
            dpDT.Enabled = true;
            dpDE.Enabled = true;
            tbMa.Enabled = false;
            tbTen.Text = "";
            tbMa.Text = "";
            btnChon.Text = "Ghi";
            cheDo = 2;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbDSTL.Enabled = true;
            gbTT.Enabled = true;
            tbTen.Enabled = false;
            dpDT.Enabled = false;
            dpDE.Enabled = false;
            tbMa.Enabled = false;
            tbTen.Text = "";
            tbMa.Text = "";
            btnChon.Text = "Xoá";
            cheDo = 3;
        }

        private void dgDSTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSTL.Rows[e.RowIndex];
                tbMa.Text = row.Cells["MACTL"].Value.ToString();
                tbTen.Text = row.Cells["TENCTL"].Value.ToString();
                if (DateTime.TryParse(row.Cells["NGAYBATDAU"].Value.ToString(), out DateTime ngayS))
                {
                    dpDT.Value = ngayS;
                }
                if (DateTime.TryParse(row.Cells["NGAYKETTHUC"].Value.ToString(), out DateTime ngayE))
                {
                    dpDE.Value = ngayE;
                }


            }
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
                MessageBox.Show("Không bỏ trống mã", "Thông báo", MessageBoxButtons.OK);
                return false;
            }


            if (tbTen.Text.Trim().Length > 30)
            {
                MessageBox.Show("Tên không thể lớn hơn 30 kí tự", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            DateTime dt = dpDT.Value; // Lấy giá trị DateTime từ DateTimePicker dpdt
            DateTime de = dpDE.Value; // Lấy giá trị DateTime từ DateTimePicker dpde

            if (dt >= de)
            {
                return false;
            }

            return true;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            bool kiemtra = kiemTraDauVao();
            if (kiemtra == false)
                return;
            string ma = tbMa.Text.Trim();
            string ten = tbTen.Text;
            DateTime dt = dpDT.Value;
            DateTime de = dpDE.Value;
            if (cheDo == 1)
            {
                String cauTruyVan =
                  "DECLARE @result int " +
                  "EXEC @result = Them_CTL '" +
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
                    string cauTruyVanInsert = "INSERT INTO CUOC_TRIEN_LAM(MACTL, TENCTL, NGAYBATDAU, NGAYKETTHUC) VALUES (@MACTL, @TENCTL, @NGAYBATDAU, @NGAYKETTHUC)";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MACTL", ma);
                        command.Parameters.AddWithValue("@TENCTL", ten);
                        command.Parameters.AddWithValue("@NGAYBATDAU", dt);
                        command.Parameters.AddWithValue("@NGAYKETTHUC", de);


                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    // Cập nhật lại dữ liệu trong DataGridView
                    dgDSTL.DataSource = ds.Tables["CUOC_TRIEN_LAM"];

                    // Thiết lập lại AutoSizeMode của các cột
                    foreach (DataGridViewColumn column in dgDSTL.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    FormTrienLam_Load(sender, e);
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
                    string query = "UPDATE CUOC_TRIEN_LAM SET TENCTL = @TENCTL, NGAYBATDAU = @NGAYBATDAU, NGAYKETTHUC = @NGAYKETTHUC WHERE MACTL = @MACTL";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("@MACTL", ma);
                        command.Parameters.AddWithValue("@TENCTL", ten);
                        command.Parameters.AddWithValue("@NGAYBATDAU", dt);
                        command.Parameters.AddWithValue("@NGAYKETTHUC", de);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                }
                FormTrienLam_Load(sender, e);
                return;

            }
            else if (cheDo == 3)
            {

                String cauTruyVan = "DECLARE @result int " +
                                    "EXEC @result = Xoa_CTL '" +
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

                        DtCTL backup = new DtCTL(ma, ten, dt,de);

                        danhSachBackup.Add(backup);

                        string query = "DELETE FROM CUOC_TRIEN_LAM WHERE MACTL = '" + ma + "'";

                        // Kết nối đến cơ sở dữ liệu và thực thi câu truy vấn
                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                        }

                        // Cập nhật lại dữ liệu trong DataGridView
                        dgDSTL.DataSource = ds.Tables["CUOC_TRIEN_LAM"];

                        // Thiết lập lại AutoSizeMode của các cột
                        foreach (DataGridViewColumn column in dgDSTL.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                        FormTrienLam_Load(sender, e);
                    }

                }
                else
                {
                    MessageBox.Show("Bộ sưu tập này có tác phẩm nghệ thuật, không thể xoá.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
        private void PhucHoiDuLieuCTL()
        {
            if (danhSachBackup.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để phục hồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DtCTL duLieuCanPhucHoi = danhSachBackup[danhSachBackup.Count - 1];


            string cauTruyVanInsert = "INSERT INTO CUOC_TRIEN_LAM(MACTL, TENCTL, NGAYBATDAU, NGAYKETTHUC) VALUES (@MACTL, @TENCTL, @NGAYBATDAU, @NGAYKETTHUC)";

            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                // Thêm các tham số
                command.Parameters.AddWithValue("@MACTL", duLieuCanPhucHoi.MaCTL);
                command.Parameters.AddWithValue("@TENCTL", duLieuCanPhucHoi.TenCTL);
                command.Parameters.AddWithValue("@NGAYBATDAU", duLieuCanPhucHoi.NgayBD);
                command.Parameters.AddWithValue("@NGAYKETTHUC", duLieuCanPhucHoi.NgayKT);


                command.ExecuteNonQuery();
                connection.Close();
            }
            // Xóa dữ liệu khỏi danh sách phục hồi
            danhSachBackup.RemoveAt(danhSachBackup.Count - 1);

            // Cập nhật lại dữ liệu trong DataGridView
            dgDSTL.DataSource = ds.Tables["CUOC_TRIEN_LAM"];

            // Thiết lập lại AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSTL.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhucHoiDuLieuCTL();
            FormTrienLam_Load(sender, e);

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTrienLam_Load(sender, e);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}