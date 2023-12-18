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
    public partial class frmChiTietHoaDon : Form
    {
        private CHoaDon hoaDonCanXem;
        private CXuLyKhachHang xulyKH = new CXuLyKhachHang();
        private List<CKhachHang> dskh = new List<CKhachHang>();
        private CTruyXuatDuLieuKhachHang txkh = new CTruyXuatDuLieuKhachHang();

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
    private void frmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            if (txkh.docFile("QLDSKH.txt", ref dskh) == true)
            {
                //MessageBox.Show("đã đọc được dữ liệu!", "Thông báo");
            }
            else MessageBox.Show("không đọc được dữ liệu khách hàng", "Thông báo");
            CKhachHang temp = new CKhachHang();
            temp = xulyKH.timKH(hoaDonCanXem.MaKhachHang, dskh);

            mahd.Text = hoaDonCanXem.MaHoaDon;
            if (hoaDonCanXem.MaKhachHang == "")
            {
                makh.Text = "Không có";
            }
            else
            {
                makh.Text = hoaDonCanXem.MaKhachHang;
                tenkh.Text = temp.TenKhachHang.ToString();
            }
            ngaylap.Text = hoaDonCanXem.NgayLap.ToString();
            dgv_dsMua.AutoGenerateColumns = false;
            dgv_dsMua.DataSource = hoaDonCanXem.getDsMua().ToList();
            tongtien.Text = hoaDonCanXem.TongTienHoaDon.ToString();
            tinhtrang.Text = hoaDonCanXem.TinhTrang + " !!";
        }
    }
}
