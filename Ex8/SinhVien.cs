using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
     class SinhVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string lop { get; set; }
        public string MaSoSV { get; set; }
        public SinhVien() { }
        public SinhVien(string hoTen, int namSinh, string lop, string maSoSV)
        {
            HoTen = hoTen;
            NamSinh = namSinh;
            this.lop = lop;
            MaSoSV = maSoSV;
        }
        public virtual void Input()
        {
            Console.WriteLine("Nhap ho ten sinh vien: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap lop : ");
            lop = Console.ReadLine();
            Console.WriteLine("Nhap ma so sinh vien: ");
            MaSoSV= Console.ReadLine();

        }
        public virtual void Output() { 
            Console.WriteLine($"Ho ten : {HoTen}");
            Console.WriteLine($"Nam sinh: {NamSinh}");
            Console.WriteLine($"Lop: {lop}");
            Console.WriteLine($"Ma so sinh vien: {MaSoSV}");
        }
    }
}
