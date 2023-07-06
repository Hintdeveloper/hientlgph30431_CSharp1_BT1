using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hientlgph30431_CSharp1_BT1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            SinhVienUD sinhVienUD = new SinhVienUD();
            int choice;

            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Nhap doi tuong");
                Console.WriteLine("2. Xuat danh sach");
                Console.WriteLine("3. Danh sach sinh vien tham gia HappyBee");
                Console.WriteLine("4. Xoa sinh vien khong tham gia HappyBee");
                Console.WriteLine("5. Ke thua");
                Console.WriteLine("0. Thoat");
                Console.WriteLine("Insert number: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting");
                        break;
                    case 1:
                        service.AddSV();
                        break;
                    case 2:
                        service.ExportList();
                        break;
                    case 3:
                        service.AllowHappyBee();
                        break;
                    case 4:
                        service.BanHappyBee();
                        break;
                    case 5:
                        service.KeThua(sinhVienUD);
                        break;
                    default:
                        Console.WriteLine("Lua chon khong phu hop. An nut bat ky de thoat phan mem");
                        break;
                }

            } while (choice >= 1 && choice <= 5);        
        }
    }
}
