namespace BaiTap2s22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<HocSinh> dsHocSinh = new List<HocSinh>();

            Console.WriteLine("nhap so luong hoc sinh:");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"nhap thong tin cho hoc sinh {i + 1}:");
                Console.Write("ho ten:");
                string HoTen = Console.ReadLine();
                Console.Write("nam sinh:");
                int NamSinh = int.Parse(Console.ReadLine());
                Console.WriteLine("tong diem:");
                double TongDiem = double.Parse(Console.ReadLine());

                dsHocSinh.Add(new HocSinh(HoTen, NamSinh, TongDiem));
            }
            //sắp xếp danh sách theo tổng điểm giảm dần và năm sinh tăng dần
            var dsHocSinhSapXep = dsHocSinh.OrderByDescending(x => x.TongDiem).ThenBy(x => x.NamSinh).ToList();

            //hiển thị danh sách
            Console.WriteLine("\n danh sach sau khi sap xep la:");
            foreach(var hocSinh in dsHocSinhSapXep)
            {
                Console.WriteLine(hocSinh);
            }
        }
    }
}
