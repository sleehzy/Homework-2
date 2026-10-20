namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Класс треугольника");
            Console.Write("Введите длину стороны a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите длину стороны b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите длину стороны c: ");
            double c = double.Parse(Console.ReadLine());

            Triangle t = new Triangle(a, b, c);
            t.PrintInfo();


            Console.WriteLine("Класс окружности");
            Console.Write("Введите координату X центра: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите координату Y центра: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Введите радиус окружности: ");
            double r = double.Parse(Console.ReadLine());

            Circle C = new Circle(x, y, r);
            C.PrintInfoCircle();

            Console.WriteLine("Класс пироженого");

            Console.Write("Введите название пирожного: ");
            string name = Console.ReadLine();
            Console.Write("Введите вес (г): ");
            double Cakeweight = double.Parse(Console.ReadLine());
            Console.Write("Введите цену (руб.): ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Введите калорийность (ккал): ");
            double calories = double.Parse(Console.ReadLine());
            Console.Write("Введите состав: ");
            string composition = Console.ReadLine();

            // Использование синтаксиса инициализации объектов из лекции (стр. 60)
            Cake cake1 = new Cake(name, Cakeweight, price, calories, composition);
            Console.WriteLine("--- Класс со свойствами ---");
            Console.WriteLine(cake1.Information);

            MethodCake cake2 = new MethodCake(name, Cakeweight, price, calories, composition);
            Console.WriteLine("--- Класс с методами ---");
            Console.WriteLine(cake2.GetInformation());

            Console.WriteLine("Класс Кота");
            Console.Write("Введите кличку котика: ");
            string nickname = Console.ReadLine();
            Console.Write("Введите породу: ");
            string breed = Console.ReadLine();
            Console.Write("Введите рост (см): ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Введите вес (кг): ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Введите имя хозяина: ");
            string owner = Console.ReadLine();

            Cat cat1 = new Cat(nickname, breed, height, weight, owner);
            Console.WriteLine("\n--- Класс со свойствами ---");
            Console.WriteLine(cat1.Information);

            MethodCat cat2 = new MethodCat(nickname, breed, height, weight, owner);
            Console.WriteLine("\n--- Класс с методами ---");
            Console.WriteLine(cat2.GetInformation());

            Console.WriteLine("Класс машины");
            Console.Write("Введите VIN-номер двигателя: ");
            string vin = Console.ReadLine();
            Console.Write("Введите марку: ");
            string brand = Console.ReadLine();
            Console.Write("Введите модель: ");
            string model = Console.ReadLine();
            Console.Write("Введите год выпуска: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Введите цвет: ");
            string color = Console.ReadLine();

            Car car = new Car(vin, brand, model, year, color);

            Console.WriteLine("\nИнформация о машине:");
            Console.WriteLine(car.Info);

            Console.Write("\nВведите фактический номер двигателя для сверки: ");
            string actualVin = Console.ReadLine();
            Console.WriteLine(car.CheckVin(actualVin));


            Console.WriteLine("Класс рабочего");
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            string HumanName = Console.ReadLine();
            Console.Write("Введите отчество: ");
            string patronymic = Console.ReadLine();
            Console.Write("Введите должность: ");
            string position = Console.ReadLine();
            Console.Write("Введите год принятия на работу: ");
            int hireYear = int.Parse(Console.ReadLine());

            Employee emp = new Employee(surname, name, patronymic, position, hireYear);

            Console.WriteLine("\nИнформация о сотруднике:");
            Console.WriteLine(emp.Info);

            Console.Write("\nВведите текущий год: ");
            int currentYear = int.Parse(Console.ReadLine());
            Console.WriteLine($"Стаж сотрудника: {emp.GetExperience(currentYear)} лет");

        }
    }
}
