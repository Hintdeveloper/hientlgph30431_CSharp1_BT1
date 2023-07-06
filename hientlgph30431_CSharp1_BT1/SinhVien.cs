using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hientlgph30431_CSharp1_BT1
{
    public class SinhVien
    {
        string MaSV;
        string Ten;
        int NamSinh;
        double Diem;

        public string MaSV1 { get => MaSV; set => MaSV = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public int NamSinh1 { get => NamSinh; set => NamSinh = value; }
        public double Diem1 { get => Diem; set => Diem = value; }

        public SinhVien(string maSV, string ten, int namSinh, double diem)
        {
            MaSV1 = maSV;
            Ten1 = ten;
            NamSinh1 = namSinh;
            Diem1 = diem;
        }

        public SinhVien()
        {
            
        }

        public virtual void InThongTin()
        {
            Console.WriteLine("Ma SV: " + MaSV1 + "\n");
            Console.WriteLine("Ten: " + Ten1 + "\n");
            Console.WriteLine("Nam sinh: " + NamSinh1 + "\n");
            Console.WriteLine("Diem: " + Diem1 + "\n");
        }
    }
}
