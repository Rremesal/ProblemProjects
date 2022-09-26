using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<int> fibonacci = new List<int>();
            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }


            int newTerm = 0;
            for(int i = 0; i < numbers.Count();i++)
            {
                if(i != 0 || i != 1)
                {
                    newTerm += ((numbers[i - 1]) + (numbers[i - 2]));
                    fibonacci.Add(newTerm);
                }
                fibonacci.Add(i);
                
            }

            foreach (int i in fibonacci) Console.WriteLine(i);

            

        }
    }
}
