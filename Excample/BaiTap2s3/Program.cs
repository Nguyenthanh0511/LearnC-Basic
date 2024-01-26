namespace BaiTap2s3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TuyenSinh tuyenSinh = new TuyenSinh();
            double diemchuanA = 15;
            double diemchuanB = 16;
            double diemchuanC = 13.5;

            int choice;
            do
            {
                Console.WriteLine("1. Nhập thông tin thí sinh");
                Console.WriteLine("2. Hiển thị thông tin thí sinh trúng tuyển");
                Console.WriteLine("3. Tìm kiếm thí sinh theo số báo danh");
                Console.WriteLine("4. Thoát");
                Console.Write("Nhập lựa chọn: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        tuyenSinh.NhapThongTin();
                        break;
                    case 2:
                        tuyenSinh.HienThiTrungTuyen(diemchuanA, diemchuanB, diemchuanC);
                        break;
                    case 3:
                        tuyenSinh.TimKiemTheoSBD();
                        break;
                    case 4:
                        Console.WriteLine("Thoát khỏi chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            } while (choice != 4);
        }
    }
}
