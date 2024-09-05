using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double defaultConsumption = 10;

        public SportCar(int hoursePower, int fuel) : base(hoursePower, fuel)
        {

        }
    }
}
