using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excample15
{
    internal class DaGiac
    {
        public int soCanh {  get; private set; }
        public List<double> kichThuocCanh;

        public DaGiac()
        {
            this.kichThuocCanh = new List<double>();
        }
        public DaGiac(int soCanh, List<double> kichThuocCanh)
        {
            this.soCanh = soCanh;
            this.kichThuocCanh = kichThuocCanh;
        }

        public double TinhChuVi() {
            return kichThuocCanh.Sum();
        }

        public void HienThi()
        {
            int index = 1;
            foreach (double k in kichThuocCanh)
            {
                Console.WriteLine("Canh " + index + ": " + k);
                index++;
            }
        }
    }
}
