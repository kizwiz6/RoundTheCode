using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RoundTheCode
{
    public abstract class Vehicle
    {
        public int Wheels { get; set; }
    }

    public class Car : Vehicle
    {
    }

    public class Motorbike : Vehicle
    {
    }

    public class Wheel
    {
        public int CountTotalWheels(Vehicle[] vehicles)
        {
            var wheelCount = 0;

            foreach (var vehicle in vehicles)
            {
                wheelCount+= vehicle.Wheels;
            }

            return wheelCount;
        }
    }
}
