using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hientlgph30431_CSharp1_BT1
{
    public class Service
    {
        List<SinhVien> sinhViens;

        public Service()
        {
            sinhViens = new List<SinhVien>()
            {
                new SinhVien(){MaSV1 = "PH1", Ten1="a", NamSinh1=2003,Diem1=7.5f},
                new SinhVien(){MaSV1 = "PH2", Ten1="b", NamSinh1=2002,Diem1=8.5f},
                new SinhVien(){MaSV1 = "PH3", Ten1="c", NamSinh1=2001,Diem1=8f},
                new SinhVien(){MaSV1 = "PH4", Ten1="d", NamSinh1=2004,Diem1=7f},
            };           
        }

        public void AddSV()
        {
            for (int i = 0; i < sinhViens.Count; i++)
            {
                Console.WriteLine("Nhap ma SV:");
                sinhViens[i].MaSV1 = Console.ReadLine();
                Console.WriteLine("Ten: ");
                sinhViens[i].Ten1 = Console.ReadLine();
                Console.WriteLine("Nam sinh: ");
                sinhViens[i].NamSinh1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Diem: ");
                sinhViens[i].Diem1 = Convert.ToDouble(Console.ReadLine());



                Console.WriteLine("Co nhap tiep ? Y/N");
                string inp;
                inp = Console.ReadLine();
                if (inp.ToLower() == "y")
                {
                    sinhViens.Add(sinhViens[i]);
                    continue;
                }
                else
                {
                    sinhViens.Add(sinhViens[i]);
                    Console.WriteLine("Them thanh cong");
                    break;
                }

            }            
        }

        public void ExportList()
        {
            foreach (var item in sinhViens)
            {
                item.InThongTin();
            }
        }

        public void AllowHappyBee()
        {
            foreach (var item in sinhViens.Where(x => x.Diem1 >=8))
            {
                item.InThongTin();
            }
        }
        public void BanHappyBee()
        {
            for (int i = 0; i < sinhViens.Count; i++)
            {
                if (DateTime.Now.Year - sinhViens[i].NamSinh1 > 25)
                {
                    sinhViens.RemoveAt(i);
                }
            }
        }

        public void KeThua(SinhVienUD sinhVienUD)
        {
            sinhVienUD = new SinhVienUD();
            Console.WriteLine("Nhap ma SV:");
            sinhVienUD.MaSV1 = Console.ReadLine();
            Console.WriteLine("Nhap ten SV:");
            sinhVienUD.Ten1 = Console.ReadLine();
            Console.WriteLine("Nhap nam sinh SV:");
            sinhVienUD.NamSinh1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap diem SV:");
            sinhVienUD.Diem1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap ki hoc SV:");
            sinhVienUD.KiHoc1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hien thi thong tin\n");
            sinhVienUD.InThongTin();
        }
    }
}
