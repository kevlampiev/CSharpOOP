using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BuildingsClasses
{
    public class Creator
    {

        static Hashtable Buildings=new Hashtable();
        private Creator() { }

        /// <summary>
        /// Генерация случайного дома
        /// </summary>
        /// <returns>Новый дом</returns>
        public static Building CreateBuild()
        {
            Random random = new Random();
                
            double height = random.Next(100, 500)/10.0;
            int numberOfFloors = random.Next(1, 25);
            int numberOfFlats = random.Next(10, 1024);
            int numberOfFrontDoors = random.Next(1, 10);

            Building house = new Building(height, numberOfFloors, numberOfFlats, numberOfFrontDoors);

            Buildings.Add(house.HouseNumber, house);
            return house; 
        }


        /// <summary>
        /// Отобразить все построенные дома
        /// </summary>
        public static void DisplayBuildings() 
        {
            Console.WriteLine("Все здания: ");

            foreach (var el in Buildings.Keys) 
            {
                ((Building)Buildings[el]).DisplayBuingingInfo();
            }
        }

        public static void RemoveBuilding(int houseNumber)
        {
            Buildings.Remove(houseNumber);
        }
    }
}
