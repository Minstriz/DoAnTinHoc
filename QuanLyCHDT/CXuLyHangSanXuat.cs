using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDT
{
    internal class CXuLyHangSanXuat
    {
        public CHang TimMaHang(string ma, List<CHang> dsHang)
        {
            foreach (CHang k in dsHang)
            {
                if (k.IdHang == ma)
                    return k;
            }
            return null;
        }
    }
}
