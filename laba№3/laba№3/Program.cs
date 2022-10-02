using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int n = Convert.ToInt32(Console.ReadLine());

            if (true)
            {
                a = n % 10;
                Console.WriteLine(a + "= чило а");
                n /= 10;
                b = n % 10;
                Console.WriteLine(b + "= чило b");
                n /= 10;
                c = n % 10;
                Console.WriteLine(c + "= чило c");
                n /= 10;

                bool x = (a != b && a != c && a != n && b != n && c != n);
                if (x == true)
                {
                    Console.WriteLine("Всі цифри в числі - різні");
                }
                else
                {
                    Console.WriteLine("Число має одинакові цифри");
                }
            }
        }
    }
}
