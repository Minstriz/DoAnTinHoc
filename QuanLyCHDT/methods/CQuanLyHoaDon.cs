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
    internal class CQuanLyHoaDon
    {
        private List<CHoaDon> m_dsHoaDon;

        public List<CHoaDon> GetDsHoaDon
        {
            get { return m_dsHoaDon; }
        }

        public CQuanLyHoaDon()
        {
            m_dsHoaDon = new List<CHoaDon>();
        }

        public void them(CHoaDon hoaDonCanThem)
        {
            m_dsHoaDon.Add(hoaDonCanThem);
        }

        public bool docFile(string tenfile)
        {
            try
            {
                using (FileStream f = new FileStream(tenfile, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    m_dsHoaDon = bf.Deserialize(f) as List<CHoaDon>;

                    // Kiểm tra m_dsHoaDon không phải là null trước khi sử dụng
                    if (m_dsHoaDon == null)
                    {
                        MessageBox.Show("Dữ liệu trong file không hợp lệ!", "Thông báo");
                        return false;
                    }
                }

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

        public bool ghiFile(string tenfile)
        {
            try
            {
                // Kiểm tra m_dsHoaDon không phải là null trước khi ghi file
                if (m_dsHoaDon != null)
                {
                    using (FileStream f = new FileStream(tenfile, FileMode.Create))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(f, m_dsHoaDon);
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
