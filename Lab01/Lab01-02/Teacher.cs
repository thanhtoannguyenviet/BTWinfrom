using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Teacher : Person
    {
        public string TeacherID { get; set; }
        public string DiaChi { get; set; }
        public void Input()
        {
            Console.WriteLine("Nhap Ma Giang Vien :");
            TeacherID = Console.ReadLine();
            Console.WriteLine("Nhap Ten Giang Vien :");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap Dia Chi :");
            DiaChi = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("Ma Giang Vien:" + TeacherID);
            Console.WriteLine("Ho va ten:" + Name);
            Console.WriteLine("Diem Trung Binh:" + DiaChi);
        }

    }
}
