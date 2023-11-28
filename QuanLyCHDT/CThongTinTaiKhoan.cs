using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDT
{
    internal class CThongTinTaiKhoan
    {
        string m_taiKhoan, m_matKhau, m_idKhachHang;

        public string TaiKhoan { get => m_taiKhoan; set => m_taiKhoan = value; }
        public string MatKhau { get => m_matKhau; set => m_matKhau = value; }
        public string IdKhachHang { get => m_idKhachHang; set => m_idKhachHang = value; }

        public CThongTinTaiKhoan() {
            m_matKhau = string.Empty;
            m_matKhau = string.Empty;
            m_idKhachHang = string.Empty;
        }
        public CThongTinTaiKhoan(string taiKhoan, string matKhau, string IdKhachHang)
        {
            m_taiKhoan = taiKhoan;
            m_matKhau = matKhau;
            m_idKhachHang = IdKhachHang;
        }
    }
}
