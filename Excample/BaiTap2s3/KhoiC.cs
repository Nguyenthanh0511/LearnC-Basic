using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2s3
{
    internal class KhoiC:ThiSinh
    {
        public double DiemVan { get; set; }
        public double DiemSu { get; set; }
        public double DiemDia { get; set; }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap diem van:");
            DiemVan = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem su:");
            DiemSu = double.Parse(Console.ReadLine());
            Console.Write("Nhap diem dia:");
            DiemDia = double.Parse(Console.ReadLine());
        }
        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine($"diem van:{DiemVan}");
            Console.WriteLine($"diem su:{DiemSu}");
            Console.WriteLine($"diem dia:{DiemDia}");
            Console.WriteLine();
        }
    }
}
