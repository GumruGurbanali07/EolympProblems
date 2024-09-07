
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

           Qefesdeki Dovsanlar
             string[] s = Console.ReadLine().Split(' ');
            int x = int.Parse(s[0]);
            int y = int.Parse(s[1]);
            int z = y / x;
            if (y % x != 0)
            {
                z = z + 1;
            }
            Console.WriteLine(z);

            -------------------------------------------------------------------------------------

           Zanbaqli Gol
             int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n - 1);

            -------------------------------------------------------------------------------------

           Intervaldaki Tam ededlerin cemi
             string[] st = Console.ReadLine().Split(' ');
            int a = int.Parse(st[0]);
            int b = int.Parse(st[1]);
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);

            -------------------------------------------------------------------------------------

           Sevimli Filler
             int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n);

            -------------------------------------------------------------------------------------

           Almalari bolusdurme - 1
             string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            string[] st = Console.ReadLine().Split(' ');
            int k = int.Parse(st[0]);
            int result = k / n;
            Console.WriteLine(result);

            -------------------------------------------------------------------------------------

           Almalari bolusdurme - 2
             string[] s = Console.ReadLine().Split(' ');
            int n = int.Parse(s[0]);
            string[] st = Console.ReadLine().Split(' ');
            int k = int.Parse(st[0]);
            int result = k % n;
            Console.WriteLine(result);

            -------------------------------------------------------------------------------------

           abc
             Console.WriteLine("a");
            Console.WriteLine("bb");
            Console.WriteLine("ccc");

            -------------------------------------------------------------------------------------

           Sonuncu reqem
             int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 10);

            -------------------------------------------------------------------------------------

           Saribulbuller
             string[] st = Console.ReadLine().Split(' ');
            int n = int.Parse(st[0]);
            int k = int.Parse(st[1]); ??????

             -------------------------------------------------------------------------------------

            Su alma
             int n = int.Parse(Console.ReadLine());
            int say = 0;
            int alinanSu = n * 100 / 120;
            int qaliqPul = n % 120;
            if ((alinanSu * 20 + qaliqPul) % 120 == 0)
            {
                say = say + alinanSu;
            }
            Console.WriteLine(say + 1);

            -------------------------------------------------------------------------------------

           Stepanin dostlari
             int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n - 1);

            -------------------------------------------------------------------------------------

           Ekskursiya
             string[] st = Console.ReadLine().Split(' ');
            int o = int.Parse(st[0]);
            int q = int.Parse(st[1]);
            int y = int.Parse(st[2]);
            Console.WriteLine(o / y + q / y);

            -------------------------------------------------------------------------------------

           Iki qatar
            string[] st = Console.ReadLine().Split(' ');
            int t = int.Parse(st[0]);
            int t1 = int.Parse(st[1]);
            int vaxt = t * t * 60 / t1;
            int a = vaxt / 60;
            int b = vaxt % 60;
            Console.WriteLine(a + " " + b);



        }
    }
}
