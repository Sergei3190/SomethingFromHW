using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            // Лысков С.

            int sum = 0;

            while (true)
            {
                Console.Write("Введите число: "); int a = Convert.ToInt32(Console.ReadLine());

                if (a == 0)
                {
                    break;
                }
                else if (a % 2 != 0 && a >= 0)
                {
                    sum += a;
                }

            }

            Console.WriteLine($"Сумма всех введенных нечетных и положительных чисел равна: {sum}");

            Console.ReadKey();
        }
    }
}
