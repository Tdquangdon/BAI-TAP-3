using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_C4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai 3 - Cau 4: Nhap vao so nguyen n, Kiem tra xem co phai SO CHINH PHUONG hay khong:

            Console.Write("Nhap vao mot so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            if (KiemTraSoChinhPhuong(n))
            {
                Console.WriteLine($"So nguyen {n} LA so chinh phuong");
            }
            else
            {
                Console.WriteLine($"So nguyen {n} KHONG PHAI LA so chinh phuong");
            }

            Console.WriteLine("<-------------------------- KET THUC CAU 4 -------------------------->");

        }
        static bool KiemTraSoChinhPhuong(int n)
        {
            // Goi n1 la can bac hai cua n:

            double n1 = Math.Sqrt(n);

            if (n1 * n1 == n)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}
