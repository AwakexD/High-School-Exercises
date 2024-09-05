using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, double salary) : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<IPrivate>();
        }

        public IList<IPrivate> Privates { get; }

        public override string ToString()
        {
            return
                $"{base.ToString()}{Environment.NewLine}Privates:{Environment.NewLine + "  "}{string.Join(Environment.NewLine + "  ", this.Privates)}";
        }
    }
}
