using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCHDT
{
    public partial class frmSoSanh : Form
    {
        private List<CDienThoai> DsDienThoai = new List<CDienThoai>();
        private CTruyXuatDuLieuDienThoai truyxuat = new CTruyXuatDuLieuDienThoai();
        CDienThoai currentDienThoai = null;
        CDienThoai currentDienThoai2 = null;
        public frmSoSanh()
        {
            InitializeComponent();
        }
        private void hienThi()
        {
            dgvDienThoai.DataSource = DsDienThoai.ToList();
        }
        private void frmSoSanh_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            if (truyxuat.docFile("QLDSDT.txt", ref DsDienThoai) == true)
            {
                hienThi();
                //MessageBox.Show("đã đọc được dữ liệu!", "Thông báo");
            }
        }

        private void dgvDienThoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                currentDienThoai = (CDienThoai)dgvDienThoai.Rows[e.RowIndex].DataBoundItem;
            }
        }

        private void btnSanPhamSoSanh1_Click(object sender, EventArgs e)
        {
            txtIDSanPham.Text = currentDienThoai.IdSanPham.ToString();
            txtTenDienThoai.Text = currentDienThoai.TenDienThoai.ToString();
            txtHangSanXuat.Text = currentDienThoai.HangSanXuat.ToString();
            txtHeDieuHanh.Text = currentDienThoai.HeDieuHanh.ToString();
            txtManHinh.Text = currentDienThoai.ManHinh.ToString();
            txtChip.Text = currentDienThoai.Chip.ToString();
            txtRam.Text = currentDienThoai.Ram.ToString();
            txtRom.Text = currentDienThoai.Rom.ToString();
            txtPin.Text = currentDienThoai.Pin.ToString();
            txtSoLuongNhap.Text = currentDienThoai.SoLuongNhap.ToString();
            txtGiaBan.Text = currentDienThoai.GiaBan.ToString();
            txtGiaNhap.Text = currentDienThoai.GiaNhap.ToString();
        }

        private void btnXoaSanPhamSoSanh1_Click(object sender, EventArgs e)
        {
            txtIDSanPham.Clear();
            txtTenDienThoai.Clear();
            txtHangSanXuat.Clear();
            txtHeDieuHanh.Clear();
            txtManHinh.Clear();
            txtChip.Clear();
            txtRam.Clear();
            txtRom.Clear();
            txtPin.Clear();
            txtSoLuongNhap.Clear();
            txtGiaBan.Clear();
            txtGiaNhap.Clear();
        }

        private void brnSanPhamSoSanh2_Click(object sender, EventArgs e)
        {
            txtId2.Text = currentDienThoai.IdSanPham.ToString();
            txtTen2.Text = currentDienThoai.TenDienThoai.ToString();
            txtHang2.Text = currentDienThoai.HangSanXuat.ToString();
            txtHeDieuHanh2.Text = currentDienThoai.HeDieuHanh.ToString();
            txtManHinh2.Text = currentDienThoai.ManHinh.ToString();
            txtChip2.Text = currentDienThoai.Chip.ToString();
            txtRam2.Text = currentDienThoai.Ram.ToString();
            txtRom2.Text = currentDienThoai.Rom.ToString();
            txtPin2.Text = currentDienThoai.Pin.ToString();
            txtSoLuongNhap2.Text = currentDienThoai.SoLuongNhap.ToString();
            txtGiaBan2.Text = currentDienThoai.GiaBan.ToString();
            txtGiaNhap2.Text = currentDienThoai.GiaNhap.ToString();
        }

        private void btnXoaSanPham2_Click(object sender, EventArgs e)
        {
            txtId2.Clear(); ;
            txtTen2.Clear(); ;
            txtHang2.Clear(); ;
            txtHeDieuHanh2.Clear(); ;
            txtManHinh2.Clear();
            txtChip2.Clear(); ;
            txtRam2.Clear(); ;
            txtRom2.Clear();
            txtPin2.Clear();
            txtSoLuongNhap2.Clear();
            txtGiaBan2.Clear();
            txtGiaNhap2.Clear();
        }
    }
}
