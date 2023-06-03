using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNT.DoiTuong
{
    class DtTPNT
    {
        public string MaPTNT { get; set; }
        public string TenTP { get; set; }
        public string MaTacGia { get; set; }
        public string Nam { get; set; }
        public string MaCD { get; set; }
        public string MaQT { get; set; }
        public string MaTD { get; set; }
        public string DienGiai { get; set; }
        public DtTPNT(string maPTNT, string tenTP, string maTacGia, string nam, string maCD, string maQT, string maTD,string dienGiai)
        {
            MaPTNT = maPTNT;
            TenTP = tenTP;
            MaTacGia = maTacGia;
            Nam = nam;
            MaCD = maCD;
            MaQT = maQT;
            MaTD = maTD;
            DienGiai = dienGiai;
        }
    }
}
