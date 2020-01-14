using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать метод подсчета количества цифр числа. Лысков С.

            Console.Write("введите число: "); int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Convert.ToInt32(Math.Log10(a) + 1));

            int count = Counter(a);

            Console.WriteLine($"Количество цифр в числе: {count} ");

            Console.ReadKey();

        }

        /// <summary>
        /// Метод подсчета количества цифр в числе 
        /// </summary>
        /// <param name="x">вводное число</param>
        /// <returns></returns>
        private static int Counter(int x)
        {
            int counter = 0;

            while (x != 0)
            {
                counter++;
                x = x / 10; // тк  int целочисленный тип данных, то при делении на 10, дробная часть будет отсекаться
            }

            return counter;
        }
    }
}


