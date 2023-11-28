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

namespace QuanLyCHDT
{
    public partial class FormMain : Form
    {
        private List<CDienThoai> DsDienThoai = new List<CDienThoai>();
        private List<CKhachHang> dskh = new List<CKhachHang>();
        private CTruyXuatDuLieuDienThoai truyxuat = new CTruyXuatDuLieuDienThoai();
        private CTruyXuatDuLieuKhachHang txkh =  new CTruyXuatDuLieuKhachHang();
        private CXuLyDienThoai xuly = new CXuLyDienThoai();
        private CTruyXuatDuLieuDienThoai txdt = new CTruyXuatDuLieuDienThoai();
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
        }

        private void dgvDienThoai_Click(object sender, EventArgs e)
        {
            
        }

        private void tabQuanLySanPham_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem1HangSanXuat_Click(object sender, EventArgs e)
        {

        }

        private void dgvDienThoai_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow i in dgvDienThoai.SelectedRows)
            {
                string ma = i.Cells[0].Value.ToString();
                CDienThoai t = xuly.timDT(ma, DsDienThoai);
                if (t != null)
                {
                    string temp;
                    temp = i.Cells[0].Value.ToString();
                    txdt.id(temp);
                }
            }
            frmProductDetail frm = new frmProductDetail();
            frm.ShowDialog();
        }

        private void btnSoSanh_Click(object sender, EventArgs e)
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
