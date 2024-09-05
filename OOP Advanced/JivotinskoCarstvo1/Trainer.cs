using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JivotinskoCarstvo1
{
    public class Trainer
    {
        public IAnimal Animal{ get; set; }

        public Trainer(IAnimal animla)
        {
            this.Animal = animla;
        }

        public void Make()
        {
            this.Animal.Perform();
        }
    }
}
