using Excample12;
using System;

MaTran maTran1 = new MaTran(2, 3);
maTran1.Input();
maTran1.Ouput();

MaTran maTran2 = new MaTran(2, 3);
maTran2.Input();
maTran2.Ouput();

Console.WriteLine("Tac vu:");
Console.WriteLine("1. Tong 2 ma tran");
Console.WriteLine("2. Hieu 2 ma tran");
Console.WriteLine("3. Tich 2 ma tran");
Console.WriteLine("4. Thuong 2 ma tran");

Console.Write("Nhap lua chon: ");
int option = int.Parse(Console.ReadLine());
switch (option)
{
    case 1:
        double[,] resultSum = MaTran.sumMatrix(maTran1, maTran2);
        if (resultSum != null)
        {
            MaTran.Output(resultSum);
        }
        break;
    case 2:
        double[,] resultDiff = MaTran.diffMatrix(maTran1, maTran2);
        if (resultDiff != null)
        {
            MaTran.Output(resultDiff);
        }
        break;
    case 3:
        double[,] resultPro = MaTran.proMatrix(maTran1, maTran2);
        if (resultPro != null)
        {
            MaTran.Output(resultPro);
        }
        break;
    case 4:
        double[,] resultQuo = MaTran.proMatrix(maTran1, maTran2);
        if (resultQuo != null)
        {
            MaTran.Output(resultQuo);
        }
        break;
    default:
        Console.WriteLine("Lua chon khong hop le.");
        break;
}