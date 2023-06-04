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
        public DateTime NgayMuon { get; set; }
        public DateTime NgayTra { get; set; }

        public DtMuon(string maTPNT, string maBST, DateTime ngayMuon, DateTime ngayTra)
        {
            MaBST = maBST;
            MaTPNT = maTPNT;
            NgayMuon = ngayMuon;
            NgayTra = ngayTra;
        }
    }

}
