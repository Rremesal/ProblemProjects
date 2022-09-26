using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeProduct
{
    internal class Program
    {
        public static int factorOne = 100;
        public static int factorTwo = 100;
        public static int result = factorOne * factorTwo;
        public static char[] array;
        static void Main(string[] args)
        {
            for(int i = 0; i < 1000; i++)
            {
                for(int j = 0; j < 1000; j++)
                {
                    Console.WriteLine($"{i} x {j} = {result}");
                   
            }
            
        }

        
    }
}
