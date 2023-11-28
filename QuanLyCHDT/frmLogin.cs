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
    public partial class frmLogin : Form
    {
        List<CThongTinTaiKhoan> dstk  = new List<CThongTinTaiKhoan> ();
        public frmLogin()
        {
            InitializeComponent();
        }
        private CThongTinTaiKhoan tim(string ma)
        {
            foreach (CThongTinTaiKhoan a in dstk)
            {
                if (a.TaiKhoan == ma)
                {
                    return a;
                }
            }
            return null;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "admin" && txtMatKhau.Text == "admin")
            {
                FormMain frm = new FormMain();
                frm.Show();
                this.Hide();
            }
            else if (tim(txtTaiKhoan.Text) == null || tim(txtMatKhau.Text) == null)
            {
                MessageBox.Show("Tài khoản hoặc mặt khẩu không đúng. Vui lòng thử lại", "Thông báo");
                txtMatKhau.Text = "";
                txtMatKhau.Focus();
            }
            else
            {
                MessageBox.Show("Sai account!");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frm = new frmDangKy();
            frm.Show();
            this.Hide();
        }
    }
}
