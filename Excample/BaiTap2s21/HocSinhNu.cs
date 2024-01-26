using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2s21
{
    internal class HocSinhNu:HocSinh
    {
        public double DiemVuCong { get; set; }
        public HocSinhNu(string HoTen, string GioiTinh, double DiemToan, double DiemLy, double DiemHoa, double DiemVuCong):base(HoTen, GioiTinh, DiemToan, DiemLy, DiemHoa)
        {
            this.DiemVuCong = DiemVuCong;
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"diem vu cong la:{DiemVuCong}");
        }
    }
}
