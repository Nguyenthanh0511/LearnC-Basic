using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
     class Manager
    {
        private List<TaiLieu> danhSachTaiLieu = new List<TaiLieu>();

        public void Input()
        {
            Console.WriteLine("1. Sach | 2. Tap Chi | 3. Bao");
            Console.Write("Chon loai tai lieu (1-3): ");
            int loaiTaiLieu = int.Parse(Console.ReadLine());

            TaiLieu taiLieu = null;

            switch (loaiTaiLieu)
            {
                case 1:
                    taiLieu = new Sach();
                    break;
                case 2:
                    taiLieu = new TapChi();
                    break;
                case 3:
                    taiLieu = new Bao();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le.");
                    return;
            }

            taiLieu.Input();
            danhSachTaiLieu.Add(taiLieu);
            Console.WriteLine("Them tai lieu thanh cong!");
        }

        public void Output()
        {
            foreach (var taiLieu in danhSachTaiLieu)
            {
                taiLieu.Output();
                Console.WriteLine("---------------");
            }
        }

        public void Search()
        {
            Console.WriteLine("1. Sach | 2. Tap Chi | 3. Bao");
            Console.Write("Chon loai tai lieu can tim kiem (1-3): ");
            int loaiTaiLieu = int.Parse(Console.ReadLine());

            foreach (var taiLieu in danhSachTaiLieu)
            {
                if (loaiTaiLieu == 1 && taiLieu is Sach)
                {
                    taiLieu.Output();
                    Console.WriteLine("---------------");
                }
                else if (loaiTaiLieu == 2 && taiLieu is TapChi)
                {
                    taiLieu.Output();
                    Console.WriteLine("---------------");
                }
                else if (loaiTaiLieu == 3 && taiLieu is Bao)
                {
                    taiLieu.Output();
                    Console.WriteLine("---------------");
                }
            }
        }
    }
}
