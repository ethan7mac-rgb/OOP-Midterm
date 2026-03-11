using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Midterm
{
    public static class UtilityHelper
    {
        //a very cool random number generated
        public static double GenerateRandomNumber()
        {
            Random rand = new Random();
            return rand.Next(0, 100);
        }
    }
}
