using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
     class NhanVien: CanBo
    {
        public string CongViec { get; set; }
        public NhanVien() { }
        public NhanVien(string hoTen, int namSinh, string gioiTinh, string diaChi, string congViec):base ( hoTen,  namSinh,  gioiTinh,  diaChi) {
            this.CongViec = CongViec;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap bac cong viec: ");
            CongViec = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Cong viec: {CongViec}");
        }
    }
}
