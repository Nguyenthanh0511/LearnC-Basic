using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excample14
{
    internal class PhanSo
    {
        public int tuSo {  get; private set; }
        public int mauSo { get; private set; }

        public PhanSo() { }

        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }

        public void NhapPhanSo()
        {
            Console.Write("Nhap tu so: ");
            this.tuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            this.mauSo = int.Parse(Console.ReadLine());
        }

        public void HienPhanSo()
        {
            Console.WriteLine(this.tuSo);
            Console.WriteLine("--------");
            Console.WriteLine(this.mauSo);
        }

        static int FindUCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        static int FindBCNN(int a, int b)
        {
            return Math.Abs(a * b) / FindUCLN(a, b);
        }

        public void RutGon()
        {
            int ucln = FindUCLN(this.tuSo, this.mauSo);
            this.tuSo /= ucln;
            this.mauSo /= ucln;
            HienPhanSo();
        }

        public static PhanSo CongPhanSo(PhanSo phanSo1, PhanSo phanSo2)
        {
            int bcnn = FindBCNN(phanSo1.mauSo, phanSo2.mauSo);
            PhanSo result = new PhanSo((phanSo1.tuSo + phanSo2.tuSo), bcnn);
            return result;
        }

        public static PhanSo TruPhanSo(PhanSo phanSo1, PhanSo phanSo2)
        {
            int bcnn = FindBCNN(phanSo1.mauSo, phanSo2.mauSo);
            PhanSo result = new PhanSo((phanSo1.tuSo - phanSo2.tuSo), bcnn);
            return result;
        }

        public static PhanSo NhanPhanSo(PhanSo phanSo1, PhanSo phanSo2)
        {
            PhanSo result = new PhanSo((phanSo1.tuSo * phanSo2.tuSo), (phanSo1.mauSo * phanSo2.mauSo));
            return result;
        }

        public static PhanSo ChiaPhanSo(PhanSo phanSo1, PhanSo phanSo2)
        {
            PhanSo ps2Temp = new PhanSo(phanSo2.mauSo, phanSo2.tuSo);
            PhanSo result = NhanPhanSo(phanSo1, ps2Temp);
            return result;
        }
    }
}
