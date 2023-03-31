using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_C8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cau 8: Nhap vao so nguyen duong n bat ky. Hien thi ra cac SO NGUYEN TO tu 1 den n:

            Console.Write("Nhap vao so nguyen n bat ky: ");
            uint n = uint.Parse(Console.ReadLine());

            Console.WriteLine($"Cac so nguyen to tu 1 den {n} la: ");

            for (uint i = 2; i <= n; i++)
            {
                if (La_So_Nguyen_To(i))
                {
                    Console.Write($"{i}\t");
                }
            }

            Console.WriteLine();
            Console.WriteLine("<-------------------------- KET THUC CAU 8 -------------------------->");
        }

        static Boolean La_So_Nguyen_To(uint Songuyen)
        {
            Boolean Check = true;

            for (int i = 2; i < Songuyen; i++)
            {
                if (Songuyen % i == 0)
                {
                    Check = false;
                    break;
                }
            }
            return Check;
        }


    }
}
