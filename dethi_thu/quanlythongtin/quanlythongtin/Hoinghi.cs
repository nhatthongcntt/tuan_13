using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlythongtin
{
    class HoiNghi
    {
        private string _maHN;

        public string MaHN
        {
            get { return _maHN; }
            set { _maHN = value; }
        }
        private string _tenHN;

        public string TenHN
        {
            get { return _tenHN; }
            set { _tenHN = value; }
        }
        private int _soNguoi;

        public int SoNguoi
        {
            get { return _soNguoi; }
            set { _soNguoi = value; }
        }
        private string _maLoaiPhong;

        public string MaLoaiPhong
        {
            get { return _maLoaiPhong; }
            set { _maLoaiPhong = value; }
        }
        public HoiNghi()
        {

        }
    }
}
