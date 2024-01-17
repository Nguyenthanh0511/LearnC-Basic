using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excample16
{
    internal class Diem
    {
        public double hoanhDo { get; private set; }
        public double tungDo { get; private set; }

        public Diem() { }
        public Diem(double hoanhDo, double tungDo)
        {
            this.hoanhDo = hoanhDo;
            this.tungDo = tungDo;
        }

        public void NhapDiem()
        {
            Console.Write("Nhap Hoang Do: ");
            this.hoanhDo = double.Parse(Console.ReadLine());
            Console.Write("Nhap Tung Do: ");
            this.tungDo= double.Parse(Console.ReadLine());
        }

        public void HienThi()
        {
            Console.WriteLine("Hoanh Do: " + hoanhDo);
            Console.WriteLine("Tung Do: " + tungDo);
        }

        public static double TinhKhoangCanh(Diem diem1, Diem diem2)
        {
            return Math.Sqrt(Math.Pow(diem2.hoanhDo - diem1.hoanhDo, 2) + Math.Pow(diem2.tungDo - diem1.tungDo, 2));
        }
    }
}
