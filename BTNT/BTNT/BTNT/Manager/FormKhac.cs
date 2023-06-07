using BTNT.DoiTuong;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTNT.Manager
{
    public partial class FormKhac : DevExpress.XtraEditors.XtraForm
    {
        public FormKhac()
        {
            InitializeComponent();
        }
        byte[] imageBytes;
        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                if (string.IsNullOrEmpty(imagePath))
                    return;
                Image image = Image.FromFile(imagePath);
                pictureBox.Image = image;
                tbUrl.Text = imagePath;
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        imageBytes = br.ReadBytes((int)fs.Length);
                    }
                }
            }
        }

        private void layDanhSachPC()
        {
            string cmd = "SELECT MAPC, TENPC FROM PHONG_CACH_K";
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
        private void layDanhSachTL()
        {
            string cmd = "SELECT MATL, TENTL FROM THE_LOAI";
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

                    cbbTL.DataSource = dt;
                    cbbTL.DisplayMember = "TENTL";
                    cbbTL.ValueMember = "MATL";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void layDanhSachTPDK()
        {
            string cmd = "SELECT TP.MATPNT, TP.TENTP FROM TPNT TP WHERE TP.MATPNT IN (SELECT MATPNT FROM KHAC)";
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
        private void loadDataTPK()
        {
            if (ds == null)
            {
                ds = new DataSet();
            }

            string sqlCommand = "SELECT TP.MATPNT, TP.TENTP, CONCAT(TG.HO, ' ', TG.TEN) AS HOVATEN, PC.TENPC, K.ANH, TL.TENTL FROM TPNT TP JOIN TAC_GIA TG ON TP.MATG = TG.MATACGIA JOIN KHAC K ON K.MATPNT = TP.MATPNT JOIN PHONG_CACH_K PC ON PC.MAPC = K.MAPC JOIN THE_LOAI TL on TL.MATL=K.MATL  WHERE TP.MATPNT IN (SELECT MATPNT FROM KHAC)";
            DataTable dataTable = Program.ExecSqlDataTable(sqlCommand);

            // Xóa bảng "TPNT" nếu đã tồn tại trong DataSet
            if (ds.Tables.Contains("TPNT_K"))
                ds.Tables.Remove("TPNT_K");

            // Đặt tên cho bảng và thêm dữ liệu vào DataSet
            dataTable.TableName = "TPNT_K";
            ds.Tables.Add(dataTable);

            // Gán nguồn dữ liệu cho DataGridView
            dgDSPTK.DataSource = ds.Tables["TPNT_K"];
            dgDSPTK.Columns["MATPNT"].HeaderText = "Mã";
            dgDSPTK.Columns["TENTP"].HeaderText = "Tên tac phẩm";
            dgDSPTK.Columns["HOVATEN"].HeaderText = "Tên tác giả";
            dgDSPTK.Columns["TENPC"].HeaderText = "Phong cách";
            dgDSPTK.Columns["ANH"].HeaderText = "Url ảnh";
            dgDSPTK.Columns["TENTL"].HeaderText = "Thể loại";
            // Thiết lập AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSPTK.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        int cheDo = 0;
        private void FormKhac_Load(object sender, EventArgs e)
        {
            loadDataTPK();
            loadDataTPNT();
            layDanhSachPC();
            layDanhSachTL();
            gbDSTPK.Enabled = false;
            gbTPNT.Enabled = false;
            gbTT.Enabled = false;
            cbbTP.Enabled = true;
            cbbPC.Enabled = true;
            btnChonHinh.Enabled = true;
            btnChon.Text = "Chon";
            tbUrl.Text = "";
            cheDo = 0;
            pictureBox.Image = null;
            cbbTL.Enabled = true;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbDSTPK.Enabled = false;
            gbTPNT.Enabled = true;
            gbTT.Enabled = true;
            cbbTP.Enabled = true;
            cbbPC.Enabled = true;
            btnChonHinh.Enabled = true;
            btnChon.Text = "Thêm";
            tbUrl.Text = "";
            cheDo = 1;
            layDanhSachTPNT();
            pictureBox.Image = null;
            cbbTL.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbDSTPK.Enabled = true;
            gbTPNT.Enabled = false;
            gbTT.Enabled = true;
            cbbTP.Enabled = true;
            cbbPC.Enabled = true;
            btnChonHinh.Enabled = true;
            btnChon.Text = "Ghi";
            tbUrl.Text = "";
            cheDo = 2;
            layDanhSachTPDK();
            pictureBox.Image = null;
            cbbTL.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbDSTPK.Enabled = true;
            gbTPNT.Enabled = false;
            gbTT.Enabled = true;
            cbbTP.Enabled = true;
            cbbPC.Enabled = false;
            btnChonHinh.Enabled = false;
            btnChon.Text = "Xoá";
            tbUrl.Text = "";
            cheDo = 3;
            layDanhSachTPDK();
            pictureBox.Image = null;
            cbbTL.Enabled = false;
        }
        List<DtKhac> danhSachBackup = new List<DtKhac>();

        private void btnChon_Click(object sender, EventArgs e)
        {
            string ma = cbbTP.SelectedValue.ToString();
            string phongCach = cbbPC.SelectedValue.ToString();
            byte[] anh = imageBytes;
            string theloai = cbbTL.SelectedValue.ToString();

            // Kiểm tra mã TPNT trong bảng DIEU_KHAC
            if (cheDo == 1)
            {
                String cauTruyVan =
                   "DECLARE @result int " +
                   "EXEC @result = KiemTraMATPNT_Khac '" +
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
                    string cauTruyVanInsert = "INSERT INTO KHAC(MATPNT, MAPC, ANH, MATL) VALUES (@MATPNT, @MAPC, @ANH, @MATL)";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MATPNT", ma);
                        command.Parameters.AddWithValue("@MAPC", phongCach);
                        command.Parameters.AddWithValue("@ANH", anh);
                        command.Parameters.AddWithValue("@MATL", theloai);

                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                    // Cập nhật lại dữ liệu trong DataGridView
                    dgDSPTK.DataSource = ds.Tables["TPNT_K"];

                    // Thiết lập lại AutoSizeMode của các cột
                    foreach (DataGridViewColumn column in dgDSTPNT.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    FormKhac_Load(sender, e);
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
                    string query = "UPDATE KHAC SET MAPC = @MAPC, ANH = @ANH, MATL = @MATL WHERE MATPNT = @MATPNT";

                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);

                        // Thêm các tham số
                        command.Parameters.AddWithValue("@MATPNT", ma);
                        command.Parameters.AddWithValue("@MAPC", phongCach);
                        command.Parameters.AddWithValue("@ANH", anh);
                        command.Parameters.AddWithValue("@MATL", theloai);
                        command.ExecuteNonQuery();
                        connection.Close();
                    }

                }
                FormKhac_Load(sender, e);
                return;

            }
            else if (cheDo == 3)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xoá MÃ KHÁC này?", "Xác nhận xoá",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    DtKhac backup = new DtKhac(ma, phongCach,anh , theloai);

                    danhSachBackup.Add(backup);

                    string query = "DELETE FROM KHAC WHERE MATPNT = '" + ma + "'";

                    // Kết nối đến cơ sở dữ liệu và thực thi câu truy vấn
                    using (SqlConnection connection = new SqlConnection(Program.connstr))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                    }

                    // Cập nhật lại dữ liệu trong DataGridView
                    dgDSPTK.DataSource = ds.Tables["TPNT_K"];

                    // Thiết lập lại AutoSizeMode của các cột
                    foreach (DataGridViewColumn column in dgDSTPNT.Columns)
                    {
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    FormKhac_Load(sender, e);
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
            DtKhac duLieuCanPhucHoi = danhSachBackup[danhSachBackup.Count - 1];

            // Kiểm tra mảng byte
            if (duLieuCanPhucHoi.AnhChup == null || duLieuCanPhucHoi.AnhChup.Length == 0)
            {
                MessageBox.Show("Dữ liệu ảnh không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thực hiện việc phục hồi dữ liệu
            string cauTruyVanInsert = "INSERT INTO KHAC(MATPNT, MAPC, ANH,MATL) VALUES (@MATPNT, @MAPC, @ANH, @MATL)";

            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(cauTruyVanInsert, connection);

                // Thêm các tham số
                command.Parameters.AddWithValue("@MATPNT", duLieuCanPhucHoi.MaTPNT);
                command.Parameters.AddWithValue("@MAPC", duLieuCanPhucHoi.PhongCach);

                // Chuyển đổi byte array thành đối tượng Image
                byte[] imageBytes = duLieuCanPhucHoi.AnhChup;
                Image image;

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    image = Image.FromStream(ms);
                }

                // Gán đối tượng Image vào tham số @ANH
                command.Parameters.AddWithValue("@ANH", ImageToByteArray(image));
                command.Parameters.AddWithValue("@MATL", duLieuCanPhucHoi.MaTL);
                command.ExecuteNonQuery();
                connection.Close();
            }

            // Xóa dữ liệu khỏi danh sách phục hồi
            danhSachBackup.RemoveAt(danhSachBackup.Count - 1);

            // Cập nhật lại dữ liệu trong DataGridView
            dgDSPTK.DataSource = ds.Tables["TPNT_K"];

            // Thiết lập lại AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSPTK.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        // Chuyển đổi đối tượng Image thành byte array
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


        private void cbbPC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void dgDSPTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSPTK.Rows[e.RowIndex];
                cbbTP.SelectedItem = row.Cells["MATPNT"].Value.ToString();
                cbbPC.SelectedItem = row.Cells["TENPC"].Value.ToString();

                // Kiểm tra nếu ô "ANH" không rỗng
                if (!DBNull.Value.Equals(row.Cells["ANH"].Value))
                {
                    // Lấy giá trị byte[] từ cột "ANH"
                    byte[] imageBytes = (byte[])row.Cells["ANH"].Value;

                    // Chuyển đổi byte[] thành đường dẫn tạm thời
                    string tempImagePath = Path.GetTempFileName();
                    File.WriteAllBytes(tempImagePath, imageBytes);

                    // Hiển thị ảnh từ đường dẫn tạm thời
                    pictureBox.Image = Image.FromFile(tempImagePath);

                    // Gán đường dẫn tạm thời vào TextBox
                    tbUrl.Text = tempImagePath;
                }
                else
                {
                    // Nếu ô "ANH" rỗng, xoá ảnh và xóa đường dẫn trong TextBox
                    pictureBox.Image = null;
                    tbUrl.Text = string.Empty;
                }
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

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PhucHoiDuLieuTPNTDK();
            FormKhac_Load(sender, e);
        }
    }
}