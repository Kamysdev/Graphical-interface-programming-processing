using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figures.Entity
{
    internal class Rectangle
    {
        private Point2D p1;
        private Point2D p2;
        private Point2D p3;
        private Point2D p4;

        public Rectangle(Point2D p1, Point2D p2, Point2D p3, Point2D p4)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }

        public Point2D GetPoint1() { return this.p1; }
        public Point2D GetPoint2() { return this.p2; }
        public Point2D GetPoint3() { return this.p3; }
        public Point2D GetPoint4() { return this.p4; }

        public void ShiftX(double shift) { p1.ShiftX(shift); p2.ShiftX(shift); p3.ShiftX(shift); p4.ShiftX(shift); }
        public void ShiftY(double shift) { p1.ShiftY(shift); p2.ShiftY(shift); p3.ShiftY(shift); p4.ShiftY(shift); }

        public double GetPerimeter()
        {
            double Aside = Math.Sqrt(Math.Pow(p2.GetX() - p1.GetX(), 2) + Math.Pow(p2.GetY() - p1.GetY(), 2));
            double Bside = Math.Sqrt(Math.Pow(p4.GetX() - p3.GetX(), 2) + Math.Pow(p4.GetY() - p3.GetY(), 2));

            return (Aside + Bside) * 2;
        }

        public double GetArea()
        {
            double Aside = Math.Sqrt(Math.Pow(p2.GetX() - p1.GetX(), 2) + Math.Pow(p2.GetY() - p1.GetY(), 2));
            double Bside = Math.Sqrt(Math.Pow(p4.GetX() - p3.GetX(), 2) + Math.Pow(p4.GetY() - p3.GetY(), 2));

            return Aside * Bside;
        }
    }
}
