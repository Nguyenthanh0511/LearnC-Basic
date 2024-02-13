using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
     class KySu:CanBo
    {
        public string NganhDaoTao { get; set; }
        public KySu() { }
        public KySu (string hoTen, int namSinh, string gioiTinh, string diaChi, string NganhDaoTao): base( hoTen,  namSinh,  gioiTinh, diaChi)
        {
            this.NganhDaoTao = NganhDaoTao;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap nganh dao tao: ");
            NganhDaoTao = Console.ReadLine();
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($" Nganh dao tao: {NganhDaoTao}");
        }
    }
}
