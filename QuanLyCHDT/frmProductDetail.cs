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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyCHDT
{
    public partial class frmProductDetail : Form
    {
        List<CDienThoai> dsdt = new List<CDienThoai>();
        CTruyXuatDuLieuDienThoai tx = new CTruyXuatDuLieuDienThoai();
        CXuLyDienThoai xl = new CXuLyDienThoai();
        private string id;

        public frmProductDetail()
        {
            InitializeComponent();
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        private void hienChiTiet()
        {

            if (tx.docFile_le("idKH.out", ref id) == true)
            {
                if (xl.timDT(id, dsdt) != null)
                {
                    CDienThoai dt = xl.timDT(id, dsdt);
                    txtIDSanPhamSua.Text = dt.IdSanPham;
                    txtTenDienThoaiSua.Text = dt.TenDienThoai;
                    txtManHinhSua.Text = dt.ManHinh;
                    txtHeDieuHanhSua.Text = dt.HeDieuHanh;
                    txtPinSua.Text = dt.Pin;
                    txtRamSua.Text = dt.Ram;
                    txtSoLuongNhapSua.Text = dt.SoLuongNhap;
                    txtHangSua.Text = dt.HangSanXuat;
                    txtChipSua.Text = dt.Chip;
                    txtRomSua.Text = dt.Rom;
                    txtGiaNhapSua.Text = dt.GiaNhap;
                    txtGiaBanSua.Text = dt.GiaBan;
                }
            }
        }
        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            if (tx.docFile("QLDSDT.txt", ref dsdt)){
                hienChiTiet();
            }
            else
            {
                MessageBox.Show("Deo doc dc");
            }
        }
    }
}
