using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_03
{
    public class KHVN:KhachHang
    {
        public int DTKH { get; set; } //( 1 la sinh hoạt,2 la kinh doanh,3 la sản xuất
        public int DinhMuc { get; set; }

        public double ThanhTien
        {
            get
            {
                if (SoLuong <= DinhMuc)
                    return SoLuong * DonGia;
                else
                    return SoLuong * DonGia*DinhMuc+(SoLuong-DinhMuc)*DonGia*2.5;
            }
        }
        public new void Input()
        {
            int tempInt;
            Console.WriteLine("Nhap doi tuong khach hang:(1 la sinh hoat, 2 la kinh doanh,3 la san xuat)");
            bool CheckDTKH = Int32.TryParse(Console.ReadLine(), out tempInt);
            if(CheckDTKH)
                DTKH = tempInt;
            else
            {
                DTKH = 1;
                Console.WriteLine("Ban nhap sai nen Doi tuong khach hang la sinh hoat");
            }

            Console.WriteLine("Nhap dinh muc:");
            bool CheckDM = Int32.TryParse(Console.ReadLine(), out tempInt);
            if (CheckDM)
                DinhMuc = tempInt;
            else
            {
                DinhMuc = 3000;
                Console.WriteLine("Ban nhap sai nen dinh muc la 3000");
            }
            base.Input();
        }

        public new void Output()
        {
            base.Output();
            string doituong = "";
            switch (DTKH)
            {
                case 1:
                    doituong = "sinh hoat";
                    break;
                case 2:
                    doituong = "kinh doanh";
                    break;
                case 3:
                    doituong = "san xuat";
                    break;
            }
            Console.WriteLine("Dinh muc:" + DinhMuc);
            Console.WriteLine("DTKH:" + doituong);
        }
    }
}
