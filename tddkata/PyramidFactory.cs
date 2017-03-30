namespace tddkata
{
    public class PyramidFactory
    {
        private class Pyramid : IShape
        {
            public double GetVolume()
            {
                return 0;
            }
        }
        public static IShape Create(int i, int i1)
        {
            return new Pyramid();
        }
    }
}