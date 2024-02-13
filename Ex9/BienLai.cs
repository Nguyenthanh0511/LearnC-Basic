using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9
{
     class BienLai
    {
        public KhachHang HoSuDung { get; set; }
        public int ChiSoCu { get; set; }
        public int ChiSoMoi { get; set; }
        public double SoTienPhaiTra { get; set; }
        public void Input()
        {
            HoSuDung = new KhachHang();
            HoSuDung.Input();
            Console.WriteLine("Nhap cho so cu: ");
            ChiSoCu = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chi so moi: ");
            ChiSoMoi = int.Parse(Console.ReadLine());
            TinhTienDien();
        }
        public void Output()
        {
            HoSuDung.Output();
            Console.WriteLine($"Chi So Cu: {ChiSoCu}");
            Console.WriteLine($"Chi So Moi: {ChiSoMoi}");
            Console.WriteLine($"So Tien Phai Tra: {SoTienPhaiTra} VND");
        }
        public void TinhTienDien()
        {
            int soDienSD = ChiSoMoi - ChiSoCu;
            if(soDienSD < 50)
            {
                SoTienPhaiTra = soDienSD * 1250;
            }
            else if(soDienSD < 100)
            {
                SoTienPhaiTra = 50*1250+(soDienSD-50)*1500;
            }
            else
            {
                SoTienPhaiTra = 50 * 1250 + 50 * 1500 + (soDienSD - 100) * 2000;
            }
        }
    }
}
