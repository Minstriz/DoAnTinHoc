using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCHDT
{
    [Serializable]
    class CDienThoai
    {
        //test push
        private string m_idSanPham;
        private string m_idHang; //1 apple, 2 samsung, 3 oppo, 4 huawei
        private string m_tenDienThoai;
        private string m_hangSanXuat;
        private string m_heDieuHanh;
        private string m_manHinh;
        private string m_chip;
        private string m_ram;
        private string m_rom;
        private string m_pin;
        private string m_giaNhap;
        private string m_giaBan;
        private string m_soLuongNhap;

        public CDienThoai()
        {
            IdSanPham = "";
            IdHang = "";
            TenDienThoai = "";
            HangSanXuat = "";
            HeDieuHanh = "";
            ManHinh = "";
            Chip = "";
            Ram = "";
            Rom = "";
            Pin = "";
            GiaNhap = "";
            GiaBan = "";
            SoLuongNhap = "";
        }
        public CDienThoai(string IdSanPham,string idHang, string TenDienThoai, string HangSanXuat, string HeDieuHanh, string ManHinh, string Chip, string Ram, string Rom, string Pin, string GiaNhap, string GiaBan, string SoLuongNhap)
        {
            m_idSanPham = IdSanPham;
            m_idHang = IdHang;
            m_tenDienThoai = TenDienThoai;
            m_hangSanXuat = HangSanXuat;
            m_heDieuHanh = HeDieuHanh;
            m_manHinh = ManHinh;
            m_chip = Chip;
            m_giaNhap = GiaNhap;
            m_giaBan = GiaBan;
            m_ram = Ram;
            m_rom = Rom;
            m_pin = Pin;
            m_soLuongNhap = SoLuongNhap;
        }

        public string IdSanPham { get => m_idSanPham; set => m_idSanPham = value; }
        public string TenDienThoai { get => m_tenDienThoai; set => m_tenDienThoai = value; }
        public string HangSanXuat { get => m_hangSanXuat; set => m_hangSanXuat = value; }
        public string HeDieuHanh { get => m_heDieuHanh; set => m_heDieuHanh = value; }
        public string ManHinh { get => m_manHinh; set => m_manHinh = value; }
        public string Chip { get => m_chip; set => m_chip = value; }
        public string Ram { get => m_ram; set => m_ram = value; }
        public string Rom { get => m_rom; set => m_rom = value; }
        public string Pin { get => m_pin; set => m_pin = value; }
        public string GiaNhap { get => m_giaNhap; set => m_giaNhap = value; }
        public string GiaBan { get => m_giaBan; set => m_giaBan = value; }
        public string SoLuongNhap { get => m_soLuongNhap; set => m_soLuongNhap = value; }
        public string IdHang { get => m_idHang; set => m_idHang = value; }
    }
}
