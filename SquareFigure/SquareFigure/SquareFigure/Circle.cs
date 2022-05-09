using System;
using Figures;

namespace Figures {

    public class Circle : ISquareable {

        private double radius;
        public double Radius { get { return radius; } }

        public Circle(double radius) {

            if (radius < 0) {
                throw new ArgumentOutOfRangeException("Радиус не может быть меньше 0");
            }
            else {
                this.radius = radius;
            }

        }

        public double calcSquare() {
            return Math.PI * Math.Pow(radius, 2);
        }
    }

}
