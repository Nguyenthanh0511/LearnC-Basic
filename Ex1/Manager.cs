using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
     class Manager
    {
        private List<CanBo> danhsa = new List<CanBo>();
        public void Input()
        {
            Console.WriteLine("1. Cong nhan | 2. Ky su | 3. Nhan vien");
            Console.Write("Chọn can bo so: ");
            int choice = int.Parse(Console.ReadLine());
            CanBo canBo = null;
            switch (choice)
            {
                case 1:
                    canBo = new CongNhan();
                    break;
                case 2:
                    canBo = new KySu();
                    break;
                case 3:
                    canBo = new NhanVien();
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    return;
            }
            canBo.Input();
            danhsa.Add(canBo);
            Console.WriteLine("Them can bo thanh cong!");
        }
        public void Output()
        {
            foreach (var canBo in danhsa)
            {
                canBo.Output();
                Console.WriteLine("---------------");
            }
        }

        public void SearchName()
        {
            Console.Write("Nhap ho ten can tim kiem: ");
            string hoTenTimKiem = Console.ReadLine();

            foreach (var canBo in danhsa)
            {
                if (canBo.hoTen.ToLower().Contains(hoTenTimKiem.ToLower()))
                {
                    canBo.Input();
                }
            }
        }
    }
}
