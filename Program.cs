using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int N = 1, X = 1, s=0; (5 >= N) && (25 >= X); N++, X++)
                
            {
                Console.WriteLine("Квадрат числа {0}, равен {1}",N, N*N);
                Console.WriteLine("Сумма {0}x не четных чисел , равен {1}",X, s= s+2*X-1);
            }
            Console.ReadKey();

        }
    }
}
