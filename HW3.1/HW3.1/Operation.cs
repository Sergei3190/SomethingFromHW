using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3._1
{
    /// <summary>
    /// класс операций вычитания и умножения
    /// </summary>
    class Operation
    {
        /// <summary>
        /// метод вычитания чисел
        /// </summary>
        /// <param name="x1">певое число</param>
        /// <param name="x2">второе число</param>
        /// <returns></returns>
        static public double Subtraction(double x1, double x2) => x1 - x2;

        /// <summary>
        /// метод произведения чисел
        /// </summary>
        /// <param name="x1">первое число</param>
        /// <param name="x2">второе число</param>
        /// <returns></returns>
        static public double Multiplication(double x1, double x2) => x1 * x2;
    }
}
