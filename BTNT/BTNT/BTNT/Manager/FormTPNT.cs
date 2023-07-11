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
    public partial class FormTPNT : DevExpress.XtraEditors.XtraForm
    {
        public FormTPNT()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int cheDo = 0;
        private void FormTPNT_Load(object sender, EventArgs e)
        {
            loadCBB();
            loadDataTacGia();
            gbThongTin.Enabled = false;
            tbMa.Enabled = true;
            tbTen.Enabled = true;
            cbbTacGia.Enabled = true;
            cbbCD.Enabled = true;
            cbbQT.Enabled = true;
            cbbTD.Enabled = true;
            tbNam.Enabled = true;
            tbDienGiai.Enabled = true;
            cheDo = 0;
            btnChon.Text = "Chọn";
            tbMa.Text = "";
            tbTen.Text = "";
            tbDienGiai.Text = "";
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbThongTin.Enabled = true;
            tbMa.Enabled = true;
            tbTen.Enabled = true;
            cbbTacGia.Enabled = true;
            cbbCD.Enabled = true;
            cbbQT.Enabled = true;
            cbbTD.Enabled = true;
            tbDienGiai.Enabled = true;
            tbNam.Enabled = true;
            cheDo = 1;
            btnChon.Text = "Thêm";
            tbMa.Text = "";
            tbTen.Text = "";
            tbDienGiai.Text = "";
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbThongTin.Enabled = true;
            tbMa.Enabled = false;
            tbTen.Enabled = true;
            cbbTacGia.Enabled = true;
            cbbCD.Enabled = true;
            cbbQT.Enabled = true;
            cbbTD.Enabled = true;
            tbDienGiai.Enabled = true;
            tbNam.Enabled = true;
            cheDo = 2;
            btnChon.Text = "Ghi";
            tbMa.Text = "";
            tbTen.Text = "";
            tbDienGiai.Text = "";
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            gbThongTin.Enabled = true;
            tbMa.Enabled = false;
            tbTen.Enabled = false;
            cbbTacGia.Enabled = false;
            cbbCD.Enabled = false;
            cbbQT.Enabled = false;
            cbbTD.Enabled = false;
            tbNam.Enabled = false;
            tbDienGiai.Enabled = false;
            cheDo = 3;
            btnChon.Text = "Xoá";
            tbMa.Text = "";
            tbTen.Text = "";
            tbDienGiai.Text = "";
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTPNT_Load(sender, e);
        }
        private void layDanhSachThoiDai()
        {
            string cmd = "SELECT MATD, TENTD FROM THOI_DAI ORDER BY TENTD";
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

                    cbbTD.DataSource = dt;
                    cbbTD.DisplayMember = "TENTD";
                    cbbTD.ValueMember = "MATD";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void layDanhSachTacGia()
        {
            string cmd = "SELECT MATACGIA, CONCAT(HO, ' ', TEN) AS hoTen FROM TAC_GIA";
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

                    cbbTacGia.DataSource = dt;
                    cbbTacGia.DisplayMember = "hoTen";
                    cbbTacGia.ValueMember = "MATACGIA";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void layDanhSachChuDe()
        {
            string cmd = "SELECT MACD,TENCHUDE FROM CHUDE ORDER BY TENCHUDE";
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

                    cbbCD.DataSource = dt;
                    cbbCD.DisplayMember = "TENCHUDE";
                    cbbCD.ValueMember = "MACD";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void layDanhSachQuocGia()
        {
            string cmd = "SELECT MAQT, TENQT FROM QUOC_GIA ORDER BY TENQT";
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

                    cbbQT.DataSource = dt;
                    cbbQT.DisplayMember = "TENQT";
                    cbbQT.ValueMember = "MAQT";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadCBB()
        {
            layDanhSachQuocGia();
            layDanhSachChuDe();
            layDanhSachTacGia();
            layDanhSachThoiDai();
        }
        DataSet ds = null;
        private void loadDataTacGia()
        {
            if (ds == null)
            {
                ds = new DataSet();
            }

            string sqlCommand = "SELECT TP.MATPNT, TP.TENTP, CONCAT(TG.HO, ' ' ,TG.TEN) AS HOVATEN, TP.NAM, CD.TENCHUDE, TD.TENTD, QT.TENQT, TP.DIENGIAI FROM TPNT TP JOIN TAC_GIA TG ON TP.MATG = TG.MATACGIA JOIN CHUDE CD ON CD.MACD = TP.MACD JOIN THOI_DAI TD ON TD.MATD=TP.MATD JOIN QUOC_GIA QT ON QT.MAQT = TP.MAQT";

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
            dgDSTPNT.Columns["HOVATEN"].HeaderText = "Tên tác giả"; // Sử dụng trường mới đã gộp
            dgDSTPNT.Columns["NAM"].HeaderText = "Năm";
            dgDSTPNT.Columns["TENQT"].HeaderText = "Quốc gia";
            dgDSTPNT.Columns["TENCHUDE"].HeaderText = "Chủ đề";
            dgDSTPNT.Columns["TENTD"].HeaderText = "Thời đại";
            dgDSTPNT.Columns["DIENGIAI"].HeaderText = "Diễn giải";
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
                tbMa.Text = row.Cells["MATPNT"].Value.ToString();
                tbTen.Text = row.Cells["TENTP"].Value.ToString();
                tbNam.Text = row.Cells["NAM"].Value.ToString();
                tbDienGiai.Text = row.Cells["DIENGIAI"].Value.ToString();
                cbbCD.SelectedItem = row.Cells["TENCHUDE"].Value.ToString();
                cbbQT.SelectedItem = row.Cells["TENQT"].Value.ToString();
                cbbTacGia.SelectedItem = row.Cells["HOVATEN"].Value.ToString();
                cbbTD.SelectedItem = row.Cells["TENTD"].Value.ToString();
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
                MessageBox.Show("Không bỏ trống tên", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (tbNam.Text.Trim() == "")
            {
                MessageBox.Show("Không bỏ trống năm", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (Regex.IsMatch(tbNam.Text.Trim(), @"^[0-9]+$") == false)
            {
                MessageBox.Show("Mã chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        List<DtTPNT> danhSachBackup = new List<DtTPNT>();

        private void btnChon_Click(object sender, EventArgs e)
        {
            bool kiemTra = kiemTraDauVao();
            if (kiemTra == false)
                return;
            string ma = tbMa.Text.Trim();
            string ten = tbTen.Text;
            string nam = tbNam.Text;
            string thoiDai = cbbTD.SelectedValue.ToString();
            string quocGia = cbbQT.SelectedValue.ToString();
            string chuDe = cbbCD.SelectedValue.ToString();
            string tacGia = cbbTacGia.SelectedValue.ToString();
            string dienGiai = tbDienGiai.Text;
            if (cheDo ==1)
            {

                String cauTruyVan =
                  "DECLARE @result int " +
                  "EXEC @result = KiemTraMATPNTTonTai '" +
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

                if (result == 0)
                {
                    string cauTruyVanInsert = "INSERT INTO TPNT (MATPNT, TENTP, MATG, NAM, MACD, MATD, MAQT, DIENGIAI) VALUES (@MaTPNT, @TenTP, @MaTG, @Nam, @MaCD, @MaTD, @MaQT, @DienGiai)";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MaTPNT", ma);
                        command.Parameters.AddWithValue("@TenTP", ten);
                        command.Parameters.AddWithValue("@MaTG", tacGia);
                        command.Parameters.AddWithValue("@Nam", nam);
                        command.Parameters.AddWithValue("@MaCD", chuDe);
                        command.Parameters.AddWithValue("@MaTD", thoiDai);
                        command.Parameters.AddWithValue("@MaQT", quocGia);
                        command.Parameters.AddWithValue("@DienGiai", dienGiai);

                        command.ExecuteNonQuery();
                        connection.Close();
                    }




                    // Cập nhật lại dữ liệu trong DataGridView
                    dgDSTPNT.DataSource = ds.Tables["TPNT"];

                    // Thiết lập lại AutoSizeMode của các cột
                    foreach (DataGridViewColumn column in dgDSTPNT.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    FormTPNT_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Mã đã tồn tại. Vui lòng chọn mã khác.", "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(cheDo ==2)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn sửa dữ liệu tác phẩm này?", "Xác nhận sửa",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    string query = "UPDATE TPNT SET TENTP = @TenTP, MATG = @MaTG, NAM = @Nam, MACD = @MaCD, MATD = @MaTD, MAQT = @MaQT, DIENGIAI = @DienGiai WHERE MATPNT = @MaTP";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@TenTP", ten);
                        command.Parameters.AddWithValue("@MaTG", tacGia);
                        command.Parameters.AddWithValue("@Nam", nam);
                        command.Parameters.AddWithValue("@MaCD", chuDe);
                        command.Parameters.AddWithValue("@MaTD", thoiDai);
                        command.Parameters.AddWithValue("@MaQT", quocGia);
                        command.Parameters.AddWithValue("@DienGiai", dienGiai);
                        command.Parameters.AddWithValue("@MaTP", ma);

                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                }
                FormTPNT_Load(sender, e);
                return;
            }
            else if(cheDo ==3)
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

                        DtTPNT backup = new DtTPNT(ma,ten,tacGia,nam,chuDe,quocGia,thoiDai,dienGiai);

                        danhSachBackup.Add(backup);

                        string query = "DELETE FROM TPNT WHERE MATPNT = '" + tbMa.Text.Trim() + "'";

                        // Kết nối đến cơ sở dữ liệu và thực thi câu truy vấn
                        using (SqlConnection connection = new SqlConnection(Program.connstr))
                        {
                            connection.Open();
                            SqlCommand command = new SqlCommand(query, connection);
                            command.ExecuteNonQuery();
                        }

                        // Cập nhật lại dữ liệu trong DataGridView
                        dgDSTPNT.DataSource = ds.Tables["TPNT"];

                        // Thiết lập lại AutoSizeMode của các cột
                        foreach (DataGridViewColumn column in dgDSTPNT.Columns)
                        {
                            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                        FormTPNT_Load(sender, e);
                    }
                }

            }
        }
        private void PhucHoiDuLieuTPNT()
        {
            if (danhSachBackup.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để phục hồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy dữ liệu cuối cùng trong danh sách
            DtTPNT duLieuCanPhucHoi = danhSachBackup[danhSachBackup.Count - 1];

            // Thực hiện việc phục hồi dữ liệu
            string cauTruyVanInsert = "INSERT INTO TPNT (MATPNT, TENTP, MATG, NAM, MACD, MATD, MAQT, DIENGIAI) VALUES (@MaTPNT, @TenTP, @MaTG, @Nam, @MaCD, @MaTD, @MaQT, @DienGiai)";

            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                // Thêm các tham số
                command.Parameters.AddWithValue("@MaTPNT", duLieuCanPhucHoi.MaPTNT);
                command.Parameters.AddWithValue("@TenTP", duLieuCanPhucHoi.TenTP);
                command.Parameters.AddWithValue("@MaTG", duLieuCanPhucHoi.MaTacGia);
                command.Parameters.AddWithValue("@Nam", duLieuCanPhucHoi.Nam);
                command.Parameters.AddWithValue("@MaCD", duLieuCanPhucHoi.MaCD);
                command.Parameters.AddWithValue("@MaTD", duLieuCanPhucHoi.MaTD);
                command.Parameters.AddWithValue("@MaQT", duLieuCanPhucHoi.MaQT);
                command.Parameters.AddWithValue("@DienGiai", duLieuCanPhucHoi.DienGiai);

                command.ExecuteNonQuery();
                connection.Close();
            }

            // Xóa dữ liệu khỏi danh sách phục hồi
            danhSachBackup.RemoveAt(danhSachBackup.Count - 1);

            // Cập nhật lại dữ liệu trong DataGridView
            dgDSTPNT.DataSource = ds.Tables["TPNT"];

            // Thiết lập lại AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSTPNT.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhucHoiDuLieuTPNT();
            FormTPNT_Load(sender, e);
        }

        private void gbThongTin_Enter(object sender, EventArgs e)
        {

        }
    }
}