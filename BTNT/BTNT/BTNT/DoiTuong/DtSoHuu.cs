using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNT.DoiTuong
{
    class DtSoHuu
    {
        public string MaTPNT { get; set; }
        public string NgaySoHuu { get; set; }
        public Byte TinhTrang { get; set; }
        public string GiaTri { get; set; }

        public DtSoHuu(string maTPNT, string ngaySoHuu, Byte tinhTrang, string giaTri)
        {
            MaTPNT = maTPNT;
            NgaySoHuu = ngaySoHuu;
            TinhTrang = tinhTrang;
            GiaTri = giaTri;
        }
    }

}
