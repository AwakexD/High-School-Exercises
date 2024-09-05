using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, double salary, string crops) : base(id, firstName, lastName, salary)
        {
            this.Crops = crops;
        }

        public string Crops { get; }

        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}Corps: {this.Crops}{Environment.NewLine}";
        }
    }
}
