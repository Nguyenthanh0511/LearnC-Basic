using Ex8;

List<SinhVien> dsSV = new List<SinhVien>();
List<TheMuon> dsTheMuon = new List<TheMuon>();
int luaChon;
do
{
    Console.WriteLine("1. Them Sinh Vien");
    Console.WriteLine("2. Them The Muon");
    Console.WriteLine("3. Tim kiem theo Ma Sinh Vien");
    Console.WriteLine("4. Hien thi danh sach den han tra");
    Console.WriteLine("0. Thoat");
    Console.Write("Lua chon: ");
    luaChon = int.Parse(Console.ReadLine());

    switch (luaChon)
    {
        case 1:
            SinhVien sinhVien = new SinhVien();
            sinhVien.Input();
            dsSV.Add(sinhVien);
            Console.WriteLine("Them Sinh Vien thanh cong!");
            break;
        case 2:
            TheMuon theMuon = new TheMuon();
            theMuon.Input();
            dsTheMuon.Add(theMuon);
            Console.WriteLine("Them The Muon thanh cong!");
            break;
        case 3:
            Console.Write("Nhap Ma Sinh Vien can tim kiem: ");
            string maSinhVien = Console.ReadLine();
            SinhVien sinhVienTimKiem = dsSV.FirstOrDefault(sv => sv.MaSoSV == maSinhVien);
            if (sinhVienTimKiem != null)
            {
                sinhVienTimKiem.Output();
            }
            else
            {
                Console.WriteLine("Khong tim thay sinh vien co Ma Sinh Vien nhu tren.");
            }
            break;
        case 4:
            Console.WriteLine("Cac sinh vien den han tra:");
            foreach (var theMuonDenHan in dsTheMuon.Where(tm => tm.DaDenHanTra()))
            {
                theMuonDenHan.Output();
                Console.WriteLine("---------------");
            }
            break;
        case 0:
            Console.WriteLine("Thoat chuong trinh.");
            break;
        default:
            Console.WriteLine("Lua chon khong hop le.");
            break;
    }

} while (luaChon != 0);