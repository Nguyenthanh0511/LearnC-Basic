using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8
{
     class TheMuon
    {
        public int SoPhieuMuon { get; set; }
        public DateTime NgayMuon { get; set; }   
        public DateTime HanTra { get; set; }
        public int SoHieuSach { get; set; }
        public SinhVien SinhVienMuon { get; set; }
        public TheMuon()
        {
            SinhVienMuon = new SinhVien();
        }
        public TheMuon(int SoPhieuMuon, DateTime NgayMuon, DateTime HanTra, int SoHieuSach)
        {
            this.SoPhieuMuon = SoPhieuMuon;
            this.NgayMuon = NgayMuon;
            this.HanTra = HanTra;
            this.SoHieuSach = SoHieuSach;

        }
        public  void Input()
        {
            Console.WriteLine("Nhap so phieu muon: ");
            SoPhieuMuon = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ngay muon (yyyy/MM/dd): ");
            NgayMuon = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ngay tra (yyyy/MM/dd): ");
            HanTra = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap So hieu sach: ");
            SoHieuSach = int.Parse(Console.ReadLine());
            SinhVienMuon.Input();
        }
        public  void Output()
        {
            Console.WriteLine($"So phieu muon: {SoPhieuMuon}");
            Console.WriteLine($"Ngay muon: {NgayMuon}");
            Console.WriteLine($"Ngay tra: {HanTra}");
            Console.WriteLine($"So hieu sach: {SoHieuSach}");
            SinhVienMuon.Output();
        }
        public bool DaDenHanTra()
        {
            return DateTime.Now > HanTra;
        }
    }
}
