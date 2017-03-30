using System;

namespace tddkata
{
    public class Cylinder : IShape
    {
        private int radius;
        private int length;

        public Cylinder(int radius, int length)
        {
            this.radius = radius;
            this.length = length;
        }

        public double GetVolume()
        {
            return Math.PI*radius;
        }
    }
}