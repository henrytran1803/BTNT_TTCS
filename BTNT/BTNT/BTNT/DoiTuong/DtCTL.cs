using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNT.DoiTuong
{
    class DtCTL
    {
        public string MaCTL { get; set; }
        public string TenCTL { get; set; }
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }

        // Constructor
        public DtCTL(string maCTL, string tenCTL, DateTime ngayBD, DateTime ngayKT)
        {
            MaCTL = maCTL;
            TenCTL = tenCTL;
            NgayBD = ngayBD;
            NgayKT = ngayKT;
        }
    }

}
