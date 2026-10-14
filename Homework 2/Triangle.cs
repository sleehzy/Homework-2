using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    public class Triangle
    {
        private double A;
        private double B;
        private double C;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double GetPerimeter()
        {
            return A + B + C;
        }

        public void Info()
        {
            Console.WriteLine("Стороны треугольника:");
            Console.WriteLine($" a = {A}");
            Console.WriteLine($" b = {B}");
            Console.WriteLine($" c = {C}");
            Console.WriteLine($"Периметр: {GetPerimeter()}");
        }

    }
}
