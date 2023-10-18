using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Generic_collections
{
    internal class Employee
    {
        // Properties to store employee information
        public int _Id { get; set; }
        public string _Name { get; set; }
        public string _Gender { get; set; }
        public decimal _Salary { get; set; }

        // Constructor to initialize employee properties
        public Employee(int Id, string Name, string Gender, decimal Salary)
        {
            this._Id = Id;
            this._Name = Name;
            this._Gender = Gender;
            this._Salary = Salary;
        }

        // Display method to print employee information to the console
        public void Display()
        {
            Console.WriteLine($"{_Id} - {_Name} - {_Gender} - {_Salary}");
        }

        // An additional Display2 method with a different format
        public void Display2()
        {
            Console.WriteLine($"ID = {_Id}, Name = {_Name}, Gender = {_Gender}, Salary = {_Salary}");
        }
    }
}
