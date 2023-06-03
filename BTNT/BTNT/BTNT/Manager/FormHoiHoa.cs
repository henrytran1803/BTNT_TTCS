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
    public partial class FormHoiHoa : DevExpress.XtraEditors.XtraForm
    {
        public FormHoiHoa()
        {
            InitializeComponent();
        }

        private void FormHoiHoa_Load(object sender, EventArgs e)
        {
            dgDSTPNT.ReadOnly = true;
            dgDSPTHH.ReadOnly = true;
            gbDSTPHH.Enabled = false;
            gbTPNT.Enabled = false;
            loadDataTPNT();
            loadDataTPHH();
            loadCBB();
            cheDo = 0;
            gbTT.Enabled = false;
            cbbCL.Enabled = true;
            cbbTP.Enabled = true;
            cbbTruongPhai.Enabled = true;
            cbbVL.Enabled = true;
            btnChon.Text = "Chọn";
        }
        List<DtHoiHoa> danhSachBackup = new List<DtHoiHoa>();
        DataSet ds = null;
        int cheDo = 0;
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
        private void layDanhSachTPHH()
        {
            string cmd = "SELECT TP.MATPNT, TP.TENTP FROM TPNT TP WHERE TP.MATPNT IN (SELECT MATPNT FROM HOI_HOA)";
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
        private void layDanhSachVL()
        {
            string cmd = "SELECT MAVL, TENVL FROM VAT_LIEU_HH";

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
        private void layDanhSachCL()
        {
            string cmd = "SELECT MACL, TENCL FROM CHAT_LIEU";
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

                    cbbCL.DataSource = dt;
                    cbbCL.DisplayMember = "TENCL";
                    cbbCL.ValueMember = "MACL";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void layDanhSachTP()
        {
            string cmd = "SELECT MATP, TENTP FROM TRUONG_PHAI";
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

                    cbbTruongPhai.DataSource = dt;
                    cbbTruongPhai.DisplayMember = "TENTP";
                    cbbTruongPhai.ValueMember = "MATP";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void loadCBB()
        {
            layDanhSachCL();
            layDanhSachTP();
            layDanhSachVL();
        }
        private void loadDataTPHH()
        {
            if (ds == null)
            {
                ds = new DataSet();
            }

            string sqlCommand = "SELECT HH.MATPNT, TP.TENTP, CONCAT(TG.HO, ' ', TG.TEN) AS HOVATEN, TPH.TENTP, VL.TENVL, CL.TENCL FROM TPNT TP JOIN TAC_GIA TG ON TP.MATG = TG.MATACGIA JOIN HOI_HOA HH ON HH.MATPNT = TP.MATPNT JOIN CHAT_LIEU CL ON CL.MACL = HH.MACL JOIN VAT_LIEU_HH VL ON VL.MAVL = HH.MAVL JOIN TRUONG_PHAI TPH ON TPH.MATP = HH.MATP  WHERE TP.MATPNT IN (SELECT MATPNT FROM HOI_HOA)";
            DataTable dataTable = Program.ExecSqlDataTable(sqlCommand);

            // Xóa bảng "TPNT" nếu đã tồn tại trong DataSet
            if (ds.Tables.Contains("TPNT_HH"))
                ds.Tables.Remove("TPNT_HH");

            // Đặt tên cho bảng và thêm dữ liệu vào DataSet
            dataTable.TableName = "TPNT_HH";
            ds.Tables.Add(dataTable);

            // Gán nguồn dữ liệu cho DataGridView
            dgDSPTHH.DataSource = ds.Tables["TPNT_HH"];
            dgDSPTHH.Columns["MATPNT"].HeaderText = "Mã";
            dgDSPTHH.Columns["TENTP"].HeaderText = "Tên tac phẩm";
            dgDSPTHH.Columns["HOVATEN"].HeaderText = "Tên tác giả";
            dgDSPTHH.Columns["TENVL"].HeaderText = "Vật liệu";
            dgDSPTHH.Columns["TENTP"].HeaderText = "Trường phái";
            dgDSPTHH.Columns["TENVL"].HeaderText = "Vật liệu";
            // Thiết lập AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSPTHH.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
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

        private void dgDSPTHH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSPTHH.Rows[e.RowIndex];
                cbbTP.SelectedItem = row.Cells["MATPNT"].Value.ToString();
                cbbCL.SelectedItem = row.Cells["TENCL"].Value.ToString();
                cbbVL.SelectedItem = row.Cells["TENVL"].Value.ToString();
                cbbTruongPhai.SelectedItem = row.Cells["TENTP"].Value.ToString();
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

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cheDo = 1;
            gbTT.Enabled = true;
            cbbCL.Enabled = true;
            cbbTP.Enabled = true;
            cbbTruongPhai.Enabled = true;
            cbbVL.Enabled = true;
            btnChon.Text = "Thêm";
            btnChon.Enabled = true;
            gbDSTPHH.Enabled = false;
            gbTPNT.Enabled = true;
            layDanhSachTPNT();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cheDo = 2;
            gbTT.Enabled = true;
            cbbCL.Enabled = true;
            cbbTP.Enabled = true;
            cbbTruongPhai.Enabled = true;
            cbbVL.Enabled = true;
            btnChon.Text = "Ghi";
            btnChon.Enabled = true;
            gbDSTPHH.Enabled = true;
            gbTPNT.Enabled = false;
            layDanhSachTPHH();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cheDo = 3;
            gbTT.Enabled = true;
            cbbCL.Enabled = false;
            cbbTP.Enabled = false;
            cbbTruongPhai.Enabled = false;
            cbbVL.Enabled = false;
            btnChon.Text = "Xoá";
            btnChon.Enabled = true;
            gbDSTPHH.Enabled = true;
            gbTPNT.Enabled = false;
            layDanhSachTPHH();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            string ma = cbbTP.SelectedValue.ToString();
            string vatLieu = cbbVL.SelectedValue.ToString();
            string chatLieu = cbbCL.SelectedValue.ToString();
            string truongPhai = cbbTruongPhai.SelectedValue.ToString();

            // Kiểm tra mã TPNT trong bảng DIEU_KHAC
            if (cheDo == 1)
            {
                String cauTruyVan =
                   "DECLARE @result int " +
                   "EXEC @result = KiemTraMATPNT_Hoi_Hoa '" +
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
                    string cauTruyVanInsert = "INSERT INTO HOI_HOA(MATPNT, MAVL, MATP, MACL) VALUES (@MATPNT, @MAVL, @MATP, @MACL)";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MATPNT", ma);
                        command.Parameters.AddWithValue("@MAVL", vatLieu);
                        command.Parameters.AddWithValue("@MATP", truongPhai);
                        command.Parameters.AddWithValue("@MACL", chatLieu);

                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    // Cập nhật lại dữ liệu trong DataGridView
                    dgDSPTHH.DataSource = ds.Tables["TPNT_HH"];

                    // Thiết lập lại AutoSizeMode của các cột
                    foreach (DataGridViewColumn column in dgDSTPNT.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    FormHoiHoa_Load(sender, e);
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
                    string query = "UPDATE HOI_HOA SET MAVL = @MAVL, MACL = @MACL, MATP = @MATP WHERE MATPNT = @MATPNT";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MATPNT", ma);
                        command.Parameters.AddWithValue("@MAVL", vatLieu);
                        command.Parameters.AddWithValue("@MATP", truongPhai);
                        command.Parameters.AddWithValue("@MACL", chatLieu);

                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                }
                FormHoiHoa_Load(sender, e);
                return;

            }
            else if (cheDo == 3)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá mã khoa này?", "Xác nhận xoá",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    DtHoiHoa backup = new DtHoiHoa(ma, chatLieu, vatLieu, truongPhai);

                    danhSachBackup.Add(backup);

                    string query = "DELETE FROM HOI_HOA WHERE MATPNT = '" + ma + "'";

                    // Kết nối đến cơ sở dữ liệu và thực thi câu truy vấn
                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                    }

                    // Cập nhật lại dữ liệu trong DataGridView
                    dgDSPTHH.DataSource = ds.Tables["TPNT_HH"];

                    // Thiết lập lại AutoSizeMode của các cột
                    foreach (DataGridViewColumn column in dgDSTPNT.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    FormHoiHoa_Load(sender, e);
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
            DtHoiHoa duLieuCanPhucHoi = danhSachBackup[danhSachBackup.Count - 1];

            // Thực hiện việc phục hồi dữ liệu
            string cauTruyVanInsert = "INSERT INTO HOI_HOA(MATPNT, MAVL, MATP, MACL) VALUES (@MATPNT, @MAVL, @MATP, @MACL)";
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                // Thêm các tham số
                command.Parameters.AddWithValue("@MATPNT", duLieuCanPhucHoi.MaTPNT);
                command.Parameters.AddWithValue("@MAVL", duLieuCanPhucHoi.MaVL);
                command.Parameters.AddWithValue("@MATP", duLieuCanPhucHoi.MaTP);
                command.Parameters.AddWithValue("@MACL", duLieuCanPhucHoi.MaCL);

                command.ExecuteNonQuery();
                connection.Close();
            }
            // Xóa dữ liệu khỏi danh sách phục hồi
            danhSachBackup.RemoveAt(danhSachBackup.Count - 1);

            // Cập nhật lại dữ liệu trong DataGridView
            dgDSPTHH.DataSource = ds.Tables["TPNT_HH"];

            // Thiết lập lại AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSPTHH.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhucHoiDuLieuTPNTDK();
            FormHoiHoa_Load(sender, e);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormHoiHoa_Load(sender, e);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}