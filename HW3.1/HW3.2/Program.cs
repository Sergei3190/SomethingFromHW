using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3._2
{
    class Program
    {
        //2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных 
        //положительных чисел.Сами числа и сумму вывести на экран, используя tryParse;
        //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
        //При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;

        static string Console_message = "Введите число:";

        static void Catch(string s)
        {
            if (!Int32.TryParse(s, out int a))
            {
                throw new FormatException();
                //throw new Exception();
            }
        }

        static void Main(string[] args)
        {
            int sum = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine(Console_message);
                    string input = Console.ReadLine();
                    bool flag = (Int32.TryParse(input, out int a));
                    if (flag)
                    {
                        Console.WriteLine($"Вы ввели верный формат числа: {input}");

                        if (a == 0)
                        {
                            break;
                        }
                        else if (a % 2 != 0 && a >= 0)
                        {
                            sum += a;
                        }
                    }
                    else Catch(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введён неверный формат числа, попробуйте ещё раз");

                }
                finally // гарантирует выполнение программы без аварийного выхода
                {
                    Console.WriteLine("продолжаем выполнение программы");
                }
            }

            Console.WriteLine($"Сумма всех введенных нечетных и положительных чисел равна: {sum} ");
            Console.ReadKey();

            #region Ex1 

            //int sum = 0;

            //while (true)
            //{
            //    Console.WriteLine(Console_message);

            //    string input = Console.ReadLine();

            //    if (Int32.TryParse(input, out int a))
            //    {
            //        Console.WriteLine($"Вы ввели верный формат числа: {input}");

            //        if (a == 0)
            //        {
            //            break;
            //        }

            //        else if (a % 2 != 0 && a >= 0)
            //        {
            //            sum += a;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Введён неверный формат числа, попробуйте ещё раз");
            //    }
            //}

            //Console.WriteLine($"Сумма всех введенных нечетных и положительных чисел равна: {sum}");

            //Console.ReadKey();
            #endregion
        }
    }
}
