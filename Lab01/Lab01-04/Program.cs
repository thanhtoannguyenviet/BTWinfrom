using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab01_04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sach> list = new List<Sach>();
            Console.WriteLine("Nhap so luong khach hang:");
            int N = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Bam 1 de them Sach giao khoa");
                Console.WriteLine("Bam 2 de them Sach tham khao");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        SachGK gk = new SachGK();
                        gk.Input();
                        list.Add(gk);
                        break;
                    case 2:
                        SachTK tk = new SachTK();
                        tk.Input();
                        list.Add(tk);
                        break;
                    default:
                        Console.WriteLine("Nhap sai");
                        break;
                }
            }

            var lsGks = from s in list where s is SachGK select (SachGK)s;
            //Xuat danh sach
            foreach (var gk in lsGks)
            {
                gk.Output();
            }

            var lsTKs = from s in list where s is SachTK select (SachTK)s;
            foreach (var tk in list)
            {
                tk.Output();
            }
            //Tong thanh tien
            var gkSum = lsGks.Sum(s=>s.ThanhTien);
            Console.WriteLine("Tong tanh tien sach giao khoa:"+ gkSum);
            var tkSum = lsTKs.Sum(s => s.ThanhTien);
            Console.WriteLine("Tong tanh tien sach tham khao:" + tkSum);
            //Tinh trung binh don gia sach tham khao
            var dgSTK = lsTKs.Average(s => s.DonGia);
            Console.WriteLine("Trung binh don gia sach tham khao"+dgSTK);
            //Sach cua nha xb X
            var lsXB = lsGks.Where(l => l.NhaXuatBan == "X").ToList();
            foreach (var xbX in lsXB)
            {
                xbX.Output();
            }
            //Xuat ra thanh tien cua ma sach 
            Console.WriteLine("Nhap ma sach can tim");
            var key = int.Parse(Console.ReadLine());
            var thanhtien = list.Where(x => x.MaSach == key).Sum(x => x.ThanhTien);
            Console.WriteLine("Thanh tien cua san pham do la:"+thanhtien);
          

        }
    }
}
