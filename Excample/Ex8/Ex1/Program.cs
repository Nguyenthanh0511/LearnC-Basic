using Ex1;

Manager manager = new Manager();

int luaChon;
do
{
    Console.WriteLine("1. Nhap can bo | 2. Tim kiem | 3. Hien thi danh sach | 0. Thoat");
    Console.Write("Lua chon: ");
    luaChon = int.Parse(Console.ReadLine());

    switch (luaChon)
    {
        case 1:
            manager.Input();
            break;
        case 2:
            manager.SearchName();
            break;
        case 3:
            manager.Output();
            break;
        case 0:
            Console.WriteLine("Thoat chuong trinh.");
            break;
        default:
            Console.WriteLine("Lua chon khong hop le.");
            break;
    }

} while (luaChon != 0);
    