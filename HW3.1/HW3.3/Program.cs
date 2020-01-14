using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. * Описать класс дробей -рациональных чисел, являющихся отношением двух целых чисел.Предусмотреть методы сложения, вычитания, 
            //умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса. Достаточно решить 2 задачи.
            //Все программы сделать в одном решении.
            //**Добавить проверку, чтобы знаменатель не равнялся 0.Выбрасывать исключение
            //ArgumentException("Знаменатель не может быть равен 0");
            //Добавить упрощение дробей


            Fraction fr1 = new Fraction(3, 5);
            Console.WriteLine("{0} = {1:F2}",fr1.GetFraction(),Fraction.GetNumber(fr1));
            Fraction fr2 = new Fraction(2, 6);
            Console.WriteLine("{0} = {1:F2}",fr2.GetFraction(),Fraction.GetNumber(fr2));

            Fraction sum = Fraction.Sum(fr1, fr2);
            Console.WriteLine("{0} = {1:F2}",sum.GetFraction(),Fraction.GetNumber(sum));
            //Console.WriteLine("{0:f2}", Fraction.GetNumber(sum));

            Fraction deffer = Fraction.Deffer(fr1, fr2);
            Console.WriteLine("{0} = {1:F2}",deffer.GetFraction(),Fraction.GetNumber(deffer));

            Fraction multiplication = Fraction.Multiplication(fr1, fr2);
            Console.WriteLine("{0} = {1:F2}",multiplication.GetFraction(),Fraction.GetNumber(multiplication));

            Fraction division = Fraction.Division(fr1, fr2);
            Console.WriteLine("{0} = {1:F2}",division.GetFraction(),Fraction.GetNumber(division));

            Console.ReadKey();
        }
    }
}
