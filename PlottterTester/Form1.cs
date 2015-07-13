using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using FunctionPlotter;
using static System.Math;


namespace PlottterTester
{
    public partial class PlotForm : Form
    {
        public PlotForm()
        {
            InitializeComponent();
            var plotter = new Plotter(Cos, -2*PI, 2*PI, -3.5, 3.5);

            // optional -> adding function
            plotter.Functions.AddRange(new List<FunctionGraph> {
                new FunctionGraph { Function = Sin },
                new FunctionGraph { Function = x => Sin(20*x) + Sin(x), Color = Color.Purple },
                new FunctionGraph { Function = x => x * x * x },
                new FunctionGraph { Function = x => 2.5/(1+x*x), Color = Color.Green }
            });

            // draws the function
            plotter.Draw();
            plotBox.Image = plotter.Plot;
        }
    }
}
