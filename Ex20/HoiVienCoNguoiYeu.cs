using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2s20
{
    internal class HoiVienCoNguoiYeu:HoiVien
    {
        public string HoTenNY { get; set; }
        public string SoDienThoaiNY { get; set; }

        public HoiVienCoNguoiYeu(string HoTen, string DiaChi, string HoTenNY, string SoDienThoaiNY):base(HoTen, DiaChi)
        {
            this.HoTenNY = HoTenNY;
            this.SoDienThoaiNY = SoDienThoaiNY;
        }
        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"ho ten nguoi yeu:{HoTenNY}");
            Console.WriteLine($"so dien thoai nguoi yeu:{SoDienThoaiNY}");
        }
    }
}
