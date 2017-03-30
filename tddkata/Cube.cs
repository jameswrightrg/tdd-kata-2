using System;

namespace tddkata
{
    public class Cube
    {
        public double Sidelength { get; }

        private Cube(double sidelength)
        {
            Sidelength = sidelength;
        }

        public static Cube Create(double sidelength)
        {
            return new Cube(sidelength);
        }
    }
}