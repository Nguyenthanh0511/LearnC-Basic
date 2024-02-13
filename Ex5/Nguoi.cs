using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap5_QuanLyKhachSan
{
    class Nguoi : INguoi
    {
        private string hoTen;
        private int namSinh;
        private int cccd;
        public Nguoi()
        {

        }
        public Nguoi(string name , int ns , int chungMinh)
        {
            this.hoTen = name;
            this.namSinh = ns;
            this.cccd = chungMinh; 
        }
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        public int NamSinh
        {
            get { return namSinh;}
            set { namSinh = value; }   
        }
        public int SoChungMinh
        {
            get { return cccd; }
            set { cccd = value; }
        }
        

        public void Input()
        {
            Console.Write("Nhap so CMND: ");
            cccd = int.Parse(Console.ReadLine());

            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());

        }
        public void Output()
        {
            Console.WriteLine($"So CMND: {cccd}");
            Console.WriteLine($"Ho ten: {hoTen}");
            Console.WriteLine($"Tuoi: {namSinh}");
        }
         
    }
}
