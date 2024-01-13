using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopTruuTuong
{
    public abstract class Customer
    {
        protected string maKH;
        protected string hoTen;
        public string HoTen
        {
            get { return hoTen;  }
        }
        public Customer() { }
        public Customer(string maKH, string hoTen)
        {
            this.maKH = maKH;
            this.hoTen = hoTen;
        }
        public abstract int TinhCuoc();
    }
}
