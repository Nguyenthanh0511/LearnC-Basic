//Viết phương thức tính cước
//- Trường hợp 1: Viết ở 2 class(Cs_PayToCapacity, Cs_PyInFull) => Mất đi tính đa hình
//- TH2: Viết ở 3 lớp
//Lớp chứa phương thức trừu tượng = > lớp đó cũng là lớp trừu tượng=> tạo khi không định nghĩa rõ ràng nội dung của một phương thức
//Không được tạo đối tượng từ lớp trừu tượng
using LopTruuTuong;

Customer[] customers = new Customer[2];
customers[0] = new Cs_PayToCapacity("c1", "Hoang Phuong Hue", 3000);
customers[1] = new Cs_PayInFull("c2", "Nguyen Van T");
for(int i = 0;i < customers.Length; i++)
{
    Console.Write(customers[i].HoTen + ":");
    Console.WriteLine(customers[i].TinhCuoc());
}
Console.ReadLine();