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
            for (int i = 0; i <= 2520; i++)
            {
                for (int j = 1; j <= 20; j++)
                {
                    
                    if( i % j == 0)
                    {
                        Console.WriteLine($"{i} / {j} = {i % j}");
                    }
                }
            }
                
            
        }
    }
}
