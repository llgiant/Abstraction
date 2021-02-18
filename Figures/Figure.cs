using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Figure : IFigure
    {
        private IFigure figure;     
        public double Area => figure.Area;

      public Figure(IFigure figure)
        {
            this.figure = figure;
        }

    }
}
