using BTNT.DoiTuong;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTNT.Manager
{
    public partial class FormTacGia : DevExpress.XtraEditors.XtraForm
    {
        public FormTacGia()
        {
            InitializeComponent();
        }

        private void FormTacGia_Load(object sender, EventArgs e)
        {
            loadCombobox();
            loadDataTacGia();
            dgDSTacGia.ReadOnly = true;
            cheDo = 0;
            gbThongTin.Enabled = false;
            tbMa.Enabled = true;
            tbHo.Enabled = true;
            tbTen.Enabled = true;
            tbNgayS.Enabled = true;
            tbThangS.Enabled = true;
            tbNamS.Enabled = true;
            tbNgayM.Enabled = true;
            tbThangM.Enabled = true;
            tbNamM.Enabled = true;
            cbbQuocTich.Enabled = true;
            cbbThoiDai.Enabled = true;
            cbbPhongCach.Enabled = true;
            tbDienGiai.Enabled = true;
            btnChon.Text = "Chọn";
        }
        private void loadCombobox()
        {
            layDanhSachQuocGia();
            layDanhSachPhongCach();
            layDanhSachThoiDai();
        }
        private void layDanhSachQuocGia()
        {
            string cmd = "SELECT MAQT, TENQT FROM QUOC_GIA";
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

                    cbbQuocTich.DataSource = dt;
                    cbbQuocTich.DisplayMember = "TENQT";
                    cbbQuocTich.ValueMember = "MAQT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void layDanhSachThoiDai()
        {
            string cmd = "SELECT MATD, TENTD FROM THOI_DAI";
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

                    cbbThoiDai.DataSource = dt;
                    cbbThoiDai.DisplayMember = "TENTD";
                    cbbThoiDai.ValueMember = "MATD";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void layDanhSachPhongCach()
        {
            string cmd = "SELECT MAPC, TENPC FROM PHONG_CACH_TG";
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

                    cbbPhongCach.DataSource = dt;
                    cbbPhongCach.DisplayMember = "TENPC";
                    cbbPhongCach.ValueMember = "MAPC";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        DataSet ds = null;
        private void loadDataTacGia()
        {
            if (ds == null)
            {
                ds = new DataSet();
            }

            string sqlCommand = "SELECT TG.MATACGIA, TG.HO, TG.TEN, TG.NGAYSINH, TG.NGAYMAT, QT.TENQT, TD.TENTD, PC.TENPC, TG.DIENGIAI FROM TAC_GIA TG JOIN PHONG_CACH_TG PC ON TG.MAPC = PC.MAPC JOIN QUOC_GIA QT ON TG.MAQT=QT.MAQT JOIN THOI_DAI TD ON TD.MATD=TG.MATD";

            DataTable dataTable = Program.ExecSqlDataTable(sqlCommand);

            // Xóa bảng "TPNT" nếu đã tồn tại trong DataSet
            if (ds.Tables.Contains("TAC_GIA"))
                ds.Tables.Remove("TAC_GIA");

            // Đặt tên cho bảng và thêm dữ liệu vào DataSet
            dataTable.TableName = "TAC_GIA";
            ds.Tables.Add(dataTable);

            // Gán nguồn dữ liệu cho DataGridView
            dgDSTacGia.DataSource = ds.Tables["TAC_GIA"];
            dgDSTacGia.Columns["MATACGIA"].HeaderText = "Mã";
            dgDSTacGia.Columns["HO"].HeaderText = "Hoj";
            dgDSTacGia.Columns["TEN"].HeaderText = "Tên"; // Sử dụng trường mới đã gộp
            dgDSTacGia.Columns["NGAYSINH"].HeaderText = "Ngày sinh";
            dgDSTacGia.Columns["NGAYMAT"].HeaderText = "Ngày mất";
            dgDSTacGia.Columns["TENQT"].HeaderText = "Quốc tịch";
            dgDSTacGia.Columns["TENTD"].HeaderText = "Thời đại";
            dgDSTacGia.Columns["TENPC"].HeaderText = "Phong cách";
            dgDSTacGia.Columns["DIENGIAI"].HeaderText = "Diễn giải";
            // Thiết lập AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSTacGia.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        int cheDo = 0;
        private void dgDSTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSTacGia.Rows[e.RowIndex];
                tbMa.Text = row.Cells["MATACGIA"].Value.ToString();
                tbHo.Text = row.Cells["HO"].Value.ToString();
                tbTen.Text = row.Cells["TEN"].Value.ToString();

                // Tách ngày sinh thành ngày, tháng, năm
                DateTime ngaySinh = Convert.ToDateTime(row.Cells["NGAYSINH"].Value);
                tbNgayS.Text = ngaySinh.Day.ToString();
                tbThangS.Text = ngaySinh.Month.ToString();
                tbNamS.Text = ngaySinh.Year.ToString();

                // Tách ngày mất thành ngày, tháng, năm
                DateTime ngayMat = Convert.ToDateTime(row.Cells["NGAYMAT"].Value);
                tbNgayM.Text = ngayMat.Day.ToString();
                tbThangM.Text = ngayMat.Month.ToString();
                tbNamM.Text = ngayMat.Year.ToString();

                cbbQuocTich.SelectedItem = row.Cells["TENQT"].Value.ToString();
                cbbThoiDai.SelectedItem = row.Cells["TENTD"].Value.ToString();
                cbbPhongCach.SelectedItem = row.Cells["TENPC"].Value.ToString();
                tbDienGiai.Text = row.Cells["DIENGIAI"].Value.ToString();
            }
        }
        private bool kiemTraDauVao()
        {
            // Lấy giá trị từ TextBox ngày sinh
            int ngaySinh, thangSinh, namSinh;
            if (!int.TryParse(tbNgayS.Text, out ngaySinh) ||
                !int.TryParse(tbThangS.Text, out thangSinh) ||
                !int.TryParse(tbNamS.Text, out namSinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return false;
            }

            // Lấy giá trị từ TextBox ngày mất
            int ngayMat, thangMat, namMat;
            if (!int.TryParse(tbNgayM.Text, out ngayMat) ||
                !int.TryParse(tbThangM.Text, out thangMat) ||
                !int.TryParse(tbNamM.Text, out namMat))
            {
                MessageBox.Show("Ngày mất không hợp lệ!");
                return false;
            }

            // Kiểm tra ngày sinh và ngày mất
            DateTime ngaySinhDT, ngayMatDT;
            try
            {
                ngaySinhDT = new DateTime(namSinh, thangSinh, ngaySinh);
                ngayMatDT = new DateTime(namMat, thangMat, ngayMat);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Ngày tháng năm không hợp lệ!");
                return false;
            }

            // Kiểm tra ràng buộc ngày sinh < ngày mất
            if (ngaySinhDT >= ngayMatDT)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn ngày mất!");
                return false;
            }
            // Kiểm tra giá trị ngày sinh
            if (ngaySinh < 1 || ngaySinh > DateTime.DaysInMonth(namSinh, thangSinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return false;
            }

            // Kiểm tra giá trị ngày mất
            if (ngayMat < 1 || ngayMat > DateTime.DaysInMonth(namMat, thangMat))
            {
                MessageBox.Show("Ngày mất không hợp lệ!");
                return false;
            }
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
            if (tbHo.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống họ", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (tbTen.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống tên", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cheDo = 1;
            gbThongTin.Enabled = true;
            tbMa.Enabled = true;
            tbHo.Enabled = true;
            tbTen.Enabled = true;
            tbNgayS.Enabled = true;
            tbThangS.Enabled = true;
            tbNamS.Enabled = true;
            tbNgayM.Enabled = true;
            tbThangM.Enabled = true;
            tbNamM.Enabled = true;
            cbbQuocTich.Enabled = true;
            cbbThoiDai.Enabled = true;
            cbbPhongCach.Enabled = true;
            tbDienGiai.Enabled = true; btnChon.Text = "Thêm";
        }
        List<DtTacGia> danhSachBackup = new List<DtTacGia>();
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cheDo = 2;
            gbThongTin.Enabled = true;
            tbMa.Enabled = false;
            tbHo.Enabled = true;
            tbTen.Enabled = true;
            tbNgayS.Enabled = true;
            tbThangS.Enabled = true;
            tbNamS.Enabled = true;
            tbNgayM.Enabled = true;
            tbThangM.Enabled = true;
            tbNamM.Enabled = true;
            cbbQuocTich.Enabled = true;
            cbbThoiDai.Enabled = true;
            cbbPhongCach.Enabled = true;
            tbDienGiai.Enabled = true;
            btnChon.Text = "Ghi";
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cheDo = 3;
            gbThongTin.Enabled = true;
            tbMa.Enabled = false;
            tbHo.Enabled = false;
            tbTen.Enabled = false;
            tbNgayS.Enabled = false;
            tbThangS.Enabled = false;
            tbNamS.Enabled = false;
            tbNgayM.Enabled = false;
            tbThangM.Enabled = false;
            tbNamM.Enabled = false;
            cbbQuocTich.Enabled = false;
            cbbThoiDai.Enabled = false;
            cbbPhongCach.Enabled = false;
            tbDienGiai.Enabled = false;
            btnChon.Text = "Xoá";

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            bool kiemTra = kiemTraDauVao();
            if (kiemTra == false)
                return;
            string maTacGia = tbMa.Text.Trim();
            string hoTacGia = tbHo.Text;
            string tenTacGia = tbTen.Text;
            string ngaySinhNgay = tbNgayS.Text.Trim();
            string thangSinhNgay = tbThangS.Text.Trim();
            string namSinhNgay = tbNamS.Text.Trim();
            string ngayMatNgay = tbNgayM.Text.Trim();
            string thangMatNgay = tbThangM.Text.Trim();
            string namMatNgay = tbNamM.Text.Trim();
            string quocTich = cbbQuocTich.SelectedValue.ToString();
            string thoiDai = cbbThoiDai.SelectedValue.ToString();
            string phongCach = cbbPhongCach.SelectedValue.ToString();
            string dienGiai = tbDienGiai.Text;

            // Kiểm tra ngày tháng năm sinh và ngày tháng năm mất
            string ngaySinh = namSinhNgay + "/" + thangSinhNgay + "/" + ngaySinhNgay;
            string ngayMat = namMatNgay + "/" + thangMatNgay + "/" + ngayMatNgay;
            if (cheDo ==1)
            {
                String cauTruyVan =
                   "DECLARE @result int " +
                   "EXEC @result = CheckAuthorExists '" +
                   tbMa.Text.Trim() + "' " +
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

                if (result == 1)
                {
                    // Lấy giá trị từ TextBox và ComboBox
                    

                    // Tạo câu truy vấn INSERT
                    string cauTruyVanInsert = "INSERT INTO Tac_Gia (MATACGIA, HO, TEN, NGAYSINH, NGAYMAT, MAQT, MATD, MAPC, DIENGIAI) VALUES (@MaTacGia, @HoTacGia, @TenTacGia, @NgaySinh, @NgayMat, @MaQT, @MaTD, @MaPC, @DienGiai)";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MaTacGia", maTacGia);
                        command.Parameters.AddWithValue("@HoTacGia", hoTacGia);
                        command.Parameters.AddWithValue("@TenTacGia", tenTacGia);
                        command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        command.Parameters.AddWithValue("@NgayMat", ngayMat);
                        command.Parameters.AddWithValue("@MaQT", quocTich);
                        command.Parameters.AddWithValue("@MaTD", thoiDai);
                        command.Parameters.AddWithValue("@MaPC", phongCach);
                        command.Parameters.AddWithValue("@DienGiai", dienGiai);

                        command.ExecuteNonQuery();
                        connection.Close();
                    }



                    // Cập nhật lại dữ liệu trong DataGridView
                    dgDSTacGia.DataSource = ds.Tables["Tac_Gia"];

                    // Thiết lập lại AutoSizeMode của các cột
                    foreach (DataGridViewColumn column in dgDSTacGia.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    FormTacGia_Load(sender, e);

                }
                else
                {
                    MessageBox.Show("Mã tác giả đã tồn tại. Vui lòng chọn mã giảng viên khác.", "Thông báo",
                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }
            else if(cheDo==2)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa dữ liệu khoa này?", "Xác nhận sửa",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = $"UPDATE Tac_Gia SET HO = @HoTacGia, TEN = @TenTacGia, NGAYSINH = @NgaySinh, NGAYMAT = @NgayMat, MAQT = @MaQT, MATD = @MaTD, MAPC = @MaPC, DIENGIAI = @DienGiai WHERE MATACGIA = @MaTacGia";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@HoTacGia", hoTacGia);
                        command.Parameters.AddWithValue("@TenTacGia", tenTacGia);
                        command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                        command.Parameters.AddWithValue("@NgayMat", ngayMat);
                        command.Parameters.AddWithValue("@MaQT", quocTich);
                        command.Parameters.AddWithValue("@MaTD", thoiDai);
                        command.Parameters.AddWithValue("@MaPC", phongCach);
                        command.Parameters.AddWithValue("@DienGiai", dienGiai);
                        command.Parameters.AddWithValue("@MaTacGia", maTacGia);

                        command.ExecuteNonQuery();
                    }


                    FormTacGia_Load(sender, e);
                }

                return;
            }
            else if(cheDo==3)
            {
                String cauTruyVan =
    "DECLARE @result int " +
    "EXEC @result = CheckMATACGIA '" +
    tbMa.Text.Trim() + "' " +
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

                // Nếu kết quả trả về là 0 (mã khoa không tồn tại), thực hiện thêm dữ liệu vào bảng KHOA
                if (result == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá mã khoa này?", "Xác nhận xoá",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {

                        DtTacGia backup = new DtTacGia(tbMa.Text.Trim(), tbHo.Text, tbTen.Text, ngaySinh, ngayMat, quocTich, thoiDai, phongCach, dienGiai);

                        danhSachBackup.Add(backup);

                        string query = "DELETE FROM TAC_GIA WHERE MATACGIA = '" + tbMa.Text.Trim() + "'";

                        // Kết nối đến cơ sở dữ liệu và thực thi câu truy vấn
                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                        }

                        // Cập nhật lại dữ liệu trong DataGridView
                        dgDSTacGia.DataSource = ds.Tables["TAC_GIA"];

                        // Thiết lập lại AutoSizeMode của các cột
                        foreach (DataGridViewColumn column in dgDSTacGia.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                        FormTacGia_Load(sender, e);

                    }
                }
            }
          
        }

       private void PhucHoiDuLieuTacGia()
        {
            if (danhSachBackup.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để phục hồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy dữ liệu cuối cùng trong danh sách
            DtTacGia duLieuCanPhucHoi = danhSachBackup[danhSachBackup.Count - 1];

            // Thực hiện việc phục hồi dữ liệu
            string cauTruyVanInsert = "INSERT INTO Tac_Gia (MATACGIA, HO, TEN, NGAYSINH, NGAYMAT, MAQT, MATD, MAPC, DIENGIAI) VALUES (@MaTacGia, @HoTacGia, @TenTacGia, @NgaySinh, @NgayMat, @MaQT, @MaTD, @MaPC, @DienGiai)";

            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                // Thêm các tham số
                command.Parameters.AddWithValue("@MaTacGia", duLieuCanPhucHoi.MaTacGia);
                command.Parameters.AddWithValue("@HoTacGia", duLieuCanPhucHoi.HoTacGia);
                command.Parameters.AddWithValue("@TenTacGia", duLieuCanPhucHoi.TenTacGia);
                command.Parameters.AddWithValue("@NgaySinh", duLieuCanPhucHoi.NgaySinh);
                command.Parameters.AddWithValue("@NgayMat", duLieuCanPhucHoi.NgayMat);
                command.Parameters.AddWithValue("@MaQT", duLieuCanPhucHoi.MaQT);
                command.Parameters.AddWithValue("@MaTD", duLieuCanPhucHoi.MaTD);
                command.Parameters.AddWithValue("@MaPC", duLieuCanPhucHoi.MaPC);
                command.Parameters.AddWithValue("@DienGiai", duLieuCanPhucHoi.DienGiai);

                command.ExecuteNonQuery();
                connection.Close();
            }

            // Xóa dữ liệu khỏi danh sách phục hồi
            danhSachBackup.RemoveAt(danhSachBackup.Count - 1);

            // Cập nhật lại dữ liệu trong DataGridView
            dgDSTacGia.DataSource = ds.Tables["GIAOVIEN"];

            // Thiết lập lại AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSTacGia.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhucHoiDuLieuTacGia();
            FormTacGia_Load(sender, e);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTacGia_Load(sender, e);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}