using System;
using System.Net;
using System.Xml.Linq;

            Converter converter = new Converter(27.50, 33.00, 7.50); // Курси валют відносно гривні

            double amountInUah = 1000.0;

            // Конвертація гривні в інші валюти
            double amountInUsd = converter.UahToUsd(amountInUah);
            double amountInEur = converter.UahToEur(amountInUah);
            double amountInPln = converter.UahToPln(amountInUah);

            Console.WriteLine($"1000 UAH = {amountInUsd} USD");
            Console.WriteLine($"1000 UAH = {amountInEur} EUR");
            Console.WriteLine($"1000 UAH = {amountInPln} PLN");

            // Конвертація інших валют у гривню
            double amountInUah2 = converter.UsdToUah(100);
            double amountInUah3 = converter.EurToUah(100);
            double amountInUah4 = converter.PlnToUah(100);

            Console.WriteLine($"100 USD = {amountInUah2} UAH");
            Console.WriteLine($"100 EUR = {amountInUah3} UAH");
            Console.WriteLine($"100 PLN = {amountInUah4} UAH");




 

