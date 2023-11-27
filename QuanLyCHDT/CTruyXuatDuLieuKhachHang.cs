using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCHDT
{
    internal class CTruyXuatDuLieuKhachHang
    {
        public bool ghiFile(string tenfile, ref List<CKhachHang> dskh)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, dskh);
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool docFile(string tenfile, ref List<CKhachHang> dskh)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                dskh = bf.Deserialize(f) as List<CKhachHang>;
                f.Close();
                return true;
            }
            catch (IOException)
            {
                MessageBox.Show("Đã xảy ra lỗi khi đọc file dữ liệu!", "Thông báo");
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể đọc file dữ liệu!", "Thông báo");
                return false;
            }
        }
    }
}
