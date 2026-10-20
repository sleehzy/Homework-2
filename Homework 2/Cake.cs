using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    public class Cake
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }


        public double Calories { get; }


        public string Composition { get; }


        public Cake(string name, double weight, double price, double calories, string composition)
        {
            Name = name;
            Weight = weight;
            Price = price;
            Calories = calories;
            Composition = composition;
        }


        public string Information
        {
            get
            {
                return $"Название: {Name}\nВес: {Weight} г\nЦена: {Price} руб.\n" +
                       $"Калорийность: {Calories} ккал\nСостав: {Composition}";
            }
        }
    }
    class MethodCake
    {
        private string _name;
        private double _weight;
        private double _price;
        private double _calories;
        private string _composition;

        public MethodCake(string name, double weight, double price, double calories, string composition)
        {
            _name = name;
            _weight = weight;
            _price = price;
            _calories = calories;
            _composition = composition;
        }

        
        public string GetName() { return _name; }
        public void SetName(string name) { _name = name; }

        public double GetWeight() { return _weight; }
        public void SetWeight(double weight) { _weight = weight; }

        public double GetPrice() { return _price; }
        public void SetPrice(double price) { _price = price; }

        public double GetCalories() { return _calories; } 

        public string GetComposition() { return _composition; } 

        
        public string GetInformation()
        {
            return $"Название: {_name}\nВес: {_weight} г\nЦена: {_price} руб.\n" +
                   $"Калорийность: {_calories} ккал\nСостав: {_composition}";
        }
    }
}
