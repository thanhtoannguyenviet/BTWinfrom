using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Tester
    {
        static void Main(string[] args)
        {
            Student sd = new Student();

            Console.WriteLine("Nhap tong so sinh vien N=:");
            int N = Convert.ToInt32(Console.ReadLine());
            List<Student> lsStu = new List<Student>();

            Console.WriteLine("=====Nhap Danh sach sinh vien=====");
            for (int i = 0; i < N; i++)
            {
                Student std = new Student();
                std.Input();
                lsStu.Add(std);
            }
            Console.WriteLine("\n\n\n\n=====Xuat Danh sach sinh vien=====");
            foreach (var stu in lsStu)
            {
                stu.Output();
            }
            //1a
            List<Student> lsCNTT = lsStu.Where(o => o.Khoa == "CNTT").ToList();
            foreach(var stu in lsCNTT)
            {
                stu.Output();
            }
            //1b
            Student topSort=lsStu.Where(o => o.Khoa == "CNTT").OrderByDescending(o => o.DiemTb).FirstOrDefault();
            if (topSort != null)
                topSort.Output();
            else
                Console.WriteLine("Khong tim thay ");

            var sortLs = lsStu.Where(o => o.Khoa == "CNTT").OrderBy(o => o.DiemTb);
            foreach(var i in sortLs)
            {
                i.Output();
            }
            Console.ReadKey();
        }
    }
}
