using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyCHDT
{
    [Serializable]
    public class CMuaSanPham
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public int Gia { get; set; }

        public int ThanhTien
        {
            get { return Gia * SoLuong; }
        }

        public CMuaSanPham()
        {
            MaSanPham = string.Empty;
            SoLuong = 0;
            Gia = 0;
        }

        public CMuaSanPham(string maSanPham, string tenSanPham, int soLuong, int gia)
        {
            MaSanPham = maSanPham;
            SoLuong = soLuong;
            Gia = gia;
            TenSanPham = tenSanPham;
        }
    }

    [Serializable]
    public class CHoaDon
    {
        private List<CMuaSanPham> m_dsMua;
        private string m_maHoaDon;
        private string m_maKhachHang;
        private CChiTietHoaDon m_chitiet;

        public List<CMuaSanPham> getDsMua()
        {
            return m_dsMua;
        }
        public string MaHoaDon { get => m_maHoaDon; set => m_maHoaDon = value; }
        public string MaKhachHang { get => m_maKhachHang; set => m_maKhachHang = value; }

        public DateTime NgayLap
        {
            get { return m_chitiet.NgayLapHoaDon; }
            set { m_chitiet.NgayLapHoaDon = value; }
        }

        public string TinhTrang
        {
            get { return m_chitiet.TinhTrang; }
            set { m_chitiet.TinhTrang = value; }
        }
        public int TongTienHoaDon
        {
            get
            {
                int s = 0;
                foreach (var item in m_dsMua)
                    s += item.Gia * item.SoLuong;
                return s;
            }
        }

        public CHoaDon()
        {
            m_maHoaDon = string.Empty;
            m_maKhachHang = "";
            m_dsMua = new List<CMuaSanPham>();
        }
        public CHoaDon(string MaHoaDon, string MaKhachHang)
        {
            m_maHoaDon = MaHoaDon;
            m_maKhachHang = MaKhachHang;
            m_dsMua = new List<CMuaSanPham>();
        }

        public void capNhatChiTiet(DateTime ngay, bool tt)
        {
            m_chitiet = new CChiTietHoaDon(ngay, tt);
        }

        public void capNhat(CDienThoai dt, int SL)
        {
            CMuaSanPham spMoi = m_dsMua.Find(sp => sp.MaSanPham == dt.IdSanPham);
            if (spMoi == null)
            {
                m_dsMua.Add(new CMuaSanPham(dt.IdSanPham, dt.TenDienThoai, SL, Convert.ToInt32(dt.GiaBan)));
            }
            else
                spMoi.SoLuong = SL;
        }

        public void xoa(string MaSP)
        {
            CMuaSanPham spCanXoa = m_dsMua.Find(sp => sp.MaSanPham == MaSP);
            if (spCanXoa != null)
            {
                m_dsMua.Remove(spCanXoa);
            }
        }

    }
}
