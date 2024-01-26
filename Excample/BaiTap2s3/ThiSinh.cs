using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2s3
{
    internal class ThiSinh
    {
        public string SoBaoDanh { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string UuTien { get; set; }

        public virtual void NhapThongTin()
        {
            Console.Write("Nhap thong tin cho thi sinh:");
            Console.Write("Nhap so bao danh:");
            SoBaoDanh = Console.ReadLine();
            Console.Write("Nhap ho ten:");
            HoTen = Console.ReadLine();
            Console.Write("Nhap dia chi:");
            DiaChi = Console.ReadLine();
            Console.Write("Nhap thanh phan ưuu tien:");
            UuTien = Console.ReadLine();
        }
        public virtual void XuatThongTin()
        {
            Console.WriteLine($"so bao danh la:{SoBaoDanh}");
            Console.WriteLine($"ho ten:{HoTen}");
            Console.WriteLine($"dia chi:{DiaChi}");
            Console.WriteLine($"doi tuong uu tien:{UuTien}");
        }
    }
}
