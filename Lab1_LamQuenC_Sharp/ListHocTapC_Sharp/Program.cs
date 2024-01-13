// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
namespace ListHocTapC_Sharp
{
    class Program
    {

        static void Main(string[] args)
        {

            //int x1, x2, y1, y2;
            //x1 = int.Parse(Console.ReadLine());
            //x2 = int.Parse(Console.ReadLine());
            //y1 = int.Parse(Console.ReadLine());
            //y2 = int.Parse(Console.ReadLine());

            // Công thức 
            //double khoangCach;
            //khoangCach = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            //Output 
            //Console.WriteLine("Khoang cach la :{0}",khoangCach);

            // Bài 1: in tên , tuổi
            string name;
            int age;
            Console.WriteLine("Nhap ten :");
            name = Console.ReadLine();
            Console.WriteLine("Nhap tuoi :");
            age = int.Parse(Console.ReadLine());
            Console.Write($"Chao [{name}]{age,20}");

            //Bài 2: Diện tích chiều dài và chiều rộng của hình chữ nhật 
            double height,width;
            do
            {
                Console.WriteLine("Nhap chieu dai :");
                height = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap chieu rong :");
                width = double.Parse(Console.ReadLine());
            } while (height < width);
            //
            double dienTich = height * width;
            Console.WriteLine("Dien tich la :" + dienTich);


            //Bài tập 3 : Chuyển độ F sang C 
            //input nhập từ bàn phím f c 
            //output : f or c
            //công thức : f = (c*9/5) +32 . c = 5/9*f - 32
            double F , C;
            Console.WriteLine("Nhap gia tri F :");
            F = double.Parse(Console.ReadLine());
            //Công thức
            C = (5.0/9.0)*(F - 32);
            Console.Write($"Voi F [{F}] chuyen sang C = [{C}]");
            //Console.WriteLine("Nhap gia tri C :");
            //C = double.Parse(Console.ReadLine());

            //Bài 5 và 6 
            Console.WriteLine("Nhap so tu ban phim");
            int soNguyen;
            soNguyen = int.Parse(Console.ReadLine());
            if(soNguyen % 2 == 0)
            {
                Console.Write($"So [{soNguyen}] la so chan");
            }
            else
            {
                Console.Write($"So [{soNguyen}] la so le");
            }
            //Kiem tra am
            if( soNguyen < 0)
            {
                Console.Write($"So [{soNguyen}] la so am");
            }
            else
            {
                Console.Write($"So [{soNguyen}] la so duong");
            }
            //Bài 8 
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1;j<=10; j++)
                {
                    int result = i * j;
                    Console.Write($"\n{i}*{j} = {result} ");
                }
                Console.WriteLine("\n");
            }
            //Bài 9 : Kiểm tra số nguyên tố
            Console.WriteLine("Nhap so nguyen to :");
            int soNguyenTo;
            soNguyenTo = int.Parse(Console.ReadLine());
            if (kiemTraSoNguyenTo(soNguyenTo))
            {
                Console.WriteLine("So nguyen to:");
            }
            else
            {
                Console.WriteLine("Khong phai so nguyen to:");
            }
        }
        static bool kiemTraSoNguyenTo(int soNguyenTo)
        {
            if (soNguyenTo == 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(soNguyenTo); i++)
            {
                if (soNguyenTo % i == 0)
                {
                    return false;
                }
            }
            return true; 
        }
    }
}