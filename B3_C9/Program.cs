using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3_C9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cau 9: Nhap so hang n. Ve tam giac * voi so hang tuong ung:

            Console.Write("Nhap vao so hang n bat ky: ");
            int n = int.Parse(Console.ReadLine());

            Ve_Tam_Giac(n);

            Console.WriteLine("<-------------------------- KET THUC CAU 9 -------------------------->");
        }

        static void Ve_Tam_Giac(int N)
        {
            string m = "*";

            for (int i = 1; i <= N; i++)

            {
                m += "*";
                Console.WriteLine(m);
            }
        }

    }

}
