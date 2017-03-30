using System;

namespace tddkata
{
    public class FillMeasurer
    {
        public double Measure(Cube cube)
        {
            return Math.Pow(cube.Sidelength, 3);
        }
    }
}