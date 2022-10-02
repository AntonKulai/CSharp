using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn;
            int nk;


            double sum = 0;


            nn = int.Parse(Console.ReadLine());
            nk = int.Parse(Console.ReadLine());

            for (int k = nn; k < nk; k++)
            {
                sum += (Math.Pow(k,2)-3)/(Math.Pow(k,2)-(Math.Pow(-1,k)*k+3));
            }

            Console.WriteLine(sum);


            Console.ReadKey();
        }
    }
}
