using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_04
{
    class SachTK:Sach
    {
        public double Thue { get; set; }

        public double ThanhTien
        {
            get { return SoLuong * DonGia + Thue; }
        }
        public void Input()
        {
            base.Input();
            Console.WriteLine("Nhap Tien thue:");
            int tempThue;
            bool checkTinhTrang = int.TryParse(Console.ReadLine(), out tempThue);
            if (checkTinhTrang)
            {
                Thue = tempThue;
            }
            else
            {
                Console.WriteLine("Nhap sai dinh dang, Thue se la 10000");
                Thue=10000;
            }
        }

        public void Output()
        {
            base.Output();
            Console.WriteLine("Thue"+Thue);
            Console.WriteLine("Thanh tien:" + ThanhTien);
        }
    }
}
