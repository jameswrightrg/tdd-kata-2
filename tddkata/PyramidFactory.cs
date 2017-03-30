namespace tddkata
{
    public class PyramidFactory
    {
        private class Pyramid : IShape
        {
            private int m_SideLength;
            private int m_Height;

            public Pyramid(int sideLength, int height)
            {
                this.m_SideLength = sideLength;
                this.m_Height = height;
            }

            public double GetVolume()
            {
                return m_Height / 6.0;
            }
        }

        public static IShape Create(int sideLength, int height)
        {
            return new Pyramid(sideLength, height);
        }
    }
}