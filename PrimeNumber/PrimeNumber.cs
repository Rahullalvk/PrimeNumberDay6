using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class PrimeNumber
    {
        public static void DisplayPrimeNumber()
        {
            int i = 1;
            Console.WriteLine("Enter the starting value");
            int Min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending value");
            int Max = Convert.ToInt32(Console.ReadLine());

            for (int n = Min; n <= Max; n++)
            {
                while (n % i != 0)
                {
                    i++;
                }
                Console.WriteLine(n);


            }
        
        }
    }
}
