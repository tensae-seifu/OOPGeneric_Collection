using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a stack to store Employee objects
            Stack<Employee> emp = new Stack<Employee>();

            // Create five Employee objects
            Employee emp1 = new Employee(101, "Anna", "Female", 35000);
            Employee emp2 = new Employee(102, "Bernard", "Male", 45000);
            Employee emp3 = new Employee(103, "David", "Male", 28000);
            Employee emp4 = new Employee(104, "Sara", "Female", 39000);
            Employee emp5 = new Employee(105, "Hanna", "Female", 20000);

            // Push the Employee objects onto the stack
            emp.Push(emp1);
            emp.Push(emp2);
            emp.Push(emp3);
            emp.Push(emp4);
            emp.Push(emp5);

            // Display a header
            Console.WriteLine($"           Employees are");
            Console.WriteLine($"           =============\n\n");

            // Loop through the Employee objects in the stack and display them
            foreach (Employee e in emp)
            {
                e.Display();
                Console.WriteLine($"Remaining objects in the stack: {emp.Count}");
                Console.WriteLine();
            }

            Console.WriteLine("=========================================");

            // Create a copy of the original stack
            Stack<Employee> empCopy = new Stack<Employee>(emp);

            // Loop through the copied stack, popping items from the original stack
            foreach (Employee e in empCopy)
            {
                emp.Pop();
                e.Display();
                Console.WriteLine($"Remaining objects in the stack: {emp.Count}");
                Console.WriteLine();
            }
            Console.WriteLine("=========================================");

            // Restore the original stack by pushing the items from the copied stack back
            foreach (Employee e in empCopy)
            {
                emp.Push(e);
            }

            // Peek at the first two employees in the stack
            if (emp.Count >= 2)
            {
                Employee firstEmployee = emp.Peek(); // Peek at the first employee
                Employee secondEmployee = emp.Peek();

                // Since Peek doesn't remove the item from the stack, you need to pop it if you want to access the second item.

                if (emp.Count >= 1)
                {
                    secondEmployee = emp.Peek(); // Peek at the second employee
                }

                // Display the information of the first employee
                if (firstEmployee != null)
                {
                    Console.WriteLine("First Employee:");
                    firstEmployee.Display();
                }

                // Display the information of the second employee
                if (secondEmployee != null)
                {
                    Console.WriteLine("\nSecond Employee:");
                    secondEmployee.Display();
                }
            }
            else
            {
                Console.WriteLine("There are not enough employees in the stack to peek at.");
            }

            Console.WriteLine("=========================================");

            // Check if empCopy contains emp3
            bool contains = empCopy.Contains(emp3);

            if (contains)
            {
                Console.WriteLine($"Emp3 is in the stack");
            }
            else
            {
                Console.WriteLine($"Emp3 is NOT in the stack");
            }

            // Display a separator for the next section
            Console.WriteLine("\n\n\n");
            Console.WriteLine($"           ==============================");
            Console.WriteLine($"                      Del2 List");
            Console.WriteLine($"           ==============================\n\n\n");

            // Create a list to store Employee objects
            List<Employee> list = new List<Employee>();

            // Add Employee objects to the list
            list.Add(emp1);
            list.Add(emp2);
            list.Add(emp3);
            list.Add(emp4);
            list.Add(emp5);

            // Check if emp2 exists in the list
            contains = list.Contains(emp2);

            if (contains)
            {
                Console.WriteLine($"Employee 2 object exists in the list");
            }
            else
            {
                Console.WriteLine($"Employee 2 object DOES NOT exist in the list");
            }

            Console.WriteLine("\n\n");

            // Find the first male employee in the list
            Employee maleEmployee = list.Find(employee => employee._Gender == "Male");

            if (maleEmployee != null)
            {
                // Display the information of the found male employee
                maleEmployee.Display2();
            }

            Console.WriteLine("\n\n");

            // Find all male employees in the list
            List<Employee> maleEmployees = list.FindAll(employee => employee._Gender == "Male");

            // Iterate through the list of male employees and display their information
           foreach(Employee employee1 in maleEmployees) 
            {
                employee1.Display2();
            }

            Console.ReadLine(); // Pause execution until the user presses Enter
        }
    }
}
