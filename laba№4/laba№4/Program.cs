using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1111
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Даний масив ненульових цілих чисел розміру N.Перевірити, чи чергуються в ньому 1)парні та непарні і 2) додатні і від ємні числа. 
             * Якщо чергуються, то вивести 0, якщо ні, то вивести номер першого елементу, що порушує закономірність.*/

            Console.WriteLine("Введіть розмір масиву");

            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Введіть [" + i + "] елемент масиву: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();



            Console.WriteLine("1) перевірка на чергування парних та непарних");
            int counter1 = 0;

            for (int i = 1; i < N; i++)
            {
                if ((arr[i - 1] + arr[i]) % 2 == 0)
                {
                    counter1++;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (counter1 == 0)
            {
                Console.WriteLine("0");
            }



            Console.WriteLine("2) перевірка на чергування від'ємних і додатніх");
            int counter2 = 0;

            for (int i = 1; i < N; i++)
            {
                if (arr[i - 1] * arr[i] > 0)
                {
                    counter2++;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (counter2 == 0)
            {
                Console.WriteLine("0");
            }



            Console.ReadLine();
        }
    }
}
