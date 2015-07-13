# Function Plotter
A simple library to plot functions, written in C#.

# Usage
To generate a Bitmap for f(x) = cos(x) where the x-range = [-2pi, 2p] and the y-range = [-3.5, 3.5]

    var plotter = new Plotter(Cos, -2*PI, 2*PI, -3.5, 3.5);
    plotter.Draw();
    plotBox.Image = plotter.Plot;

# Adding more function to the same plot with optional colors
    plotter.Functions.AddRange(new List<FunctionGraph> {
        new FunctionGraph { Function = Sin },
        new FunctionGraph { Function = x => Sin(20*x) + Sin(x), Color = Color.Purple },
        new FunctionGraph { Function = x => x * x * x },
        new FunctionGraph { Function = x => 2.5/(1+x*x), Color = Color.Green }
    });
