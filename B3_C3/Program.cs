using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_C3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bai 3 - Cau 3: Nhap vao so nguyen duong n, Tinh tong giai thua tu 1 den n:

            Console.Write("Nhap vao mot so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tong cac giai thua tu 1 den {n} la: {TongGiaiThua(n)}");

            Console.WriteLine("<-------------------------- KET THUC CAU 3 -------------------------->");

        }
        static int TongGiaiThua(int n)
        {
            int Tich = 1;

            int Tong = 0;

            for (int i = 1; i <= n; i++)
            {
                Tich = Tich * i;
                Tong = Tong + Tich;
            }
            return Tong;
        }
    }

}
