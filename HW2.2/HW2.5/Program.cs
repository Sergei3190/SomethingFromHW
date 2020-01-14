using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2._5
{
    class Program
    {
        static void Main(string[] args)
        {

            // а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
            // б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            // Лысков С.

            Console.Write("Введите вес человека в кг: "); double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите рост человека в см: "); double h = Convert.ToDouble(Console.ReadLine())/100;

            var I = m / (h * h);

            Console.WriteLine("Индекс массы тела равен " + "{0:F2}", I);

            if ( 18.5 <= I && I <= 24.99 )
            {
                Console.WriteLine("Норма");
            }
            else if ( I < 18.5)
            {
                double  shortage = (18.5 - I) * h * h;
                Console.WriteLine($"Недостаточная масса тела, необходимо набрать {shortage:F2} кг ");
                
            } 
            else if ( I > 24.99 )
            {
                double excess = ( I - 24.99 ) * h * h;
                Console.WriteLine("Избыточная масса тела, необходимо скинуть {0:F2} кг", excess);
            }


            Console.ReadKey();

        }
    }
}
