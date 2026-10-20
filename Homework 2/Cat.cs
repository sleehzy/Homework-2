using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    public class Cat
    {
        public string Nickname { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        // Автоматическое свойство только для чтения (get;)
        public string Breed { get; }

        // Автоматическое свойство только для чтения (запрет записи)
        public string Owner { get; }

        // Конструктор
        public Cat(string nickname, string breed, double height, double weight, string owner)
        {
            Nickname = nickname;
            Breed = breed;
            Height = height;
            Weight = weight;
            Owner = owner;
        }

        // Вычисляемое свойство (только get)
        public string Information
        {
            get
            {
                return $"Кличка: {Nickname}\nПорода: {Breed}\nРост: {Height} см\n" +
                       $"Вес: {Weight} кг\nХозяин: {Owner}";
            }
        }
    }

    public class MethodCat
    {
        private string _nickname;
        private string _breed;
        private double _height;
        private double _weight;
        private string _owner;

        public MethodCat(string nickname, string breed, double height, double weight, string owner)
        {
            _nickname = nickname;
            _breed = breed;
            _height = height;
            _weight = weight;
            _owner = owner;
        }

        // Геттеры и сеттеры
        public string GetNickname() { return _nickname; }
        public void SetNickname(string nickname) { _nickname = nickname; }

        public double GetHeight() { return _height; }
        public void SetHeight(double height) { _height = height; }

        public double GetWeight() { return _weight; }
        public void SetWeight(double weight) { _weight = weight; }

        public string GetBreed() { return _breed; } // Только геттер

        public string GetOwner() { return _owner; } // Только геттер

        // Метод получения информации
        public string GetInformation()
        {
            return $"Кличка: {_nickname}\nПорода: {_breed}\nРост: {_height} см\n" +
                   $"Вес: {_weight} кг\nХозяин: {_owner}";
        }
    }

}

