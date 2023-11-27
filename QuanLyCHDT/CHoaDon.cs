using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDT
{
    internal class CHoaDon
    {
        string m_maHoaDon;
        string m_maKhachHang;
        int m_tongSL;
        int m_tongTien;

        public string MaHoaDon { get => m_maHoaDon; set => m_maHoaDon = value; }
        public string MaKhachHang { get => m_maKhachHang; set => m_maKhachHang = value; }
        public int TongSL { get => m_tongSL; set => m_tongSL = value; }
        public int TongTien { get => m_tongTien; set => m_tongTien = value; }

        public CHoaDon() {
            m_tongTien = 0;
            m_maHoaDon = string.Empty;
            m_maKhachHang = string.Empty;
            m_tongSL=0;
        }
        public CHoaDon(string MaHoaDon, string MaKhachHang, int TongSl, int TongTien) {
            m_maHoaDon = MaHoaDon;
            m_maKhachHang = MaKhachHang;
            m_tongSL = TongSl;  
            m_tongTien= TongTien;
        }

    }
}
