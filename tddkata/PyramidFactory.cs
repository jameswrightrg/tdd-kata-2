namespace tddkata
{
    public class PyramidFactory
    {
        private class Pyramid : IShape
        {
            private double m_SideLength;
            private double m_Height;

            public Pyramid(double sideLength, double height)
            {
                this.m_SideLength = sideLength;
                this.m_Height = height;
            }

            public double GetVolume()
            {
                return m_Height * m_SideLength / 6.0;
            }
        }

        public static IShape Create(double sideLength, double height)
        {
            return new Pyramid(sideLength, height);
        }
    }
}