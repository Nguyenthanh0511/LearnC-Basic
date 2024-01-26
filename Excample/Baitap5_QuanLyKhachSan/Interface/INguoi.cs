using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap5_QuanLyKhachSan
{
    interface INguoi
    {
        string HoTen { get; set; }
        int NamSinh { get; set; }
        int SoChungMinh { get;  set; }
        void Input();
        void Output();

    }
}
