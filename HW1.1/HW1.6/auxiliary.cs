using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._6
{   
    /// <summary>
    /// Вспомогательный класс
    /// </summary>
    class Auxiliary
    {
        /// <summary>
        /// Метод вывода текста на консоль
        /// </summary>
        /// <param name="text"></param>
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }
        /// <summary>
        /// Метод задержки черного экрана
        /// </summary>
        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}

