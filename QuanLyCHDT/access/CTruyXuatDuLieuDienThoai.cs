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

namespace QuanLyCHDT
{
    internal class CTruyXuatDuLieuDienThoai : CDienThoai
    {
        
        public bool ghiFile(string tenfile, ref List<CDienThoai> DsDienThoai)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(f, DsDienThoai);
                f.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool docFile(string tenfile, ref List<CDienThoai> DsDienThoai)
        {
            try
            {
                FileStream f = new FileStream(tenfile, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                DsDienThoai = bf.Deserialize(f) as List<CDienThoai>;
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
        //public bool docFile_le(string fileName, ref string id)
        //{
        //    try
        //    {
        //        StreamReader reader = new StreamReader(fileName);

        //        // Đọc dữ liệu từ file
        //        string line;
        //        while ((line = reader.ReadLine()) != null)
        //        {
        //            id = line;
        //        }

        //        // Đóng đối tượng StreamReader
        //        reader.Close();
        //        return true;
        //    }
        //    catch (IOException)
        //    {
        //        MessageBox.Show("Đã xảy ra lỗi khi đọc file dữ liệu!", "Thông báo");
        //        return false;
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Không thể đọc file dữ liệu!", "Thông báo");
        //        return false;
        //    }

        //}
        //public void id(string id)
        //{

        //    if (ghiFile_le("idKH.out", ref id) == true)
        //    {
        //        MessageBox.Show("Bạn đã ghi file thành công", "Thông báo");
        //    }
        //    else MessageBox.Show("Ghi file không thành công", "Thông báo");
        //}
        //public bool ghiFile_le(string fileName, ref string id)
        //{
        //    try
        //    {
        //        StreamWriter writer = new StreamWriter(fileName);

        //        // Ghi dữ liệu vào file
        //        writer.WriteLine(id);

        //        // Đóng đối tượng StreamWriter
        //        writer.Close();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
    }
}
