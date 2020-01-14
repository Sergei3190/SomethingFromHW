using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
            // Лысков С.

            int tryCount = 1;
            int maxTryCount = 3;

            do
            {
                Console.Write("Введите логин: "); string userLog = Console.ReadLine();
                Console.Write("Введите пароль: "); string userPassw = Console.ReadLine();

                // логин и пароль user 
                string login = "root";
                string password = "GeekBrains";

                Console.WriteLine(((userLog == login) && (userPassw == password)) ? "Вы прошли авторизацию " : "Вы не прошли авторизацию. Осталось " + (maxTryCount - tryCount) + " попыток ");
                tryCount++;

            } while (tryCount <= maxTryCount);


            Console.ReadKey();

        }
    }
}
