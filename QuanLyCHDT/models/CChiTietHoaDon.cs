using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDT
{
    [Serializable]
    internal class CChiTietHoaDon
    {
        private DateTime m_ngayLapHoaDon;
        private string m_tinhtrang;
        public DateTime NgayLapHoaDon { get => m_ngayLapHoaDon; set => m_ngayLapHoaDon = value; }
        public string TinhTrang
        {
            get { return m_tinhtrang; }
            set { m_tinhtrang = value; }
        }
        public CChiTietHoaDon()
        {
            m_ngayLapHoaDon = DateTime.Now;
            m_tinhtrang = "";
        }

        public CChiTietHoaDon(DateTime ngayLapHoaDon, bool tt)
        {
            NgayLapHoaDon = ngayLapHoaDon;
            m_tinhtrang = tt ? "Đã thanh toán" : "Chưa thanh toán";
        }
    }
}
