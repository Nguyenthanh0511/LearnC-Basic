using Excample16;

Console.WriteLine("Nhap n: ");
int n = int.Parse(Console.ReadLine());

List<TamGiac> daGiacs = new List<TamGiac>();
for (int i = 0; i < n; i++)
{
    Diem diem1 = new Diem();
    Diem diem2 = new Diem();
    Diem diem3 = new Diem();

    Console.WriteLine("Nhap diem 1: ");
    diem1.NhapDiem();
    Console.WriteLine("Nhap diem 2: ");
    diem2.NhapDiem();
    Console.WriteLine("Nhap diem 3: ");
    diem3.NhapDiem();

    TamGiac tamGiac = new TamGiac(diem1, diem2, diem3);
    daGiacs.Add(tamGiac);
}

Console.WriteLine("Chu Vi va Dien Tich cac Tam Giac");
int index = 1;
foreach (TamGiac tamGiac in daGiacs)
{
    Console.WriteLine("Hinh " + index);
    Console.WriteLine("Chu Vi: " + tamGiac.TinhChuVi());
    Console.WriteLine("Dien Tich: " + tamGiac.TinhDienTich());
}