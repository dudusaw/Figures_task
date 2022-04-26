using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_task.src
{
    public class Circle : IFigure
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentException("wrong radius");
            this.radius = radius;
        }

        public double Square()
        {
            return Math.PI * radius * radius;
        }
    }
}
