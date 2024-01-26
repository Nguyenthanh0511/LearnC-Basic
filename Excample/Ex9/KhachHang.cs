using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
     class KhachHang
    {
        public string HoTenChuHo { get; set; }
        public string SoNha { get; set; }
        public string MaSoCongTo { get; set; }

        public void Input()
        {
            Console.Write("Nhap Ho Ten Chu Ho: ");
            HoTenChuHo = Console.ReadLine();
            Console.Write("Nhap So Nha: ");
            SoNha = Console.ReadLine();
            Console.Write("Nhap Ma So Cong To: ");
            MaSoCongTo = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine($"Ho Ten Chu Ho: {HoTenChuHo}");
            Console.WriteLine($"So Nha: {SoNha}");
            Console.WriteLine($"Ma So Cong To: {MaSoCongTo}");
        }
    }
}
