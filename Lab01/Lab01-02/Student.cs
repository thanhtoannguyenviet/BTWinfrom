using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Student:Person
    {
        public string StudentID { get; set; }
        public double DiemTb { get; set; }
        public string Khoa { get; set; }
        public void Input()
        {
            Console.WriteLine("Nhap MaSV :");
            StudentID = Console.ReadLine();
            Console.WriteLine("Nhap Ho va Ten:");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap Diem Trung Binh:");
            DiemTb = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Khoa:");
            Khoa = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine("MSSV:" + StudentID);
            Console.WriteLine("Ho va ten:" + Name);
            Console.WriteLine("Diem Trung Binh:" + DiemTb);
            Console.WriteLine("Khoa:" + Khoa);
        }
    }
}
