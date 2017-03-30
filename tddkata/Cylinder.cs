using System;

namespace tddkata
{
    public class Cylinder : IShape
    {
        private double radius;
        private int length;

        public Cylinder(double radius, int length)
        {
            this.radius = radius;
            this.length = length;
        }

        public double GetVolume()
        {
            return Math.PI*Math.Pow(radius, 2);
        }
    }
}