using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Triangle : IFigure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double Area
        {
            get
            {
                double p = (SideA + SideB + SideC) / 2;
                return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            }
        }
        public Triangle()
        {
            SideA = SideB = SideC = default;
        }
        public Triangle(double a,double b,double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }
        public bool IsRight()
        {
            return SideA == GetSqrt(SideB, SideC)
                || SideB == GetSqrt(SideA, SideC)
                || SideC == GetSqrt(SideA, SideB);
        }

        private double GetSqrt(double side1, double side2)
        {
            return Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));
        }
    }
}

