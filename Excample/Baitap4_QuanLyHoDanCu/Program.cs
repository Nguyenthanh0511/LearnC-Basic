using System;
namespace Baitap4_QuanLyHoDanCu
{
    class Program
    {
        static void Main(string[] args)
        {
            KhuPho khuPho = new KhuPho();
            int luaChon;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Nhap thong tin ho dan");
                Console.WriteLine("2. Tim kiem thong tin ho dan");
                Console.WriteLine("3. Hien thi thong tin toan bo");
                Console.WriteLine("4. Thoat");
                luaChon = int.Parse(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        khuPho.Input();
                        break;
                    case 2:
                        Console.WriteLine("Tim kiem ten Nguyen Trung Thanh");
                        khuPho.TimKiem("Nguyen Trung Thanh");
                        break;
                    case 3:
                        khuPho.Output(); break;
                    case 4:
                        Console.WriteLine("Lua chon khong hop le.");
                        break;


                }
            } while (luaChon!=5);
        }
    }
}