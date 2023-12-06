using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static QuanLyCHDT.CHang;

namespace QuanLyCHDT
{
    public partial class FormMain : Form
    {
        private List<CDienThoai> DsDienThoai = new List<CDienThoai>();
        private List<CDienThoai> DsTemp = new List<CDienThoai>();
        private List<CKhachHang> dskh = new List<CKhachHang>();
        private List<CHang> dsHang = new List<CHang>();
        private CTruyXuatDuLieuDienThoai truyxuat = new CTruyXuatDuLieuDienThoai();
        private CTruyXuatDuLieuKhachHang txkh =  new CTruyXuatDuLieuKhachHang();
        private CXuLyDienThoai xuly = new CXuLyDienThoai();
        private CXuLyKhachHang xulyKH = new CXuLyKhachHang();
        private CXuLyHangSanXuat xulyHSX = new CXuLyHangSanXuat();
        private CTruyXuatDuLieuDienThoai txdt = new CTruyXuatDuLieuDienThoai();
        private CTruyXuatDuLieuHangSanXuat txhsx = new CTruyXuatDuLieuHangSanXuat();
        string radioValue;
        int indexClick = -1;
        CKhachHang currentKhachHang = null;
        CDienThoai currentDienThoai = null;
        private void hienThi()
        {
            dgvDienThoai.DataSource = DsDienThoai.ToList();
            dgvKhachHang.DataSource = dskh.ToList();
            QLHSXdgvDienThoai.DataSource = DsDienThoai.ToList();
            QLHSXdgvHangSanXuat.DataSource = dsHang.ToList();
        }
        public FormMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Kích hoạt tính năng tự động thay đổi kích thước cửa sổ
            this.AutoSize = true;
            if (truyxuat.docFile("QLDSDT.txt", ref DsDienThoai) == true)
            {
                hienThi();
                //MessageBox.Show("đã đọc được dữ liệu!", "Thông báo");
            }
            else MessageBox.Show("không đọc được dữ liệu điện thoại", "Thông báo");

            if (txkh.docFile("QLDSKH.txt", ref dskh) == true)
            {
                hienThi();
                //MessageBox.Show("đã đọc được dữ liệu!", "Thông báo");
            }
            else MessageBox.Show("không đọc được dữ liệu khách hàng", "Thông báo");
            if(txhsx.docFile("QLDSHSX.txt", ref dsHang) == true) {
                hienThi();
            }
            else MessageBox.Show("không đọc được dữ liệu danh sách hãng", "Thông báo");
            txhsx.docFile("QLDSHSX.txt", ref dsHang);
            updateComboboxHangSanXuatMainView();
        }
        private void updateComboboxHangSanXuatMainView()
        {
            foreach (CHang c in dsHang)
            {
                cbHangSanXuat.Items.Add(c.TenHang);
            }
        }

        private void btnThem1DienThoai_Click(object sender, EventArgs e)
        {
            frmNhapDienThoai frm  = new frmNhapDienThoai();
            frm.ShowDialog();
            this.Hide();
        }
        private void btnThem1DienThoai_Click_1(object sender, EventArgs e)
        {
            frmNhapDienThoai frm = new frmNhapDienThoai();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnXoa1DienThoai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedIndex = -1;
                for (int i = 0; i < dgvDienThoai.SelectedCells.Count; i++)
                {
                    if (dgvDienThoai.SelectedCells[i].RowIndex >= 0)
                    {
                        selectedIndex = dgvDienThoai.SelectedCells[i].RowIndex;
                        break;
                    }
                }
                if (selectedIndex != -1)
                {
                    //Kiểm tra xem người dùng có click vào dòng không
                    //Nếu đã click thì xóa dòng đó
                    DsDienThoai.RemoveAt(selectedIndex);
                    selectedIndex = -1;
                    hienThi();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                truyxuat.ghiFile("QLDSDT.txt", ref DsDienThoai); //cap nhat lai file sau khi xoa. 
            }
        }

        private void btnLoc_Click_1(object sender, EventArgs e)
        {
            frmLoc frm = new frmLoc();
            frm.ShowDialog();
        }



        private void btnNhap1KhachHang_Click(object sender, EventArgs e)
        {
            frmNhap1KhachHang frm = new frmNhap1KhachHang();
            frm.ShowDialog();
            this.Hide();
        }



