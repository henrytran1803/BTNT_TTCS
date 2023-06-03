using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNT.DoiTuong
{
    class DtKhac
    {
        public string MaTPNT { get; set; }
        public string PhongCach { get; set; }
        public string AnhChup { get; set; }

        public DtKhac(string maTPNT, string phongCach, string anhChup)
        {
            MaTPNT = maTPNT;
            PhongCach = phongCach;
            AnhChup = anhChup;
        }
    }

}
