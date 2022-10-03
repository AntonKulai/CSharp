using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Дано ціле число N. Виводити в рядок числа, починаючи від 1, 2, 3, 4…, до того 
            моменту, поки сума цих чисел не буде більшою від N.*/

            string N;
            int a;

            Console.WriteLine("Введіть число:");

            N = Console.ReadLine();

            a = Convert.ToInt32(N);

            int S = 0;
            int b = 0;

            for (int i = 0; i < a; i++)
            {
                b++;
                Console.WriteLine(b);
                S += b;

                if (S > a)
                {
                    break;
                }

            }
            Console.WriteLine(S);
        }
    }
}

