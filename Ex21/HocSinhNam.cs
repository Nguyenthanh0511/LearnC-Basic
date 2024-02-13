using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2s21
{
    internal class HocSinhNam:HocSinh
    {
        public double DiemKiThuat { get; set; }
        public HocSinhNam(string HoTen, string GioiTinh, double DiemToan, double DiemLy, double DiemHoa, double DiemKiThuat):base(HoTen, GioiTinh, DiemToan, DiemLy, DiemHoa)
        {
            this.DiemKiThuat = DiemKiThuat;
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"diem ki thuat la:{DiemKiThuat}");
        }
    }
}
