using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excample13
{
    internal class XeTai : PhuongTien
    {
        public double trongTai { get; private set; }

        public XeTai() : base() { }

        public XeTai(string hangSanXuat, int namSanXuat, double giaBan, string mauSac, double trongTai) : base(hangSanXuat, namSanXuat, giaBan, mauSac)
        {
            this.trongTai = trongTai;
        }

        public void NhapDangKy()
        {
            base.NhapDangKy();
            Console.Write("Nhap trong tai: ");
            this.trongTai = double.Parse(Console.ReadLine());
        }
    }
}
