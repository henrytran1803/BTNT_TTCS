using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNT.DoiTuong
{
    class DtTacGia
    {
        public string MaTacGia { get; set; }
        public string HoTacGia { get; set; }
        public string TenTacGia { get; set; }
        public string NgaySinh { get; set; }
        public string NgayMat { get; set; }
        public string MaQT { get; set; }
        public string MaTD { get; set; }
        public string MaPC { get; set; }
        public string DienGiai { get; set; }
        public DtTacGia(string maTacGia, string hoTacGia, string tenTacGia, string ngaySinh, string ngayMat, string maQT, string maTD, string maPC, string dienGiai)
        {
            MaTacGia = maTacGia;
            HoTacGia = hoTacGia;
            TenTacGia = tenTacGia;
            NgaySinh = ngaySinh;
            NgayMat = ngayMat;
            MaQT = maQT;
            MaTD = maTD;
            MaPC = maPC;
            DienGiai = dienGiai;
        }

    }
}
