namespace BaiTap2s20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HoiVien> dsHoiVien = new List<HoiVien>();

            Console.WriteLine("nhap so hoi vien:");
            int soHoiVien = int.Parse(Console.ReadLine());

            for(int i = 0; i < soHoiVien; i++)
            {
                Console.WriteLine($"Nhap thong tin cho hoi vien thu {i + 1}:");

                Console.Write("ho ten:");
                string HoTen = Console.ReadLine();
                Console.Write("dia chi:");
                string DiaChi = Console.ReadLine();
                Console.Write("lua chon hoi vien:(1. hoi vien co gia dinh, 2. hoi vien co nguoi yeu):");
                int choice = int.Parse(Console.ReadLine());

                if(choice == 1)
                {
                    Console.Write("ho ten vo:");
                    string HoTenVo = Console.ReadLine();
                    Console.Write("ngay cuoi:");
                    DateTime NgayCuoi = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);
                    dsHoiVien.Add(new HoiVienCoGiaDinh(HoTen, DiaChi, HoTenVo, NgayCuoi));
                }
                else if(choice == 2)
                {
                    Console.Write(" ho ten nguoi yeu:");
                    string HoTenNY = Console.ReadLine();
                    Console.Write("so dien thoai nguoi yeu:");
                    string SoDienThoaiNY = Console.ReadLine();
                    dsHoiVien.Add(new HoiVienCoNguoiYeu(HoTen, DiaChi, HoTenNY, SoDienThoaiNY));
                }
            }
            Console.WriteLine("danh sach hoi vien có ngay cuoi la: 11.11.2021");
            foreach(var hoiVien in dsHoiVien)
            {
                if (hoiVien is HoiVienCoGiaDinh && ((HoiVienCoGiaDinh)hoiVien).NgayCuoi == DateTime.Parse("11.11.2021"))
                {
                    hoiVien.HienThiThongTin();
                }
            }
            Console.WriteLine("danh sach hoi vien co nguoi yeu nhung chua lap gia dinh:");
            foreach(var hoiVien in dsHoiVien)
            {
                if(hoiVien is HoiVienCoNguoiYeu && !(hoiVien is HoiVienCoNguoiYeu))
                {
                    hoiVien.HienThiThongTin();
                }
            }
        }
    }
}
