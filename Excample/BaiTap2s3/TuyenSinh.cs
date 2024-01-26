using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2s3
{
    internal class TuyenSinh
    {
        private List<ThiSinh> dsThiSinh = new List<ThiSinh>();

        public void NhapThongTin()
        {
            Console.WriteLine("chon khoi thi (1. khoi A, 2. khoi B, 3. Khoi C):");
            int choice = int.Parse(Console.ReadLine());

            ThiSinh thiSinh;
            switch (choice)
            {
                case 1:
                    thiSinh = new KhoiA();
                    break;
                case 2:
                    thiSinh = new KhoiB();
                    break;
                case 3:
                    thiSinh = new KhoiC();
                    break;
                default:
                    Console.WriteLine("lua chon khong hop le!");
                    return;
            }
            thiSinh.NhapThongTin();
            dsThiSinh.Add(thiSinh);
            Console.WriteLine("thong tin thi sinh da duoc cap nhat!");
        }
        public void HienThiTrungTuyen(double diemchuanA, double diemchuanB, double diemchuanC)
        {
            Console.WriteLine("danh sach thi sinh trung tuyen");
            foreach(var thiSinh in dsThiSinh)
            {
                double diemchuan = 0;

                if(thiSinh is KhoiA)
                {
                    diemchuan = diemchuanA;
                }
                else if(thiSinh is KhoiB)
                {
                    diemchuan = diemchuanB;
                }
                else if(thiSinh is KhoiC)
                {
                    diemchuan = diemchuanC;
                }

                if(TinhTongDiem(thiSinh) >= diemchuan)
                {
                    thiSinh.XuatThongTin();
                }
            }
        }
        public void TimKiemTheoSBD()
        {
            Console.WriteLine("Nhap so bao danh can tim:");
            string soBaoDanh = Console.ReadLine();
            foreach(var thiSinh in dsThiSinh)
            {
                if (thiSinh.SoBaoDanh.Equals(soBaoDanh))
                {
                    thiSinh.XuatThongTin();
                    return;
                }
            }
            Console.WriteLine("khong tim thay thi sinh!");
        }
        private double TinhTongDiem(ThiSinh thiSinh)
        {
            double tongDiem = 0;

            if(thiSinh is KhoiA)
            {
                KhoiA ts = (KhoiA)thiSinh;
                tongDiem = ts.DiemToan + ts.DiemLy + ts.DiemHoa;
            }
            else if(thiSinh is KhoiB)
            {
                KhoiB ts = (KhoiB)thiSinh;
                tongDiem = ts.DiemToan + ts.DiemHoa + ts.DiemSinh;
            }
            else if(thiSinh is KhoiC)
            {
                KhoiC ts = (KhoiC)thiSinh;
                tongDiem = ts.DiemVan + ts.DiemSu + ts.DiemDia;
            }

            return tongDiem + thiSinh.UuTien;
        }
    }
}
