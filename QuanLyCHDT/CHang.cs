using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDT
{
    internal class CHang
    {
        string idHang;
        string idDienThoai;
        string tenHang;

        public string IdHang { get => idHang; set => idHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public string IdDienThoai { get => idDienThoai; set => idDienThoai = value; }

        public CHang()
        {
            idHang = string.Empty;
            tenHang = string.Empty;
            idDienThoai= string.Empty;
        }
        public CHang(string idHang, string tenHang, string idDienThoai)
        {
            IdHang = idHang;
            TenHang = tenHang;
            IdDienThoai = idDienThoai;
        }
    }
}
