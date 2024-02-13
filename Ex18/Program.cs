using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace BaiTap2s18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CoQuan> dscoQuan = new List<CoQuan>();

            int choice;
            do
            {
                Console.WriteLine("1. Nhập thông tin cá nhân");
                Console.WriteLine("2. Hiển thị thông tin cá nhân trong Phòng tài chính");
                Console.WriteLine("3. Tìm kiếm thông tin theo họ tên");
                Console.WriteLine("4. Thoát");

                Console.WriteLine("Nhap lua chon:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Thong tin ca nhan trong phong tai chinh");
                        foreach (var coQuan in dscoQuan)
                        {
                            if (coQuan is CoQuan && ((CoQuan)coQuan).DonViCT == "Phong tai chinh")
                            {
                                coQuan.In();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Nhap ho ten can tim:");
                        string hoTen = Console.ReadLine();
                        bool TimKiem = false;

                        foreach (var coQuan in dscoQuan)
                        {
                            if (coQuan.HoTen.ToLower().Contains(hoTen.ToLower()))
                            {
                                coQuan.In();
                                TimKiem = true;
                            }
                        }
                        if (!TimKiem)
                        {
                            Console.WriteLine("ho ten khong hop le!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Thoat khoi chuong trinh.");
                        break;
                    default:
                        Console.WriteLine("lua chon khong hop le!");
                        break;
                }
            } while (choice != 3);
        }
    }
}
