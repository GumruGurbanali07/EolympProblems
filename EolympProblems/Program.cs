
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

            -------------------------------------------------------------------------------------

Olimpiada

                        string[] s = Console.ReadLine().Split(' ');
            int h1 = int.Parse(s[0]);
            int m1 = int.Parse(s[1]);
            int s1 = int.Parse(s[2]);
            string[] st = Console.ReadLine().Split(' ');
            int h2 = int.Parse(st[0]);
            int m2 = int.Parse(st[1]);
            int s2 = int.Parse(st[2]);
            int h3 = h2 - h1;
            int m3 = m2 - m1;
            int s3 = s2 - s1;
            Console.WriteLine(h3 + " " + m3 + " " + s3);

            h = t / 3600;
            m = (t % 3600) / 60;
            s = t % 60;


            -------------------------------------------------------------------------------------

Turist

                        string[] s = Console.ReadLine().Split(' ');
            int k = int.Parse(s[0]);
            int w = int.Parse(s[1]);

            string[] st = Console.ReadLine().Split(' ');
            int a1 = int.Parse(st[0]);
            int b1 = int.Parse(st[1]);
            int a2 = int.Parse(st[2]);
            int b2 = int.Parse(st[3]);
            int a3 = int.Parse(st[4]);
            int b3 = int.Parse(st[5]);

            if ((a1 + a2 + a3 <= w || a1 + a2 <= w || a1 + a3 <= w || a2 + a3 <= w) && (b1 + b2 + b3 >= k || b1 + b2 >= k || b1 + b3 >= k || b2 + b3 >= k))
            {
                Console.WriteLine("YES");
            }
            else
            {

                Console.WriteLine("NO");

            }

            -------------------------------------------------------------------------------------

Deyisdirme


                        int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] st = Console.ReadLine().Split(' ');
                int k = int.Parse(st[0]);
                if (k % 3 == 1)
                {
                    Console.WriteLine("VGC");
                }
                else if (k % 3 == 2)
                {
                    Console.WriteLine("CVG");
                }
                else if (k % 3 == 3)
                {
                    Console.WriteLine("GCV");
                }
                else if (k == 1)
                {
                    Console.WriteLine("VGC");
                }
                else if (k == 2)
                {
                    Console.WriteLine("CVG");
                }
                else if (k == 3)
                {
                    Console.WriteLine("GCV");
                }
            }



            -------------------------------------------------------------------------------------

Ag kubikler

                        string[] st = Console.ReadLine().Split(' ');
            int a = int.Parse(st[0]);
            int b = int.Parse(st[1]);
            int c = int.Parse(st[2]);
            int v = a * b * c / 1;
            int result = 6 * v - 2 * (a * c + b * c + a * c);
            Console.WriteLine(v + " " + result);


            -------------------------------------------------------------------------------------

Temir

                        int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] st1 = Console.ReadLine().Split(' ');
                int l = int.Parse(st1[0]);
                int w = int.Parse(st1[1]);
                int h = int.Parse(st1[2]);
                int v = l * w * h / 16;
                int res = 6 * v - 2 * (l * w + l * h + w * h);
                Console.WriteLine(res);
            }  ?????

              -------------------------------------------------------------------------------------

  Nikolay ucun zaman


              ------------------------------------------------------------------------------------ -

  Birinci yoxsa axirinci

                        int n = int.Parse(Console.ReadLine());
            int a = n / 100;
            int b = n % 100 / 10;
            int c = n % 10;
            if (a >= b && a >= c)
            {
                Console.WriteLine(a);
            }
            else if (b >= a && b >= c)
            {

                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }

            -------------------------------------------------------------------------------------

Kvadrat tenlik

            ------------------------------------------------------------------------------------ -

Ilin fesilleri

                        int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("Spring");
            }
            else if (n == 2)
            {

                Console.WriteLine("Summer");
            }
            else if (n == 3)
            {
                Console.WriteLine("Autumn");
            }
            else if (n == 4)
            {
                Console.WriteLine("Winter");
            }
            else if (n % 4 == 1)
            {
                Console.WriteLine("Spring");
            }
            else if (n % 4 == 2)
            {
                Console.WriteLine("Summer");
            }
            else if (n % 4 == 3)
            {
                Console.WriteLine("Autumn");
            }
            else if (n % 4 == 4)
            {
                Console.WriteLine("Winter");
            }


            -------------------------------------------------------------------------------------

Dolab

                        string[] st = Console.ReadLine().Split(' ');
            int a = int.Parse(st[0]);
            int b = int.Parse(st[1]);
            int c = int.Parse(st[2]);
            int x = int.Parse(st[3]);
            int y = int.Parse(st[4]);
            if (a <= x && b <= y)
            { Console.WriteLine("YES"); }
            else if (a <= x && c <= y)
            { Console.WriteLine("YES"); }
            else if (b <= x && c <= y)
            { Console.WriteLine("YES"); }
            else if (b <= x && a <= y)
            { Console.WriteLine("YES"); }
            else if (c <= x && a <= y)
            { Console.WriteLine("YES"); }
            else if (c <= x && b <= y)
            { Console.WriteLine("YES"); }
            else
            { Console.WriteLine("NO"); }


            -------------------------------------------------------------------------------------

