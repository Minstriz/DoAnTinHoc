using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCHDT.views
{
    public partial class frmNhapHoaDon : Form
    {
        private CTruyXuatDuLieuDienThoai truyxuat = new CTruyXuatDuLieuDienThoai();
        private List<CDienThoai> DsDienThoai = new List<CDienThoai>();
        private List<CDienThoai> DsSpTrongGioHang = new List<CDienThoai>();
        CDienThoai currentDienThoai = new CDienThoai();
        CDienThoai currentDienThoaiGioHang = new CDienThoai();
        CKhachHang currentKhachHang = new CKhachHang();
        private List<CKhachHang> dskh = new List<CKhachHang>();
        private CTruyXuatDuLieuKhachHang txkh = new CTruyXuatDuLieuKhachHang();
        public frmNhapHoaDon()
        {
            InitializeComponent();
        }
        private void hienThi()
        {
            dgvDienThoai.DataSource = DsDienThoai.ToList();
            dgvGioHang.DataSource = DsSpTrongGioHang.ToList();
            dgvKhachHang.DataSource = dskh.ToList();
        }
        private void frmNhapHoaDon_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            if (truyxuat.docFile("QLDSDT.txt", ref DsDienThoai) == true)
            {
                hienThi();
                //MessageBox.Show("đã đọc được dữ liệu!", "Thông báo");
            }
            if (txkh.docFile("QLDSKH.txt", ref dskh) == true)
            {
                hienThi();
                //MessageBox.Show("đã đọc được dữ liệu!", "Thông báo");
            }
            else MessageBox.Show("không đọc được dữ liệu khách hàng", "Thông báo");
        }

        private void LocDsDienThoai()
        {
            List<CDienThoai> dsLoc = new List<CDienThoai>();
            string value = txtLoc.Text; //lấy value trong textbox
            string comboBoxValue = cbLoc.SelectedItem.ToString();
            if (txtLoc.Text != "")
            {
                CXuLyDienThoai xuly = new CXuLyDienThoai();
                xuly.tim(comboBoxValue, value, ref DsDienThoai, ref dsLoc);
                dgvDienThoai.DataSource = dsLoc.ToList();
                dsLoc.Clear();
            }
        }
        private void LocDSKH()
        {
            if (txtLocKhachHang.Text == "")
                hienThi();
            CKhachHang khachHang = new CKhachHang();
            List<CKhachHang> dsLoc = new List<CKhachHang>();
            switch (cbLocKH.SelectedIndex)
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
        private void txtLoc_TextChanged(object sender, EventArgs e)
        {
            LocDsDienThoai();
        }

        private void dgvDienThoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                currentDienThoai = (CDienThoai)dgvDienThoai.Rows[e.RowIndex].DataBoundItem;
            }
        }

        private void btnThemVaoGioHang_Click(object sender, EventArgs e)
        {
            if(currentDienThoai != null)
            {
                DsSpTrongGioHang.Add(currentDienThoai);
                hienThi();
            }
        }

        private void btnXoaSpGioHang_Click(object sender, EventArgs e)
        {
            if (currentDienThoaiGioHang != null)
            {
                DsSpTrongGioHang.Remove(currentDienThoaiGioHang);
                hienThi();
            }
        }

        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                currentDienThoaiGioHang = (CDienThoai)dgvGioHang.Rows[e.RowIndex].DataBoundItem;
            }
        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                currentKhachHang = (CKhachHang)dgvKhachHang.Rows[e.RowIndex].DataBoundItem;
                txtMaKhachHangNHD.Text = currentKhachHang.MaKhachHang;
                txtNDHTenKhachHang.Text = currentKhachHang.TenKhachHang;
                txtNDHsdt.Text = currentKhachHang.SoDienThoai;

            }
        }

        private void txtLocKhachHang_TextChanged(object sender, EventArgs e)
        {
            LocDSKH();
        }

        private void txtLocKhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            txtLocKhachHang.SelectAll();
            lbTxtNhapDuLieuTimKiem.Visible = false;
        }

        private void txtLocKhachHang_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void txtLoc_MouseClick(object sender, MouseEventArgs e)
        {
            txtLoc.SelectAll();
        }
    }
}
