using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    internal class Circle : CircularFigure
    {
        public Circle(int radio) : base(radio) { }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radio1, 2);
        }
    }
}
