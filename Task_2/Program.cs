using System;
using System.Runtime.InteropServices;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Виберіть опцію:");
            Console.WriteLine("1) hrn to usd");
            Console.WriteLine("2) hrn to eur");
            Console.WriteLine("3) hrn to pln");
            Console.WriteLine("4) usd to hrn");
            Console.WriteLine("5) eur to hrn");
            Console.WriteLine("6) pln to hrn");

            string operationChoice = Console.ReadLine();


            if (operationChoice == "1" || operationChoice == "2" || operationChoice == "3" || operationChoice == "4" || operationChoice == "5" || operationChoice == "6")
            {
                Converter money = new Converter(40, 41, 8, 1);

                Console.WriteLine("Введiть суму:");


                if (double.TryParse(Console.ReadLine(), out double number))
                {
                    double result = 0;

                    switch (operationChoice)
                    {
                        case "1":

                            result = money.MethodUsd(number, 40, 1);
                            Console.WriteLine($"Ваш результат {number} грн на USD: {result}");
                            break;
                        case "2":
                            result = money.MethodEur(number, 41, 1);
                            Console.WriteLine($"Ваш результат {number} грн на EUR: {result}");
                            break;
                        case "3":
                            result = money.MethodPln(number, 8, 1);
                            Console.WriteLine($"Ваш результат {number} грн на PLN: {result}");
                            break;

                            //To

                        case "4":
                            result = money.MethodToUsd(number, 40, 1);
                            Console.WriteLine($"Ваш результат {number} usd на грн: {result}");
                            break;
                        case "5":
                            result = money.MethodToEur(number,41, 1);
                            Console.WriteLine($"Ваш результат {number} eur на грн: {result}");
                            break;
                        case "6":
                            result = money.MethodToPln(number, 8, 1);
                            Console.WriteLine($"Ваш результат {number} pln на грн: {result}");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Не то");
                }
            }
            else
            {
                Console.WriteLine("Не то");
            } 
        }
    }
}