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

        }
    }
}
