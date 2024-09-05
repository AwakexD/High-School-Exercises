using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double defaultConsumption = 8;

        public override double FuelConsumption { get => base.FuelConsumption; set => base.FuelConsumption = value; }
        public RaceMotorcycle(int hoursePower, int fuel) : base(hoursePower, fuel)
        {

        }
    }
}
