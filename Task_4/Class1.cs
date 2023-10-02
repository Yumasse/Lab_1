using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class User
    {
        public string Login { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public DateTime RegistrationDate { get; }

        public User(string login, string firstName, string lastName, int age)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;

            RegistrationDate = DateTime.Now; 
        }

        public void DisplayUserInfo()
        {
            Console.WriteLine("Логін: " + Login);
            Console.WriteLine("Ім'я: " + FirstName);
            Console.WriteLine("Прізвище: " + LastName);
            Console.WriteLine("Вік: " + Age);
            Console.WriteLine("Дата заповнення анкети: " + RegistrationDate);
        }
    }
}


