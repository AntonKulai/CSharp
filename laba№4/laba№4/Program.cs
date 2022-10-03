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

            int x = 0;
            Console.Write("Введіть розмір масиву: ");

            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];

            Console.WriteLine("Введіть елементи масиву: ");
            for (int i = 0; i < N; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {

                if ((arr[i++] & arr[i]) % 2 == 0)
                {
                    x = 1;
                }

                else
                {
                    x = 2;
                    Console.WriteLine("Чергування парних і непарних чисел перервалось на елементі під номером: " + (i) + " і " + (i - 1));
                    break;
                }
            }

            if (x == 1)
            {
                Console.WriteLine("0");
            }



            /*for (int i = 0; i < N; i++)                           я не зміг зробити 2ге завдання
            {
                if ((arr[i] * arr[i + 1]) < 0)
                {
                    k = 1;
                }

                else
                {
                    k = 2;
                    Console.WriteLine("Чергування від'ємних і додатних чисел перервалось на елементі під номером:" + i + " і " + (i - 1));
                    break;
                }
            }
            }*/
        }
    }
}

