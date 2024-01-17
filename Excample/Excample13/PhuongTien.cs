using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excample13
{
    internal class PhuongTien
    {
        public string hangSanXuat { get; set; }
        public int namSanXuat { get; set; }
        public double giaBan { get; set; }
        public string mauSac { get; set; }

        public PhuongTien() { }
        public PhuongTien(string hangSanXuat, int namSanXuat, double giaBan, string mauSac) { 
            this.hangSanXuat = hangSanXuat;
            this.namSanXuat = namSanXuat;
            this.giaBan = giaBan;
            this.mauSac = mauSac;
        }

        public void NhapDangKy()
        {
            Console.Write("Nhap hang san xuat: ");
            this.hangSanXuat = Console.ReadLine();
            Console.Write("Nhap nam san suat: ");
            this.namSanXuat = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia ban: ");
            this.giaBan = double.Parse(Console.ReadLine());
            Console.Write("Nhap mau sac: ");
            this.mauSac = Console.ReadLine();
        }
    }
}
