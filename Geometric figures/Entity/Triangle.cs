using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figures.Entity
{
    internal class Triangle
    {
        private Point2D p1;
        private Point2D p2;
        private Point2D p3;

        public Triangle(Point2D p1, Point2D p2, Point2D p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public Point2D GetPoint1() { return this.p1; }
        public Point2D GetPoint2() { return this.p2; }
        public Point2D GetPoint3() { return this.p3; }

        public void ShiftX(double shift) { p1.ShiftX(shift); p2.ShiftX(shift); p3.ShiftX(shift); }
        public void ShiftY(double shift) { p1.ShiftY(shift); p2.ShiftY(shift); p3.ShiftY(shift); }

        public double GetPerimeter()
        {
            double Aside = Math.Sqrt(Math.Pow(p2.GetX() - p1.GetX(), 2) + Math.Pow(p2.GetY() - p1.GetY(), 2));
            double Bside = Math.Sqrt(Math.Pow(p3.GetX() - p2.GetX(), 2) + Math.Pow(p3.GetY() - p2.GetY(), 2));
            double Сside = Math.Sqrt(Math.Pow(p1.GetX() - p3.GetX(), 2) + Math.Pow(p1.GetY() - p3.GetY(), 2));

            return Aside + Bside + Сside;
        }

        public double GetArea()
        {
            double p = GetPerimeter() / 2;

            return Math.Sqrt(p * (p - Math.Sqrt(Math.Pow(p2.GetX() - p1.GetX(), 2) + Math.Pow(p2.GetY() - p1.GetY(), 2)))
                                * (p - Math.Sqrt(Math.Pow(p3.GetX() - p2.GetX(), 2) + Math.Pow(p3.GetY() - p2.GetY(), 2)))
                                * (p - Math.Sqrt(Math.Pow(p1.GetX() - p3.GetX(), 2) + Math.Pow(p1.GetY() - p3.GetY(), 2))));
        }
    }
}
