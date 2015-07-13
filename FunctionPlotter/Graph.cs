using System;
using System.Drawing;

namespace FunctionPlotter
{
    public class Graph
    {
        public Func<double, double> Function { get; set; }
        public Color Color;
    }
}