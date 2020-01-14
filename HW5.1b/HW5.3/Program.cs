using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5._3
{
    class Program
    {
        /// <summary>
        /// метод сравнения строк 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        public static string Сomparison(string s1, string s2)
        {
            string text1 = "Cтроки НЕ являются перестановкой друг друга";
            string text2 = "Строки являются перестановкой друг друга";

            try
            {
                if (s1.Length == s2.Length)
                {
                    for (int j = 0; j < s2.Length; j++)
                    {
                        if (s1.Contains(s2[j]))
                        {
                            continue;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
                else
                {
                    throw new Exception();
                }
                return text2;

            }
            catch (Exception)
            {
                return text1;

            }
           


            //if (s1.Length == s2.Length)
            //{
            //    for (int j = 0; j < s2.Length; j++)
            //    {
            //        if (s1.Contains(s2[j]))
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{text}");
            //        }
            //        break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"{text1}");
            //}

        }

        static void Main(string[] args)
        {
            //*Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
            // Например:
            // badc являются перестановкой abcd.

            Console.WriteLine($"Введите строку 1: "); string s1 = Console.ReadLine();
            Console.WriteLine($"Введите строку 2: "); string s2 = Console.ReadLine();

            string res = Сomparison(s1, s2);

            Console.WriteLine(res);

            #region Ex1 - вариант №2 - LINQ
            //if(s1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToUpper).OrderBy(x => x)))
            //{
            //    Console.WriteLine($"Строки {s1} и {s2} являются перестановкой друг друга");

            //}
            //else
            //{
            //    Console.WriteLine($"Строки {s1} и {s2} НЕ являются перестановкой друг друга");
            //}
            #endregion

            Console.ReadKey();

        }  
    }
}
