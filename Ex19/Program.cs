using System.Data;
using System.Reflection.Metadata.Ecma335;

namespace BaiTap2s19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thi sinh:");
            int SoThiSinh = int.Parse(Console.ReadLine());

            List<ThiSinh> dsthiSinh = new List<ThiSinh>();

            //Nhập thông tin thí sinh
            for(int i = 0; i < SoThiSinh; i++)
            {
                Console.WriteLine($"Nhap thong tin cho thi sinh thu {i + 1}:");

                ThiSinh thiSinh = new ThiSinh();

                Console.WriteLine("ho:");
                thiSinh.HoTen.Ho = Console.ReadLine();
                Console.WriteLine("ten dem:");
                thiSinh.HoTen.TenDem = Console.ReadLine();
                Console.WriteLine("ten:");
                thiSinh.HoTen.Ten = Console.ReadLine();
                Console.WriteLine("xa:");
                thiSinh.QueQuan.Xa = Console.ReadLine();
                Console.WriteLine("huyen:");
                thiSinh.QueQuan.Huyen = Console.ReadLine();
                Console.WriteLine("tinh:");
                thiSinh.QueQuan.Tinh = Console.ReadLine();
                Console.WriteLine("truong:");
                thiSinh.Truong = Console.ReadLine();
                Console.WriteLine("tuoi:");
                thiSinh.Tuoi = int.Parse(Console.ReadLine());
                Console.WriteLine("diem toan:");
                thiSinh.DiemThi.DiemToan = double.Parse(Console.ReadLine());
                Console.WriteLine("diem ly:");
                thiSinh.DiemThi.DiemLy = double.Parse(Console.ReadLine());
                Console.WriteLine("diem hoa:");
                thiSinh.DiemThi.DiemHoa = double.Parse(Console.ReadLine());

                dsthiSinh.Add(thiSinh);
            }
            //hiển thị thông tin thí sinh có tổng điểm ba môn lớn hơn 15
            Console.WriteLine("danh sach thi sinh co tong diem ba mon lon hon 15:");
            foreach(var thiSinh in dsthiSinh)
            {
                if(TinhTongDiem(thiSinh.DiemThi) > 15)
                {
                    thiSinh.InThongTin();
                }
            }
            //sắp xếp danh sach theo thứ tự giảm dần
            dsthiSinh.Sort((ts1, ts2) => TinhTongDiem(ts1.DiemThi).CompareTo(TinhTongDiem(ts2.DiemThi)));

            //hiển thị danh sách sau khi sắp xếp 
            Console.WriteLine("danh sach thi sinh sau khi sap xep theo tong diem giam dan:");
            foreach(var thiSinh in dsthiSinh)
            {
                thiSinh.InThongTin();
            }
        }
        //hàm tính tổng
        static double TinhTongDiem(DiemThi diemThi)
        {
            return diemThi.DiemToan + diemThi.DiemLy + diemThi.DiemHoa;
        }
    }
}
