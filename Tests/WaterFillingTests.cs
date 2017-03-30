using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using tddkata;

namespace Tests
{
    public class WaterFillingTests
    {
        [Test]
        public void ZeroDimensionCubeHoldsNoWater()
        {
            var emptyCube = Cube.Create(0);
            var fillMeasurer = new FillMeasurer();
            Assert.That(fillMeasurer.Measure(emptyCube), Is.Zero);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(1.5)]
        public void CubeHoldsCubeOfSideLengthWater(double sideLength)
        {
            var fillMeasurer = new FillMeasurer();
            var cube = Cube.Create(sideLength);
            Assert.That(fillMeasurer.Measure(cube), Is.EqualTo(Math.Pow(sideLength, 3)).Within(0.001));
        }

        [Test]
        public void ZeroDimensionCylinderHoldsNoWater()
        {
            var fillMeasurer = new FillMeasurer();
            var emptyCylinder = new Cylinder(0, 0);
            Assert.That(fillMeasurer.Measure(emptyCylinder), Is.Zero);
        }
    }
}
