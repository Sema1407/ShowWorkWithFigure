using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;

namespace TestFigures {

    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void calcCircleSquare_Testmethod_calcSquare() {

            Circle c = new Circle(65);
            double res = c.calcSquare();
            double expected = 4225*Math.PI;
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void CreateCircleObject_inputNegativeRadius() {

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Circle(-5));

        }

        [TestMethod]
        public void tringaleSquare_testMetodcalcSquare() {

            Triangle t = new Triangle(5, 6, 8);
            double res = t.calcSquare();

            double expected = Math.Sqrt(224.4375);
            
            Assert.AreEqual(expected, res);

        }

        [TestMethod]
        public void CreateTriangleObject_inputNegativeSides() {

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(5, 6, -8));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(5, -6, 8));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Triangle(-5, 6, 8));

        }

        [TestMethod]
        public void checkTringaleProperty_Istrue() {

            Triangle tr = new Triangle(8,6,10);

            Assert.IsTrue(tr.IsRectangular);

        }

        [TestMethod]
        public void checkTringaleProperty_IsFalse() {

            Triangle tr = new Triangle(8, 3, 15);

            Assert.IsFalse(tr.IsRectangular);

        }
    }
}
