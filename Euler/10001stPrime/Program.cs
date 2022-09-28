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
            for(int i = 0; i <= 10001;i++)
            {
                int counter = 0;
                for(int j = 1; j <= i;j++)
                {
                    if(i % j == 0)
                    {
                        counter++;
                    }

                    
                }
                Console.WriteLine($"{i}");
                if (counter == 2) Console.WriteLine(i);
            }

            
            
        }

    }
}
