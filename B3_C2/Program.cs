using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai 3 - Cau 2: Nhap vao so nguyen duong n, hien thi bang cuu chuong tu 1 den n:

            Console.Write("Nhap vao mot so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            BangCuuChuong(n);

            Console.WriteLine("<-------------------------- KET THUC CAU 2 -------------------------->");

        }
        static void BangCuuChuong(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Bang cuu chuong {i} la: ");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"\t{i} x {j} = {i * j}");
                }
            }
        }
    }
}
