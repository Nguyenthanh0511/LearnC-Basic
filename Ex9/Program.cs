using Ex9;

List<BienLai> dsBienLai = new List<BienLai>();

Console.Write("Nhap so luong bien lai: ");
int soLuongBienLai = int.Parse(Console.ReadLine());

for (int i = 0; i < soLuongBienLai; i++)
{
    BienLai bienLai = new BienLai();
    bienLai.Input();
    dsBienLai.Add(bienLai);
}

Console.WriteLine("\nDanh sach bien lai:");
foreach (BienLai bienLai in dsBienLai)
{
    bienLai.Output();
    Console.WriteLine();
}