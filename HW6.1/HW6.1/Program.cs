using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6._1
{
    public delegate double Fun(double x, double y);

    class Program
    {
      /// <summary>
      /// Метод вывода функций
      /// </summary>
      /// <param name="F">делегат</param>
      /// <param name="a">множитель</param>
      /// <param name="x">начало координат</param>
      /// <param name="b">конец координат</param>
        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a,x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        /// <summary>
        /// метод вызова функции a*x^2
        /// </summary>
        /// <param name="a">множитель</param>
        /// <param name="x">координата</param>
        /// <returns></returns>
        public static double F(double a, double x)
        {
            return a * x * x;
        }

        /// <summary>
        /// метод вызова функции a*sin(x)
        /// </summary>
        /// <param name="a">множитель</param>
        /// <param name="x">координата</param>
        /// <returns></returns>
        public static double F1(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main(string[] args)
        {
            //Изменить программу вывода таблицы функции так, 
            //чтобы можно было передавать функции типа double (double, double). 
            //Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).

            #region Option №1

            Table(F, 2, 0, 10);
            Table(F1, 2, 0, 10);

            #endregion

            #region Option №2

            Table((a,x) => a * x * x, 2, 0, 10);
            Table((a,x) => a * Math.Sin(x), 2, 0, 10);

            #endregion

            Console.ReadKey();
        }
    }
}
