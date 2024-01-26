using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2s22
{
    internal class HocSinh
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public double TongDiem { get; set; }

        public HocSinh(string HoTen, int NamSinh, double TongDiem)
        {
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.TongDiem = TongDiem;
        }
        public override string ToString()
        {
            return $"ho ten:{HoTen.ToUpper()}, nam sinh:{NamSinh}, tong diem:{TongDiem}";
        }
    }
}
