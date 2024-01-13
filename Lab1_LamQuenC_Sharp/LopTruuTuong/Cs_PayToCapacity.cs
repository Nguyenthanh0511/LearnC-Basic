using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopTruuTuong
{
     class Cs_PayToCapacity:Customer
    {
        private int dungLuong;
        public Cs_PayToCapacity() { }

        public Cs_PayToCapacity(string maKH, string hoTen) : base(maKH, hoTen)
        {
        }

        public Cs_PayToCapacity(string maKH, string hoTen,int dungLuong):base( maKH, hoTen)
        {
            this.dungLuong = dungLuong;
        }
        public override int TinhCuoc()
        {
            return dungLuong * 200000;
        }
    }
}
