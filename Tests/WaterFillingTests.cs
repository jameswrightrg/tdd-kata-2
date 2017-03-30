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
            var emptyCube = Cube.Create(0,0,0);
            var fillMeasurer = new FillMeasurer();
            Assert.That(fillMeasurer.Measure(emptyCube), Is.Zero);
        }
    }
}
