using Baitap5_QuanLyKhachSan.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap5_QuanLyKhachSan
{
    class KhachSan : IKhachSan
    {
        private int soNgayTro;
        private string loaiTro;
        private double giaPhong;
        private List<Nguoi> listNguoi = new List<Nguoi>();
        public KhachSan() { }
        public KhachSan(int so, string loai, double gia)
        {
            this.giaPhong = gia;
            this.soNgayTro = so;
            this.loaiTro = loai;
        }
        public string getLoaiTro
        {
            get { return loaiTro; }
            set { loaiTro = value; }
        }
        public void Input()
        {
            Console.Write("Nhap so ngay: ");
            soNgayTro = int.Parse(Console.ReadLine());

            Console.Write("Nhap ho ten: ");
            loaiTro = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            giaPhong = double.Parse(Console.ReadLine());
            Console.Write("Nhap thong tin nguoi: ");
            Nguoi nguoi = new Nguoi();
            listNguoi.Add(nguoi);
        }
        public void Output()
        {
            Console.WriteLine($"So ngay: {soNgayTro}");
            Console.WriteLine($"Ten loai phong: {loaiTro}");
            Console.WriteLine($"Tuoi: {giaPhong}");
            foreach(Nguoi nguoi in listNguoi)
            {
                nguoi.Output();
            }
        }
        public void TimKiem()
        {
            Console.WriteLine("Nhap ten tim kiem");
            string ten = Console.ReadLine();
            foreach (var nguoi in listNguoi)
            {
                if (nguoi.HoTen == ten)
                {
                    nguoi.Output();
                    break;
                }
            }
            Console.WriteLine("Khong tim thay ten");
        }
    }
}
