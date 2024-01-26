using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap5_QuanLyKhachSan.Interface
{
    interface IKhachSan
    {
       public string getLoaiTro { get; set; }
        public void Input();
        public void Output();
        public void TimKiem();

    }
}
