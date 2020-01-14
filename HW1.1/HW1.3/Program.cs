using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);\nб)*Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;\n\nЛысков С.\n");

            Console.WriteLine("Введите значение х для первой точки : ");
            string x = Console.ReadLine();
            double х1 = double.Parse(x);

            Console.WriteLine("Введите значение y для первой точки : ");
            string y = Console.ReadLine();
            double y1 = double.Parse(y);

            Console.WriteLine("Введите значение х для второй точки : ");
            x = Console.ReadLine();
            double х2 = Convert.ToDouble(x);

            Console.WriteLine("Введите значение y для второй точки : ");
            y = Console.ReadLine();
            double y2 = Convert.ToDouble(y);
            double r = Distance(х1, y1, х2, y2);

            Console.WriteLine("Расстояние между точками равно " + "{0:F2}", r);

            Console.ReadLine();

        }
        /// <summary>
        /// Метод вычисления расстояния между двумя точками с координатами Х и У
        /// </summary>
        /// <param name="х1"></param>
        /// <param name="y1"></param>
        /// <param name="х2"></param>
        /// <param name="y2"></param>
        /// <returns></returns>
        public static double Distance(double х1, double y1, double х2, double y2)
        {
            return Math.Sqrt(Math.Pow(х2 - х1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
