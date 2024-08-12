using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Car
    {
        public string _brand;
        public string _model;
        public string _colour;
        private int _numberOfDoors;


        public Car(string brand, string model, string colour, int numberOfDoors)
        {
            _brand = brand;
            _model = model;
            _colour = colour;
            NumberOfDoors = numberOfDoors;
        }

        public string Brand { get { return _brand; } }

        public string Model { get { return _model; } }

        public string Colour { get { return _colour; } }

        public int NumberOfDoors
        {
            get { return _numberOfDoors; }

            set
            {
                if (value == 2 || value == 4)
                    _numberOfDoors = value;
                else
                {
                    _numberOfDoors = -1;
                }
            }
        }

        public void CarInformation()
        {
            Console.WriteLine("Aracın markası: " + _brand + "\nModeli: " + _model + "\nRengi: " + _colour + "\nKapı sayısı: " + _numberOfDoors);

            if (_numberOfDoors == -1)
                Console.WriteLine("Kapı sayısı 2 veya 4 olmalıdır.");
        }

    }
}