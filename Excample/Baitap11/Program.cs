using System;

class SoPhuc
{
    public double phanThuc;
    public double phanAo;

    public SoPhuc()
    {
        phanThuc = 0;
        phanAo = 0;
    }

    public SoPhuc(double a, double b)
    {
        phanThuc = a;
        phanAo = b;
    }

    public void NhapSoPhuc()
    {
        Console.Write("Nhập phần thực: ");
        phanThuc = double.Parse(Console.ReadLine());
        Console.Write("Nhập phần ảo: ");
        phanAo = double.Parse(Console.ReadLine());
    }

    public void HienThiSoPhuc()
    {
        Console.WriteLine($"Số phức: {phanThuc} + {phanAo}i");
    }

    public SoPhuc Cong(SoPhuc b)
    {
        SoPhuc tong = new SoPhuc();
        tong.phanThuc = this.phanThuc + b.phanThuc;
        tong.phanAo = this.phanAo + b.phanAo;
        return tong;
    }

    public SoPhuc Tru(SoPhuc b)
    {
        SoPhuc hieu = new SoPhuc();
        hieu.phanThuc = this.phanThuc - b.phanThuc;
        hieu.phanAo = this.phanAo - b.phanAo;
        return hieu;
    }

    public SoPhuc Nhan(SoPhuc b)
    {
        SoPhuc tich = new SoPhuc();
        tich.phanThuc = this.phanThuc * b.phanThuc - this.phanAo * b.phanAo;
        tich.phanAo = this.phanThuc * b.phanAo + this.phanAo * b.phanThuc;
        return tich;
    }

    public SoPhuc Chia(SoPhuc b)
    {
        SoPhuc thuong = new SoPhuc();
        double mau = b.phanThuc * b.phanThuc + b.phanAo * b.phanAo;
        thuong.phanThuc = (this.phanThuc * b.phanThuc + this.phanAo * b.phanAo) / mau;
        thuong.phanAo = (this.phanAo * b.phanThuc - this.phanThuc * b.phanAo) / mau;
        return thuong;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập số phức A:");
        SoPhuc A = new SoPhuc();
        A.NhapSoPhuc();

        Console.WriteLine("\nNhập số phức B:");
        SoPhuc B = new SoPhuc();
        B.NhapSoPhuc();

        Console.WriteLine("\nChọn tác vụ:");
        Console.WriteLine("a) Tính tổng hai số phức");
        Console.WriteLine("b) Tính hiệu hai số phức");
        Console.WriteLine("c) Tính tích hai số phức");
        Console.WriteLine("d) Tính thương hai số phức");

        char luaChon = Console.ReadKey().KeyChar;
        SoPhuc ketQua = new SoPhuc();

        switch (luaChon)
        {
            case 'a':
                ketQua = A.Cong(B);
                Console.WriteLine($"\nTổng hai số phức: {ketQua.phanThuc} + {ketQua.phanAo}i");
                break;

            case 'b':
                ketQua = A.Tru(B);
                Console.WriteLine($"\nHiệu hai số phức: {ketQua.phanThuc} + {ketQua.phanAo}i");
                break;

            case 'c':
                ketQua = A.Nhan(B);
                Console.WriteLine($"\nTích hai số phức: {ketQua.phanThuc} + {ketQua.phanAo}i");
                break;

            case 'd':
                ketQua = A.Chia(B);
                Console.WriteLine($"\nThương hai số phức: {ketQua.phanThuc} + {ketQua.phanAo}i");
                break;

            default:
                Console.WriteLine("\nLựa chọn không hợp lệ.");
                break;
        }
    }
}
