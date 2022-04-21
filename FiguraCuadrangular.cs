using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    internal abstract class FiguraCuadrangular : Figure
    {
        public int Lado1 { get; set; }

        public FiguraCuadrangular(int lado1)
        {
            this.Lado1 = lado1;
        }
    }
}
