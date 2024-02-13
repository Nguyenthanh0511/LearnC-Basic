using System;
using System.Collections.Generic;

abstract class Nguoi
{
    public string hoTen;
    public int tuoi;
    public int namSinh;
    public string queQuan;
    public string gioiTinh;

    public abstract void NhapThongTin();
    public abstract void HienThiThongTin();
}

class CanBoGiaoVien : Nguoi
{
    private int luongCung;
    private int thuong;
    private int phat;
    public int luongThucLinh;
    private string soCMND;

    public CanBoGiaoVien()
    {
        base.hoTen = "";
        base.tuoi = 0;
        base.namSinh = 0;
        base.queQuan = "";
        base.gioiTinh = "";
        luongCung = 0;
        thuong = 0;
        phat = 0;
        luongThucLinh = 0;
        soCMND = "";
    }

    public override void NhapThongTin()
    {
        //base.NhapThongTin();
        Console.Write("Nhập số chứng minh thư nhân dân: ");
        soCMND = Console.ReadLine();
        Console.Write("Nhập lương cứng: ");
        luongCung = int.Parse(Console.ReadLine());
        Console.Write("Nhập thưởng: ");
        thuong = int.Parse(Console.ReadLine());
        Console.Write("Nhập phạt: ");
        phat = int.Parse(Console.ReadLine());
    }

    public override void HienThiThongTin()
    {
        Console.WriteLine("Thông tin cán bộ giáo viên:");
        Console.WriteLine($"Họ và tên: {hoTen}");
        Console.WriteLine($"Năm sinh: {namSinh}");
        Console.WriteLine($"Quê quán: {queQuan}");
        Console.WriteLine($"Giới tính: {gioiTinh}");
        Console.WriteLine($"Số chứng minh thư nhân dân: {soCMND}");
        Console.WriteLine($"Lương cứng: {luongCung}");
        Console.WriteLine($"Thưởng: {thuong}");
        Console.WriteLine($"Phạt: {phat}");
        Console.WriteLine($"Lương thực lĩnh: {luongThucLinh}");
    }

    public void NhapThongTinLuong()
    {
        Console.Write("Nhập lương cứng: ");
        luongCung = int.Parse(Console.ReadLine());
        Console.Write("Nhập thưởng: ");
        thuong = int.Parse(Console.ReadLine());
        Console.Write("Nhập phạt: ");
        phat = int.Parse(Console.ReadLine());
    }

    public void TinhLuongThucLinh()
    {
        luongThucLinh = luongCung + thuong - phat;
    }
}

class QuanLyGiaoVien
{
    static void Main()
    {
        Console.Write("Nhập số lượng cán bộ giáo viên: ");
        int n = int.Parse(Console.ReadLine());
        List<CanBoGiaoVien> danhSachGiaoVien = new List<CanBoGiaoVien>();

        for (int i = 0; i < n; i++)
        {
            CanBoGiaoVien giaoVien = new CanBoGiaoVien();
            giaoVien.NhapThongTin();
            giaoVien.TinhLuongThucLinh();
            danhSachGiaoVien.Add(giaoVien);
        }

        Console.Write("Nhập quê quán cần tìm kiếm: ");
        string queQuanCanTim = Console.ReadLine();
        Console.WriteLine($"Danh sách cán bộ giáo viên từ {queQuanCanTim}:");
        foreach (CanBoGiaoVien giaoVien in danhSachGiaoVien)
        {
            if (giaoVien.queQuan.Equals(queQuanCanTim, StringComparison.OrdinalIgnoreCase))
            {
                giaoVien.HienThiThongTin();
            }
        }

        Console.WriteLine("Danh sách cán bộ giáo viên có lương thực lĩnh trên 5 triệu đồng:");
        foreach (CanBoGiaoVien giaoVien in danhSachGiaoVien)
        {
            if (giaoVien.luongThucLinh > 5000000)
            {
                giaoVien.HienThiThongTin();
            }
        }
    }
}
