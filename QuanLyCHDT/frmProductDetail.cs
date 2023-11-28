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
        List<CDienThoai> detail;
        CTruyXuatDuLieuDienThoai tx = new CTruyXuatDuLieuDienThoai();
        public frmProductDetail()
        {
            InitializeComponent();
        }
        private void hienThi()
        {
            dgvDienThoai.DataSource = detail.ToList();
            
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("QLDSDT.txt", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();

            //Lấy dữ liệu từ file cho vào detail
            detail = bf.Deserialize(fs) as List<CDienThoai>;
            fs.Close();

            detail = new List<CDienThoai>();
            int selectedIndex = -1;

            // Kiểm tra xem có ô nào được chọn trong DataGridView không
            for (int i = 0; i < dgvDienThoai.SelectedCells.Count; i++)
            {
                if (dgvDienThoai.SelectedCells[i].RowIndex >= 0)
                {
                    selectedIndex = dgvDienThoai.SelectedCells[i].RowIndex;
                    break;
                }
            }
            //Đọc dữ liệu từ file
            try
            {
                    // Hiển thị dữ liệu của sản phẩm đã chọn
                    txtIDSanPhamSua.Text = detail[0].IdSanPham;
                    txtTenDienThoaiSua.Text = detail[0].TenDienThoai;
                    txtChipSua.Text = detail[0].Chip;
                    txtGiaBanSua.Text = detail[0].GiaBan;
                    txtGiaNhapSua.Text = detail[0].GiaNhap;
                    txtHangSua.Text = detail[0].HangSanXuat;
                    txtHeDieuHanhSua.Text = detail[0].HeDieuHanh;
                    txtManHinhSua.Text = detail[0].ManHinh;
                    txtPinSua.Text = detail[0].Pin;
                    txtSoLuongNhapSua.Text = detail[0].SoLuongNhap;
                    txtRamSua.Text = detail[0].Ram;
                    txtRomSua.Text = detail[0].Rom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }
    }
}
