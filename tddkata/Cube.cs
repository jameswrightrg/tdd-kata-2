using System;

namespace tddkata
{
    public class Cube : IShape
    {
        private double Sidelength { get; }

        private Cube(double sidelength)
        {
            Sidelength = sidelength;
        }

        public static Cube Create(double sidelength)
        {
            return new Cube(sidelength);
        }

        public double GetVolume()
        {
            return Math.Pow(Sidelength, 3);
        }
    }
}