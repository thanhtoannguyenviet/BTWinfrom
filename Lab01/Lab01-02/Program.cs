using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            Console.WriteLine("So luong nguoi muon nhap");
            int N = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine("Bam 1 de them giang vien");
                Console.WriteLine("Bam 2 de them sinh vien");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Teacher gv = new Teacher();
                        gv.Input();
                        list.Add(gv);
                        break;
                    case 2:
                        Student std = new Student();
                        std.Input();
                        list.Add(std);
                        break;
                    default:
                        Console.WriteLine("Nhap sai");
                        break;
                }
            }
            //Xuat danh sach SV
            var lsStudent = from s in list where s is Student select (Student) s;
            foreach (Student c in lsStudent )
            {
                c.Output();
            }
            //Xuat danh sach GV
            var lsTeacher = from s in list where s is Teacher select (Teacher)s;
            foreach (Teacher c in lsTeacher)
            {
                c.Output();
            }
            //Xuat sinh vien co diem cao nhat thuoc khoa CNTT
            Student stu = (list.Where(s => s is Student && ((Student) s).Khoa == "CNTT")
                            .Select(s => (Student) s)).OrderByDescending(p => p.DiemTb)
                                .FirstOrDefault();
            stu.Output();
            //Tim Giang vien va sinh vien co find key
            string findKey = Console.ReadLine();
            FindPeoplebyFindkey(findKey,list);
            
        }

        static void FindPeoplebyFindkey(string findKey,List<Person> ls)
        {
            var lsFind = ls.Where(p => p.Name.ToLower().Contains(findKey.ToLower())).ToList();
            Console.WriteLine("Danh sach sinh vien co ten la "+findKey+":");
            foreach (Student s in lsFind)
            {
                s.Output();
            }
            Console.WriteLine("Danh sach giang vien co ten la " + findKey + ":");
            foreach (Teacher t in lsFind)
            {
                t.Output();
            }
        }
    }
}
