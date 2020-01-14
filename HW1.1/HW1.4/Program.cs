using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Написать программу обмена значениями двух переменны\n\nЛысков С.\n");

            int a = 5;
            int b = 3;

            Console.WriteLine($"a = {a}, b = {b}\n");

            Console.WriteLine("С использованием третьей переменной: ");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("a = {0}, b = {1}\n", a, b);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*без использования третьей переменной: ");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a = {a}, b = {b} ");
            Console.ReadKey();
        
        }
    }
}
