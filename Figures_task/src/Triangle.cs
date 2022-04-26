using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_task.src
{
    public class Triangle : IFigure
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (!CheckTriangleExists(side1, side2, side3))
            {
                throw new ArgumentException("Such triangle does not exist.");
            }
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        private bool CheckTriangleExists(double side1, double side2, double side3)
        {
            return (side1 > 0) && (side2 > 0) && (side3 > 0) 
                && (side1 + side2 > side3) 
                && (side2 + side3 > side1) 
                && (side3 + side1 > side2);
        }

        public double Square()
        {
            double p = (side1 + side2 + side3) / 2;
            double square = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
            return square;
        }

        public bool IsRight()
        {
            if (side1 > side2 && side1 > side3)
            {
                return CheckIsRight(side1, side2, side3);
            } else if (side2 > side3 && side2 > side1)
            {
                return CheckIsRight(side2, side1, side3);
            } else
            {
                return CheckIsRight(side3, side1, side2);
            }
        }

        private bool CheckIsRight(double maxSide, double s2, double s3)
        {
            double h = Math.Pow(s2, 2) + Math.Pow(s3, 2);
            return EqualsDiff(Math.Pow(maxSide, 2), h);
        }

        private bool EqualsDiff(double d1, double d2, double eps = 0.00000001)
        {
            return (Math.Abs(d1 - d2) < eps);
        }
    }
}
