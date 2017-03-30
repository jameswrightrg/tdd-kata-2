using System;

namespace tddkata
{
    public class FillMeasurer
    {
        public double Measure(IShape shape)
        {
            return shape.GetVolume();
        }
    }
}