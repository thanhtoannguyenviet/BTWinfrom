using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Lab01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KhachHang> list = new List<KhachHang>();
            Console.WriteLine("Nhap so luong khach hang:");
            int N = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Bam 1 de them khach hang viet nam");
                Console.WriteLine("Bam 2 de them khach hang nuoc ngoai");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        KHVN vn = new KHVN();
                        vn.Input();
                        list.Add(vn);
                        break;
                    case 2:
                        KHNN nn = new KHNN();
                        nn.Input();
                        list.Add(nn);
                        break;
                    default:
                        Console.WriteLine("Nhap sai");
                        break;
                }
            }

            var lsKHVN = from s in list where s is KHVN select (KHVN) s;
            //Xuat danh sach
            foreach (var khvn in list)
            {
                khvn.Output();
            }

            var lsKHNN = from s in list where s is KHNN select (KHNN) s;
            foreach (var khnn in list)
            {
                khnn.Output();
            }

            // số lượng cho từng loại khách hàng
            var countKHVN = list.Where(v => v is KHVN).Count();
            Console.WriteLine("So luong  khach Viet" + countKHVN);

            var countKHNN = list.Where(v => v is KHNN).Count();
            Console.WriteLine("So luong  khach nuoc ngoai" + countKHNN);
            // trung bình thành tiền của khách hàng người nước ngoài
            var AverageKHNN = list.Where(v => v is KHNN).Average(v => v.ThanhTien);
            Console.WriteLine("Trung bin thanh tien cua khach hang nuoc ngoai" + AverageKHNN);

            var lsHoaDon = list.Where(v => v.NgayRaHD.Year == 2019 && v.NgayRaHD.Month == 09).ToList();
            foreach (var item in lsHoaDon)
            {
                item.Output();
            }

            //Tim ds
            var findKey = Console.ReadLine();
            var lsThanhTien = list.Where(v => v.MaKH == findKey)
                .Select(v => new {HoTen = v.HoTen, ThanhTien = v.ThanhTien});
            foreach (var kh in lsThanhTien)
            {
                Console.WriteLine(kh.HoTen + "----" + kh.ThanhTien);
            }
        }
    }
}
