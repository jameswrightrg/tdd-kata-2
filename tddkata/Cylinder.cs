using System;

namespace tddkata
{
    public class Cylinder : IShape
    {
        private double radius;
        private double length;

        public Cylinder(double radius, double length)
        {
            this.radius = radius;
            this.length = length;
        }

        public double GetVolume()
        {
            return Math.PI*Math.Pow(radius, 2)*length;
        }
    }
}