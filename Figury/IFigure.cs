using System;
using System.Collections.Generic;
using System.Text;

namespace Figury
{
    interface IFigure
    {
        double Field();
        double Perimeter();
        void Scale(double factor);
    }
}
