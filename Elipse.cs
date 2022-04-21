using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    internal class Elipse : CircularFigure
    {
        public int Radio2 { get; set; }
        public Elipse(int radio, int radio2) : base(radio)
        {
            this.Radio2 = radio2;
        }

        public override double CalculateArea()
        {
            return Radio1 * Radio2 * Math.PI;
        }
    }
}
