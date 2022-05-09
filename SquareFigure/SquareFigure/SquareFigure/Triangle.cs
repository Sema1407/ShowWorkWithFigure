using System;
using System.Collections.Generic;
using Figures;

namespace Figures {

    public class Triangle : ISquareable {

        //sides
        private double a;
        public double A { get { return a; } }
        private double b;
        public double B { get { return b; } }
        private double c;
        public double C { get { return c; } }


        public bool IsRectangular {
            get {
                if
                    ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a)) {
                    return true;

                } else {
                    return false;
                }
            }
        }

        public Triangle(double a, double b, double c) {

            Dictionary<string, double> sides = new Dictionary<string, double>();
            sides.Add(nameof(a), a);
            sides.Add(nameof(b), b);
            sides.Add(nameof(c), c);

            foreach (KeyValuePair<string, double> keyValue in sides) {

                if (keyValue.Value < 0) {
                    throw new ArgumentOutOfRangeException(nameof(keyValue.Key), "Значение не может быть меньше 0");
                }
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double calcSquare() {

            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;

        }

    }

}
