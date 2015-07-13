using System;
using System.Collections.Generic;

namespace FunctionPlotter
{
    public static class Extensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> doWorkWith)
        {
            foreach (T item in source)
                doWorkWith(item);
        }
    }
}
