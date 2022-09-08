using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingsClasses
{
    public class Building
    {
        private int _houseNumber;
        private double _height;
        private int _numberOfFloors;
        private int _numberOfFlats;
        private int _numberOfFrontDoors;

        static private int _currentNumber = 1;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="height">Высота (минимальное значение 2,4 метра </param>
        /// <param name="numberOfFloors">Количество этажей. Минимальное значение -1 </param>
        /// <param name="numberOfFlats">Количество квартир. Ниминальное зеначение кол0во этажей*кол-во подъездов</param>
        /// <param name="numberOfFrontDoors">Количество подъездов. Минимально значение - 1 </param>
        public Building(double height, int numberOfFloors, int numberOfFlats, int numberOfFrontDoors) 
        {
            _houseNumber = _currentNumber++;
            _numberOfFloors = Math.Max(numberOfFloors, 1);
            _numberOfFrontDoors = Math.Max(numberOfFrontDoors, 1);
            _numberOfFlats = Math.Max(numberOfFlats, _numberOfFrontDoors*_numberOfFloors);
            _height = Math.Max(height, 2.4 * _numberOfFloors);
        }

        // Надо бы, конечно, через константы, но не сегодня
        public Building() : this(17 * 2.7, 17, 17 * 4 * 4, 4) { }

        public int HouseNumber { get { return _houseNumber; } }
        public double Height { 
            get { return _height; } 
            set { if (value>0)_height = value; }
        }

        public int NumberOfFloors 
        {
            get { return _numberOfFloors;  }
            set { if (value > 0) _numberOfFloors = value; }
        }

        public int NumberOfFlats 
        {
            get { return _numberOfFlats;  }
            set { if (value > 0) _numberOfFloors = value; }
        }

        public int NumberOfFrontDoors
        {
            get { return _numberOfFrontDoors; }
            set { if (value > 0) _numberOfFrontDoors = value; }
        }
        /// <summary>
        /// ВЫсота этажа
        /// </summary>
        public double FloorHeight { get { return _height / _numberOfFloors; } }

        /// <summary>
        /// Количество квартир в подъезде
        /// </summary>
        public int FlatsPerFrontDoor { get { return _numberOfFlats / _numberOfFrontDoors;  } }

        /// <summary>
        /// Количество квартир на этаже
        /// </summary>
        public int FlatsPerFloor { get { return FlatsPerFrontDoor / _numberOfFloors;  } }

        public void DisplayBuingingInfo() 
        {
            Console.WriteLine(new String('-', 80));
            Console.WriteLine($"House No {HouseNumber} info:");
            Console.WriteLine($"Number of flats: {NumberOfFlats}");
            Console.WriteLine($"Number of front doors: {NumberOfFrontDoors}");
            Console.WriteLine($"Number of floors: {NumberOfFloors}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Floor height: {FloorHeight}");
            Console.WriteLine($"Flatrs per floor: {FlatsPerFloor}");

        }

    }
}
