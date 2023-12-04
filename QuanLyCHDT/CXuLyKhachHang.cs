using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDT
{
    internal class CXuLyKhachHang
    {
        public CKhachHang timKH(string ma, List<CKhachHang> dskh)
        {
            foreach (CKhachHang a in dskh)
            {
                if (a.MaKhachHang == ma)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
