using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    class Program
    {
        static void Print(int a)//завдання 1.5
        {

            Console.Write(a % 10);
            while ((a /= 10) != 0)
            {
                Console.Write(a % 10);
            }
            Console.WriteLine();
        }

        static void Print(string str)//завдання 2.5
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }

        static void Print(double fractional_number)//завдання 3.5 , не знаю як доробити
        {
            int number = Convert.ToInt32(fractional_number);
            string str_number = Convert.ToString(number);

            string str_fractional_number = Convert.ToString(fractional_number);

            for (int i = str_number.Length - 1; i >= 0; i--)
            {
                Console.Write(str_number[i]);
            }
            Console.Write(',');

            for (int i = str_fractional_number.Length - 1; i >= 0; i--)
            {
                Console.Write(str_fractional_number[i]);
            }
        }











        static void Print1(int a)
        {
            if (a != 0)
            {
                Console.Write(a % 10);
                a /= 10;

                Print1(a);
            }

        }

        static void Print1(string str, int i)//завдання 2.6
        {
            if (i > 0)
            {
                Console.Write(str[i - 1]);
                i--;
                Print1(str, i);
            }
        }











        static void PrintArray(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Resize(ref int[] arr1, int newSize)
        {
            int[] arr = new int[newSize];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr[i] = arr1[i];
            }

            arr1 = arr;
        }



        static void Main(string[] args)
        {
            Console.Write("(1.5) Введіть число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Print(a);

            Console.Write("(1.6) Введіть число:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Print1(a1);
            Console.WriteLine();

            Console.Write("(2.5) Введіть строку:");
            string b = Console.ReadLine();
            Print(b);

            Console.Write("(2.6) Введіть строку:");
            string b1 = Console.ReadLine();
            int i2 = b1.Length;
            Print1(b1, i2);
            Console.WriteLine();

            Console.Write("Введіть дробове число:");
            double c = Convert.ToDouble(Console.ReadLine());
            Print(c);
            Console.WriteLine();

            Console.Write("Введіть розмір масиву:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];

            Console.WriteLine("Введіть елементи масиву");
            for (int i = 0; i < N; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            PrintArray(arr);

            Console.Write("Введіть розмір масиву:");
            int M = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[M];

            Console.WriteLine("Введіть елементи масиву");
            for (int i = 0; i < M; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введіть новий розмір масиву:");
            int newSize = Convert.ToInt32(Console.ReadLine());
            Resize(ref arr1, newSize);

            for (int i = 0; i < newSize; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();

            /*Array.Resize(ref arr1, newSize);
              for (int i = 0; i < arr1.Length; i++) //також можна змінити розмір масиву за допомогою класу Array та його статичного методу Resize.
              {
                  Console.WriteLine(arr1[i]);
              }*/

            Console.ReadLine();
        }
    }
}
