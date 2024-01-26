using System.Runtime.CompilerServices;

namespace BaiTap2s21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HocSinh> dsHocSinh = new List<HocSinh>();

            Console.WriteLine("Nhap so hoc sinh:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap thong tin cho hoc sinh thu {i + 1}:");

                Console.Write("ho ten:");
                string HoTen = Console.ReadLine();
                Console.Write("gioi tinh:");
                string GioiTinh = Console.ReadLine();
                Console.Write("diem toan:");
                double DiemToan = double.Parse(Console.ReadLine());
                Console.Write("diem ly:");
                double DiemLy = double.Parse(Console.ReadLine());
                Console.Write("diem hoa:");
                double DiemHoa = double.Parse(Console.ReadLine());

                if(GioiTinh.ToLower() == "Nam")
                {
                    Console.WriteLine("Nhap diem ki thuat:");
                    double DiemKiThuat = double.Parse(Console.ReadLine());

                    dsHocSinh.Add(new HocSinhNam(HoTen, GioiTinh, DiemToan, DiemLy, DiemHoa, DiemKiThuat));
                }
                else if(GioiTinh.ToLower() == "Nu")
                {
                    Console.WriteLine("Nhap diem vu cong:");
                    double DiemVuCong = double.Parse(Console.ReadLine());

                    dsHocSinh.Add(new HocSinhNu(HoTen, GioiTinh, DiemToan, DiemLy, DiemHoa, DiemVuCong));
                }
            }
            Console.WriteLine("Thong tin ve nam hoc sinh co diem ki thuat nho hon 8:");
            foreach(var hocSinh in dsHocSinh)
            {
                if(hocSinh is HocSinhNam && ((HocSinhNam)hocSinh).DiemKiThuat < 8)
                {
                    hocSinh.XuatThongTin();
                }
            }
            //thông tin học sinh nam trước học sinh nữ
            Console.WriteLine("Thong tin hoc sinh nam truoc hoc sinh nu:");
            foreach(var hocSinh in dsHocSinh)
            {
                hocSinh.XuatThongTin();
            }
        }
    }
}
