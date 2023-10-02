using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public Employee(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public (decimal salary, decimal tax) CalculateSalary(string position, int experience)
        {

            decimal salary = 0;  // Оклад 
            decimal tax = 0;     // Податок

            // Розрахунок окладу та податка.

            if (position == "Менеджер")
            {
                decimal baseSalary = 30000;
                salary = experience >= 5 ? baseSalary + 5000 : baseSalary;
            }
            else if (position == "Програміст")
            {
                decimal baseSalary = 35000;
                salary = experience >= 5 ? baseSalary + 5000 : baseSalary;
            }
            else
            {
                decimal baseSalary = 25000;
                salary = experience >= 5 ? baseSalary + 5000 : baseSalary;
            }

            tax = 0.1m * salary;

            return (salary, tax);
        }

        public void DisplayInfo(string position, int experience)
        {
            (decimal salary, decimal tax) = CalculateSalary(position, experience);
            Console.WriteLine("Інформація про співробітника:");
            Console.WriteLine("Прізвище: " + LastName);
            Console.WriteLine("Ім'я: " + FirstName);
            Console.WriteLine("Посада: " + position);
            Console.WriteLine("Оклад: " + salary);
            Console.WriteLine("Податковий збір: " + tax);
        }
    }








}

