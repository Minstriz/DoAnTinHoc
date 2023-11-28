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
    public partial class frmDangKy : Form
    {
        private List<CThongTinTaiKhoan> dstk = new List<CThongTinTaiKhoan>();
        private CTruyXuatTaiKhoan tx = new CTruyXuatTaiKhoan();
        private CXuLyTaiKhoan xl = new CXuLyTaiKhoan();
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(txtMatKhau == textConfirmPass)
            {
                checkBox.Checked = true;
            }
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            tx.docFile("taiKhoan.txt", ref dstk);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            CThongTinTaiKhoan tk = new CThongTinTaiKhoan();
            tk.TaiKhoan = txtTaiKhoan.Text;
            tk.MatKhau = txtMatKhau.Text;
            xl.them(tk, dstk);
            if (tx.ghiFile("taiKhoan.txt", ref dstk) == true)
            {
                MessageBox.Show("Bạn đã ghi file thành công", "Thông báo");
            }
            else MessageBox.Show("Ghi file không thành công", "Thông báo");
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
        }

        private void btnThoatDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }
    }
}
