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
            Assert.That(MeasureShape(emptyCube), Is.Zero);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(1.5)]
        public void CubeHoldsCubeOfSideLengthWater(double sideLength)
        {
            var cube = Cube.Create(sideLength);
            Assert.That(MeasureShape(cube), Is.EqualTo(Math.Pow(sideLength, 3)).Within(0.001));
        }

        [Test]
        public void ZeroDimensionCylinderHoldsNoWater()
        {
            var emptyCylinder = new Cylinder(0, 0);
            Assert.That(MeasureShape(emptyCylinder), Is.Zero);
        }

        [Test]
        public void UnitLengthAndRadiusCylinderHoldsPi()
        {
            IShape unitCylinder = new Cylinder(1, 1);
            Assert.That(MeasureShape(unitCylinder), Is.EqualTo(Math.PI).Within(0.00001));
        }

        private static double MeasureShape(IShape shape)
        {
            return new FillMeasurer().Measure(shape);
        }
    }
}
