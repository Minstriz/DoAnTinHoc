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
using System.Security.Policy;
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
        private List<CKhachHang> dskh = new List<CKhachHang>();
        private List<CHang> dsHang = new List<CHang>();
        private CTruyXuatDuLieuDienThoai truyxuat = new CTruyXuatDuLieuDienThoai();
        private CXuLyDienThoai xuly = new CXuLyDienThoai();
        private CXuLyKhachHang xulyKH = new CXuLyKhachHang();
        private CXuLyHangSanXuat xulyHSX = new CXuLyHangSanXuat();
        private CTruyXuatDuLieuKhachHang txkh = new CTruyXuatDuLieuKhachHang();
        private CTruyXuatDuLieuHangSanXuat txhsx = new CTruyXuatDuLieuHangSanXuat();
        CQuanLyHoaDon qlhd = new CQuanLyHoaDon();
        private CHoaDon hoaDonTamThoi = new CHoaDon();
        int indexClick = -1;
        CKhachHang currentKhachHang = null;
        CDienThoai currentDienThoai = null;
        CHoaDon currentHoaDon = null;
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
            //Resize cửa sổ 
            this.AutoSize = true;
            //Sản phẩm
            if (truyxuat.docFile("QLDSDT.txt", ref DsDienThoai) == true)
            {
                hienThi();
                //MessageBox.Show("đã đọc được dữ liệu!", "Thông báo");
            }
            else MessageBox.Show("không đọc được dữ liệu điện thoại", "Thông báo");
            //Khách hàng
            if (txkh.docFile("QLDSKH.txt", ref dskh) == true)
            {
                hienThi();
                //MessageBox.Show("đã đọc được dữ liệu!", "Thông báo");
            }
            else MessageBox.Show("không đọc được dữ liệu khách hàng", "Thông báo");
            //Hãng sản xuất
            if (txhsx.docFile("QLDSHSX.txt", ref dsHang) == true)
            {
                hienThi();
            }
            else MessageBox.Show("không đọc được dữ liệu danh sách hãng", "Thông báo");
            txhsx.docFile("QLDSHSX.txt", ref dsHang);
            updateComboboxHangSanXuatMainView();

            //Xử lý đơn hàng
            cb_sanpham.DisplayMember = "TenDienThoai";
            cb_sanpham.ValueMember = "IdSanPham";
            cb_sanpham.DataSource = DsDienThoai;
            cb_sanpham.SelectedIndex = -1;
            dgv_dsMua.AutoGenerateColumns = false;
            rdbt_Tatca.Checked = true;
            dgv_dsHoaDon.AutoGenerateColumns = false;
            if (qlhd.docFile("DanhSachHoaDon.txt"))
            {
                hienThiDSHoaDon();
            }
            updateComboboxKhachHang_QLDH();
        }
        private void updateComboboxHangSanXuatMainView()
        {
            cbHangSanXuat.Items.Clear();
            foreach (CHang c in dsHang)
            {
                cbHangSanXuat.Items.Add(c.TenHang);
            }
        }
        private void btnThem1DienThoai_Click(object sender, EventArgs e)
        {
            frmNhapDienThoai frm = new frmNhapDienThoai();
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
            if (e.RowIndex >= 0 && e.RowIndex < dgvDienThoai.Rows.Count)
            {
                indexClick = e.RowIndex;
            }
        }
        private void btnThem1HangSanXuat_Click(object sender, EventArgs e)
        {
            if (txtIDHang.Text == "" || txtTenHang.Text == "")
            {
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
            CDienThoai currentDienThoai = xuly.timDT(maDT, DsDienThoai);
            if (currentDienThoai == null)
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
                currentDienThoai.Rom = txtRom.Text;
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
        private void hienThiHoaDon()
        {
            dgv_dsMua.DataSource = hoaDonTamThoi.getDsMua().ToList();
        }
        private void hienThiDSHoaDon()
        {
            if (rdbt_Tatca.Checked)
            {
                dgv_dsHoaDon.DataSource = qlhd.GetDsHoaDon.ToList();
            }
            else if (rdbt_ChuaTT.Checked)
                dgv_dsHoaDon.DataSource = qlhd.GetDsHoaDon.Where(hd => hd.TinhTrang == "Chưa thanh toán").ToList();
            else
                dgv_dsHoaDon.DataSource = qlhd.GetDsHoaDon.Where(hd => hd.TinhTrang == "Đã thanh toán").ToList();
        }

        private void btn_CapNhatSP_Click(object sender, EventArgs e)
        {
            if (cb_sanpham.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm !!");
                return;
            }

            int SL = 0;

            try
            {
                SL = Convert.ToInt32(txt_SLHD.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập số lượng không hợp lệ !!", "Thông báo");
                return;
            }

            if (SL == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0 !!", "Thông báo");
                return;
            }

            CDienThoai dtMoi = dtMoi = DsDienThoai.Find(dt => dt.IdSanPham == cb_sanpham.SelectedValue.ToString());

            if (dtMoi == null)
            {
                MessageBox.Show("Không tồn tại sản phẩm này !!", "Thông báo");
                return;
            }
            hoaDonTamThoi.capNhat(dtMoi, SL);
            hienThiHoaDon();
        }

        private void btn_LammoiHD_Click(object sender, EventArgs e)
        {
            hoaDonTamThoi = new CHoaDon();
            txt_MaKHHD.Text = "";
            cmbKH_QLDH.Text = null;
            rdbt_Sau.Checked = rdbt_Truoc.Checked = false;
            cb_sanpham.SelectedValue = "";
            txt_SLHD.Text = "";
            hienThiHoaDon();
        }

        private void btn_XoaSPMua_Click(object sender, EventArgs e)
        {
            if (cb_sanpham.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm !!");
                return;
            }
            hoaDonTamThoi.xoa(cb_sanpham.SelectedValue.ToString());
            hienThiHoaDon();
        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            if ((rdbt_Truoc.Checked || rdbt_Sau.Checked) == false)
            {
                MessageBox.Show("Vui lòng chọn trạng thái hóa đơn !!", "Thông báo");
                return;
            }
            if (txt_MaKHHD.Text != "")
            {
                if (dskh.Find(kh => kh.MaKhachHang == txt_MaKHHD.Text) == null)
                {
                    MessageBox.Show("Mã khách hàng không tồn tại", "Thông báo");
                }
            }
            if (hoaDonTamThoi.getDsMua().Count == 0)
            {
                MessageBox.Show("Chưa có sản phẩm nào !!", "Thông báo");
                return;
            }
            //Quy tắc xử lý mã hóa đơn: HD12001 (12 là ngày lập, 001 là thứ tự)
            hoaDonTamThoi.MaHoaDon = "HD" + DateTime.Now.ToString("dd");
            string s = Convert.ToString(qlhd.GetDsHoaDon.Count + 1);
            while (s.Length < 3)
                s = "0" + s;
            hoaDonTamThoi.MaHoaDon += s;
            hoaDonTamThoi.MaKhachHang = txt_MaKHHD.Text;
            hoaDonTamThoi.capNhatChiTiet(DateTime.Now, rdbt_Truoc.Checked);
            qlhd.them(hoaDonTamThoi);
            hienThiDSHoaDon();
            if (!qlhd.ghiFile("DanhSachHoaDon.txt"))
            {
                MessageBox.Show("Lưu danh sách hóa đơn bị lỗi !!", "Thông báo");
            }
            btn_LammoiHD_Click(sender, e);
        }
        private void rdbt_Tatca_CheckedChanged(object sender, EventArgs e)
        {
            hienThiDSHoaDon();
        }

        private void rdbt_DaTT_CheckedChanged(object sender, EventArgs e)
        {
            hienThiDSHoaDon();
        }

        private void rdbt_ChuaTT_CheckedChanged(object sender, EventArgs e)
        {
            hienThiDSHoaDon();
        }

        private void dgv_dsMua_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv_dsMua.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void dgv_dsHoaDon_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dgv_dsHoaDon.Rows[e.RowIndex].Cells[0].Value = e.RowIndex +1;
        }

        private void dgv_dsHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                DataGridViewRow selectedRow = dgv_dsHoaDon.Rows[e.RowIndex];
                string maHDCanXem = selectedRow.Cells[2].Value.ToString();
                frmChiTietHoaDon frm = new frmChiTietHoaDon(qlhd.GetDsHoaDon.Find(hd => hd.MaHoaDon == maHDCanXem));
                frm.Show();
            }
            if (e.RowIndex != -1)
            {
                currentHoaDon = (CHoaDon)dgv_dsHoaDon.Rows[e.RowIndex].DataBoundItem;
                txt_MaKHHD.Text = currentHoaDon.MaKhachHang.ToString();
                CKhachHang temp = new CKhachHang();
                temp = xulyKH.timKH(txt_MaKHHD.Text, dskh);
             
                cmbKH_QLDH.Text = temp.ToString();
                if (currentHoaDon.TinhTrang is "Đã thanh toán")
                {
                    rdbt_Truoc.Checked = true;
                }
                else
                {
                    rdbt_Sau.Checked = true;
                }
                
            }
        }
        private void cbHangSanXuat_Click(object sender, EventArgs e)
        {
            updateComboboxHangSanXuatMainView();
        }
        private void updateComboboxKhachHang_QLDH()
        {
            cmbKH_QLDH.Items.Clear();
            foreach(CKhachHang c in dskh)
            {
                cmbKH_QLDH.Items.Add(c.ToString());
            }
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            {
                sapXep();
            }
        }
        private void sapXep()
        {
            if (truyxuat.docFile("QLDSDT.txt", ref DsDienThoai) == true)
            {
                if (cmbSort.SelectedItem.ToString() == ("A to Z"))
                {
                    foreach (CDienThoai sort in DsDienThoai)
                    {
                        DsDienThoai.Sort((kh1, kh2) => kh1.TenDienThoai.CompareTo(kh2.TenDienThoai));
                        dgvDienThoai.DataSource = DsDienThoai;
                    }
                }
                else if (cmbSort.SelectedItem.ToString() == ("Z to A"))
                {
                    foreach (CDienThoai sort in DsDienThoai)
                    {
                        DsDienThoai.Sort((kh1, kh2) => kh2.TenDienThoai.CompareTo(kh1.TenDienThoai));
                        dgvDienThoai.DataSource = DsDienThoai;
                    }
                }
                else if (cmbSort.SelectedItem.ToString() == ("Giá thấp tới cao"))
                {
                    foreach (CDienThoai sort in DsDienThoai)
                    {
                        DsDienThoai.Sort((kh1, kh2) => kh2.GiaBan.CompareTo(kh1.GiaBan));
                        dgvDienThoai.DataSource = DsDienThoai;
                    }
                }
                else if (cmbSort.SelectedItem.ToString() == ("Giá cao tới thấp"))
                {
                    foreach (CDienThoai sort in DsDienThoai)
                    {
                        DsDienThoai.Sort((kh1, kh2) => kh1.GiaBan.CompareTo(kh2.GiaBan));
                        dgvDienThoai.DataSource = DsDienThoai;
                    }
                }
            }
        }
        private void btnUpdateTinhTrang_Click(object sender, EventArgs e)
        {
            if (rdbt_Truoc.Checked is true)
                currentHoaDon.TinhTrang = "Đã thanh toán";
            if (rdbt_Sau.Checked is true)
                currentHoaDon.TinhTrang = "Chưa thanh toán";
            hienThiDSHoaDon();
        }

        private void rdbt_Truoc_TextChanged(object sender, EventArgs e)
        {
            btnUpdateTinhTrang.Enabled = true;
        }

        private void rdbt_Sau_TextChanged(object sender, EventArgs e)
        {
            btnUpdateTinhTrang.Enabled = true;
        }

        private void rdbt_Sau_Click(object sender, EventArgs e)
        {
            btnUpdateTinhTrang.Enabled = true;
        }

        private void rdbt_Truoc_Click(object sender, EventArgs e)
        {
            btnUpdateTinhTrang.Enabled = true;
        }

        private void cmbKH_QLDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem combobox có giá trị được chọn hay không
            if (cmbKH_QLDH.SelectedItem != null)
            {
                // Lấy mã khách hàng
                string maKhachHang = cmbKH_QLDH.SelectedItem.ToString().Split(new char[] { '-' }, 2)[0];

                // Gán mã khách hàng vào ô textbox
                txt_MaKHHD.Text = maKhachHang;
            }
        }
    }
}
