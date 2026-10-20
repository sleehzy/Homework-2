using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
   public struct Employee
   {
        public string Surname;
        public string Name;
        public string Patronymic;
        public string Position;
        public int HireYear;

        public Employee(string surname, string name, string patronymic, string position, int hireYear)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Position = position;
            HireYear = hireYear;
        }

        public string Info
        {
            get
            {
                return $"ФИО: {Surname} {Name} {Patronymic}\nДолжность: {Position}\n" +
                       $"Год принятия на работу: {HireYear}";
            }
        }

        
        public int GetExperience(int currentYear)
        {
            return currentYear - HireYear;
        }

   }
}
