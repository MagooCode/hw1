using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_hw.Vehicles
{
    internal class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public decimal FuelCapacity;
        public decimal FuelFor1Km;
        public decimal CurrentFuel;

        public Car(string colour, short year, string Brand, string Model, decimal FuelCapacity, decimal FuelFor1KM, decimal CurrentFuel) : base(colour, year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.FuelCapacity = FuelCapacity;
            this.FuelFor1Km = FuelFor1KM;
            this.CurrentFuel = CurrentFuel;
        }

        public void showInfo()
        {
            Console.WriteLine($"{colour} {year} {Brand} {Model} {FuelCapacity} {FuelFor1Km} {CurrentFuel}");
        }
        public void Drive(decimal Distance)
        {
            if ((CurrentFuel / FuelFor1Km) > Distance)
            {
                Console.WriteLine(CurrentFuel - (Distance / FuelFor1Km));
            }
            else
            {
                Console.WriteLine("Fuel shortage");
            }
        }

    }
}
