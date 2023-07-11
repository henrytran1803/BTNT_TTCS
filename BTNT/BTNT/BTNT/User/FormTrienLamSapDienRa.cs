using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTNT.User
{
    public partial class FormTrienLamSapDienRa : DevExpress.XtraEditors.XtraForm
    {
        public FormTrienLamSapDienRa()
        {
            InitializeComponent();
        }

        private void FormTrienLamSapDienRa_Load(object sender, EventArgs e)
        {
            loadDataTrienLam();

        }
        DataSet ds = null;
        private void loadDataTrienLam()
        {
            if (ds == null)
            {
                ds = new DataSet();
            }
            string sqlCommand = "SELECT MACTL, TENCTL, NGAYBATDAU, NGAYKETTHUC FROM CUOC_TRIEN_LAM WHERE NGAYBATDAU >= GETDATE() ORDER BY NGAYBATDAU ";
            DataTable dataTable = Program.ExecSqlDataTable(sqlCommand);

            // Xóa bảng "TPNT" nếu đã tồn tại trong DataSet
            if (ds.Tables.Contains("CTL"))
                ds.Tables.Remove("CTL");

            // Đặt tên cho bảng và thêm dữ liệu vào DataSet
            dataTable.TableName = "CTL";
            ds.Tables.Add(dataTable);

            // Gán nguồn dữ liệu cho DataGridView
            dgDSTrienLam.DataSource = ds.Tables["CTL"];
            dgDSTrienLam.Columns["MACTL"].HeaderText = "Mã";
            dgDSTrienLam.Columns["TENCTL"].HeaderText = "Tên cuộc triển lãm";
            dgDSTrienLam.Columns["NGAYBATDAU"].HeaderText = "Ngày bắt đầu"; // Sử dụng trường mới đã gộp
            dgDSTrienLam.Columns["NGAYKETTHUC"].HeaderText = "Ngày kết thúc";
            // Thiết lập AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSTrienLam.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void loadDataTacPham(string maCTL)
        {
            if (ds == null)
            {
                ds = new DataSet();
            }

            string sqlCommand = "SELECT TP.MATPNT, TP.TENTP, CONCAT(TG.HO, ' ', TG.TEN) AS TENTACGIA, TP.NAM FROM CT_CTL CTL JOIN TPNT TP ON CTL.MATPNT = TP.MATPNT JOIN TAC_GIA TG ON TG.MATACGIA = TP.MATG WHERE CTL.MACTL = '"+maCTL+"'";

            DataTable dataTable = Program.ExecSqlDataTable(sqlCommand);

            // Xóa bảng "TPNT" nếu đã tồn tại trong DataSet
            if (ds.Tables.Contains("CTCTL"))
                ds.Tables.Remove("CTCTL");

            // Đặt tên cho bảng và thêm dữ liệu vào DataSet
            dataTable.TableName = "CTCTL";
            ds.Tables.Add(dataTable);

            // Gán nguồn dữ liệu cho DataGridView
            dgDSTacPham.DataSource = ds.Tables["CTCTL"];
            dgDSTacPham.Columns["MATPNT"].HeaderText = "Mã";
            dgDSTacPham.Columns["TENTP"].HeaderText = "Tên tác phẩm";
            dgDSTacPham.Columns["TENTACGIA"].HeaderText = "Tên tác giả"; // Sử dụng trường mới đã gộp
            dgDSTacPham.Columns["NAM"].HeaderText = "Năm";

            // Thiết lập AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSTacPham.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dgDSTrienLam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSTrienLam.Rows[e.RowIndex];
                lbNMaCTL.Text = row.Cells["MACTL"].Value.ToString();
                lbNTenCTL.Text = row.Cells["TENCTL"].Value.ToString();
                lbNhapNgayBatDau.Text = row.Cells["NGAYBATDAU"].Value.ToString();
                lbNNgayKetThuc.Text = row.Cells["NGAYKETTHUC"].Value.ToString();

                loadDataTacPham(row.Cells["MACTL"].Value.ToString());

            }
        }

        private void dgDSTacPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSTacPham.Rows[e.RowIndex];
                lbNMaTP.Text = row.Cells["MATPNT"].Value.ToString();
                lbNTenTP.Text = row.Cells["TENTP"].Value.ToString();
                lbNTenTacGia.Text = row.Cells["TENTACGIA"].Value.ToString();
                lbNNam.Text = row.Cells["NAM"].Value.ToString();

            }
        }
    }
}