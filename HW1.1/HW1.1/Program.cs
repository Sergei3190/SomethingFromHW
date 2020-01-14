using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.\nа) используя склеивание;\nб) используя форматированный вывод;\nв)*используя вывод со знаком $;\n\nЛысков С.\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Aнкета:\n");

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("1. Как Ваше имя?");
            String name = Console.ReadLine();

            Console.WriteLine("2. Какая у Вас фамилия?");
            String surname = Console.ReadLine();

            Console.WriteLine("3. Сколько Вам Лет?");
            string ag = Console.ReadLine();
            int age = Convert.ToInt32(ag);

            Console.WriteLine("4. Какой у Вас рост?");
            string gr = Console.ReadLine();
            int growth = Int32.Parse(gr);

            Console.WriteLine("5. Какой у Вас вес?");
            string wht = Console.ReadLine();
            double weight = Convert.ToDouble(wht);

            Console.WriteLine("Меня зовут " + name + ", фамилия " + surname + ", мне " + age + " года, мой рост " + growth + " см и вес " + weight + " кг.");
            Console.ReadLine();

            Console.WriteLine("Мое имя {0}, фамилия {1}, лет {2}, рост {3}, вес {4}", name, surname, age, growth, weight);
            Console.ReadLine();

            Console.WriteLine($"Мое имя {name}, фамилия {surname}, лет {age}, рост {growth}, вес {weight}");
            Console.ReadLine();
        }
    }
}
