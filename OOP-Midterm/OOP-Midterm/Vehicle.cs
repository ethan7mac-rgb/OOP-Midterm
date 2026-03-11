using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Midterm
{
    //abstract vehicle class
    public abstract class Vehicle
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }
        //constructor for vehicle
        public Vehicle(string inMake, string inModel, int inYear)
        {
            Make = inMake;
            Model = inModel;
            Year = inYear;
        }
        //overrides toString for fun i guees
        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}";
        }
        //create a abstract method for derived classes to use
        public abstract double CaculateFuelEfficiency();
    }
}
