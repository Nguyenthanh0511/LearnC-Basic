using Excample15;

Console.WriteLine("Nhap n: ");
int n = int.Parse(Console.ReadLine());

List<DaGiac> daGiacs = new List<DaGiac>();
for (int i = 0; i < n; i++)
{
    Console.Write("Nhap so canh: ");
    int soCanh = int.Parse(Console.ReadLine());

    Console.WriteLine("Nhap kich thuoc cac canh: ");
    List<double> kichThuocCanh = new List<double>();
    for (int j = 0; j < soCanh; j++)
    {
        Console.Write("Canh " + (j + 1) + ": ");
        double temp = double.Parse(Console.ReadLine());

        kichThuocCanh.Add(temp);
    }

    List<double> kichThuocCanhTemp = new List<double>(kichThuocCanh);
    double canhMax = kichThuocCanhTemp.Max();
    kichThuocCanhTemp.Remove(canhMax);
    double sumCanh = kichThuocCanhTemp.Sum(canh => Math.Pow(canh, 2));

    if (sumCanh == Math.Pow(canhMax, 2))
    {
        TamGiac tamGiac = new TamGiac(soCanh, kichThuocCanh);
        daGiacs.Add(tamGiac);
    }
}

Console.WriteLine("Da Giac Pitago");
int index = 1;
foreach (DaGiac daGiac in daGiacs)
{
    Console.WriteLine("Da Giac " + index);
    daGiac.HienThi();
}