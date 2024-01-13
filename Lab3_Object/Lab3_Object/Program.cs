using Bai1_PhanSO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap phan so thu nhat :");
        Console.Write("Tu so: ");
        int tuSo1 = int.Parse(Console.ReadLine());
        Console.Write("Mau so: ");
        int mauSo1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap phan so thu hai:");
        Console.Write("Tu so: ");
        int tuSo2 = int.Parse(Console.ReadLine());
        Console.Write("Mau so: ");
        int mauSo2 = int.Parse(Console.ReadLine());

        PhanSO ps1 = new PhanSO(tuSo1, mauSo1);
        PhanSO ps2 = new PhanSO(tuSo2, mauSo2);

        Console.WriteLine("Chon phep toan:");
        Console.WriteLine("1. Cong ");
        Console.WriteLine("2. Tru");
        Console.WriteLine("3. Nhan");
        Console.WriteLine("4. Chia");
        Console.WriteLine("5. Kiem tra toi gian");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                PhanSO tong = ps1 + ps2;
                Console.Write("Tong: ");
                tong.InPhanSO();
                break;
            case 2:
                PhanSO hieu = ps1 - ps2;
                Console.Write("Hieu: ");
                hieu.InPhanSO();
                break;
            case 3:
                PhanSO tich = ps1 * ps2;
                Console.Write("Tich: ");
                tich.InPhanSO();
                break;
            case 4:
                PhanSO thuong = ps1 / ps2;
                Console.Write("Thuong : ");
                thuong.InPhanSO();
                break;
            case 5:
                Console.WriteLine($"Phan so thu nhat {(ps1.LaToiGian() ? "la" : "khong la")} toi gian.");
                Console.WriteLine($"Phan so thu hai {(ps2.LaToiGian() ? "la" : "khong la ")} toi gian.");
                break;
            default:
                Console.WriteLine("Lua chon khong hop le.");
                break;
        }
    }
}