using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace PatikaWeek4PracticeInheritance
{
    public class BaseKisi // Creating a new base class
    {
        public string Ad { get; set; } // Setting 2 common properties

        public string Soyad { get; set; }

        public void DisplayFullName() // Method to call full name
        {
            Console.WriteLine($"Tüm ad: {Ad} {Soyad}");
        }

    }

    public class Ogrenci : BaseKisi // Creating a new class that inherits from a base class
    {
        public int StudentNumber { get; set; } // Setting a new property for this class

        public void DisplayFullNameAndNumber() // Method that display full name and student number
        {
            DisplayFullName();
            Console.WriteLine($"Öğrenci Numarası: {StudentNumber}");
        }

    }

    public class Ogretmen : BaseKisi // Creating a new class that inherits from a base class
    {
        public decimal Salary { get; set; } // Setting a new property for this class

        public void DisplayFullNameAndSalary() // Method that display full name and salary
        {
            DisplayFullName();
            Console.WriteLine($"Öğretmenin Maaşı: {Salary} TL");
        }
    }
}
