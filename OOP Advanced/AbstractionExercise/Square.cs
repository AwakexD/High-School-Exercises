using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExercise
{
    public class Square : ColoredFigure
    {
        public Square(string color, double size) : base(color, size)
        {
        }

        public override void GetName()
        {
            Console.WriteLine($"Name: {this.GetType()}");
        }

        public override double GetArea()
        {
            return Math.Pow(base.size, 2.0);
        }
    }
}
