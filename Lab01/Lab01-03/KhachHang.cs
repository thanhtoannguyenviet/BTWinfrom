using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_03
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public DateTime NgayRaHD { get; set; }
        public double SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien { get; set; }

        protected void Input()
        {
            
            Console.WriteLine("Nhap Ma :");
            MaKH=Console.ReadLine();
            Console.WriteLine("Nhap Ho Ten :");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhap Ngay ra Hoa Don (yyyy-MM-dd ):");
            
            DateTime temps ;
            bool checkDate=DateTime.TryParse(Console.ReadLine(),out temps);
            if (checkDate)
                NgayRaHD = temps;
            else
            {
                Console.WriteLine("Ban nhap sai ngay ra hoa don, cho nen NgayRaHD se la ngay hien tai");
                NgayRaHD =DateTime.Now;
            }
            Console.WriteLine("Nhap So Luong :");
            double temp;
            bool checkSoLuong=Double.TryParse(Console.ReadLine(), out temp);
            if(checkSoLuong)
                SoLuong = temp;
            else
            {
                Console.WriteLine("Ban da nhap sai nen so luong se la 20 KWh");
                SoLuong = 20;
            }
            Console.WriteLine("Nhap Don Gia :");
            bool checkDonGia = Double.TryParse(Console.ReadLine(), out temp);
            if (checkDonGia)
                DonGia = temp;
            else
            {
                Console.WriteLine("Ban da nhap sai nen don gia se la 6000");
                DonGia = 6000;
            }

        }

        public void Output()
        {
            Console.WriteLine("Ma:"+MaKH);
            Console.WriteLine("Ten:"+HoTen);
            Console.WriteLine("Ngay:"+NgayRaHD);
            Console.WriteLine("So luong"+SoLuong);
            Console.WriteLine("Don gia"+DonGia);
        }
    }
}
