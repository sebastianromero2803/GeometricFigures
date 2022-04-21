using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    internal interface IFigureWithSide
    {
        public int Base { get; set; }
        public int Height { get; set; }

        public decimal CalculateArea();
    }
}
