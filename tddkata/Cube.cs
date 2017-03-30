using System;

namespace tddkata
{
    public class Cube
    {
        public int Sidelength { get; }

        private Cube(int sidelength)
        {
            Sidelength = sidelength;
        }

        public static Cube Create(int sidelength)
        {
            return new Cube(sidelength);
        }
    }
}