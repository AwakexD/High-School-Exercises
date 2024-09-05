using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, double salary, string crops) : base(id, firstName, lastName, salary, crops)
        {
            this.Missions = new List<IMissions>();
        }

        public List<IMissions> Missions { get; }

        public override string ToString()
        {
            return $"{base.ToString()}Missions:{Environment.NewLine + "  "}{string.Join(Environment.NewLine + "  ", this.Missions)}".Trim();
        }
    }
}
