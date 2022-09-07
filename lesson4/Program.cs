using System;
using BuildingsClasses;

namespace lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++) 
            {
                Creator.CreateBuild();
            }
            Console.WriteLine("СОЗДАНЫ 3 ДОМА");
            Creator.DisplayBuildings();
            Creator.RemoveBuilding(2);
            Console.WriteLine("РАЗРУШЕН СРЕДНИЙ");
            Creator.DisplayBuildings();
            Console.ReadKey();
        }
    }
}
