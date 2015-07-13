using System;
using System.Drawing;

namespace FunctionPlotter
{
    public class FunctionGraph
    {
        public Func<double, double> Function { get; set; }
        public Color Color;
    }
}