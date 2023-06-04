using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNT.DoiTuong
{
    class DtBST
    {
        public string MaBST { get; set; }
        public string TenBST { get; set; }
        public string MaHT { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public string MoTa { get; set; }
        public DtBST(string maBST,string tenBST, string maHT, string sdt, string diaChi, string moTa)
        {
            MaBST = maBST;
            MaHT = maHT;
            SDT = sdt;
            DiaChi = diaChi;
            MoTa = moTa;
            TenBST = tenBST;
        }
    }

}
