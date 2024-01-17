using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excample16
{
    internal class TamGiac
    {
        public Diem diem1 { get; private set; }
        public Diem diem2 { get; private set; }
        public Diem diem3 { get; private set; }

        public TamGiac() { }
        public TamGiac(Diem diem1, Diem diem2, Diem diem3)
        {
            this.diem1 = diem1;
            this.diem2 = diem2;
            this.diem3 = diem3;
        }

        public double TinhChuVi()
        {
            return Diem.TinhKhoangCanh(diem1, diem2) + Diem.TinhKhoangCanh(diem3, diem2) + Diem.TinhKhoangCanh(diem1, diem3);
        }

        public double TinhDienTich()
        {
            return 0.5 * Math.Abs((diem2.hoanhDo - diem1.hoanhDo) * (diem3.tungDo - diem1.tungDo) - (diem3.hoanhDo - diem1.hoanhDo) * (diem2.tungDo - diem1.tungDo));
        }
    }
}
