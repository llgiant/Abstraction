using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Circle : IFigure
    {
        public Circle()
        {
            Radius = default;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; }

        public double  Area => Math.PI * Math.Pow(Radius, 2);
    }
}
