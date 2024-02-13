using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2s20
{
    internal class HoiVienCoGiaDinh:HoiVien
    {
        public string HoTenVo { get; set; }
        public DateTime NgayCuoi { get; set; }

        public HoiVienCoGiaDinh(string HoTen, string DiaChi, string HoTenVo, DateTime NgayCuoi):base(HoTen, DiaChi)
        {
            this.HoTenVo = HoTenVo;
            this.NgayCuoi = NgayCuoi;
        }
        public override void HienThiThongTin()
        {
            base.HienThiThongTin();
            Console.WriteLine($"ho ten vo:{HoTenVo}");
            Console.WriteLine($"ngay cuoi:{NgayCuoi.Tostring("dd.MM.yyyy")}");
        }
    }
}
