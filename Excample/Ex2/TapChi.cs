using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
     class TapChi: TaiLieu
    {
        public int SoPhatHanh { get; set; }
        public int ThangPhatHanh { get; set; }
        public TapChi() { }
        public TapChi(string maTaiLieu, string nhaXuatBan, int soBanPhatHanh, int SoPhatHanh, int ThangPhatHanh): base( maTaiLieu,  nhaXuatBan,  soBanPhatHanh) {
            this.SoPhatHanh = SoPhatHanh;
            this.ThangPhatHanh = ThangPhatHanh;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap so phat hanh: ");
            SoPhatHanh = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thang phat hanh: ");
            ThangPhatHanh = int.Parse(Console.ReadLine());

        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"So phat hanh: {SoPhatHanh}");
            Console.WriteLine($"Thang phat hanh: {ThangPhatHanh}");
        }
    }
}
