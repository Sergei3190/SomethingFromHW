using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3._1
{
    struct Complex
    {
       // 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
       //    б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;

        // Все методы и поля публичные. Мы можем получить доступ к ним из другого класса.

        public double im; // указали мнимую часть 
        public double re; // указали действительную часть 


        /// <summary>
        /// метод вычитания комплексных чисел
        /// </summary>
        /// <param name="z1">первое комплексное число</param>
        /// <param name="z2">второе комплексное число </param>
        /// <returns></returns>
        static public Complex Deffer(Complex z1, Complex z2) 
        {
            return new Complex
            {
                re = z1.re - z2.re,
                im = z1.im - z2.im

            };
        }

        /// <summary>
        /// метод сложения комплексных чисел
        /// </summary>
        /// <param name="z1">первое комплексное число</param>
        /// <param name="z2">второе комплексное число</param>
        /// <returns></returns>
        static public Complex Sum(Complex z1, Complex z2)
        {
            return new Complex
            {
                re = z1.re + z2.re,
                im = z1.im + z2.im
            };
        }

        /// <summary>
        /// метод создания new комплексного числа
        /// </summary>
        /// <param name="Re"></param>
        /// <param name="Im"></param>
        public Complex(double Re, double Im)
        {
            im = Im;
            re = Re;
        }

        /// <summary>
        /// метод сложения 2-х комплексных чисел
        /// </summary>
        /// <param name="x2">второе комплексное число </param>
        /// <returns></returns>
        public Complex Plus(Complex x2) 
        {
            Complex result = new Complex()
            {
                im = x2.im + this.im,
                re = x2.re + this.re
            };
            return result;
        }

        /// <summary>
        /// метод вывода комплексного числа
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Complex z1 = new Complex(1, 2);
            Complex z2 = new Complex(3, 4);
            Complex z3 = new Complex(5, 6);
            Console.WriteLine(z1.ToString());
            Console.WriteLine(z2.ToString());
            Console.WriteLine(z3.ToString());

            //Complex res = z1.Plus(z2);
            Complex res = Complex.Sum(z1, z2);
            Console.WriteLine(res.ToString());

            Complex def = Complex.Deffer(z3, z1);
            Console.WriteLine(def.ToString());

            double a = 12;
            double b = 12.5;

            Console.WriteLine("Разность двух чисел: " + Operation.Subtraction(b, a));

            Console.WriteLine("Произведение двух чисел: " + Operation.Multiplication(b, a));

            Console.ReadLine();

        }
    }
}

    
