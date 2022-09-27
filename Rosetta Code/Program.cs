using System;

class Program
{
    static void Main(string[] args)
    {
        List<bool> listOfDoors = new List<bool>();
        //false equals closed door, true equals open door
        for(int i = 0; i < 100; i++) listOfDoors.Add(false);

        //go past every door and open it
        for(int i = 0; i < listOfDoors.Count(); i++)
        {
            Console.WriteLine($"{i} : {listOfDoors[i]}");
        }



    }
}
