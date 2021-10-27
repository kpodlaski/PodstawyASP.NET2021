using System;

namespace Figury
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My GARDEN");
            ComplexFigure garden = new ComplexFigure();
            garden.AddPositiveElement(new Rectangle(20, 20, 150, 60));
            garden.AddNegativeElement(new Rectangle(100, 40, 70, 20));
            Circle c = new Circle();
            garden.AddNegativeElement(c);
            garden.Draw();
            Console.WriteLine("Pole Ogrodu: " + garden.Field());
            Console.WriteLine("Obwód Ogrodu: " + garden.Perimeter());
            c.Scale(1.5);
            garden.Draw();
            Console.WriteLine("Pole Ogrodu: " + garden.Field());
            Console.WriteLine("Obwód Ogrodu: " + garden.Perimeter());
        }
    }
}
