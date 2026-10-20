using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    public class Triangle
    {
        private double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

       
        public double GetPerimeter()
        {
            return a + b + c;
        }

       
        public void PrintInfo()
        {
            Console.WriteLine($"Стороны треугольника: a = {a}, b = {b}, c = {c}");
            Console.WriteLine($"Периметр треугольника: {GetPerimeter()}");
        }

    }
}
