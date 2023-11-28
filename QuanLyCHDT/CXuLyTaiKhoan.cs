using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCHDT
{
    internal class CXuLyTaiKhoan
    {
        public CThongTinTaiKhoan tim(string ma, List<CThongTinTaiKhoan> dstk)
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
        public void them(CThongTinTaiKhoan tk, List<CThongTinTaiKhoan> dstk)
        {

            if (tim(tk.TaiKhoan, dstk) == null)
            {
                dstk.Add(tk);
                //hienThi();
            }
            else
            {
                MessageBox.Show("Mã số " + tk.TaiKhoan + " đã tồn tại", "thông báo");
            }
        }
    }
}
