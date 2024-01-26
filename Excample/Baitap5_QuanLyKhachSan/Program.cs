using System;
using Baitap5_QuanLyKhachSan.Interface;

namespace Baitap5_QuanLyKhachSan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tạo đối tượng KhachSan
            IKhachSan khachSan = new KhachSan();

            // Gọi các phương thức của KhachSan
            khachSan.Input();
            khachSan.Output();
            khachSan.TimKiem();

            // Tạo đối tượng Nguoi
            INguoi nguoi = new Nguoi();

            // Gọi các phương thức của Nguoi
            nguoi.Input();
            nguoi.Output();
        }
    }
}
