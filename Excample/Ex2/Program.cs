using Ex2;

Manager manager = new Manager();
int luaChon;
do
{
    Console.WriteLine("1. Nhap tai lieu | 2. Hien thi danh sach | 3. Tim kiem theo loai | 0. Thoat");
    Console.Write("Lua chon: ");
    luaChon = int.Parse(Console.ReadLine());

    switch (luaChon)
    {
        case 1:
            manager.Input();
            break;
        case 2:
            manager.Output();
            break;
        case 3:
            manager.Search();
            break;
        case 0:
            Console.WriteLine("Thoat chuong trinh.");
            break;
        default:
            Console.WriteLine("Lua chon khong hop le.");
            break;
    }

} while (luaChon != 0);