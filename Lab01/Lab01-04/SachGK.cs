using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_04
{
    public class SachGK:Sach
    {
        public int TinhTrang { get; set; } //1 la Moi , 2 la Cu

        public double ThanhTien
        {
            get { return TinhTrang == 1 ? SoLuong * DonGia : SoLuong * DonGia / 2; }
        }

        public void Input()
        {
            base.Input();
            Console.WriteLine("Nhap Tinh trang:");
            int tempTinhTrang;
            bool checkTinhTrang = int.TryParse(Console.ReadLine(), out tempTinhTrang);
            if (checkTinhTrang)
            {
                TinhTrang = tempTinhTrang;
                if (TinhTrang != 1 || TinhTrang != 2)
                {
                    Console.WriteLine("Nhap sai dinh dang, Tinh trang se la Moi");
                    TinhTrang = 1;
                }
            }
            else
            {
                Console.WriteLine("Nhap sai dinh dang, Tinh trang se la Moi");
                TinhTrang = 1;
            }
        }

        public void Output()
        {
            base.Output();
            Console.WriteLine(TinhTrang==1?"Sach Moi":"Sach Cu");
            Console.WriteLine("Thanh tien:"+ThanhTien);
        }
    }
}
