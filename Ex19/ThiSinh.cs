using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2s19
{
    public class HoTen
    {
        public string Ho;
        public string TenDem;
        public string Ten;
    }
    public class QueQuan
    {
        public string Xa;
        public string Huyen;
        public string Tinh;
    }
    public class DiemThi
    {
        public double DiemToan;
        public double DiemLy;
        public double DiemHoa;
    }
    internal class ThiSinh
    {
        public int Tuoi { get; set; }
        public string SoBaoDanh { get; set; }
        public string Truong { get; set; }
        public HoTen HoTen { get; set; }
        public QueQuan QueQuan { get; set; }
        public DiemThi DiemThi { get; set; }

        public void InThongTin()
        {
            Console.WriteLine($"ho ten:{HoTen}");
            Console.WriteLine($"que quan:{QueQuan}");
            Console.WriteLine($"truong:{Truong}");
            Console.WriteLine($"tuoi:{Tuoi}");
            Console.WriteLine($"so bao danh:{SoBaoDanh}");
            Console.WriteLine($"diem thi:{DiemThi}");
        }
    }
}
