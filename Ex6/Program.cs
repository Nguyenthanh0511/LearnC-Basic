using System;
using System.Collections.Generic;
namespace Baitap6
{

    abstract class Nguoi
    {
        public string hoTen;
        public int tuoi;
        public int namSinh;
        public string queQuan;
        public string gioiTinh;

        public abstract void NhapThongTin();
        public abstract void HienThiThongTin();
    }

    class HSHocSinh : Nguoi
    {
        private string lop;
        private int khoaHoc;
        private int kyHoc;

        public HSHocSinh()
        {
            base.hoTen = "";
            base.tuoi = 0;
            base.namSinh = 0;
            base.queQuan = "";
            base.gioiTinh = "";
            lop = "";
            khoaHoc = 0;
            kyHoc = 0;
        }

        public override void NhapThongTin()
        {
            Console.Write("Nhập họ và tên: ");
            hoTen = Console.ReadLine();
            // Nhập các thông tin khác
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine("Thông tin học sinh:");
            Console.WriteLine("Họ và tên: " + hoTen);
            // Hiển thị các thông tin khác
        }
    }

    class QuanLyHocSinh
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số lượng học sinh: ");
            int n = int.Parse(Console.ReadLine());
            List<HSHocSinh> danhSachHocSinh = new List<HSHocSinh>();

            for (int i = 0; i < n; i++)
            {
                HSHocSinh hocSinh = new HSHocSinh();
                hocSinh.NhapThongTin();
                danhSachHocSinh.Add(hocSinh);
            }

            Console.WriteLine("Danh sách học sinh nữ và sinh năm 1985:");
            foreach (HSHocSinh hocSinh in danhSachHocSinh)
            {
                if (hocSinh.gioiTinh.Equals("nữ", StringComparison.OrdinalIgnoreCase) && hocSinh.namSinh == 1985)
                {
                    hocSinh.HienThiThongTin();
                }
            }

            Console.Write("Nhập quê quán cần tìm kiếm: ");
            string queQuanCanTim = Console.ReadLine();
            Console.WriteLine("Danh sách học sinh từ " + queQuanCanTim + ":");
            foreach (HSHocSinh hocSinh in danhSachHocSinh)
            {
                if (hocSinh.queQuan.Equals(queQuanCanTim, StringComparison.OrdinalIgnoreCase))
                {
                    hocSinh.HienThiThongTin();
                }
            }
        }
    }

}