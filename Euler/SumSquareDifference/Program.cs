using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumOfTheSquares = 0;
            for(int i = 1; i <= 100; i++)
            {
                double square = Math.Pow(i, 2);
                sumOfTheSquares += square;
            }
            Console.WriteLine($"The sum of the square is: {sumOfTheSquares}");

            double sum = 0;
            for(int j = 1; j <= 100; j++)
            {
                sum += j;
            }
            double squareOfTheSum = Math.Pow(sum, 2);
            Console.WriteLine($"The square of the sum: {squareOfTheSum}");
            double difference = squareOfTheSum - sumOfTheSquares;
            Console.WriteLine($"The difference between the two: {difference}");

        }
    }
}
