﻿using System;
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
    public partial class frmNhapDienThoai : Form
    {
        private List<CDienThoai> DsDienThoai = new List<CDienThoai>();
        private List<CXuLyDienThoai> xldt = new List<CXuLyDienThoai>();
        private List<CHang> DsHang = new List<CHang>();
        private CTruyXuatDuLieuDienThoai truyxuat = new CTruyXuatDuLieuDienThoai();
        private CTruyXuatDuLieuHangSanXuat truyxuathang  = new CTruyXuatDuLieuHangSanXuat();
        public frmNhapDienThoai()
        {
            InitializeComponent();
        }
        private CDienThoai TimMaDienThoai(string ma)
        {
            foreach (CDienThoai k in DsDienThoai)
            {
                if (k.IdSanPham == ma)
                    return k;
            }
            return null;
        }
        public void Them()
        {
            CDienThoai dt = new CDienThoai();
            dt.IdSanPham = txtIDSanPham.Text;
            dt.TenDienThoai = txtTenDienThoai.Text;
            dt.HangSanXuat = cbHangSanXuat.Text;
            dt.HeDieuHanh = txtHeDieuHanh.Text;
            dt.ManHinh = txtManHinh.Text;
            dt.Chip = txtChip.Text;
            dt.GiaNhap = txtGiaNhap.Text;
            dt.GiaBan = txtGiaBan.Text;
            dt.Rom = txtRom.Text;
            dt.Ram = txtRam.Text;
            dt.SoLuongNhap = txtSoLuongNhap.Text;   
            dt.Pin = txtPin.Text;

            if (TimMaDienThoai(dt.IdSanPham) == null)
            {
                DsDienThoai.Add(dt);
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("ID " + dt.IdSanPham + " đã tồn tại", "thông báo");
            }
            txtIDSanPham.Clear();
            txtTenDienThoai.Clear();
            cbHangSanXuat = null;
            txtHeDieuHanh.Clear();
            txtManHinh.Clear();
            txtChip.Clear();
            txtGiaNhap.Clear();
            txtGiaBan.Clear();
            txtRom.Clear();
            txtRam.Clear();
            txtSoLuongNhap.Clear();
            txtPin.Clear();
            txtIDSanPham.Focus();
        }
        private void btnThem1DienThoai_Click(object sender, EventArgs e)
        {                                                                                                       
            Them();
            if(truyxuat.ghiFile("QLDSDT.txt", ref DsDienThoai) == true)
            {
                //MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else MessageBox.Show("Ghi file không thành công", "Thông báo");
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain frm = new FormMain();
            frm.Show();
        }
        private void updateComboboxHangSanXuat()
        {
            foreach(CHang c in DsHang)
            {
                cbHangSanXuat.Items.Add(c.TenHang);
            }
        }
        private void frmNhapDienThoai_Load(object sender, EventArgs e)
        {
            if (truyxuat.docFile("QLDSDT.txt", ref DsDienThoai) == true)
            {
                ///MessageBox.Show("đã đọc được dữ liệu!", "Thông báo");
            }
            else
            {
                MessageBox.Show("không đọc được dữ liệu", "Thông báo");
            }
            if (truyxuathang.docFile("QLDSHSX.txt",ref DsHang) == true)
            {
                ///MessageBox.Show("đã đọc được dữ liệu hãng!", "Thông báo");
            }
            else
            {
                MessageBox.Show("không đọc được dữ liệu", "Thông báo");
            }
            updateComboboxHangSanXuat();
        }
    }
}
