using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlythongtin
{
    class LoaiPhong
    {
        string _maLoaiPhong;

        public string MaLoaiPhong
        {
            get { return _maLoaiPhong; }
            set { _maLoaiPhong = value; }
        }
        string _tenLoaiPhong;

        public string TenLoaiPhong
        {
            get { return _tenLoaiPhong; }
            set { _tenLoaiPhong = value; }
        }
        public LoaiPhong()
        {

        }
    }
}
