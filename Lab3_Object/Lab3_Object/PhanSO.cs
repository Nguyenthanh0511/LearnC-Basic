using System;

namespace Bai1_PhanSO
{
    public class PhanSO
    {
        private int tuSO;
        private int mauSo;

        public PhanSO()
        {
            // Default constructor
        }

        public PhanSO(int tuSo, int mauSo)
        {
            this.tuSO = tuSo;
            this.mauSo = mauSo != 0 ? mauSo : 1;
        }

        public static PhanSO operator +(PhanSO ps1, PhanSO ps2)
        {
            int tu = ps1.tuSO * ps2.mauSo + ps2.tuSO * ps1.mauSo;
            int mau = ps1.mauSo * ps2.mauSo;
            return new PhanSO(tu, mau);
        }

        public static PhanSO operator -(PhanSO ps1, PhanSO ps2)
        {
            int tu = ps1.tuSO * ps2.mauSo - ps2.tuSO * ps1.mauSo;
            int mau = ps1.mauSo * ps2.mauSo;
            return new PhanSO(tu, mau);
        }

        public static PhanSO operator *(PhanSO ps1, PhanSO ps2)
        {
            int tu = ps1.tuSO * ps2.tuSO;
            int mau = ps1.mauSo * ps2.mauSo;
            return new PhanSO(tu, mau);
        }

        public static PhanSO operator /(PhanSO ps1, PhanSO ps2)
        {
            int tu = ps1.tuSO * ps2.mauSo;
            int mau = ps1.mauSo * ps2.tuSO;
            return new PhanSO(tu, mau);
        }

        private int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }

        public bool LaToiGian()
        {
            int ucln = UCLN(tuSO, mauSo);
            return ucln == 1;
        }

        public void InPhanSO()
        {
            Console.WriteLine($"{tuSO}/{mauSo}");
        }
    }
}
