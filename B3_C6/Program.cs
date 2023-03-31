using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_C6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai 3 - Cau 6: Nhap vao so nguyen n, Tinh tong luy thua tu 1 den n (S):

            Console.Write("Nhap vao mot so nguyen n bat ky: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tong luy thua tu 1 den {n} la {TinhTongLuyThua(n)}");

            Console.WriteLine("<-------------------------- KET THUC CAU 6 -------------------------->");

        }
        static double TinhTongLuyThua(int n)
        {
            // Dat Tong cac luy thua can tim la S:
            double S = 0;

            for (int i = 1; i <= n; i++)
            {
                S += Math.Pow(i, i);
            }
            return S;
        }

    }

}
