using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2s18
{
    internal class CoQuan:Nguoi
    {
        public string DonViCT { get; set; }
        public double HeSoLuong { get; set; }
        public CoQuan() { }

        public CoQuan(string BoMon, string Phong, double HeSoLuong)
        {
            this.DonViCT = DonViCT;
            this.HeSoLuong = HeSoLuong;
        }

        public override void In()
        {
            base.In();
            Console.WriteLine($"don vi cong tac:{DonViCT}");
            Console.WriteLine($"he so luong:{HeSoLuong}");
        }
        public double TinhLuong()
        {
            const double luongcoban = 1050000;
            return HeSoLuong * luongcoban; 
        }
    }
}
