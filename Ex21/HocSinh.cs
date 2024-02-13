using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2s21
{
    internal class HocSinh
    {
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }

        public HocSinh(string HoTen, string GioiTinh, double DiemToan, double DiemLy, double DiemHoa)
        {
            this.HoTen = HoTen;
            this.GioiTinh = GioiTinh;
            this.DiemToan = DiemToan;
            this.DiemLy = DiemLy;
            this.DiemHoa = DiemHoa;
        }
        public virtual void XuatThongTin()
        {
            Console.WriteLine($"ho ten la:{HoTen}");
            Console.WriteLine($"gioi tinh la:{GioiTinh}");
            Console.WriteLine($"diem toan la:{DiemToan}");
            Console.WriteLine($"diem ly la:{DiemLy}");
            Console.WriteLine($"diem hoa la:{DiemHoa}");
        }
    }
}
