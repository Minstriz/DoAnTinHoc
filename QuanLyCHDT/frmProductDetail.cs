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
        List<CDienThoai> dsdtDetail = new List<CDienThoai>();
        CTruyXuatDuLieuDienThoai tx = new CTruyXuatDuLieuDienThoai();
        public frmProductDetail()
        {
            InitializeComponent();
        }
        private void hienThi()
        {
            dgvDienThoai.DataSource = dsdtDetail.ToList();
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            if (tx.docFile("QLDSDT.txt", ref dsdtDetail) == true)
            {
                hienThi();
                //MessageBox.Show("đã đọc được dữ liệu!", "Thông báo");
            }
            int selectedIndex = -1;

            for (int i = 0; i < dgvDienThoai.SelectedCells.Count; i++)
            {
                if (dgvDienThoai.SelectedRows[i].Index >= 0)
                {
                    selectedIndex = dgvDienThoai.SelectedCells[i].RowIndex;
                    break;
                }
            }
            //Đọc dữ liệu từ file
            try
            {
                if (selectedIndex >= 0 && selectedIndex < dsdtDetail.Count)
                {
                    // Hiển thị dữ liệu của sản phẩm đã chọn
                    txtIDSanPhamSua.Text = dsdtDetail[selectedIndex].IdSanPham;
                    txtTenDienThoaiSua.Text = dsdtDetail[selectedIndex].TenDienThoai;
                    txtChipSua.Text = dsdtDetail[selectedIndex].Chip;
                    txtGiaBanSua.Text = dsdtDetail[selectedIndex].GiaBan;
                    txtGiaNhapSua.Text = dsdtDetail[selectedIndex].GiaNhap;
                    txtHangSua.Text = dsdtDetail[selectedIndex].HangSanXuat;
                    txtHeDieuHanhSua.Text = dsdtDetail[selectedIndex].HeDieuHanh;
                    txtManHinhSua.Text = dsdtDetail[selectedIndex].ManHinh;
                    txtPinSua.Text = dsdtDetail[selectedIndex].Pin;
                    txtSoLuongNhapSua.Text = dsdtDetail[selectedIndex].SoLuongNhap;
                    txtRamSua.Text = dsdtDetail[selectedIndex].Ram;
                    txtRomSua.Text = dsdtDetail[selectedIndex].Rom;
                }
                else
                {
                    // Hiển thị thông báo nếu không có sản phẩm nào được chọn
                    MessageBox.Show("Vui lòng chọn một sản phẩm để xem chi tiết.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }             
        }
    }
}
