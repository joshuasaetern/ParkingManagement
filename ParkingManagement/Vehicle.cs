using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingManagement
{
    internal class Vehicle
    {
        //Fields
        String make;
        String model;
        int year;
        String license;

        //Constructors
        public Vehicle(String make, String model, int year, String license )
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.license = license;
        }

        //Accessor Methods
        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
        public string License { get => license; set => license = value; }

        //Methods
        public override string ToString()
        {
            return $"{this.make} {this.model}, {this.year}";
        }
        public String PrintVehicle()
        {
            return $"Make: {this.make}\nModel: {this.model}\nYear: {this.year}\nLicense: {this.license.ToUpper()}";
        }
    }
}
