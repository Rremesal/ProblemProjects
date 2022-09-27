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
            int value = 2; //1 is no prime number
            
            for(int i = 1; i <= 6;i++)
            {
                int counter = 0;
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine($"{i} : {value} --> divided by {j}");
                    
                    if (value % j == 0)
                    {
                        counter++;
                    }
                    if(counter == 2)
                    {
                        Console.WriteLine($"{i} : {value} is a prime number");
                    }
                    counter = 0;
                }
                
                value++;
            }

            
            
        }

    }
}
