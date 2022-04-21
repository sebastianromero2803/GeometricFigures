﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    internal class Square : FiguraCuadrangular
    {
        public Square(int lado1) : base(lado1) { }
        public override double CalculateArea()
        {
            return Math.Pow(Lado1, 2);
        }
    }
}
