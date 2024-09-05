using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double defaultConsumption = 3;
        public override double FuelConsumption { get => base.FuelConsumption; set => base.FuelConsumption = value; }

        public Car(int hoursePower, int fuel) : base(hoursePower, fuel)
        {
            this.FuelConsumption = defaultConsumption;
        }
    }
}
