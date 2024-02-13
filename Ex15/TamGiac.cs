using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excample15
{
    internal class TamGiac : DaGiac
    {
        public TamGiac() : base() { }

        public TamGiac(int soCanh, List<double> kichThuocCanh) : base(soCanh, kichThuocCanh) { }

        public double TinhChuVi()
        {
            return this.kichThuocCanh.Sum();
        }

        public double TinhDienTich()
        {   
            double ncv = TinhChuVi() / 2;
            return Math.Sqrt((ncv * (ncv - this.kichThuocCanh[0]) * (ncv - this.kichThuocCanh[1]) * (ncv - this.kichThuocCanh[2])));
        }
    }
}
