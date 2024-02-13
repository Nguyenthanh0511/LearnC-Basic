using Excample14;

PhanSo phanSo1 = new PhanSo();
PhanSo phanSo2 = new PhanSo();

Console.WriteLine("Nhap phan so 1: ");
phanSo1.NhapPhanSo();
Console.WriteLine("Nhap phan so 2: ");
phanSo2.NhapPhanSo();

Console.WriteLine("Tac vu:");
Console.WriteLine("1. Tong 2 phan so");
Console.WriteLine("2. Hieu 2 phan so");
Console.WriteLine("3. Tich 2 phan so");
Console.WriteLine("4. Chia 2 phan so");

Console.Write("Nhap lua chon: ");
int option = int.Parse(Console.ReadLine());
switch (option)
{
    case 1:
        PhanSo tong = PhanSo.CongPhanSo(phanSo1, phanSo2);
        tong.HienPhanSo();
        break;
    case 2:
        PhanSo hieu = PhanSo.TruPhanSo(phanSo1, phanSo2);
        hieu.HienPhanSo();
        break;
    case 3:
        PhanSo tich = PhanSo.NhanPhanSo(phanSo1, phanSo2);
        tich.HienPhanSo();
        break;
    case 4:
        PhanSo thuong = PhanSo.ChiaPhanSo(phanSo1, phanSo2);
        thuong.HienPhanSo();
        break;
    default:
        Console.WriteLine("Lua chon khong hop le.");
        break;
}