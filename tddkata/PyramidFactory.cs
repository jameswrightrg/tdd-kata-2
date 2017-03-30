using System;
using System.Net.Sockets;

namespace tddkata
{
    public class PyramidFactory
    {
        private class Pyramid : IShape
        {
            private readonly double m_SideLength;
            private readonly double m_Height;
            private readonly int m_Sides;

            public Pyramid(double sideLength, double height, int sides)
            {
                m_SideLength = sideLength;
                m_Height = height;
                m_Sides = sides;
            }

            public double GetVolume()
            {
                switch (m_Sides)
                {
                    case 3:
                        return m_Height*Math.Pow(m_SideLength, 2)/6.0;
                    case 4:
                        return m_Height*Math.Pow(m_SideLength, 2)/3.0;
                    case 5:
                        return m_Height*Math.Pow(m_SideLength, 2)*1.72048/3.0;
                    default:
                        return 0;
                }
            }
        }

        public static IShape Create(double sideLength, double height, int sides = 3)
        {
            return new Pyramid(sideLength, height, sides);
        }
    }
}