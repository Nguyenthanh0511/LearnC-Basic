using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2s18
{
    internal class Nguoi
    {
        public string HoTen { get; set; }
        public bool GioiTinh { get; set; }
        public int Tuoi { get; set; }

        public Nguoi()
        {

        }
        public Nguoi(string HoTen, bool GioiTinh, int Tuoi)
        {
            this.HoTen = HoTen;
            this.GioiTinh = GioiTinh;
            this.Tuoi = Tuoi;
        }

        public virtual void In()
        {
            Console.WriteLine($"ho ten:{HoTen}");
            Console.WriteLine($"gioi tinh:{GioiTinh}");
            Console.WriteLine($"tuoi:{Tuoi}");
        }

    }
}
