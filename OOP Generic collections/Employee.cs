using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Generic_collections
{
    internal class Employee
    {
        public int _Id { get; set; }
        public string _Name { get; set;}
        public string _Gender { get; set; }
        public decimal _Salary { get; set; }

        public Employee( int Id,string Name, string Gender,decimal Salary) 
        
        { 
            this._Id = Id;
            this._Name = Name;
            this._Gender = Gender;
            this._Salary = Salary;
           
        
        
           
        }

        public void Display() 
        {
            
            Console.WriteLine($"{_Id} - {_Name} - {_Gender} - {_Salary}");
        
        }

       
    }
}
