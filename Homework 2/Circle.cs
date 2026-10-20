using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    public class Circle
    {
        private double x, y, r;

        public Circle(double x, double y, double r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }

        
        public double GetCircumference()
        {
            return 2 * Math.PI * r;
        }

        
        public double GetArea()
        {
            return Math.PI * r * r;
        }

        public void PrintInfoCircle()
        {
            Console.WriteLine($"Центр окружности: ({x}; {y}), радиус: {r}");
            Console.WriteLine($"Длина окружности: {GetCircumference():F3}");
            Console.WriteLine($"Площадь круга: {GetArea():F3}");
        }

    }
}
