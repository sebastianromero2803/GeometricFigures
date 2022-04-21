using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    internal class Rectangle : FiguraCuadrangular
    {
        public int Lado2 { get; set; }

        public Rectangle(int lado1, int lado2) : base(lado1) 
        {
            this.Lado2 = lado2;
        }

        public override double CalculateArea()
        {
            return Lado1 * Lado2;
        }


    }
}
