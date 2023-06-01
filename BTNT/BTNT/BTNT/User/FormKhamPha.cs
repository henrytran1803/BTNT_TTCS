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
    public partial class FormKhamPha : DevExpress.XtraEditors.XtraForm
    {
        public FormKhamPha()
        {
            InitializeComponent();
        }

        private void FormKhamPha_Load(object sender, EventArgs e)
        {
            loadDataTacPham();

        }
        DataSet ds = null;
        private void loadDataTacPham()
        {
            if (ds == null)
            {
                ds = new DataSet();
            }

            string sqlCommand = "SELECT MATPNT, TENTP, CONCAT(HO, ' ', TEN) AS 'HO VA TEN', NAM, TENQT, TENCHUDE, TENTD, DIENGIAI FROM view_TPNT";

            DataTable dataTable = Program.ExecSqlDataTable(sqlCommand);

            // Xóa bảng "TPNT" nếu đã tồn tại trong DataSet
            if (ds.Tables.Contains("TPNT"))
                ds.Tables.Remove("TPNT");

            // Đặt tên cho bảng và thêm dữ liệu vào DataSet
            dataTable.TableName = "TPNT";
            ds.Tables.Add(dataTable);

            // Gán nguồn dữ liệu cho DataGridView
            dgDSTacPham.DataSource = ds.Tables["TPNT"];
            dgDSTacPham.Columns["MATPNT"].HeaderText = "Mã";
            dgDSTacPham.Columns["TENTP"].HeaderText = "Tên tác phẩm";
            dgDSTacPham.Columns["HO VA TEN"].HeaderText = "Tên tác giả"; // Sử dụng trường mới đã gộp
            dgDSTacPham.Columns["NAM"].HeaderText = "Năm";
            dgDSTacPham.Columns["TENQT"].HeaderText = "Quốc tịch";
            dgDSTacPham.Columns["TENCHUDE"].HeaderText = "Chủ đề";
            dgDSTacPham.Columns["TENTD"].HeaderText = "Thời đại";
            dgDSTacPham.Columns["DIENGIAI"].HeaderText = "Diễn giải";
            // Thiết lập AutoSizeMode của các cột
            foreach (DataGridViewColumn column in dgDSTacPham.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void lbNGD_Click(object sender, EventArgs e)
        {

        }

        private void gbThongTin_Enter(object sender, EventArgs e)
        {

        }

        private void dgDSTacPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDSTacPham.Rows[e.RowIndex];
                lbNMa.Text = row.Cells["MATPNT"].Value.ToString();
                lbNNam.Text = row.Cells["NAM"].Value.ToString();
                lbNQT.Text = row.Cells["TENQT"].Value.ToString();
                lbNTD.Text = row.Cells["TENTD"].Value.ToString();
                lbNTenTG.Text = row.Cells["HO VA TEN"].Value.ToString();
                lbNTenTP.Text = row.Cells["TENTP"].Value.ToString();
                lbNGD.Text = row.Cells["DIENGIAI"].Value.ToString();
                lbNCD.Text = row.Cells["TENCHUDE"].Value.ToString();

            }
        }
    }
}