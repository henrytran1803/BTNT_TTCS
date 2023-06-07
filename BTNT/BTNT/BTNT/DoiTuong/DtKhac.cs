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
        public byte[] AnhChup { get; set; }
        public string MaTL { get; set; }
        public DtKhac(string maTPNT, string phongCach, byte[] anhChup, string maTL)
        {
            MaTPNT = maTPNT;
            PhongCach = phongCach;
            AnhChup = anhChup;
            MaTL = maTL;
        }
    }

}
