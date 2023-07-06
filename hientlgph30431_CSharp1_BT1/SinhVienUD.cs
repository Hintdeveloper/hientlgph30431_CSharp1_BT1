using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hientlgph30431_CSharp1_BT1
{
    public class SinhVienUD : SinhVien
    {
        int KiHoc;


        public SinhVienUD() 
        {

        }

        public SinhVienUD(string maSV, string ten, int namSinh, double diem, int kiHoc) : base(maSV, ten, namSinh, diem)
        {
            KiHoc = kiHoc;
        }

        public int KiHoc1 { get => KiHoc; set => KiHoc = value; }

        public override void InThongTin()
        {
            Console.WriteLine("Ma SV: " + MaSV1 + "\n");
            Console.WriteLine("Ten: " + Ten1 + "\n");
            Console.WriteLine("Nam sinh: " + NamSinh1 + "\n");
            Console.WriteLine("Diem: " + Diem1 + "\n");
            Console.WriteLine("Ki hoc: " + KiHoc1 + "\n");
        }
    }
}
