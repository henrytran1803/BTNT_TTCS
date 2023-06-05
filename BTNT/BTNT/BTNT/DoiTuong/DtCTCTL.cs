using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNT.DoiTuong
{
    class DtCTCTL
    {
        public string MaCTL { get; set; }
        public string MaTPNT { get; set; }
        public DtCTCTL(string maCTL, string maTPNT)
        {
            MaCTL = maCTL;
            MaTPNT = maTPNT;

        }
    }
}
