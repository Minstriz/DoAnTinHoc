using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDT
{
    class CChiTietHoaDon
    {
        string m_idChiTietHoaDon;
        double m_tongTien;
        string m_idHoaDon;
        List<CDienThoai> m_dsSanPham;

        public string IdChiTietHoaDon { get => m_idChiTietHoaDon; set => m_idChiTietHoaDon = value; }
        public double TongTien { get => m_tongTien; set => m_tongTien = value; }
        public string IdHoaDon { get => m_idHoaDon; set => m_idHoaDon = value; }
        internal List<CDienThoai> DsSanPham { get => m_dsSanPham; set => m_dsSanPham = value; }

        public CChiTietHoaDon()
        {
            m_tongTien = 0.0;
            m_idHoaDon = string.Empty;
            m_idChiTietHoaDon = string.Empty;
            m_dsSanPham = null;

        }
        public CChiTietHoaDon(string idChiTietHoaDon, double tongTien, string idHoaDon, List<CDienThoai> dsSanPham)
        {
            IdChiTietHoaDon = idChiTietHoaDon;
            TongTien = tongTien;
            IdHoaDon = idHoaDon;
            DsSanPham = dsSanPham;
        }

        public double GetTongTienDienThoai()
        {
            // Khởi tạo biến đếm tổng tiền
            double tongTien = 0;

            // Duyệt từng điện thoại trong danh sách
            foreach (CDienThoai dt in DsSanPham)
            {
                double giaBan = Convert.ToDouble(dt.GiaBan); 
                // Cộng dồn giá bán của từng điện thoại
                tongTien +=giaBan;
            }

            // Trả về tổng tiền
            return tongTien;
        }
    }
}