using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _1111
{
    public class Result //я недавно ознайомився з Класами і захотів перший раз використатии його на практиці, хоча тут можна було обійтися і без його :)
    {
        public int maxNumberOfRepetition;
        public int result;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Дана матриця цілих чисел розміру M x N. Вивести номер її 1) першого; 2) останнього рядка(стовпчика), що містить максимальну кількість однакових елементів.*/

            Console.WriteLine("Введіть к-сть рядків масиву");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть к-сть стовпців масиву");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("/////////////////////////////////////////");
            Console.WriteLine();

            int[,] arr = new int[N, M];


            Random random = new Random();
            Result result = new Result();


            for (int i = 0; i < N; i++) // генерація рандомних чисел
            {
                for (int j = 0; j < M; j++)
                {
                    arr[i, j] = random.Next(10);
                }
            }

            for (int i = 0; i < N; i++) //вивід масиву
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < N; i++) //сортування чисел в масиві щоб здійснити перевірку
            {
                for (int j = 1; j < N; j++)
                {
                    int a = arr[i, j];
                    int x = j - 1;
                    while (x >= 0 && arr[i, x] > a)
                    {
                        arr[i, x + 1] = arr[i, x];
                        x = x - 1;
                    }
                    arr[i, x + 1] = a;
                }
            }

            Console.WriteLine();
            Console.WriteLine("/////////////////////////////////////////");
            Console.WriteLine();

            for (int i = 0; i < N; i++) //вивід відсортованого масиву
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < N; i++) //перевірка на к-сть одинакових елементів
            {
                int numberOfRepetitions = 0;

                for (int j = 1; j < M; j++)
                {
                    if (arr[i, j] == arr[i, j - 1])
                    {
                        numberOfRepetitions++;
                    }
                }

                if (numberOfRepetitions > result.maxNumberOfRepetition)
                {
                    result.maxNumberOfRepetition = numberOfRepetitions;
                    result.result = i;
                }
            }

            Console.WriteLine();
            Console.WriteLine("/////////////////////////////////////////");
            Console.WriteLine();

            Console.WriteLine("максимальну кількість однакових елементів містить рядок під номером: " + result.result);

            Console.ReadLine();
        }
    }
}
