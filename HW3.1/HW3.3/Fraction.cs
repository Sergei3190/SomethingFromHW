using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3._3
{
    /// <summary>
    /// Класс дробей
    /// </summary>
    class Fraction
    {
       // cоздаем структуру создания дроби

        public int numerator;
        public int denominator;

        /// <summary>
        /// Создаем дробь
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="b2"></param>
       public Fraction (int Numerator, int Denominator)
        {
            try
            {
                if (Denominator != 0)
                {
                    this.numerator = Numerator;
                    this.denominator = Denominator;
                }
                else throw new ArgumentException();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Знаменатель не может быть равен 0");
            }
            finally
            {

            }
             
        }

        /// <summary>
        /// Возвращает созданную дробь в строковом представлении
        /// </summary>
        /// <returns></returns>
        public string GetFraction()
        {
            return $"{numerator}/{denominator}";
        }

        /// <summary>
        /// Метод возвращает дробь в виде числа типа double
        /// </summary>
        /// <returns></returns>
        public static double GetNumber(Fraction fr1)
        {
            double number = Convert.ToDouble(fr1.numerator) / Convert.ToDouble(fr1.denominator);
            return number;
        }

        /// <summary>
        /// Метод сокращения дроби
        /// </summary>
        /// <param name="fr3"></param>
        /// <returns></returns>
        public static Fraction ReduceFraction(Fraction fr3)
        {
            int max = fr3.denominator;

            if (fr3.numerator > max) max = fr3.numerator;

            Fraction fr4 = new Fraction(1, 1);

            for (int MaxCommonDivisor = max; MaxCommonDivisor > 1; MaxCommonDivisor--)
            {
                if (fr3.numerator % MaxCommonDivisor == 0 && fr3.denominator % MaxCommonDivisor == 0)
                {
                    fr4.numerator = fr3.numerator /= MaxCommonDivisor;
                    fr4.denominator = fr3.denominator /= MaxCommonDivisor;
                    return fr4;
                }
            }
            return fr4;
        }

        /// <summary>
        /// Метод сложения дробей
        /// </summary>
        /// <param name="fraction1"></param>
        /// <param name="fraction2"></param>
        /// <returns></returns>
        public static Fraction Sum(Fraction fr1, Fraction fr2)
        {
            Fraction fr3 = new Fraction(1, 1);

            if (fr1.denominator == fr2.denominator)
            {
                fr3.denominator = fr1.denominator;
                fr3.numerator = fr1.numerator + fr2.numerator;
                return fr3;
            }
            else
            {
                fr3.numerator = fr1.numerator * fr2.denominator + fr2.numerator * fr1.denominator;
                fr3.denominator = fr1.denominator * fr2.denominator;
                ReduceFraction(fr3);
                return fr3;
            }
        }

        /// <summary>
        /// Метод вычитания дробей
        /// </summary>
        /// <param name="fr1"></param>
        /// <param name="fr2"></param>
        /// <returns></returns>
        public static Fraction Deffer(Fraction fr1, Fraction fr2)
        {
            Fraction fr3 = new Fraction(1, 1);

            if (fr1.denominator == fr2.denominator)
            {
                fr3.denominator = fr1.denominator;
                fr3.numerator = fr1.numerator - fr2.numerator;
                return fr3;
            }
            else
            {
                fr3.numerator = fr1.numerator * fr2.denominator - fr2.numerator * fr1.denominator;
                fr3.denominator = fr1.denominator * fr2.denominator;
                ReduceFraction(fr3);
                return fr3;
            }
        }

        /// <summary>
        /// Метод умножения дробей
        /// </summary>
        /// <param name="fr1"></param>
        /// <param name="fr2"></param>
        /// <returns></returns>
        public static Fraction Multiplication(Fraction fr1, Fraction fr2)
        {
            Fraction fr3 = new Fraction(1, 1);

            fr3.numerator = fr1.numerator * fr2.numerator;
            fr3.denominator = fr1.denominator * fr2.denominator;
            ReduceFraction(fr3);
            return fr3;
        }

        /// <summary>
        /// Метод деления дробей
        /// </summary>
        /// <param name="fr1"></param>
        /// <param name="fr2"></param>
        /// <returns></returns>
        public static Fraction Division(Fraction fr1, Fraction fr2)
        {
            Fraction fr3 = new Fraction(1, 1);

            fr3.numerator = fr1.numerator * fr2.denominator;
            fr3.denominator = fr1.denominator * fr2.numerator;
            ReduceFraction(fr3);
            return fr3;
        }
    }
}
