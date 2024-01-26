using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2s3
{
    internal class KhoiA:ThiSinh
    {
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap diem toan:");
            DiemToan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly:");
            DiemLy = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa:");
            DiemHoa = double.Parse(Console.ReadLine());
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"diem toan:{DiemToan}");
            Console.WriteLine($"diem ly:{DiemLy}");
            Console.WriteLine($"diemhoa:{DiemHoa}");
            Console.WriteLine();
        }
    }
}
