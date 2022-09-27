using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3or5
{
    internal class Program
    {
        public static int sumTotal = 0;
        static void Main(string[] args)
        {
            for(int i = 0; i < 1000; i++)
            {
                
                if ( (i % 3 == 0) || (i % 5 == 0) )
                {
                    Console.WriteLine(i);
                    sumTotal += i;
                }
            }
            Console.WriteLine($"Sum of all multiples: {sumTotal} ");
        }
    }
}
