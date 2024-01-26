using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
     class Bao: TaiLieu
    {
        public int NgayPhatHanh { get; set; }   
        public Bao() { }
        public Bao(string maTaiLieu, string nhaXuatBan, int soBanPhatHanh, int NgayPhatHanh ): base( maTaiLieu,  nhaXuatBan,  soBanPhatHanh) { 
            this.NgayPhatHanh = NgayPhatHanh;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap ngay phat hanh: ");
            NgayPhatHanh = int.Parse( Console.ReadLine() );
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Ngay phat hanh: {NgayPhatHanh}");
        }
    }
}
