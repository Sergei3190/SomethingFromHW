using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.\n\nЛысков С.\n");

            Console.WriteLine("Введите вес человека");
            String mStr = Console.ReadLine();
            int m = int.Parse(mStr);

            Console.WriteLine("Введите рост человека в см");
            string hSt = Console.ReadLine();
            double h = double.Parse(hSt)/100;

            var I = m / (h * h);

            Console.WriteLine("Индекс массы тела равен " + "{0:F2}",I);

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Результирующий тип данных - " + I.GetType());

            Console.ReadKey();


        }
    }
}
