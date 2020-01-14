using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._6
{
    class Program
    {
        public static int SumNumbers(int x)
        {
            int sum = 0;

            while (x > 0)
            {
                sum = sum + x % 10; // добавляем в сумму последнюю цифру числа "х", находя остаток от деления на 10
                x = x / 10; // проверям сколько цифр осталось в числе "x"

            }

            return sum;

        }

        static void Main(string[] args)
        {
            // Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.Хорошим называется число,
            //которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.
            //61574510

            int min = 1;
            int max = 1000000000;
            int goodNumbers = 0;

            DateTime start = DateTime.Now;

            #region
            for (int i = min; i <= max; i++)
            {
                int sum = SumNumbers(i);

                if (i % sum == 0)
                {
                    goodNumbers++;
                }
            }
            #endregion

            DateTime stop = DateTime.Now;

            Console.WriteLine("В диапазоне от {0} до {1} \"хороших\" чисел : {2}", min, max, goodNumbers);
            Console.WriteLine("{0:F2}", (stop - start).TotalSeconds) ;
            Console.ReadKey();
        }
    }
}
