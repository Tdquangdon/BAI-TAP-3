using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_C10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CAU 10: Nhap vao so nguyen n, tinh toan va hien thi DAY SO FIBONACCI:

            Console.Write("Nhap vao so nguyen n bat ky: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Day so Fibonacci voi {n} phan tu la: ");
            Fibonacci(n);

            Console.WriteLine();

            Console.WriteLine("<-------------------------- KET THUC CAU 10 -------------------------->");
        }

        static void Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int c;

            for(int i = 1; i <= n; i++) 
            {
                switch(i)
                {
                    case 1:
                        Console.Write($"0\t");
                        break;
                    
                    case 2:
                        Console.Write($"1\t");
                        break;

                    default:
                        c = a + b;
                        Console.Write($"{c}\t");
                        a = b;
                        b = c;
                        break;
                }
            }
        }
    }
}
