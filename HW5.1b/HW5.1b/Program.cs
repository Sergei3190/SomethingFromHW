using System;
using System.Text.RegularExpressions;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._1b
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов,
            //содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
            //б) **с использованием регулярных выражений.

            Regex Login = new Regex(@"[A-Za-z]{1}[A-Za-z]{1,9}$|[A-Za-z]{1}\d{1,9}$");

            Console.Write("Введите логин: "); string login = Console.ReadLine();

            if (Login.IsMatch(login))
            {
                Console.WriteLine($"Логин введён корректно");
            }
            else
            {
                Console.WriteLine($"Логин введён некорректно");
            } 

            Console.ReadKey();

        }
    }
}
