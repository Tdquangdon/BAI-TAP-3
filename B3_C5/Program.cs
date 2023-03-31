using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_C5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai 3 - Cau 5: Nhap vao so thang bat ky, Hien thi so ngay trong thang:

            Console.Write("Nhap vao mot thang bat ky - Thang ban chon la: ");
            int Thang = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao mot nam bat ky - Nam ban chon la: ");
            int Nam = int.Parse(Console.ReadLine());

            if (Thang >= 1 && Thang <= 12)
            {
                TinhNgayTrongThang(Thang, Nam);
            }

            else
            {
                Console.WriteLine("Thang ban nhap KHONG HOP LE - HUY KET QUA");
            }

            Console.WriteLine("<-------------------------- KET THUC CAU 5 -------------------------->");

        }
        static void TinhNgayTrongThang(int Thang, int Nam)
        {
            switch (Thang)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang ban chon co 30 ngay");
                    break;

                case 2:
                    if (Nam % 400 == 0 || (Nam % 4 == 0 && Nam % 100 != 0))
                    {
                        Console.WriteLine("Thang ban chon co 29 ngay (NAM NHUAN)");
                    }
                    else
                    {
                        Console.WriteLine("Thang ban chon co 28 ngay");
                    }
                    break;

                default:
                    Console.WriteLine("Thang ban chon co 31 ngay");
                    break;
            }
        }

    }

}
