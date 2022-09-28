using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001stPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountOfPrimes = 0;
            int count = 0;
            while(amountOfPrimes < 10001)
            {
                
                int counter = 0;
                for(int j = 1; j <= count;j++)
                {
                    if(count % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    amountOfPrimes++;
                    
                }
                count++;
                if (amountOfPrimes >= 9000) Console.WriteLine($" {count} : {amountOfPrimes}");
                else if (amountOfPrimes % 1000 == 0) Console.WriteLine($" {count} : {amountOfPrimes}");
            }
            Console.WriteLine(count);




        }

    }
}
