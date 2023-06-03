using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNT.DoiTuong
{
    class DtDieuKhac
    {
        public string MaTPNT { get; set; }
        public string MaVL { get; set; }
        public string KhoiLuong { get; set; }
        public string ChieuCao { get; set; }
        public string PhongCach { get; set; }

        public DtDieuKhac(string maTPNT, string maVL, string khoiLuong, string chieuCao, string phongCach)
        {
            MaTPNT = maTPNT;
            MaVL = maVL;
            KhoiLuong = khoiLuong;
            ChieuCao = chieuCao;
            PhongCach = phongCach;
        }
    }

}
