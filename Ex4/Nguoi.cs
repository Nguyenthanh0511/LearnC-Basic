using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4_QuanLyHoDanCu
{
    public class Nguoi : IQuanLyThongTin
    {
        private int cccd { get; set; }
        private string hoTen { get; set; }
        private int namSinh { get; set; }
        private string ngheNghiep { get; set; }
        public Nguoi()
        {

        }

        public Nguoi(int cccd, string hoTen, int namSinh, string ngheNghiep)
        {
            this.cccd = cccd;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.ngheNghiep = ngheNghiep;
        }
        public string getHoTen()
        {
            return hoTen;
        }
        
        public void Input()
        {
            Console.Write("Nhap so CMND: ");
            cccd = int.Parse(Console.ReadLine());

            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());

            Console.Write("Nhap nghe nghiep: ");
            ngheNghiep = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine($"So CMND: {cccd}");
            Console.WriteLine($"Ho ten: {hoTen}");
            Console.WriteLine($"Tuoi: {namSinh}");
            Console.WriteLine($"Nghe nghiep: {ngheNghiep}");
        }
    
    }
}
