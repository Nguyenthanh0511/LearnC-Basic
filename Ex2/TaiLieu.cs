using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
     class TaiLieu
    {
        public string MaTaiLieu { get; set; }
        public string NhaXuatBan { get; set; }
        public int SoBanPhatHanh { get; set; }
        public TaiLieu() { }
        public TaiLieu(string maTaiLieu, string nhaXuatBan, int soBanPhatHanh)
        {
            MaTaiLieu = maTaiLieu;
            NhaXuatBan = nhaXuatBan;
            SoBanPhatHanh = soBanPhatHanh;
        }
        public virtual void Input()
        {
            Console.WriteLine("Nhap ma tai lieu: ");
            MaTaiLieu = Console.ReadLine();
            Console.WriteLine("Nhap nha xuat ban: ");
            NhaXuatBan = Console.ReadLine();
            Console.WriteLine("Nhap so ban phat hanh: ");
            SoBanPhatHanh = int.Parse(Console.ReadLine());
        }
        public virtual void Output()
        {
            Console.WriteLine($"Ma tai lieu: {MaTaiLieu}");
            Console.WriteLine($" Nha xuat ban: {NhaXuatBan}");
            Console.WriteLine($"So ban phat hanh: {SoBanPhatHanh}");
        }
    }
}
