using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExercise
{
    public abstract class ColoredFigure
    {
        private string color;
        public double size;

        public ColoredFigure(string color, double size)
        {
            this.color = color;
            this.size = size;
        }

        public void Show()
        {
            Console.WriteLine($"Color: {color} \nSize: {size}");
        }

        public abstract void GetName();
        public abstract double GetArea();
    }
}
