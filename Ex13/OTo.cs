using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excample13
{
    internal class OTo : PhuongTien
    {
        public int soCho { get; set; }
        public string kieuDongCo { get; set; }

        public OTo() : base() {}
        public OTo(string hangSanXuat, int namSanXuat, double giaBan, string mauSac, int soCho, string kieuDongCo) : base(hangSanXuat, namSanXuat, giaBan, mauSac)
        {
            this.soCho = soCho;
            this.kieuDongCo = kieuDongCo;
        }

        public void NhapDangKy()
        {
            base.NhapDangKy();
            Console.Write("Nhap so cho: ");
            this.soCho = int.Parse(Console.ReadLine());
            Console.Write("Nhap kieu dong co: ");
            this.kieuDongCo = Console.ReadLine();
        }
    }
}
