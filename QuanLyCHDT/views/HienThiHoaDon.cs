using System;
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
    public partial class HienThiHoaDon : Form
    {
        private CHoaDon hoaDonCanXem;
        public HienThiHoaDon()
        {
            InitializeComponent();

        }
        public HienThiHoaDon(CHoaDon hd)
        {
            hoaDonCanXem = hd;
            InitializeComponent();
        }

        private void HienThiHoaDon_Load(object sender, EventArgs e)
        {
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
            tinhtrang.Text = hoaDonCanXem.TinhTrang + " !!";

        }
    }
}
