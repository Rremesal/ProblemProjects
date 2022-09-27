using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestMultiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 100000000; i++)
            {
                int counter = 0;
                for (int j = 1; j <= 20; j++)
                {
                    if(i % j == 0)
                    {
                        counter++;
                        if(counter == 20)
                        {
                            Console.WriteLine($"The answer: {i} ");
                        }
                    }
                }
            }

            
        }
    }
}
