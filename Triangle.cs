using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    internal class Triangle : Figure
    {
        public int Base { get; set; }
        public int Height { get; set; }

        public Triangle(int @base, int height)
        {
            this.Base = @base;
            this.Height = height;
        }

        public override double CalculateArea()
        {
            return Base * Height / 2;
        }
    }
}
