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
    public partial class frmNhapHang : Form
    {
        List<CHang> dsHang = new List<CHang>();
        CTruyXuatDuLieuHangSanXuat truyxuat = new CTruyXuatDuLieuHangSanXuat();
        public frmNhapHang()
        {
            InitializeComponent();
        }
        private CHang TimMaHang(string ma)
        {
            foreach (CHang k in dsHang)
            {
                if (k.IdHang == ma)
                    return k;
            }
            return null;
        }
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            truyxuat.docFile("QLDSHSX.txt", ref dsHang);
        }

        public void Them1hangSanXuat()
        {
            CHang c = new CHang();
            c.IdHang = txtIDHang.Text;
            c.TenHang = txtTenHang.Text;
            if(TimMaHang(c.IdHang) == null)
            {
                dsHang.Add(c);
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Mã hãng sản xuất " + c.IdHang + " đã tồn tại", "thông báo");
            }
        }
        private void btnThem1HangSanXuat_Click(object sender, EventArgs e)
        {
            Them1hangSanXuat();
            if (truyxuat.ghiFile("QLDSHSX.txt", ref dsHang) == true)
            {
                //MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else MessageBox.Show("Ghi file không thành công", "Thông báo");
        }

        private void btnThoat1HangSanXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
