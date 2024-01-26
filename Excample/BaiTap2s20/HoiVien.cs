using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2s20
{
    internal class HoiVien
    {
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public HoiVien(string HoTen, string DiaChi)
        {
            this.HoTen = HoTen;
            this.DiaChi = DiaChi;
        }
        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"ho ten:{HoTen}");
            Console.WriteLine($"dia chi:{DiaChi}");
        }
    }
}
