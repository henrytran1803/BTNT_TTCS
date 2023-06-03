using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNT.DoiTuong
{
    class DtHoiHoa
    {
        public string MaTPNT { get; set; }
        public string MaCL { get; set; }
        public string MaVL { get; set; }
        public string MaPC { get; set; }
        public DtHoiHoa(string maTPNT, string maCL, string maVL, string maPC)
        {
            MaTPNT = maTPNT;
            MaCL = maCL;
            MaVL = maVL;
            MaPC = maPC;
        }
    }
}
