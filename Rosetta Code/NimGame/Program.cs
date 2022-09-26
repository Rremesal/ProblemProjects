using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NimGame
{
    enum Turn
    {
        Player,
        COM
    }
    
    internal class Program
    {
        private static int tokens = 12;
        private static Turn turn = Turn.COM;
        private static string lastInput = "";
        private static int lastPlayerAmount;

        static void Main(string[] args)
        {
            Console.WriteLine($" # Welcome to NimGame, the game where you you start with a total of {tokens} tokens");
            Console.WriteLine($" # you can take either 1, 2 or 3 tokens at once, the goal is to be the last one");
            Console.WriteLine($" # to take tokens from the total and be left with 0!");
            Console.WriteLine($" ###   you will be playing against the COM (computer) good luck!\n");
            do
            {
                if (tokens <= 0) {
                    string message = (turn == Turn.Player) ? "You have" : "The COM has";

                    Console.WriteLine($"{message} won the game");
                    return;
                }

                turn = (turn == Turn.Player) ? Turn.COM : Turn.Player;

                if (turn == Turn.COM) {
                    int COMamount = 4 - lastPlayerAmount;
                    Thread.Sleep(1500); 
                    Console.WriteLine($" # COM took {COMamount} tokens\n");
                    Thread.Sleep(1500); 
                    tokens -= COMamount;
                    continue;
                }

                Console.WriteLine($" # TOTAL: {tokens}");
                string input = GetInput("How many tokens do you take? > ");
                lastInput = input;
                int amount = Int32.Parse(input);
                switch (amount) {
                    case 1:
                    case 2:
                    case 3:
                        break;
                    default: 
                        Console.WriteLine(" # Please enter 1, 2 or 3!\n");
                        continue;
                }
                
                tokens -= amount;
                lastPlayerAmount = amount;

            } while (lastInput.ToLower() != "quit" || lastInput.ToLower() != "q");
        }

        private static string GetInput(string prompt) {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
