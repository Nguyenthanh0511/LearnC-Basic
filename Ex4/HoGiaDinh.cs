using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4_QuanLyHoDanCu
{
    class HoGiaDinh : IQuanLyThongTin
    {
        public int SoThanhVien { get; set; }
        public int soNha { get; set; }
        public List<Nguoi> DanhSachNguoi { get; } = new List<Nguoi>();

        public HoGiaDinh()
        {

        }
        public HoGiaDinh(int soThanhVien,int soNha , List<Nguoi> danhSachNguoi)
        {
            this.SoThanhVien = soThanhVien;
            this.soNha = soNha;
            this.DanhSachNguoi = danhSachNguoi;
        }
        public int getSoNha()
        {
            return soNha;
        }
        public void Input()
        {
            Console.WriteLine("Nhap so luong ho gia dinh");
            soNha = int.Parse(Console.ReadLine());

            for (int i = 0; i < soNha; i++)
            {
                Nguoi hoGiaDinh = new Nguoi();
                hoGiaDinh.Input();
                DanhSachNguoi.Add(hoGiaDinh);
            }
        }
        public void Output()
        {
            Console.WriteLine($"So thanh vien trong ho: {SoThanhVien}");
            Console.WriteLine($"So nha: {soNha}");
            Console.WriteLine("Danh sach nguoi trong ho:");
            foreach (var h in DanhSachNguoi)
            {
                h.Output();
                Console.WriteLine("===========================");
            }
        }



    }
}