        private void btnXoa1KhachHang_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedIndex = -1;
                for (int i = 0; i < dgvKhachHang.SelectedCells.Count; i++)
                {
                    if (dgvKhachHang.SelectedCells[i].RowIndex >= 0)
                    {
                        selectedIndex = dgvKhachHang.SelectedCells[i].RowIndex;
                        break;
                    }
                }
                if (selectedIndex != -1)
                {
                    //Kiểm tra xem người dùng có click vào dòng không
                    //Nếu đã click thì xóa dòng đó
                    dskh.RemoveAt(selectedIndex);
                    selectedIndex = -1;
                    hienThi();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                txkh.ghiFile("QLDSKH.txt", ref dskh); //cap nhat lai file sau khi xoa. 
            }
        }


        private void cbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLocKhachHang.Enabled = true;
            txtLocKhachHang.ForeColor = Color.Black;
        }

     
        private void locTheoHang()
        {
            List<CDienThoai> dsLocHang = new List<CDienThoai>();
            for (int i = 0; i < QLHSXdgvHangSanXuat.SelectedCells.Count; i++)
            {
                // Lấy thông tin hãng được chọn
                if (QLHSXdgvHangSanXuat.SelectedCells[i].RowIndex >= 0)
                {
                    string TenHangDuocChon = (QLHSXdgvHangSanXuat.SelectedCells[i].Value.ToString());
                    foreach (CDienThoai a in DsDienThoai)
                    {
                        if (a.HangSanXuat == TenHangDuocChon)
                        {
                            dsLocHang.Add(a);
                        }
                    }
                }
            }
            // Cập nhật dữ liệu cho DataGridView
            QLHSXdgvDienThoai.DataSource = dsLocHang.ToList();
            dsLocHang.Clear();
        }
        private void LocDSKH()
        {
            if (txtLocKhachHang.Text == "")
                hienThi();
            CKhachHang khachHang = new CKhachHang();
            List<CKhachHang> dsLoc = new List<CKhachHang>();
            switch (cbLoc.SelectedIndex)
            {
                case 0:
                    foreach (CKhachHang kh in dskh)
                    {
                        if (kh.MaKhachHang.ToUpper().Contains(txtLocKhachHang.Text.ToUpper()))
                        {
                            dsLoc.Add(kh);
                        }
                    }
                    break;

                case 1:
                    foreach (CKhachHang kh in dskh)
                    {
                        if (kh.TenKhachHang.ToUpper().Contains(txtLocKhachHang.Text.ToUpper()))
                        {
                            dsLoc.Add(kh);
                        }
                    }
                    break;

                case 2:

                    foreach (CKhachHang kh in dskh)
                    {
                        if (kh.Phai.ToUpper().StartsWith(txtLocKhachHang.Text.ToUpper()))
                        {
                            dsLoc.Add(kh);
                        }
                    }
                    break;

                case 3:

                    foreach (CKhachHang kh in dskh)
                    {
                        if (Convert.ToString(kh.NgayThangNamSinh).Contains(txtLocKhachHang.Text))
                        {
                            dsLoc.Add(kh);
                        }
                    }
                    break;

                case 4:
                    foreach (CKhachHang kh in dskh)
                    {
                        if (kh.DiaChiEmail.ToUpper().Contains(txtLocKhachHang.Text.ToUpper()))
                        {
                            dsLoc.Add(kh);
                        }
                    }
                    break;

                case 5:

                    foreach (CKhachHang kh in dskh)
                    {
                        if (kh.SoDienThoai.Contains(txtLocKhachHang.Text))
                        {
                            dsLoc.Add(kh);
                        }
                    }
                    break;

            }
            dgvKhachHang.DataSource = dsLoc.ToList();
        }
        private void btnSoSanh_Click(object sender, EventArgs e)
        {
            frmSoSanh frm = new frmSoSanh();
            frm.ShowDialog();
        }


        private void txtLocKhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            txtLocKhachHang.SelectAll();
            lbTxtNhapDuLieuTimKiem.Visible = false;
        }

        private void txtLocKhachHang_TextChanged(object sender, EventArgs e)
        {
            LocDSKH();
        }
        private void dgvDienThoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                currentDienThoai = (CDienThoai)dgvDienThoai.Rows[e.RowIndex].DataBoundItem;
                txtIDSanPham.Text = currentDienThoai.IdSanPham.ToString();
                txtTenDienThoai.Text = currentDienThoai.TenDienThoai.ToString();
                cbHangSanXuat.Text = currentDienThoai.HangSanXuat.ToString();
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
        }
        private void btnThem1HangSanXuat_Click(object sender, EventArgs e)
        {
            if (txtIDHang.Text == "" || txtTenHang.Text == "") {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin của hãng!");
            }
            else
            {
                
                CHang c = new CHang();
                c.IdHang = txtIDHang.Text;
                c.TenHang = txtTenHang.Text;
                if (xulyHSX.TimMaHang(c.IdHang, dsHang) == null)
                {
                    dsHang.Add(c);
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Mã hãng sản xuất " + c.IdHang + " đã tồn tại", "thông báo");
                }
                if (txhsx.ghiFile("QLDSHSX.txt", ref dsHang) == true)
                {
                    //MessageBox.Show("Thêm thành công", "Thông báo");
                }
                else MessageBox.Show("Ghi file không thành công", "Thông báo");
                hienThi();
                txtIDHang.Clear();
                txtTenHang.Clear();
                txtIDHang.Focus();
                
            }
        }


        private void QLHSXdgvHangSanXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            locTheoHang();
        }



        private void btnXoaHSX_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int selectedIndex = -1;
                for (int i = 0; i < QLHSXdgvHangSanXuat.SelectedCells.Count; i++)
                {
                    if (QLHSXdgvHangSanXuat.SelectedCells[i].RowIndex >= 0)
                    {
                        selectedIndex = QLHSXdgvHangSanXuat.SelectedCells[i].RowIndex;
                        break;
                    }
                }
                if (selectedIndex != -1)
                {
                    //Kiểm tra xem người dùng có click vào dòng không
                    //Nếu đã click thì xóa dòng đó
                    dsHang.RemoveAt(selectedIndex);
                    selectedIndex = -1;
                    hienThi();
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                }
                txhsx.ghiFile("QLDSHSX.txt", ref dsHang); //cap nhat lai file sau khi xoa. 
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.RowIndex != -1)
            {
                currentKhachHang = (CKhachHang)dgvKhachHang.Rows[e.RowIndex].DataBoundItem;
                txtMaKhachHang.Text = currentKhachHang.MaKhachHang.ToString();
                txtTenKhachHang.Text = currentKhachHang.TenKhachHang.ToString();
                dateTimePicker2.Text = currentKhachHang.NgayThangNamSinh.ToString();
                txtSoDienThoai.Text = currentKhachHang.SoDienThoai.ToString();
                txtEmail.Text = currentKhachHang.DiaChiEmail.ToString();
                if (currentKhachHang.Phai == "Nam")
                {
                    rdoNam.Checked = true;
                }
                if (currentKhachHang.Phai == "Nữ")
                {
                    rdoNu.Checked = true;
                }
            }
        }

        private void btnSua1KhachHangNew_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKhachHang.Text;
            CKhachHang currentKhachHang = xulyKH.timKH(maKH, dskh);
            if (currentKhachHang == null)
            {
                MessageBox.Show("Chọn khách hàng để sửa!");
            }
            else
            {
                currentKhachHang.MaKhachHang = txtMaKhachHang.Text;
                currentKhachHang.TenKhachHang = txtTenKhachHang.Text;
                currentKhachHang.DiaChiEmail = txtEmail.Text;
                currentKhachHang.SoDienThoai = txtSoDienThoai.Text;
                if (rdoNam.Checked == true)
                {
                    currentKhachHang.Phai = "Nam";
                }
                if (rdoNu.Checked == true)
                {
                    currentKhachHang.Phai = "Nữ";
                }
                currentKhachHang.NgayThangNamSinh = DateTime.Parse(dateTimePicker2.Text);
                hienThi();
                MessageBox.Show("Sửa thành công");
                txkh.ghiFile("QLDSKH.txt", ref dskh);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maDT = txtIDSanPham.Text;
            CDienThoai currentDienThoai = xuly.timDT(maDT,DsDienThoai);
            if(currentDienThoai == null)
            {
                MessageBox.Show("Chọn sản phẩm để sửa!");
            }
            else
            {
                currentDienThoai.IdSanPham = txtIDSanPham.Text;
                currentDienThoai.TenDienThoai = txtTenDienThoai.Text;
                currentDienThoai.HangSanXuat = cbHangSanXuat.Text;
                currentDienThoai.HeDieuHanh = txtHeDieuHanh.Text;
                currentDienThoai.ManHinh = txtManHinh.Text;
                currentDienThoai.Chip = txtChip.Text;
                currentDienThoai.Ram = txtRam.Text;
                currentDienThoai.Rom =  txtRom.Text;
                currentDienThoai.Pin = txtPin.Text;
                currentDienThoai.SoLuongNhap = txtSoLuongNhap.Text;
                currentDienThoai.GiaBan = txtGiaBan.Text;
                currentDienThoai.GiaNhap = txtGiaNhap.Text;
                hienThi();
                MessageBox.Show("Sửa thành công");
                truyxuat.ghiFile("QLDSDT.txt", ref DsDienThoai);
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
            
        }

        private void btnThem1HSX_Click(object sender, EventArgs e)
        {
            
        }

        private void tabQuanLySanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat1KhachHang_Click(object sender, EventArgs e)
        {

        }
    }
}
