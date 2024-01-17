using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excample17
{
    internal class HinhTron
    {
        public Diem trongTam { get; private set; }
        public double bk { get; private set; }

        public HinhTron() { }
        public HinhTron(Diem trongTam, double bk)
        {
            this.trongTam = trongTam;
            this.bk = bk;
        }

        public double TinhDienTich()
        {
            return Math.Pow(bk, 2) * Math.PI;
        }

        public double TinhChuVi()
        {
            return 2 * bk * Math.PI;
        }

        public void HienThi()
        {
            Console.WriteLine("Tam: ");
            trongTam.HienThi();
            Console.WriteLine("Ban kinh: " + bk);
        }

        public static bool GiaoNhau(HinhTron hinhTron1, HinhTron hinhTron2)
        {
            double sumBk = hinhTron1.bk + hinhTron2.bk;
            double khoangCanhTam = Diem.TinhKhoangCanh(hinhTron1.trongTam, hinhTron2.trongTam);

            if (khoangCanhTam <= sumBk) return true;
            return false;
        }
    }
}
