using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Midterm
{
    public class GasCar : Vehicle
    {
        //constructor for gas car
        public GasCar(string inMake, string inModel, int inYear) : base(inMake, inModel, inYear)
        {
        }
        //random fuel efficiency from the static class
        public override double CaculateFuelEfficiency()
        {
            return UtilityHelper.GenerateRandomNumber();
        }
    }
}
