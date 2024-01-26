using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4_QuanLyHoDanCu
{
    internal class KhuPho : IQuanLyThongTin
    {
        
        private int soLuong { get; set; }
        private List<HoGiaDinh> listHoGiaDinhs { get; } = new List<HoGiaDinh>();

        public KhuPho() { }
        public KhuPho(int soThanhVien, int soLuong, List<HoGiaDinh> listHoGiaDinhs)
        {
            this.soLuong = soLuong;
            this.listHoGiaDinhs = listHoGiaDinhs;
        }

        public void Input()
        {
            Console.WriteLine("Nhap so luong ho gia dinh");
            soLuong = int.Parse(Console.ReadLine());
            for (int i = 0; i < soLuong; i++)
            {
                HoGiaDinh hoGiaDinh = new HoGiaDinh();
                hoGiaDinh.Input();
                listHoGiaDinhs.Add(hoGiaDinh);
            }
        }
        public void Output()
        {
            Console.WriteLine("THong tin toan bo ho gia dinh:");
            foreach(var h in listHoGiaDinhs)
            {
                h.Output();
                Console.WriteLine("===========================");
            }
        }

        public void TimKiem(string ten)
        {
            Console.WriteLine("Nhap ten muon tim kiem");
            ten = Console.ReadLine();
            foreach(var hoGiaDinh in listHoGiaDinhs)
            {
                foreach(var nguoi in hoGiaDinh.DanhSachNguoi)
                {
                    if(nguoi.getHoTen().Contains(ten) || hoGiaDinh.getSoNha().ToString() == ten)
                    {
                        hoGiaDinh.Output();
                        break;
                    }
                }
            }
        }


    }
}
