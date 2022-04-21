using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    internal abstract class CircularFigure : Figure
    {
        public int Radio1 { get; set; }

        public CircularFigure(int radio)
        {
            this.Radio1 = radio;
        }
    }
}
