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
    public partial class frmNhap1KhachHang : Form
    {
        private bool kt = true;
        private List<CKhachHang> dskh = new List<CKhachHang>();
        private CTruyXuatDuLieuKhachHang truyxuat = new CTruyXuatDuLieuKhachHang();
        private CKhachHang TimMaKhachHang(string ma)
        {
            foreach (CKhachHang k in dskh)
            {
                if (k.MaKhachHang == ma)
                    return k;
            }
            return null;
        }
        public frmNhap1KhachHang(bool KT)
        {
            InitializeComponent();
            kt = KT;
        }
        public void Them()
        {
            CKhachHang kh = new CKhachHang();
            kh.MaKhachHang = txtMaKhachHang.Text;
            kh.TenKhachHang = txtTenKhachHang.Text;
            kh.NgayThangNamSinh = dateTimePicker1.Value;
            kh.DiaChiEmail = txtEmail.Text;
            kh.SoDienThoai = txtSoDienThoai.Text;
            if(rdoNam.Checked == true)
            {
                kh.Phai = "Nam";
            }
            if(rdoNu.Checked==true)
            {
                kh.Phai = "Nữ";
            }

            if (TimMaKhachHang(kh.MaKhachHang) == null)
            {
                dskh.Add(kh);
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Mã khách hàng " + kh.MaKhachHang + " đã tồn tại", "thông báo");
            }
        }

        public frmNhap1KhachHang()
        {
            InitializeComponent();
        }
        public void Sua()
        {
            CKhachHang khCanSua = dskh.Find(kh => kh.MaKhachHang == txtMaKhachHang.Text);
            if (khCanSua == null)
            {
                MessageBox.Show("Không có khách hàng này !!", "Thông báo");
                return;
            }
            else
            {
                if (dskh.Any(kh => kh.MaKhachHang == khCanSua.MaKhachHang))
                {

                    khCanSua.MaKhachHang = txtMaKhachHang.Text;
                    khCanSua.TenKhachHang = txtTenKhachHang.Text;
                    khCanSua.NgayThangNamSinh = dateTimePicker1.Value;
                    khCanSua.DiaChiEmail = txtEmail.Text;
                    khCanSua.SoDienThoai = txtSoDienThoai.Text;
                    if (rdoNam.Checked == true)
                    {
                        khCanSua.Phai = "Nam";
                    }
                    if (rdoNu.Checked == true)
                    {
                        khCanSua.Phai = "Nữ";
                    }

                }
            }
        }
            private void btnThem1DienThoai_Click(object sender, EventArgs e)
            {
                if (kt)
                    Them();
                else 
                    Sua();
                if (truyxuat.ghiFile("QLDSKH.txt", ref dskh) == true)
                {
                    MessageBox.Show(btnThem1KhachHang.Text + " thành công", "Thông báo");
                }
                else MessageBox.Show("Ghi file không thành công", "Thông báo");
            }

        private void frmNhap1KhachHang_Load(object sender, EventArgs e)
        {
            rdoNam.Checked = true;
            if (kt == false)
            {
                btnThem1KhachHang.Text = "Sửa";
            }
            if (truyxuat.docFile("QLDSKH.txt", ref dskh) == true)
            {
                //hienThi();
                ///MessageBox.Show("đã đọc được dữ liệu!", "Thông báo");
            }
            else
            {
                MessageBox.Show("không đọc được dữ liệu", "Thông báo");
            }
        }

        private void btnThoat1KhachHang_Click(object sender, EventArgs e)
        {
            btnThem1KhachHang.Text = "Thêm";
            this.Hide();
            FormMain frm = new FormMain();
            frm.Show();
        }
    }
}
