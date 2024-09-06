
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EolympProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Sade mesele
            int n = int.Parse(Console.ReadLine());
            int a = n % 10;
            int b = n / 10;
            Console.WriteLine(a + " " + b);

            ------------------------------------------------------------------------------------

           Anfisa
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            int y = int.Parse(st[1]);
            int result = (x - 1) * (y - 1) + 1;
            Console.WriteLine(result);

            ------------------------------------------------------------------------------------

           Tort
            string[] st = Console.ReadLine().Split(' ');
            double t1 = double.Parse(st[0]);
            double t2 = double.Parse(st[1]);
            double t3 = double.Parse(st[2]);
            double res = 1.0 / (1.0 / t1 + 1.0 / t2 + 1.0 / t3);
            Console.WriteLine(res.ToString("F2"));

            ------------------------------------------------------------------------------------

           Merkezi Istilik Sistemi
            string[] st = Console.ReadLine().Split(' ');
            int h = int.Parse(st[0]);
            int w = int.Parse(st[1]);
            int l = int.Parse(st[2]);
            int k = int.Parse(st[3]);
            int say = h * w * l / k;
            if (say % 10 != 0)
            {
                int result = say + 1;
                Console.WriteLine(result);
            }

            ------------------------------------------------------------------------------------

           Genc Bagban
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n * (n + 1) + 1);

            ------------------------------------------------------------------------------------

           Kvadratlarin Cemi
            string[] st = Console.ReadLine().Split(' ');
            int x = int.Parse(st[0]);
            int y = int.Parse(st[1]);
            Console.WriteLine(x * x + y * y);

            -------------------------------------------------------------------------------------

            Reqemlerin hasili
            int n = int.Parse(Console.ReadLine());
            int a = n % 10;
            int b = n / 10 % 10;
            int c = n / 100 % 10;
            Console.WriteLine(a * b * c);

            -------------------------------------------------------------------------------------

            Cemin kvadrati
            int n = int.Parse(Console.ReadLine());
            int a = n % 10;
            int b = n / 10;
            Console.WriteLine((a + b) * (a + b));

            -------------------------------------------------------------------------------------


        }
    }
}
