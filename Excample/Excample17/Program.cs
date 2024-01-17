using Excample17;

Console.WriteLine("Nhap n: ");
int n = int.Parse(Console.ReadLine());

List<HinhTron> daGiacs = new List<HinhTron>();
for (int i = 0; i < n; i++)
{
    Diem trongTam = new Diem();
    Console.WriteLine("Nhap Toa Do Tam: ");
    trongTam.NhapDiem();

    Console.Write("Nhap ban kinh: ");
    double bk = double.Parse(Console.ReadLine());

    HinhTron hinhTron = new HinhTron(trongTam, bk);
    daGiacs.Add(hinhTron);
}

Console.WriteLine("Hinh Tron Giao Nhieu Hinh Tron Khac Nhat");
int maxGiao = 0;
HinhTron result = new HinhTron();
for (int i = 0; i < daGiacs.Count(); i++)
{
    int count = 0;
    for (int j = i + 1; j < daGiacs.Count(); j++)
    {
        if (HinhTron.GiaoNhau(daGiacs[i], daGiacs[j])) count++;
    }

    if (count > maxGiao)
    {
        maxGiao = count;
        result = daGiacs[i];
    }
}

if (result != default(HinhTron)) result.HienThi();