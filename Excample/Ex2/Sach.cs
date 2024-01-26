using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
     class Sach:TaiLieu
    {
        public string tenTacGia { get; set; }
        public int soTrang { get; set; }
        public Sach() { }
        public Sach(string maTaiLieu, string nhaXuatBan, int soBanPhatHanh,string tenTacGia, int soTrang): base( maTaiLieu,  nhaXuatBan,  soBanPhatHanh)
        {
            this.tenTacGia = tenTacGia;
            this.soTrang = soTrang;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap ten tac gia: ");
            tenTacGia = Console.ReadLine();
            Console.WriteLine("Nhap so trang: ");
            soTrang = int.Parse(Console.ReadLine());
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Ten tac gia: {tenTacGia}");
            Console.WriteLine($"So trang: {soTrang}");
        }
    }
}
