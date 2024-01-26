using Ex10;

Console.WriteLine("Nhap van ban:");
string input = Console.ReadLine();

VanBan vanBan = new VanBan(input);

int luaChon;
do
{
    Console.WriteLine("\n----- MENU -----");
    Console.WriteLine("1. Dem so tu");
    Console.WriteLine("2. Dem so ky tu H");
    Console.WriteLine("3. Chuan hoa xau");
    Console.WriteLine("0. Thoat");

    Console.Write("Nhap lua chon cua ban: ");
    luaChon = int.Parse(Console.ReadLine());

    switch (luaChon)
    {
        case 1:
            Console.WriteLine($"So tu trong van ban: {vanBan.DemSoTu()}");
            break;
        case 2:
            Console.WriteLine($"So ky tu H trong van ban: {vanBan.DemSoKyTuH()}");
            break;
        case 3:
            Console.WriteLine($"Xau sau chuan hoa: '{vanBan.ChuanHoaXau()}'");
            break;
        case 0:
            Console.WriteLine("Ban da thoat chuong trinh.");
            break;
        default:
            Console.WriteLine("Lua chon khong hop le.");
            break;
    }
} while (luaChon != 0);