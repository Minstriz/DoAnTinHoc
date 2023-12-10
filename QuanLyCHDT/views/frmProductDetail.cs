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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyCHDT
{
    public partial class frmProductDetail : Form
    {
        List<CDienThoai> dsdt = new List<CDienThoai>();
        CTruyXuatDuLieuDienThoai tx = new CTruyXuatDuLieuDienThoai();
        CXuLyDienThoai xl = new CXuLyDienThoai();

        public frmProductDetail()
        {
            InitializeComponent();
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
        //private void hienChiTiet()
        //{

        //    if (tx.docFile_le("idKH.out", ref id) == true)
        //    {
        //        if (xl.timDT(id, dsdt) != null)
        //        {
        //            CDienThoai dt = xl.timDT(id, dsdt);
        //            txtIDSanPhamSua.Text = dt.IdSanPham;
        //            txtTenDienThoaiSua.Text = dt.TenDienThoai;
        //            txtManHinhSua.Text = dt.ManHinh;
        //            txtHeDieuHanhSua.Text = dt.HeDieuHanh;
        //            txtPinSua.Text = dt.Pin;
        //            txtRamSua.Text = dt.Ram;
        //            txtSoLuongNhapSua.Text = dt.SoLuongNhap;
        //            txtHangSua.Text = dt.HangSanXuat;
        //            txtChipSua.Text = dt.Chip;
        //            txtRomSua.Text = dt.Rom;
        //            txtGiaNhapSua.Text = dt.GiaNhap;
        //            txtGiaBanSua.Text = dt.GiaBan;
        //        }
        //    }
        //}
        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            
            try
            {
                //for (int i = 0; i < dgvDienThoaiChiTiet.RowCount; i++)
                //{
                //    if (dgvDienThoaiChiTiet.SelectedCells[i].Selected)
                //    {
                //        selectedIndex = i;
                //        break;
                //    }
                //}
                FileStream fs = new FileStream("QLDSDTCT.txt", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();

                //Lấy dữ liệu từ file cho vào detail
                dsdt = bf.Deserialize(fs) as List<CDienThoai>;
                fs.Close();
                //hien thi chi tiet dt duoc chon
                dgvDienThoaiChiTiet.DataSource = dsdt.ToList();
                //gán giá trị in put bằng thông tin vừa lấy được từ file
                txtIDSanPhamSua.Text = dsdt[0].IdSanPham;
                txtTenDienThoaiSua.Text = dsdt[0].TenDienThoai;
                txtManHinhSua.Text = dsdt[0].ManHinh;
                txtHeDieuHanhSua.Text = dsdt[0].HeDieuHanh;
                txtPinSua.Text = dsdt[0].Pin;
                txtRamSua.Text = dsdt[0].Ram;
                txtSoLuongNhapSua.Text = dsdt[0].SoLuongNhap;
                txtHangSua.Text = dsdt[0].HangSanXuat;
                txtChipSua.Text = dsdt[0].Chip;
                txtRomSua.Text = dsdt[0].Rom;
                txtGiaNhapSua.Text = dsdt[0].GiaNhap;
                txtGiaBanSua.Text = dsdt[0].GiaBan;
                dsdt.Clear();
            }
            catch { /*MessageBox.Show("Không Thể Load");*/ }
        }
    }
}
