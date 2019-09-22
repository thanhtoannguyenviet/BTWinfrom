using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Student 
    {
        private string studentID;
        public string StudentID { get { return studentID; } set { studentID = value; } }
        public string StudentName { get; set; }
        public double DiemTb { get; set; }
        public string Khoa { get; set; }
        public Student() { }
        public Student(string id,string name,double diemTb,string khoa) {
            StudentID = id;
            StudentName = name;
            DiemTb = diemTb;
            Khoa = khoa;
        }
        public void Input()
        {
            Console.WriteLine("Nhap MaSV :");
            StudentID=Console.ReadLine();
            Console.WriteLine("Nhap Ho va Ten:");
            StudentName = Console.ReadLine();
            Console.WriteLine("Nhap Diem Trung Binh:");
            DiemTb =Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Khoa:");
            Khoa = Console.ReadLine();
        }
        public void Output() {
                Console.WriteLine("MSSV:" + StudentID);
                Console.WriteLine("Ho va ten:" +StudentName);
                Console.WriteLine("Diem Trung Binh:" + DiemTb);
                Console.WriteLine("Khoa:" + Khoa);
        }
        
    }
}
