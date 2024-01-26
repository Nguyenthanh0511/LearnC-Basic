using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
     class VanBan
    {
        private string noiDung;

        // Hàm tạo không có đối số
        public VanBan()
        {
            noiDung = "";
        }

        // Hàm tạo có đối số
        public VanBan(string st)
        {
            noiDung = st;
        }

        // Phương thức đếm số từ của một xâu
        public int DemSoTu()
        {
            string[] tuArray = noiDung.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return tuArray.Length;
        }

        // Phương thức đếm số ký tự H (không phân biệt chữ thường, chữ hoa)
        public int DemSoKyTuH()
        {
            int dem = 0;
            foreach (char kyTu in noiDung)
            {
                if (char.ToUpper(kyTu) == 'H')
                {
                    dem++;
                }
            }
            return dem;
        }

        // Chuẩn hoá một xâu theo tiêu chuẩn
        public string ChuanHoaXau()
        {
            return noiDung.Trim();
        }

    }
}
