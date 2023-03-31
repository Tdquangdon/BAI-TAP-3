using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CAU 1: Viet chuong trinh nhap vao so nguyen, xem so do chia het cho 3 hay khong:

            Console.Write("Hay nhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            if (ChiaHetCho3(n))
            {
                Console.WriteLine("So nguyen {0} CHIA HET cho 3", n);
            }
            else
            {
                Console.WriteLine("So nguyen {0} KHONG CHIA HET cho 3", n);
            }

        }
        static bool ChiaHetCho3(int n)
        {
            return (n % 3 == 0) ? true : false;
        }
    }

}
