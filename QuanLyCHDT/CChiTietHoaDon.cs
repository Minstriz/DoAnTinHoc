using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDT
{
    internal class CChiTietHoaDon
    {
        string m_idChiTietHoaDon; 
        DateTime m_ngayLapHoaDon;
        double m_tongTien;
        string m_idHoaDon;
        string m_idSanPham;

        public string IdChiTietHoaDon { get => m_idChiTietHoaDon; set => m_idChiTietHoaDon = value; }
        public double TongTien { get => m_tongTien; set => m_tongTien = value; }
        public string IdHoaDon { get => m_idHoaDon; set => m_idHoaDon = value; }
        public string IdSanPham { get => m_idSanPham; set => m_idSanPham = value; }
        public DateTime NgayLapHoaDon { get => m_ngayLapHoaDon; set => m_ngayLapHoaDon = value; }

        public CChiTietHoaDon(){
            m_tongTien = 0.0;
            m_idHoaDon = string.Empty;
            m_idChiTietHoaDon = string.Empty;
            m_idSanPham = string.Empty;
            NgayLapHoaDon = DateTime.Now;
        }
    }
}
