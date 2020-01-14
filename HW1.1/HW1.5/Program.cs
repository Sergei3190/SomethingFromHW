using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.\nб) Сделать задание, только вывод организуйте в центре экрана.\nв) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)\n\nЛысков С.\n\n ");

            string name = "Сергей";
            string surname = "Лысков";
            string city = "Химки";

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{name} {surname} {city} ");
            Print("Сергей", "Лысков", "Химки", 50, 10);

            string info = $"{name} {surname} {city} ";
            Print(info); // сделали перегрузку метода: наименование метода одинаково, параметры разные

            Console.ReadLine();

        }

        public static void Print(string text)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - text.Length / 2, Console.WindowHeight / 2);
            Console.WriteLine(text);
        }

        /// <summary>
        /// Метод вывода сообщения на заданные координаты консоли
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="city"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void Print(string name, string surname, string city, int x, int y)
        {
            Console.SetCursorPosition( x, y );
            Console.WriteLine($"{name} {surname} {city} ");
        }
    }
}
