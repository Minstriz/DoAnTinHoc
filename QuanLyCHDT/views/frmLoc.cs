using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyCHDT
{
    public partial class frmLoc : Form
    {
       
        private List<CDienThoai> dsdt = new List<CDienThoai>();

        private CTruyXuatDuLieuDienThoai truyxuat = new CTruyXuatDuLieuDienThoai();
        private CXuLyDienThoai xuly = new CXuLyDienThoai();
        public frmLoc()
        {
            InitializeComponent();
        }
        private void frmLoc_Load(object sender, EventArgs e)
        {
            truyxuat.docFile("QLDSDT.txt", ref dsdt);
            dgvDienThoaiLoc.DataSource = dsdt.ToList();
        }
        private void Sort(object sender, EventArgs e)
        {
            LocDsDienThoai();
        }
        private void LocDsDienThoai()
        {
            List<CDienThoai> dsLoc = new List<CDienThoai>();
            string value = txtLoc.Text; //lấy value trong textbox
            string comboBoxValue = cbLoc.SelectedItem.ToString();
            if (txtLoc.Text != "")
            {
                CXuLyDienThoai xuly = new CXuLyDienThoai();
                xuly.tim(comboBoxValue, value, ref dsdt, ref dsLoc);
                dgvDienThoaiLoc.DataSource = dsLoc.ToList();
                dsLoc.Clear();
            }
        }


        private void lbTxtNhapDuLieuTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void cbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            while(cbLoc.Text == string.Empty)
            {
                txtLoc.Enabled = false;
            }
            Sort(sender, e);
        }
    }
}
