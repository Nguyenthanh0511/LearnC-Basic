using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class CanBo
    {
        public string hoTen { get; set; }
        public int namSinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public CanBo() { }
        public CanBo(string hoTen, int namSinh, string gioiTinh, string diaChi)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
        }
        public virtual void Input()
        {
            Console.WriteLine("Nhap ho ten : ");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gioi tinh: ");
            gioiTinh = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            diaChi = Console.ReadLine();

        }
        public virtual void Output()
        {
            Console.WriteLine($"Ho ten: {hoTen}");
            Console.WriteLine($"Nam sinh: {namSinh}");
            Console.WriteLine($"Gioi tinh: {gioiTinh}");
            Console.WriteLine($"Dia chi: {diaChi}");
        }
    }
}
