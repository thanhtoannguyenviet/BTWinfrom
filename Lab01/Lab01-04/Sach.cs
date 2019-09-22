using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lab01_04
{
    public class Sach
    {   
            public int MaSach { get; set; }
            public DateTime NgayNhap { get; set; }
            public double DonGia { get; set; }
            public int SoLuong { get; set; }
            public string NhaXuatBan { get; set; }
            public double ThanhTien { get; set; }

            public void Input()
            {
                int tempMs;
            Console.WriteLine("Nhap Ma Sach :");
            bool CheckMaSach = Int32.TryParse(Console.ReadLine(),out tempMs);
            if (CheckMaSach)
            {
                MaSach = tempMs;
            }
            else
            {
                Console.WriteLine("Nhap sai r, Ma sach cua ban se la 1");
                MaSach = 1;
            }
            Console.WriteLine("Nhap nha xuat ban :");
            NhaXuatBan = Console.ReadLine();
            Console.WriteLine("Nhap Ngay ra Hoa Don (dd-MM-yyyy):");

            DateTime tempDate;
            bool checkDate = DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yyyy",
                CultureInfo.InvariantCulture, DateTimeStyles.None,out tempDate);
            if (checkDate)
                NgayNhap = tempDate;
            else
            {
                Console.WriteLine("Ban nhap sai dinh dang , cho nen ngay nhap  se la ngay hien tai");
                NgayNhap = DateTime.Now;
            }
            Console.WriteLine("Nhap So Luong :");
            int temp;
            bool checkSoLuong = int.TryParse(Console.ReadLine(), out temp);
            if (checkSoLuong)
                SoLuong = temp;
            else
            {
                Console.WriteLine("Ban da nhap sai nen so luong se la 20 KWh");
                SoLuong = 20;
            }
            Console.WriteLine("Nhap Don Gia :");
            double tempDg;
            bool checkDonGia = Double.TryParse(Console.ReadLine(), out tempDg);
            if (checkDonGia)
                DonGia = tempDg;
            else
            {
                Console.WriteLine("Ban da nhap sai nen don gia se la 6000");
                DonGia = 6000;
            }

        }

            public void Output()
            {
                Console.WriteLine("Ma sach:"+MaSach);
                Console.WriteLine("Nha xuat ban:"+NhaXuatBan);
                Console.WriteLine("Ngay nhap:"+NgayNhap);
                Console.WriteLine("Don gia:"+DonGia);
                Console.WriteLine("So luong:"+SoLuong);

            }
    }
}
