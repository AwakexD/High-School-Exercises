using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double defaultConsumption = 1.25;
        private double fuelConsumption;

        private int HoursePower { get; set; }
        public double Fuel { get; set; }

        public double DefaultFuelConsumption = defaultConsumption;

        public virtual double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public Vehicle(int hoursePower, int fuel)
        {
            this.HoursePower = hoursePower;
            this.Fuel = fuel;
            this.FuelConsumption = defaultConsumption;
        }

        public virtual void Drive(double kilometers)
        {
            this.Fuel = this.Fuel - ( kilometers * fuelConsumption);
        }
    }
}
