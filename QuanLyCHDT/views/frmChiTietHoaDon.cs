﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCHDT
{
    public partial class frmChiTietHoaDon : Form
    {
        private CHoaDon hoaDonCanXem;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmChiTietHoaDon(CHoaDon hd)
        {
            hoaDonCanXem = hd;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            mahd.Text = hoaDonCanXem.MaHoaDon;
            if (hoaDonCanXem.MaKhachHang == "")
            {
                makh.Text = "Không có";
            }
            else
            {
                makh.Text = hoaDonCanXem.MaKhachHang;
            }

            ngaylap.Text = hoaDonCanXem.NgayLap.ToString();

            dgv_dsMua.AutoGenerateColumns = false;
            dgv_dsMua.DataSource = hoaDonCanXem.getDsMua().ToList();

            tongtien.Text = hoaDonCanXem.TongTienHoaDon.ToString();

            tinhtrang.Text = hoaDonCanXem.TinhTrang + " !!";
        }
    }
}
