using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDT
{
    internal class CXuLyDienThoai
    {

        public void tim(string comboBoxValue, string value, ref List<CDienThoai> DsDienThoai, ref List<CDienThoai> dsTim)
        {
            foreach (CDienThoai a in DsDienThoai)
            {
                switch (comboBoxValue)
                {
                    case "Mã sản phẩm":
                        if (a.IdSanPham.ToLower().StartsWith(value.ToLower()))
                        {
                            dsTim.Add(a);
                        }
                        break;

                    case "Tên điện thoại":
                        if (a.TenDienThoai.ToLower().StartsWith(value.ToLower()))
                        {
                            dsTim.Add(a);
                        }
                        break;

                    case "Pin":
                        if (a.Pin.ToLower().StartsWith(value.ToLower()))
                        {
                            dsTim.Add(a);
                        }
                        break;

                    case "Ram":
                        if (a.Ram.ToLower().StartsWith(value.ToLower()))
                        {
                            dsTim.Add(a);
                        }
                        break;

                    case "Dung lượng":
                        if (a.Rom.ToLower().StartsWith(value.ToLower()))
                        {
                            dsTim.Add(a);
                        }
                        break;

                    case "Số lượng nhập":
                        if (a.SoLuongNhap.ToLower().StartsWith(value.ToLower()))
                        {
                            dsTim.Add(a);
                        }
                        break;

                    case "Giá nhập":
                        if (a.GiaNhap.ToLower().StartsWith(value.ToLower()))
                        {
                            dsTim.Add(a);
                        }
                        break;

                    case "Giá bán":
                        if (a.GiaBan.ToLower().StartsWith(value.ToLower()))
                        {
                            dsTim.Add(a);
                        }
                        break;

                    case "Hãng":
                        if (a.HangSanXuat.ToLower().StartsWith(value.ToLower()))
                        {
                            dsTim.Add(a);
                        }
                        break;

                    case "Hệ điều hành":
                        if (a.HeDieuHanh.ToLower().StartsWith(value.ToLower()))
                        {
                            dsTim.Add(a);
                        }
                        break;

                    case "Màn hình":
                        if (a.ManHinh.ToLower().StartsWith(value.ToLower()))
                        {
                            dsTim.Add(a);
                        }
                        break;

                    case "Chip":
                        if (a.Chip.ToLower().StartsWith(value.ToLower()))
                        {
                            dsTim.Add(a);
                        }
                        break;

                    default:
                        break;
                }
            }
        }


    }
}