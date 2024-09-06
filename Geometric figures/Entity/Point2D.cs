using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_figures.Entity
{
    public class Point2D
    {
        private double x;
        private double y;

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point2D(Point2D other)
        {
            this.x = other.x;
            this.y = other.y;
        }

        public double GetX() { return x; }
        public double GetY() { return y; }

        public void ShiftX(double shift) { x += shift; }

        public void ShiftY(double shift) { y += shift; }

        public void GetDistance(Point2D point) { }
    }
}
