using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNT.DoiTuong
{
    class DtMuon
    {
        public string MaBST { get; set; }
        public string MaTPNT { get; set; }
        public string NgayMuon { get; set; }
        public string NgayTra { get; set; }

        public DtMuon(string maBST, string maTPNT, string ngayMuon, string ngayTra)
        {
            MaBST = maBST;
            MaTPNT = maTPNT;
            NgayMuon = ngayMuon;
            NgayTra = ngayTra;
        }
    }

}
