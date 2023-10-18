using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Employee emp1 = new Employee(101, "Anna", "Female", 35000);
            Employee emp2 = new Employee(102, "Bernard", "Male", 45000);
            Employee emp3 = new Employee(103, "David", "Male", 28000);
            Employee emp4 = new Employee(104, "Sara", "Female", 39000);
            Employee emp5 = new Employee(105, "Hanna", "Female", 20000);

            Stack<Employee> emp = new Stack<Employee>();

            emp.Push(emp1);
            emp.Push(emp2);
            emp.Push(emp3);
            emp.Push(emp4);
            emp.Push(emp5);


            Console.WriteLine("Employees are");
            Console.WriteLine("=============\n\n");

            foreach (Employee e in emp)
            {

                e.Display();
                Console.WriteLine($"Remaining objects in the stack: {emp.Count}");
                Console.WriteLine();
            }

            Console.WriteLine("=================================\n");

            Stack<Employee> empCopy = new Stack<Employee>(emp);

            foreach (Employee e in empCopy)
            {
                emp.Pop();
                e.Display();
                Console.WriteLine($"Remaining objects in the stack: {emp.Count}");
                Console.WriteLine();
            }
            Console.WriteLine("================================\n");

            foreach (Employee e in empCopy)

            {
                emp.Push(e);


            }

          
            for (int i = 0; i < 2; i++)
            {
                if (emp.Count > 0)
                {
                    Employee employee = emp.Peek();
                    employee.Display();
                  
                }
               
            }

            Console.WriteLine("\n\n");
            bool contains = emp.Contains(emp3);

            if (contains)
            {

                Console.WriteLine($"Emp 3 is in the stack\n");
            }
            else
            {
                Console.WriteLine($"Emp 3 is NOT in the stack\n");
            }


            Console.WriteLine("========Del2==================\n\n");

            List<Employee> empList = new List<Employee>(emp);





            contains = empList.Contains(emp3);

            if (contains)

            {
                Console.WriteLine("Emp 3 finns i stacken\n");
            }
            else
            {

                Console.WriteLine("Emp 3 finns inte i stacken\n");
            }
            Console.WriteLine("===============================\n");

            Employee maleEmplyee = empList.Find(male => male._Gender == "Male");

            if (maleEmplyee != null)

            {
                maleEmplyee.Display2();
                Console.WriteLine("\n");

            }

            List<Employee> maleEmplyee2 = empList.FindAll(male => male._Gender == "Male");

            foreach (Employee e in maleEmplyee2)

            {

                e.Display2();
                Console.WriteLine("\n");
            }


            Console.ReadLine();

        }
    }
}
