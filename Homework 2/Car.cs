using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    public class Car
    {
        public string Vin;
        public string Brand;
        public string Model;
        public int Year;
        public string Color;

        public Car(string vin, string brand, string model, int year, string color)
        {
            Vin = vin;
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
        }

        // Свойство Info
        public string Info
        {
            get
            {
                return $"VIN: {Vin}\nМарка: {Brand}\nМодель: {Model}\n" +
                       $"Год выпуска: {Year}\nЦвет: {Color}";
            }
        }

        // Метод сверки номера двигателя
        public string CheckVin(string actualVin)
        {
            if (actualVin == Vin)
                return "Номер двигателя совпадает.";
            else
                return "ВНИМАНИЕ! Номер двигателя НЕ совпадает!";
        }
    }
}
