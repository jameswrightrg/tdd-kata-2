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
    }
}
