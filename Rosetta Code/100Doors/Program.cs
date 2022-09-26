using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100Doors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            List<bool> listOfDoors = new List<bool>();
            //false equals closed door, true equals open door
            for (int i = 0; i < 100; i++) listOfDoors.Add(false);

            //go past every door and open it
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 0; j < listOfDoors.Count(); j++)
                {
                    if (j % i == 0) listOfDoors[j] = !listOfDoors[j];
                    
                }

            }
            foreach(bool b in listOfDoors)
            {
                Console.WriteLine(counter + "::" + b);
                counter++;
            }
            Console.ReadLine();
            





        }
    }
}


