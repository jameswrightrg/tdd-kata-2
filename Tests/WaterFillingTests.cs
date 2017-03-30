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

        [Test]
        public void CubeOfUnitLengthHoldsWater()
        {
            var fillmeasurer = new FillMeasurer();
            var cube = Cube.Create(1);
            Assert.That(fillmeasurer.Measure(cube), Is.EqualTo(1).Within(0.001));
        }

        [TestCase(2)]
        public void CubeHoldsCubeOfSideLengthWater(int sideLength)
        {
            var fillMeasurer = new FillMeasurer();
            var cube = Cube.Create(sideLength);
            Assert.That(fillMeasurer.Measure(cube), Is.EqualTo(Math.Pow(sideLength, 3)).Within(0.001));
        }
    }
}
