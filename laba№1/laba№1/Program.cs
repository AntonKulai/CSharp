using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1laba
{
    class Program
    {
        static void Main(string[] args)
        {
            //8.Обчислення об'єму та прощі поверхні кулі заданого радіуса

            string str;
            double r;
            double v, v1, s, s1;

            Console.WriteLine("Введіть радіус кулі");
            str = Console.ReadLine();
            r = Convert.ToDouble(str);

            v = 1.333333333333333333333 * Math.Pow(r, 3);
            v1 = 1.333333333333333333333 * 3.141592653589793238462643 * Math.Pow(r, 3);

            s = 4 * Math.Pow(r, 2);
            s1 = 4 * 3.141592653589793238462643 * Math.Pow(r, 2);
            Console.WriteLine("об'єм кулі = " + v + "п, або  " + v1 + "(см)");
            Console.WriteLine("площа поверхні  кулі = " + s + "п, або  " + s1 + "(см)");
        }
    }
}
