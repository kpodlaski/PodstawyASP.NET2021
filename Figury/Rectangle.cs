using System;
using System.Collections.Generic;
using System.Text;

namespace Figury
{
    class Rectangle : IGraphicObject, IFigure
    {
        public Rectangle(double v1, double v2, double v3, double v4)
        {
            X = v1;
            Y = v2;
            Width = v3;
            Height = v4;
        }

        public double X { get; private set; }
        public double Y { get; private set; }
        public double Width { get; private set; }
        public double Height { get; private set; };


        public void Draw()
        {
            Console.WriteLine("Rysuję Prostkąt w p. (" + X + "," + Y+")");
        }

        public double Field()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return 2 * (Width + Height);
        }

        public void Scale(double factor)
        {
            Width *= factor;
            Height *= factor;
        }

        public void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }
    }
}
