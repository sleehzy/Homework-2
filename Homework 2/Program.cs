namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Triangle = new Triangle(3, 4, 6);


            Triangle.Info();


            Console.WriteLine("Класс окружности");
                Console.Write("Введите координату X центра: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите координату Y центра: ");
                double y = double.Parse(Console.ReadLine());
                Console.Write("Введите радиус окружности: ");
                double r = double.Parse(Console.ReadLine());

                Circle c = new Circle(x, y, r);
                c.PrintInfo();
            

        }
    }
}
