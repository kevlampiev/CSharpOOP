using System;

namespace lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building house = new Building(15, 3, 2, 1);
            house.DisplayBuingingInfo();
            Console.ReadKey();
        }
    }
}
