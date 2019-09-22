using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_03
{
    public class KHNN:KhachHang
    {
        public string QuocTich { get;set; }

        public new double ThanhTien
        {
            get { return SoLuong * DonGia; }
        }

        public new void Input()
        {
            Console.WriteLine("Nhap Quoc tich:");
            QuocTich = Console.ReadLine();
            base.Input();
        }

        public new void Output()
        {
            base.Output();
            Console.WriteLine("Quoc tich:"+QuocTich);
            Console.WriteLine("Thanh tien:"+ThanhTien);
        }
    }
}
