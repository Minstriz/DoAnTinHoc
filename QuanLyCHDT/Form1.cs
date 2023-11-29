using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyCHDT.CHang;

namespace QuanLyCHDT
{
    public partial class FormMain : Form
    {
        private List<CDienThoai> DsDienThoai = new List<CDienThoai>();
        private List<CDienThoai> DsTemp = new List<CDienThoai>();
        private List<CKhachHang> dskh = new List<CKhachHang>();
        private CTruyXuatDuLieuDienThoai truyxuat = new CTruyXuatDuLieuDienThoai();
        private CTruyXuatDuLieuKhachHang txkh =  new CTruyXuatDuLieuKhachHang();
        private CXuLyDienThoai xuly = new CXuLyDienThoai();
        private CTruyXuatDuLieuDienThoai txdt = new CTruyXuatDuLieuDienThoai();
        string radioValue;
        int indexClick = -1;
        private void hienThi()
        {
            dgvDienThoai.DataSource = DsDienThoai.ToList();
            dgvKhachHang.DataSource = dskh.ToList();
            QLHSXdgvDienThoai.DataSource = DsDienThoai.ToList();
        }
        public FormMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
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

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
        private void btnSaveFle_Click(object sender, EventArgs e)
        {
            
        }


        private void btnThem1DienThoai_Click(object sender, EventArgs e)
        {
            frmNhapDienThoai frm  = new frmNhapDienThoai();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }

        private void Show(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void tabQuanLyKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void cbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLocKhachHang.Enabled = true;
            txtLocKhachHang.ForeColor = Color.Black;
        }

     
        private void locTheoHang()
        {
            List<CDienThoai> dsLocHang = new List<CDienThoai>();
            List<CHang> dsHang = new List<CHang>();

            // Lấy thông tin hãng được chọn
            CHang hangDuocChon = new CHang();
            if (rdoApple.Checked == true)
            {
                hangDuocChon.IdHang = HangSanXuat.Apple.ToString();
                hangDuocChon.TenHang = "Apple";
            }
            else if (rdoSamsung.Checked == true)
            {
                hangDuocChon.IdHang = HangSanXuat.Samsung.ToString();
                hangDuocChon.TenHang = "Samsung";
            }

            // Lọc danh sách sản phẩm
            foreach (CDienThoai a in DsDienThoai)
            {
                if (a.HangSanXuat == hangDuocChon.IdHang)
                {
                    dsLocHang.Add(a);
                }
            }
            dsHang.Add(hangDuocChon);
            // Cập nhật dữ liệu cho DataGridView
            QLHSXdgvDienThoai.DataSource = dsLocHang.ToList();
            QLHSXdgvHangSanXuat.DataSource = dsHang.ToList();
            dsLocHang.Clear();
            dsHang.Clear();
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

                case 6:
                    foreach (CKhachHang kh in dskh)
                    {
                        if (kh.TaiKhoan.ToUpper().Contains(txtLocKhachHang.Text.ToUpper()))
                        {
                            dsLoc.Add(kh);
                        }
                    }
                    break;

                case 7:
                    foreach (CKhachHang kh in dskh)
                    {
                        if (kh.MatKhau.ToUpper().Contains(txtLocKhachHang.Text.ToUpper()))
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

        }

        private void rdoSamsung_CheckedChanged(object sender, EventArgs e)
        {
            locTheoHang();
        }

        private void rdoApple_CheckedChanged(object sender, EventArgs e)
        {
            locTheoHang();
        }

        private void btnSua1KhachHang_Click(object sender, EventArgs e)
        {
            frmNhap1KhachHang frm = new frmNhap1KhachHang(false);
            frm.ShowDialog();
            if (txkh.docFile("QLDSKH.txt", ref dskh) == true)
            {
                hienThi();
                //MessageBox.Show("đã đọc được dữ liệu!", "Thông báo");
            }
            else MessageBox.Show("không đọc được dữ liệu khách hàng", "Thông báo");
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

        private void dgvDienThoai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy chỉ mục khi click vào row
            int index = dgvDienThoai.Rows[e.RowIndex].Index;
            List<CDienThoai> detail = new List<CDienThoai>();
            try
            {
                //Tạo 1 danh sách ảo với phần tử là phần được đc click  và lưu vào file
             
                detail.Add(DsTemp[index]);
                //Ghi dữ liệu vào file
                FileStream fs = new FileStream("QLDSDTCT.txt", FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, detail);
                fs.Close();
                //Gọi form thông tin chi tiết
                frmProductDetail frm = new frmProductDetail();
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Không Thể Lưu");
            }
        }

        private void dgvDienThoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvDienThoai.Rows.Count)
            {
                indexClick = e.RowIndex;
            }
        }

        private void tabQuanLySanPham_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
    
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        //private void btnSua_Click(object sender, EventArgs e)
        //{
        //    frmNhapDienThoai frm = new frmNhapDienThoai();
        //    frm.doiTen();
        //    frm.Show();
        //    this.Hide();
        //}
    }
}
