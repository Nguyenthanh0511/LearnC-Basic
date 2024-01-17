using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excample13
{
    internal class XeMay : PhuongTien
    {
        public double congSuat { get; private set; }

        public XeMay() : base() { }
        public XeMay(string hangSanXuat, int namSanXuat, double giaBan, string mauSac, double congSuat) : base(hangSanXuat, namSanXuat, giaBan, mauSac)
        {
            this.congSuat = congSuat;
        }

        public void NhapDangKy()
        {
            base.NhapDangKy();
            Console.Write("Nhap cong xuat: ");
            this.congSuat = double.Parse(Console.ReadLine());
        }
    }
}
