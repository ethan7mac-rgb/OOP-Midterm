using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Midterm
{
    public sealed class ElectricCar : Vehicle
    {
        private int _batteryCapacity;

        public int BatteryCapacity
        {
            get { return _batteryCapacity; }
            set
            {
                //if battery higher than 100 or lower than 0 sets to closer number
                if(value > 100)
                {
                    _batteryCapacity = 100;
                }
                else if(value < 0)
                {
                    _batteryCapacity = 0;
                }
                else
                {
                    _batteryCapacity = value;
                }
            }
        }
        //constructor for electric car
        public ElectricCar(string inMake, string inModel, int inYear) : base(inMake, inModel, inYear)
        {
            //sets battery capacity to -10
            BatteryCapacity = -10;
        }

        //charges the battery aka adds 10 to battery capacity
        public string ChargeBattery()
        {
            BatteryCapacity = BatteryCapacity + 10;
            return "Battery Charged";
        }
        //overrides tostring for next to no reason other than to test that we know how to do that
        public override string ToString()
        {
            string rString = base.ToString();
            rString = rString + $", {BatteryCapacity}";
            return rString;
        }
        //Random fuel efficency from the static class
        public override double CaculateFuelEfficiency()
        {
            return UtilityHelper.GenerateRandomNumber();
        }
    }
}