Qefesdeki dovsanlar
            string[] st = Console.ReadLine().Split(' ');
            int a = int.Parse(st[0]);
            int b = int.Parse(st[1]);
            int qaliq = b % a;
            int tam = b / a;
            int say = 0;
            if (a <= b)
            {
                if (qaliq == 0)
                {
                    say = tam + 1;
                }
                else if (qaliq != 0)
                {
                    if (b - a == 1)
                    {
                        say = 2;
                    }
                    else
                    {
                        say = b - a - 1;
                    }

                }
                Console.WriteLine(say);
            }


            -------------------------------------------------------------------------------------

Cut ve tek ededler
            string[] st = Console.ReadLine().Split(' ');
            int a = int.Parse(st[0]);
            int b = int.Parse(st[1]);
            int c = int.Parse(st[2]);
            if ((a % 2 == 0 || b % 2 == 0 || c % 2 == 0) && (a % 2 == 1 || b % 2 == 1 || c % 2 == 1))
            {
                Console.WriteLine("Yes");
            }
            else { Console.WriteLine("No"); }


            -------------------------------------------------------------------------------------

Tek ededlerin cemi


            string[] st = Console.ReadLine().Split();
            long a = long.Parse(st[0]);
            long b = long.Parse(st[1]);


            if (a > b)
            {
                long temp = a;
                a = b;
                b = temp;
            }

            // Tək ədədlərlə işləmək üçün a və b tək olmasa, onları tək etmək
            if (a % 2 == 0) a++;
            if (b % 2 == 0) b--;

            // Tək ədədlərin sayını tapırıq
            long n = (b - a) / 2 + 1;

            // Gauss qaydası ilə tək ədədlərin cəmini tapırıq
            long sum = n * (a + b) / 2;

            // Nəticəni çap edirik
            Console.WriteLine(sum);



            -------------------------------------------------------------------------------------

Tenbel misa
            string[] st = Console.ReadLine().Split(' ');
            int t1 = int.Parse(st[0]);
            int t2 = int.Parse(st[1]);
            int t3 = int.Parse(st[2]);
            if (t1 < t2 && t1 < t3) { Console.WriteLine(t1); }
            else if (t2 < t1 && t2 < t3) { Console.WriteLine(t2); }
            else { Console.WriteLine(t3); }

            -------------------------------------------------------------------------------------

Saribulbuller

                        string[] st = Console.ReadLine().Split(' ');
            int n = int.Parse(st[0]);
            int k = int.Parse(st[1]); ??????
                    -------------------------------------------------------------------------------------


        Ekskursiyaya getme
            string[] st = Console.ReadLine().Split(' ');
            int o = int.Parse(st[0]);
            int q = int.Parse(st[1]);
            int y = int.Parse(st[2]);
            Console.WriteLine(o / y + q / y);


            -------------------------------------------------------------------------------------


Musbet,menfi,sifir

            int n = int.Parse(Console.ReadLine());
            string result = (n > 0) ? "Positive" : (n < 0) ? "Negative" : "Zero";
            Console.WriteLine(result);

            ------------------------------------------------------------------------------------------------------------
            Sert operatoru - 1

            ------------------------------------------------------------------------------------------------------------
            Sert operatoru-2
            ------------------------------------------------------------------------------------------------------------
            Sert operatoru-3
            ------------------------------------------------------------------------------------------------------------
            Sert operatoru-4
            ------------------------------------------------------------------------------------------------------------
            Sert operatoru-5
            ------------------------------------------------------------------------------------------------------------
            Cut ve ya tek
            ------------------------------------------------------------------------------------------------------------
            Bolunme
            ------------------------------------------------------------------------------------------------------------
            Edede bolme
            ------------------------------------------------------------------------------------------------------------
            Ucreqemli ededin ededlere bolunmesi
            ------------------------------------------------------------------------------------------------------------
            Binalarin nomresi
            ------------------------------------------------------------------------------------------------------------
            Minimum ve maksimum
            ------------------------------------------------------------------------------------------------------------
            Dordunden en boyuyu
            ------------------------------------------------------------------------------------------------------------
            Ders seviyyesi
            ------------------------------------------------------------------------------------------------------------
            SGN funksiyasi
            ------------------------------------------------------------------------------------------------------------
            Su ve buz
            ------------------------------------------------------------------------------------------------------------
            Intervalin daxilinde - 1
            ------------------------------------------------------------------------------------------------------------
            Intervalin daxilinde-2
            ------------------------------------------------------------------------------------------------------------
        }
    }
}
