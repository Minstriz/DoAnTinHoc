using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDT
{
    [Serializable]
    internal class CKhachHang
    {
        string m_maKhachHang;
        string m_tenKhachHang;
        string m_phai; //true la nam
        DateTime m_ngayThangNamSinh;
        string m_soDienThoai;
        string m_diaChiEmail;
        //string m_taiKhoan;
        //string m_matKhau;

        public string MaKhachHang { get => m_maKhachHang; set => m_maKhachHang = value; }
        public string TenKhachHang { get => m_tenKhachHang; set => m_tenKhachHang = value; }
        public DateTime NgayThangNamSinh { get => m_ngayThangNamSinh; set => m_ngayThangNamSinh = value; }
        public string SoDienThoai { get => m_soDienThoai; set => m_soDienThoai = value; }
        public string DiaChiEmail { get => m_diaChiEmail; set => m_diaChiEmail = value; }
        public string Phai { get => m_phai; set => m_phai = value; }
        public CKhachHang() {
            m_maKhachHang = "";
            m_tenKhachHang = "";
            m_ngayThangNamSinh = DateTime.Now;
            m_diaChiEmail = "";
            m_phai = ""; 
        }
        public CKhachHang(string maKhachHang, string tenKhachHang,
            DateTime NgayThangNamSinh, string SoDienThoai,
            String DiaChiEmail, string Phai)
        {
            m_maKhachHang = maKhachHang;
            m_tenKhachHang= tenKhachHang;
            m_soDienThoai= SoDienThoai;
            m_phai= Phai;
            m_diaChiEmail= DiaChiEmail;
            m_ngayThangNamSinh= NgayThangNamSinh;
        }
        public override string ToString()
        {
            return MaKhachHang+"-"+TenKhachHang+"-"+SoDienThoai;
        }
    }
}
