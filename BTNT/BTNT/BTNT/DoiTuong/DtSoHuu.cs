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
        public DateTime NgaySoHuu { get; set; }
        public string TinhTrang { get; set; }
        public string GiaTri { get; set; }

        public DtSoHuu(string maTPNT, DateTime ngaySoHuu, string tinhTrang, string giaTri)
        {
            MaTPNT = maTPNT;
            NgaySoHuu = ngaySoHuu;
            TinhTrang = tinhTrang;
            GiaTri = giaTri;
        }
    }

}
