using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
     class CongNhan:CanBo
    {
        private int bac;

        public int Bac
        {
            get { return bac; }
            set
            {
                
                if (value >= 3 || value <= 7)
                {
                    bac = value;
                }
                else
                {
                    Console.WriteLine("Gia tri cua Bac khong hop le. Bac se duoc dat mac dinh la 3.");
                    bac = 3;
                }
            }
        }
        public CongNhan() { }
        public CongNhan(string hoTen, int namSinh, string gioiTinh, string diaChi,string bac): base( hoTen,  namSinh,  gioiTinh, diaChi)
        {
            this.Bac = Bac;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap bac cong nhan (tu 3 den 7): ");
            Bac = int.Parse(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Bac cong nhan: {Bac}");
        }
    }
}
