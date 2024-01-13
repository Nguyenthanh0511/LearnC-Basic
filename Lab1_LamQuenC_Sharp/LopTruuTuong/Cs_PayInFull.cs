using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopTruuTuong
{
     class Cs_PayInFull:Customer
    {
        public Cs_PayInFull() { }
        public Cs_PayInFull(string maKH, string hoTen) : base(maKH, hoTen) { }
        public override int TinhCuoc()
        {
            return 300000;
        }
    }
}
