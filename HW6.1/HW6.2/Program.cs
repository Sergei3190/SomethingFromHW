using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6._2
{
    /// <summary>
    /// Описываем делегат
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public delegate double Fun(double x);

    class Program
    {

        /// <summary>
        /// метод вызова функции ax^2 + bx + c
        /// </summary>
        /// <param name="x">координата</param>
        /// <returns></returns>
        public static double F1(double x)
        {
            return x * x - 50 * x + 10;
        }

        /// <summary>
        /// метод вызова функции x^2
        /// </summary>
        /// <param name="x">координата</param>
        /// <returns></returns>
        public static double F2(double x)
        {
            return x * x;
        }

        /// <summary>
        /// метод вызова функции Cos(x)
        /// </summary>
        /// <param name="x">координата</param>
        /// <returns></returns>
        public static double F3(double x)
        {
            return Math.Cos(x);
        }

        /// <summary>
        /// метод сохранения результатов вычисления заданной функции на отрезке
        /// </summary>
        /// <param name="fileName">имя файла сохранения</param>
        /// <param name="a">координата</param>
        /// <param name="b">координата</param>
        public static void SaveFunc(string fileName, Fun F, double a, double b)
        {
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            StreamWriter sw = new StreamWriter(new FileStream(fileName, FileMode.Create, FileAccess.Write));

            double x = a;
            while (x <= b)
            {
                sw.WriteLine(F(x));
                x++;
            }
            sw.Close();
        }

        /// <summary>
        /// метод вывода значений функции
        /// </summary>
        /// <param name="fileName">имя файла загрузки</param>
        /// <returns></returns>
        public static List<double> Load(string fileName)
        {
            StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
            List<double> arr = new List<double>();

            while (!sr.EndOfStream)
            {
                string t = sr.ReadLine();
                double d = 0;

                try
                {
                    d = double.Parse(t);
                    arr.Add(d);
                }
                catch (Exception e)
                {
                    d = 0;
                    Console.WriteLine($"{e.Message}, в коллекцию будет добавлено значение {d}");
                    arr.Add(d);
                }
            }
            sr.Close();
     
            return arr;
        }

        /// <summary>
        /// метод возврата минимума значений функции на отрезке 
        /// </summary>
        /// <param name="fileName">имя файла загрузки</param>
        /// <param name="min">выходной модификатор</param>
        public static void Load(string fileName, out double min)
        {
            StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open, FileAccess.Read));
            min = double.MaxValue;
            List<double> arr = new List<double>();
            
            while (!sr.EndOfStream)
            {
                string t = sr.ReadLine();
                double d = 0;
                
                try
                {
                    d = double.Parse(t);
                    arr.Add(d);
                    if (d < min) min = d;
                }
                catch (Exception e)
                {
                    d = 0;
                    Console.WriteLine($"{e.Message}, в коллекцию будет добавлено значение {d}");
                    arr.Add(d);
                }  
                
            }
            sr.Close();
            
        }

        static void Main(string[] args)
        {
           
            // Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
            // а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
            // Использовать массив(или список) делегатов, в котором хранятся различные функции.
            // б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр(с использованием модификатора out-выходной параметр). 

            List<Fun> funs = new List<Fun>() //создали коллекцию делегатов
            {
                F1,
                F2,
                F3
            };

            try
            {
                Console.WriteLine($"Выберите функцию, нажмите: \n1 - ax^2 + bx + c;\n2 - x^2;\n3 - Cos(x) "); int index = int.Parse(Console.ReadLine());
                Console.Write($"Укажите начало отрезка для нахождения минимума функции: "); double a = int.Parse(Console.ReadLine());
                Console.Write($"Укажите конец отрезка для нахождения минимума функции: "); double b = int.Parse(Console.ReadLine());
                SaveFunc("HW6.2.txt", funs[index-1], a, b);
              
                List<double> arr1 = new List<double>();
                arr1 = Load("HW6.2.txt");
                foreach (var e in arr1)
                {
                    Console.Write($"{e:0.00} ");
                }

                Console.WriteLine();

                double minValue;

                Load("HW6.2.txt", out minValue);
                Console.WriteLine($"{minValue:0.00}");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }
}
