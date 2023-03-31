using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_C7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cau 7: Nhap vao so nguyen n bat ky. Tinh tong cac so le tu 1 den n:

            Console.Write("Nhap vao so nguyen n bat ky: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tong cac so le tu 1 den {n} la {TONG_SO_LE(n)}");

            Console.WriteLine("<-------------------------- KET THUC CAU 7 -------------------------->");
        }

        static int TONG_SO_LE(int n)
        {
            // Dat S la Tong cac so le tu 1 den n:

            int S = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    S += i;
                }
            }
            return S;
        }

    }

}
