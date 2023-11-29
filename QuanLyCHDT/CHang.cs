using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDT
{
    internal class CHang
    {
        public enum HangSanXuat
        {
            Apple = 1,
            Samsung = 2,
            Oppo = 3,
            Huawei = 4
        }
        string idHang;
 
        string tenHang;

        public string IdHang { get => idHang; set => idHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }


        public CHang()
        {
            idHang = string.Empty;
            tenHang = string.Empty;
        }
        public CHang(string idHang, string tenHang)
        {
            IdHang = idHang;
            TenHang = tenHang;

        }
    }
}
